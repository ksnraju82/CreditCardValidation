using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardValidation
{
    public class IsCardNumberValid
    {
        private string _cardNumber;
        public IsCardNumberValid(string cardNumber)
        {
            _cardNumber = cardNumber.Trim();
        }
        public bool Validate()
        {
            bool result = false;
            //check whether cardnumber has only numbers.
            //if yes, check the length of card.
            if (!string.IsNullOrEmpty(_cardNumber))
            {
                if (IsDigitsOnly(_cardNumber) && _cardNumber.Length == 16)
                {
                    //check whether cardnumber is valid using MOD10 algorithm.
                    return result = ValidateCardNumber(_cardNumber);
                }
                else if (IsDigitsOnly(_cardNumber) && _cardNumber.Length == 15 && 
                    (_cardNumber.StartsWith("34") || _cardNumber.StartsWith("37")))
                {
                    //check whether cardnumber is valid using MOD10 algorithm.
                    return result = ValidateVisaOrAmexCardNumber(_cardNumber);
                }
                else if (IsDigitsOnly(_cardNumber) && _cardNumber.Length == 13 &&
                    _cardNumber.StartsWith("4"))
                {
                    //check whether cardnumber is valid using MOD10 algorithm.
                    return result = ValidateVisaOrAmexCardNumber(_cardNumber);
                }
            }
            else
                result = false;

            return result;
        }

        private bool IsDigitsOnly(string CardNumber)
        {
            foreach (char c in CardNumber)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private bool ValidateCardNumber(string cardnumber)
        {
            try
            {

                Int32[] _cardnumber = cardnumber.Select(x => Int32.Parse(x.ToString())).ToArray();

                //This is very straight forward way and easy to understand with basci c# validation of the MOD10 Algorithm
                //pick every alternate number, multiply by 2, if result is greated than 9, (sum up of the 2 digint number
                // or mod of 9 gives the same result, this is simple maths), assign the value to the same array and sum all the
                //items in array and mod by 10, if result is 0 it is valid or else not valid card number.
                for (int i = _cardnumber.Length - 1; i >= 0; i--)
                {
                    if (i == 0 || i % 2 == 0)
                        _cardnumber[i] = (_cardnumber[i] * 2 > 9) ? ((_cardnumber[i] * 2) % 9) : _cardnumber[i] * 2;
                }

                if (_cardnumber.Sum() % 10 == 0)
                    return true;
                else
                    return false;

            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }
        private bool ValidateVisaOrAmexCardNumber(string cardnumber)
        {
            try
            {

                Int32[] _cardnumber = cardnumber.Select(x => Int32.Parse(x.ToString())).ToArray();

                //This is very straight forward way and easy to understand with basci c# validation of the MOD10 Algorithm
                //pick every alternate number, multiply by 2, if result is greated than 9, (sum up of the 2 digint number
                // or mod of 9 gives the same result, this is simple maths), assign the value to the same array and sum all the
                //items in array and mod by 10, if result is 0 it is valid or else not valid card number.
                for (int i = _cardnumber.Length - 2; i >= 0; i--)
                {
                    if (i == 0 || i % 2 != 0)
                        _cardnumber[i] = (_cardnumber[i] * 2 > 9) ? ((_cardnumber[i] * 2) % 9) : _cardnumber[i] * 2;
                }

                if (_cardnumber.Sum() % 10 == 0)
                    return true;
                else
                    return false;

            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }
    }
}
