using FundooApp.Interfaces;
using Moq;
using System;
using Xunit;

namespace FundooUnitTesting
{
    public class UnitTest1
    {
        [Fact]
    
        public void Test1()
        {
            //Arrange
            var service = new Mock<IFirebaseAuthentictor>();
            string FirstName = "Sandeepa";
            string Lastname = "Mohaptra";
            string EmailId = "saisandeepa96@gmail.com";
            string Password = "1234567890";

            //Act
           
           //Assert
        }
    }
}
