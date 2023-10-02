namespace _01_DataLoggin.Interfaces;

public interface IFileManager
{
    bool SaveToFile(string filePath, string content);

    string ReadFromFile(string filePath);
}
