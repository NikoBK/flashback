using Newtonsoft.Json;
using System.IO;

public class GameData
{
    public string? Name { get; set; }
    public string? Id { get; set; }
    public float? HoursPlayed { get; set; }
    public string? LastPlayed { get; set; }
}

public class Userdata
{
    public string? Username { get;set; }
    public List<GameData>? GameData { get; set; }

}

public static class DataManager
{
    private static string _cfgFile = "fbe_cfg.json";

    public static Userdata LoadUserdata(string path)
    {
        var file = $"{path}/{_cfgFile}";
        if (!File.Exists(file)) {
            return CreateUserdata(path);
        }

        Userdata? data = JsonConvert.DeserializeObject<Userdata>(File.ReadAllText(file));
        if (data == null) {
            return CreateUserdata(path);
        }
        return data;
    }

    public static Userdata CreateUserdata(string path)
    {
        Userdata data = new Userdata() {
            Username = "None",
            GameData = new List<GameData>()
        };
        SaveData(data, path);
        return data;
    }

    public static void SaveData(Userdata data, string path)
    {
        var filePath = $"{path}/{_cfgFile}";
        var json = JsonConvert.SerializeObject(data, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }
}