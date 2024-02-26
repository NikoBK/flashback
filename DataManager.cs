/*
*  File: DataManager.cs 
*  Date: 11/02/2024
*  Author: NikoBK
*/
using flashback_emulator.UserControls;
using Newtonsoft.Json;
using System.Xml.Linq;

/// <summary>
/// Application data for Flashback.
/// Needed for statstics and user identification.
/// </summary>
public class AppData
{
    public string Username { get; set; }
    public bool Registered { get; set; }
    public DateTime UserCreationDate { get; set; }
    public List<GameData> Games { get; set; }
}

/// <summary>
/// GameData for games displayed across Flashback.
/// Is used in the store as well as the library and 
/// each view for each game respectively.
/// </summary>
public class GameData
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool SupportsMultiplayer { get; set; }
    public string SWFPath { get; set; }
    public bool InLibrary { get; set; }
    public bool Playable { get; set; }
    public bool HasBeenPlayed { get; set; }
    public DateTime LastPlayed { get; set; }
    public TimeSpan TimePlayedS { get; set; }
}

public static class DataManager
{
    // TODO: Should create a Flashback folder if there is not one already.

    private static string _saveFile = "flashback.json";

    ////////// GAME RESOURCES
    // TODO: Is it better to keep images within GameData??

    // Key: Game id, value: game data.
    public static Dictionary<string, GameData> Games { get; private set; }

    // Key: game id, value: hero image.
    public static Dictionary<string, Image> Heros { get; private set; }

    // Key: game id, value: store grid image.
    public static Dictionary<string, Image> StoreGrids { get; private set; }

    // Key: game id, value: library grid image.
    public static Dictionary<string, Image> LibraryGrids { get; private set; }

    // Key: game id, value: game logo image.
    public static Dictionary<string, Image> Logos { get; private set; }

    // Key: game id, value: game icon image.
    public static Dictionary<string, Image> Icons { get; private set; }
    //////////

    public static bool Init()
    {
        // Initialize directories.
        Games = new Dictionary<string, GameData>();
        Heros = new Dictionary<string, Image>();
        StoreGrids = new Dictionary<string, Image>();
        LibraryGrids = new Dictionary<string, Image>();
        Logos = new Dictionary<string, Image>();
        Icons = new Dictionary<string, Image>();

        return ParseGames();
    }

    private static bool ParseGames()
    {
        var appdata = LoadAppData();

        // Start by parsing games first.
        string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/Flashback/games/";

        // Get all subdirectories in the games folder.
        string[] gameFolders = Directory.GetDirectories(path);

        // Parse games as GameData.
        foreach(string gameFolder in gameFolders)
        {
            // Find the game config file (.xml) and parse it to XElement.
            string[] xmlFiles = Directory.GetFiles(gameFolder, "*.xml");

            // Find the .swf file if it exists.
            string[] swfFiles = Directory.GetFiles(gameFolder, "*.swf");

            string folderName = Path.GetFileName(gameFolder);

            // Games should only be playable if they have
            // their game.xml file.
            if (xmlFiles.Length > 0 && swfFiles.Length > 0)
            {
                XElement xml = XElement.Load(xmlFiles[0]);
                GameData data = new GameData {
                    Id = xml.Attribute("id").Value, // Every game xml must have an id!
                    Name = xml.Element("Name") != null ? xml.Element("Name").Value : "No Name",
                    Description = xml.Element("Description") != null ? xml.Element("Description").Value : "No Description",
                    SWFPath = swfFiles[0],
                    SupportsMultiplayer = false,
                    Playable = true,
                    HasBeenPlayed = false
                };

                foreach (var game in appdata.Games) { 
                    if (game.Id == data.Id) {
                        data.InLibrary = true;
                    }
                }

                // Add the game to the Games dictionary.
                Games.Add(data.Id, data);

                // Find the image files.
                // hero, storegrid, libgrid, logo, icon
                // 42, 38, 40, 41, 41
                string[] hero = Directory.GetFiles(gameFolder).Where(file => file.EndsWith("hero.png") || file.EndsWith("hero.jpg")).ToArray();
                if (hero.Length > 0) { 
                    Heros.Add(data.Id, Image.FromFile(hero[0])); 
                }

                string[] storeGrid = Directory.GetFiles(gameFolder).Where(file => file.EndsWith("shopgrid.png") || file.EndsWith("shopgrid.jpg")).ToArray();
                if (storeGrid.Length > 0) { 
                    StoreGrids.Add(data.Id, Image.FromFile(storeGrid[0])); 
                }
                string[] libGrid = Directory.GetFiles(gameFolder).Where(file => file.EndsWith("libgrid.png") || file.EndsWith("libgrid.jpg")).ToArray();
                if (libGrid.Length > 0) { 
                    LibraryGrids.Add(data.Id, Image.FromFile(libGrid[0])); 
                }

                string[] logo = Directory.GetFiles(gameFolder).Where(file => file.EndsWith("logo.png") || file.EndsWith("logo.jpg")).ToArray();
                if (logo.Length > 0) { 
                    Logos.Add(data.Id, Image.FromFile(logo[0])); 
                }

                string[] icon = Directory.GetFiles(gameFolder).Where(file => file.EndsWith("icon.png") || file.EndsWith("icon.jpg") || file.EndsWith("icon.ico")).ToArray();
                if (icon.Length > 0) { 
                    Icons.Add(data.Id, Image.FromFile(icon[0])); 
                }
            }
            else {
                GameData data = new GameData {
                    Id = folderName,
                    Name = folderName,
                    Description = "No Description",
                    SupportsMultiplayer = false,
                    Playable = false,
                    HasBeenPlayed = false
                };
            }
        }

        //MessageBox.Show($"Found {Heros.Count} heros!");
        //MessageBox.Show($"Found {StoreGrids.Count} StoreGrids!");
        //MessageBox.Show($"Found {LibraryGrids.Count} LibraryGrids!");
        //MessageBox.Show($"Found {Logos.Count} Logos!");
        //MessageBox.Show($"Found {Icons.Count} Icons!");
        return true;
    }

