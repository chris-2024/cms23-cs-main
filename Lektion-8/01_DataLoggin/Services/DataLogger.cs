using _01_DataLoggin.Interfaces;

namespace _01_DataLoggin.Services;

public class DataLogger : IDataLogger
{
    private readonly string _filePath;
    private readonly IFileManager _fileManager;

    public DataLogger(string filePath, IFileManager fileManager)
    {
        this._filePath = filePath;
        this._fileManager = fileManager;
    }

    public void Log(string message)
    {
        try
        {
            _fileManager.SaveToFile(_filePath, message);
        }
        catch { }
    }
}
