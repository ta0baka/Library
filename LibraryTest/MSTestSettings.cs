using LibraryTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Npgsql;
using System;
using System.Diagnostics;

namespace YourProject.Tests
{
    [TestInitialize]
    public void SetUp()
    {
        string connectionString = "Host=myserver;Username=mylogin;Password=mypass;Database=mydatabase"; // Замените на ваши данные
        _mockDatabase = new Mock<Database>(connectionString);
        _bookRepository = new BookRepository(_mockDatabase.Object);
    }

    [TestClass]
    public class BookRepositoryTests
    {
        private Mock<Database> _mockDatabase;
        private BookRepository _bookRepository;

        [TestInitialize]
        public void SetUp()
        {
            _mockDatabase = new Mock<Database>();
            _bookRepository = new BookRepository(_mockDatabase.Object);
        }

        [TestMethod]
        public void LoadTest_AddBooks_ShouldInsert1000Books()
        {
            // Arrange
            int bookCount = 1000;

            // Act
            var stopwatch = Stopwatch.StartNew();
            _bookRepository.AddBooks(bookCount);
            stopwatch.Stop();

            // Assert
            Assert.IsTrue(stopwatch.ElapsedMilliseconds < 5000, "Время выполнения превышает 5 секунд.");
        }

        [TestMethod]
        public void AddBooks_WhenDatabaseThrowsException_ShouldThrowException()
        {
            // Arrange
            _mockDatabase.Setup(db => db.openConnection()).Throws(new Exception("Ошибка подключения"));

            // Act & Assert
            Assert.ThrowsException<Exception>(() => _bookRepository.AddBooks(10));
        }
    }
}