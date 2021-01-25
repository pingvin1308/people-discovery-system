using AutoFixture;
using Moq;
using NUnit.Framework;
using Pds.BusinessLogic.Services;
using Pds.Domain.People;
using System.Linq;
using System.Threading.Tasks;

namespace Pds.BusinessLogic.Tests
{
    public class PeopleServiceTests
    {
        [Test]
        public async Task Get_ShouldReturnPeople()
        {
            // arrange
            var fixture = new Fixture();
            var expectedPerson = fixture.Create<Person>();
            var peopleRepositoryMock = new Mock<IPeopleRepository>();

            peopleRepositoryMock
                .Setup(x => x.Get())
                .ReturnsAsync(new[] { expectedPerson });

            var service = new PeopleService(peopleRepositoryMock.Object);

            // act
            var result = await service.Get();

            // assert
            Assert.NotNull(result);
            Assert.IsNotEmpty(result);
            Assert.True(result.Any(x => x.Id == expectedPerson.Id));

            peopleRepositoryMock.Verify(x => x.Get(), Times.Once);
        }
    }
}
