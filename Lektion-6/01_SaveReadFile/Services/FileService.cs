namespace _01_SaveReadFile.Services;

internal class FileService
{
    private static readonly string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
    private static readonly string filePath = Path.Combine(currentDirectory, "customers.json");

    public static void SaveToFile(string contentAsJson)
    {
        using var sw = new StreamWriter(filePath);
        sw.WriteLine(contentAsJson);
    }

    public static string ReadFromFile()
    {
        if (File.Exists(filePath))
        {
            using var sr = new StreamReader(filePath);
            return sr.ReadToEnd();
        }

        return null!;
    }
}