    /// <summary>
    /// Try to load preexisting <see cref="AppData"/>, if none exist a new <see cref="AppData"/> JSON file will be created using <see cref="CreateAppData(string)"/>.
    /// <see cref="LoadAppData(string)"/> throws an exception if the file could not be read as it should already have some JSON content by the time <see cref="CreateAppData(string)"/>
    /// has been called.
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public static AppData LoadAppData(string path = "")
    {
        if (string.IsNullOrEmpty(path)) {
            path = GetAppDataPath();
        }

        // Ensure there is always a savefile.
        var file = $"{path}";
        if (!File.Exists(path)) {
            return CreateAppData(path);
        }

        AppData? data = JsonConvert.DeserializeObject<AppData>(File.ReadAllText(file));
        if (data == null) {
            MessageBox.Show($"Could not load data for path: {path}/{_saveFile}", "Error");
            throw new Exception($"Could not load data for path: {path}/{_saveFile}");
        }
        else {
            return data;
        }
    }

    /// <summary>
    /// Creates a new <see cref="AppData"/> savefile for the application.
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    public static AppData CreateAppData(string path)
    {
        // Sample appdata, this should be overwritten almost instantly
        // as appdata should only be created if it is needed.
        AppData data = new AppData {
            Username = "None",
            Registered = false,
            UserCreationDate = DateTime.Now,
            Games = new List<GameData>()
        };
        SaveData(data, path);
        return data;
    }

    /// <summary>
    /// Save some given <see cref="AppData"/> to a file path. <paramref name="data"/> should be an instance
    /// of the appdata file found on the path (<paramref name="path"/>) which has been loaded prior to a function
    /// call for <see cref="SaveData(AppData, string)"/>.
    /// </summary>
    /// <param name="data"></param>
    /// <param name="path"></param>
    public static void SaveData(AppData data, string path = "")
    {
        // Default to the appdata path in documents if no path is specified.
        if (string.IsNullOrEmpty(path)) {
            path = GetAppDataPath();
        }
        var filePath = $"{path}";

        // If either the file or the directory does not exist, create it.
        string directoryPath = Path.GetDirectoryName(filePath);
        if (!Directory.Exists(directoryPath)) {
            Directory.CreateDirectory(directoryPath);
            FileStream stream = File.Create(filePath);
            stream.Close();
        }

        var json = JsonConvert.SerializeObject(data, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }

    /// <summary>
    /// Save the username to the appdata, can be called from anywhere in the project.
    /// This function call will tag the user in the appdata as registered, meaning the
    /// introductory view will not be triggered anytime Flashback loads this specific appdata.
    /// </summary>
    /// <param name="username"></param>
    public static void SaveUsername(string username)
    {
        // Find the Flashback folder and store the appdata file in there.
        AppData data = LoadAppData(GetAppDataPath());
        data.Username = username;
        data.Registered = true;
        data.UserCreationDate = DateTime.Now;
        SaveData(data, GetAppDataPath());
    }

    public static string GetAppDataPath()
    {
        return $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/Flashback/appdata/{_saveFile}";
    }
}