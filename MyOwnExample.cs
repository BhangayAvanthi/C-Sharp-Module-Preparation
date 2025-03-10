using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1Preparation
{
    public class MyOwnException : Exception
    {
        public override string Message => $"{DateTime.Now.ToString()}-- internal exception at execution";

    }
    public class MyOwnExample:MyOwnException
    {
        public void example()
        {
            int x = 10;
            try
            {
                //x = x / 0;
                throw new MyOwnException();
            }
            catch (MyOwnException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
