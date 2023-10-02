using _01_DataLoggin.Interfaces;
using _01_DataLoggin.Services;
using Moq;

namespace _01_DataLoggin.Tests.Tests;

public class DataLoggerTests
{
    private readonly string _realFilePath;
    private readonly string _content;

    public DataLoggerTests()
    {
        _realFilePath = @$"{Guid.NewGuid()}.txt";
        _content = "Testing log";
    }

    [Fact] // UnitTest
    public void Log_Should_LogMessageToLogFile()
    {
        // Arrange - SUT = System Under Test
        var mockFileManager = new Mock<IFileManager>();
        IDataLogger sut = new DataLogger(_realFilePath, mockFileManager.Object);

        // Act
        sut.Log(_content);

        // Assert
        mockFileManager.Verify(x => x.SaveToFile(_realFilePath, _content), Times.Once);
    }
}
