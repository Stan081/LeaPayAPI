//using Lea.Data.Models;
//using Lea.Repository.Interfaces;
//using Moq;
//using System;
//using System.Threading.Tasks;
//using Xunit;

//namespace LeaAPI.Test.Services
//{
//    public class CardServiceTest
//    {
//        [Fact]
//        public async Task CreateCardAsync_ShouldCreateCard_WhenValidInput()
//        {
//            // Arrange
//            var cardRepositoryMock = new Mock<ICardRepository>();
//            var cardService = new CardService(cardRepositoryMock.Object);
//            var createCardDto = new CreateCardDto { CardHolderName = "John Doe", CardType = "Virtual", WalletId = "wallet123" };

//            // Act
//            var result = await cardService.CreateCardAsync(createCardDto);

//            // Assert
//            Assert.NotNull(result);
//            Assert.Equal(createCardDto.CardHolderName, result.CardHolderName);
//        }

//        [Fact]
//        public async Task GetCardByIdAsync_ShouldReturnCard_WhenCardExists()
//        {
//            // Arrange
//            var cardRepositoryMock = new Mock<ICardRepository>();
//            var card = new Card { Id = Guid.NewGuid(), CardHolderName = "John Doe" };
//            cardRepositoryMock.Setup(repo => repo.GetCardByIdAsync(It.IsAny<Guid>())).ReturnsAsync(card);
//            var cardService = new CardService(cardRepositoryMock.Object);

//            // Act
//            var result = await cardService.GetCardByIdAsync(card.Id);

//            // Assert
//            Assert.NotNull(result);
//            Assert.Equal(card.CardHolderName, result.CardHolderName);
//        }

//    }
//}
