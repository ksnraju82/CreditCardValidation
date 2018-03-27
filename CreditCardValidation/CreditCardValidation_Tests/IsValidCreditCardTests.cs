using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreditCardValidation;

namespace CreditCardValidation_Tests
{

    //VISA: 4111111111111111       (valid)
    //VISA: 4111111111111          (invalid)
    //VISA: 4012888888881881       (valid)
    //AMEX: 378282246310005        (valid)
    //Discover: 6011111111111117   (valid)
    //MasterCard: 5105105105105100 (valid)
    //MasterCard: 5105105105105106 (invalid)
    //Unknown: 9111111111111111    (invalid)   

    [TestClass]
    public class IsValidCreditCardTests
    {
        IsCardNumberValid _CreditCardNumber;
        [TestMethod]
        public void CreditCardValidation_CheckCreditCardNumberContainOnlyDigits_ReturnsTrueOnDigitsOnly()
        {
            //Arrange

            //Act

            //Assert
        }

        public void CreditCardValidation_CheckCreditCardNumberContainOtherDigits_ReturnsFlase()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void CreditCardValidation_CheckValidVisaCreditCardNumberWith16Digits_ReturnsTureifValid()
        {
            //Arrange
            _CreditCardNumber = new IsCardNumberValid("4012888888881881");
            bool actual = false;
            //Act
            actual = _CreditCardNumber.Validate();
            //Assert
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void CreditCardValidation_CheckInValidVisaCreditCardNumberWith16Digits_ReturnsFalseifInValid()
        {
            //Arrange
            _CreditCardNumber = new IsCardNumberValid("5105105105105106");
            bool actual = false;
            //Act
            actual = _CreditCardNumber.Validate();
            //Assert
            Assert.AreEqual(false, actual);
        }
        [TestMethod]
        public void CreditCardValidation_CheckValidVisaCreditCardNumberWith13Digits_ReturnsTureifValid()
        {
            //Arrange
            _CreditCardNumber = new IsCardNumberValid("4111111111111");
            bool actual = false;
            //Act
            actual = _CreditCardNumber.Validate();
            //Assert
            Assert.AreEqual(false, actual);
        }
        [TestMethod]
        public void CreditCardValidation_CheckValidAmexCreditCardNumberWith15Digits_ReturnsTureifValid()
        {
            //Arrange
            _CreditCardNumber = new IsCardNumberValid("378282246310005");
            bool actual = false;
            //Act
            actual = _CreditCardNumber.Validate();
            //Assert
            Assert.AreEqual(true, actual);
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
            _CreditCardNumber = new IsCardNumberValid("9111111111111111");
            bool actual = false;
            //Act
            actual = _CreditCardNumber.Validate();
            //Assert
            Assert.AreEqual(false, actual);
        }
    }
}
