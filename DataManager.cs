﻿using Newtonsoft.Json;

public class AppData
{
    public string Username { get; set; }
}

public static class DataManager
{
    // TODO: Should create a Flashback folder if there is not one already.

    private static string _saveFile = "flashback.json";

    /// <summary>
    /// Try to load preexisting <see cref="AppData"/>, if none exist a new <see cref="AppData"/> JSON file will be created using <see cref="CreateAppData(string)"/>.
    /// <see cref="LoadAppData(string)"/> throws an exception if the file could not be read as it should already have some JSON content by the time <see cref="CreateAppData(string)"/>
    /// has been called.
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public static AppData LoadAppData(string path)
    {
        // Ensure there is always a savefile.
        var file = $"{path}/{_saveFile}";
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
            Username = "None"
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
    public static void SaveData(AppData data, string path)
    {
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
    /// </summary>
    /// <param name="username"></param>
    public static void SaveUsername(string username)
    {
        // Flashback folder, appdata path.
        string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/Flashback/appdata/{_saveFile}";

        // Find the Flashback folder and store the appdata file in there.
        AppData data = LoadAppData(path);
        data.Username = username;
        SaveData(data, path);
    }
}