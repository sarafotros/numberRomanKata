using System;
using System.Collections.Generic;
using Xunit;

namespace RomanToNumber
{
    public class RomanToNumberTest
    {
        private Converter _converter = new Converter();

        [Theory]
        [InlineData("I",1)]
        [InlineData("II", 2)]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("V",5)]
        [InlineData("VI", 6)]
        [InlineData("X", 10)]
        [InlineData("XX", 20)]
        [InlineData("XXIII", 23)]
        [InlineData("L", 50)]
        [InlineData("C", 100)]
        [InlineData("D", 500)]
        [InlineData("M", 1000)]
  
        public void AcceptRomanNumeral_RetrunsNumber(string romanNumeral, int number)
        {
            
            var result = _converter.toNumbers(romanNumeral);
            Assert.Equal(number, result);
        }
    }

    public class Converter
    {
        private Dictionary<string, int> _romanReference = new Dictionary<string, int>()
        {
            { "I", 1 },
            {"V", 5 },
            {"X", 10 },
            {"L", 50 },
            {"C", 100 },
            {"D", 500 },
            {"M", 1000 },
 
        };

        public int toNumbers(string romanNumeral)

        {
            var arrayInputRoman = romanNumeral.ToCharArray();
            var resultSum = 0;


            for (var i = 0; i < arrayInputRoman.Length; i++)
            {
                var roman = arrayInputRoman[i];
                
                if (_romanReference.ContainsKey(roman.ToString()))
                {
                    resultSum += _romanReference[roman.ToString()];
                }

            }
            //if (_romanReference.ContainsKey(romanNumeral))
            //{
            //    return _romanReference[romanNumeral];
            //}

            return resultSum;
        }
    }
}
