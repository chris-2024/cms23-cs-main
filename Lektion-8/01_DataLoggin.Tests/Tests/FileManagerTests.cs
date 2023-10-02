using _01_DataLoggin.Interfaces;
using _01_DataLoggin.Services;

namespace _01_DataLoggin.Tests.Tests;
/*
    Unit tests focus on isolated parts of your code to ensure they work independently.
    Integration tests focus on testing the interactions and connections between these parts to ensure they work together as a cohesive system.
*/
public class FileManagerTests : IDisposable
{
    private readonly string _realFilePath;
    private readonly string _fakeFilePath;
    private readonly string _content;

    public FileManagerTests()
    {
        _realFilePath = @$"{Guid.NewGuid()}.txt";
        _fakeFilePath = @$"c:\{Guid.NewGuid()}\fakefile.txt";
        _content = "Testing content";
    }

    [Fact] // IntegrationTest
    public void SaveToFile_Should_ReturnTrue_WhenContentIsWrittenToRealFile()
    {
        // Arrange
        IFileManager fileManager = new FileManager();

        // Act
        bool result = fileManager.SaveToFile(_realFilePath, _content);
        string result_content = File.ReadAllText(_realFilePath);

        // Assert
        Assert.True(result);
        Assert.Equal(result_content.Trim(), _content);
    }

    [Fact] // UnitTest
    public void SaveToFile_Should_ReturnFalse_WhenFileNotCreated()
    {
        // Arrange
        IFileManager fileManager = new FileManager();

        // Act
        bool result = fileManager.SaveToFile(_fakeFilePath, _content);

        // Assert
        Assert.False(result);
    }

    [Fact] // UnitTest
    public void ReadFromFile_Should_ReturnNull_WhenFileDoesNotExists()
    {
        // Arrange
        IFileManager fileManager = new FileManager();

        // Act
        string result = fileManager.ReadFromFile(_fakeFilePath);

        // Assert
        Assert.Null(result);
    }

    public void Dispose()
    {
        // Cleanup
        if (File.Exists(_realFilePath))
            File.Delete(_realFilePath);
    }
}
