using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Xml.Linq;

public class Game
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string ResourcePath { get; set; }
    public string Description { get; set; }
    public int LastPlayed { get; set; }
    public float TimePlayed { get; set; }
}

public static class GameLibrary
{
    public static Dictionary<string, Game> Games { get; private set; }
    public const string Path = "res";

    public static void LoadGames()
    {
        Games = new Dictionary<string, Game>();
        string[] gamesXML = Directory.EnumerateFiles(Path, "games.xml", SearchOption.AllDirectories).ToArray();
        XElement xml = XElement.Load(gamesXML[0]);

        // Parse every game xml.
        foreach (XElement elem in xml.Elements("Game")) {
            Game game = new Game() {
                Id = elem.Attribute("id").Value,
                Name = elem.Element("Name") != null ? elem.Element("Name").Value : "Unknown",
                Description = elem.Element("Description") != null ? elem.Element("Description").Value : "N/A",
                LastPlayed = -1,
                TimePlayed = 0
            };
            game.ResourcePath = $"{Path}/{game.Id}";
            // MessageBox.Show($"Loaded game: {game.Name}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information );
            
            if (!Games.ContainsKey(game.Name)) { 
                Games.Add(game.Name, game);
            }
        }
    }

    public static Dictionary<string, Game> GetGames()
    {
        return Games;
    }
}