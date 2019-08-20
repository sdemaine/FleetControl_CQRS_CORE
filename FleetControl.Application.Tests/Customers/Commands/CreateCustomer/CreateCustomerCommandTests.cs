using MediatR;
using Moq;
using Northwind.Application.Commands.CreateCustomer;
using FleetControl.Application.Tests.Infrastructure;
using System.Threading;
using Xunit;

namespace Northwind.Application.Tests.Customers.Commands.CreateCustomer
{
    public class CreateNorthwindCustomerCommandTests : CommandTestBase
    {
        [Fact]
        public void Handle_GivenValidRequest_ShouldRaiseCustomerCreatedNotification()
        {
            // Arrange
            var mediatorMock = new Mock<IMediator>();
            var sut = new CreateNorthwindCustomerCommand.Handler(_context, mediatorMock.Object);
            var newCustomerId = "QAZQ1";

            // Act
            var result = sut.Handle(new CreateNorthwindCustomerCommand { CustomerId = newCustomerId }, CancellationToken.None);


            // Assert
            mediatorMock.Verify(m => m.Publish(It.Is<NorthwindCustomerCreated>(cc => cc.CustomerId == newCustomerId), It.IsAny<CancellationToken>()), Times.Once);
        }
    }
}
