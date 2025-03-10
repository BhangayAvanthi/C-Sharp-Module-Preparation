using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1Preparation
{
    public class CountryNames
    {
        //given country code return country name
        //if code is bet 70-99(99<=99) return india
        //if code=908 return Us
        // code=011 return dial somewhere outside of USA
        // else not found
        public string getCountryName(int countrycode)
        {
                if (countrycode >= 70 && countrycode <= 99)
                {
                    return "India";
                }
                else if (countrycode == 908)
                {
                    return "US";
                }
                else if (countrycode == 011)
                {
                    return "Dial ";
                }
                else
                {
                    throw new InvalidCodeException(countrycode);
                }

        }
    }
    public class InvalidCodeException : Exception
    {
        private int Code { get; }
       public InvalidCodeException(int code)
        {
            Code = code;
        }
        public override string Message => $"{DateTime.Now.ToString()}::::no country with given code---{Code}";
    }
}
