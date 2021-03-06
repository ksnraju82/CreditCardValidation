﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreditCardValidation;

namespace CreditCardValidation_Tests
{
    [TestClass]
    public class IsValidCreditCardTests
    {
        IsCardNumberValid _CreditCardNumber;
        [TestMethod]
        public void CreditCardValidation_CheckCreditCardNumberContainOnlyDigits_ReturnsTrueOnDigitsOnly()
        {
            //Arrange  
            _CreditCardNumber = new IsCardNumberValid("4111111111111111");
            bool actual = false;
            //Act
            actual = _CreditCardNumber.Validate();
            //Assert
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void CreditCardValidation_CheckCreditCardNumberContainDecimals_ReturnsFalseOnDicimals()
        {
            //Arrange  
            _CreditCardNumber = new IsCardNumberValid("41111111111111.1");
            bool actual = false;
            //Act
            actual = _CreditCardNumber.Validate();
            //Assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void CreditCardValidation_CheckCreditCardNumberContainOtherDigits_ReturnsFlase()
        {
            //Arrange
            _CreditCardNumber = new IsCardNumberValid("4012888888abc881");
            bool actual = false;
            //Act
            actual = _CreditCardNumber.Validate();
            //Assert
            Assert.AreEqual(false, actual);
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
        public void CreditCardValidation_CheckValidDiscoverCreditCardNumberWith16Digits_ReturnsTureifValid()
        {
            //Arrange  
            _CreditCardNumber = new IsCardNumberValid("6011111111111117");
            bool actual = false;
            //Act
            actual = _CreditCardNumber.Validate();
            //Assert
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void CreditCardValidation_CheckValidMasterCreditCardNumberWith16Digits_ReturnsTrueifValid()
        {
            //Arrange  
            _CreditCardNumber = new IsCardNumberValid("5105105105105100");
            bool actual = false;
            //Act
            actual = _CreditCardNumber.Validate();
            //Assert
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void CreditCardValidation_CheckInValidMasterCreditCardNumberWith16Digits_ReturnsFalseifInValid()
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
        public void CreditCardValidation_CheckInvalidCreditCardNumber_ReturnsFlaseIfInvalid()
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
