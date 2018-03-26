using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CreditCardValidation_Tests
{
    [TestClass]
    public class IsValidCreditCardTests
    {
        [TestMethod]
        public void CreditCardValidation_CheckCreditCardNumberContainOnlyDigits_ReturnsTrueOnDigitsOnly()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void CreditCardValidation_CheckValidVisaCreditCardNumberWith16Digits_ReturnsTureifValid()
        {
            //Arrange

            //Act

            //Assert
        }
        [TestMethod]
        public void CreditCardValidation_CheckInValidVisaCreditCardNumberWith16Digits_ReturnsFalseifInValid()
        {
            //Arrange

            //Act

            //Assert
        }
        [TestMethod]
        public void CreditCardValidation_CheckValidVisaCreditCardNumberWith13Digits_ReturnsTureifValid()
        {
            //Arrange

            //Act

            //Assert
        }
        [TestMethod]
        public void CreditCardValidation_CheckValidAmexCreditCardNumberWith15Digits_ReturnsTureifValid()
        {
            //Arrange

            //Act

            //Assert
        }
        [TestMethod]
        public void CreditCardValidation_CheckValidCreditCardNumberWith16Digits_ReturnsTureifValid()
        {
            //Arrange

            //Act

            //Assert
        }
        [TestMethod]
        public void CreditCardValidation_CheckValidCreditCardNumberWith16Digits_ReturnsFalseifInValid()
        {
            //Arrange

            //Act

            //Assert
        }
        [TestMethod]
        public void CreditCardValidation_CheckInvalidCreditCardNumber_ReturnsFlaseIfInvalis()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
