using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1Preparation
{
    public class ExceptionHandling
    {
        public void Sample()
        {
            string input = null;
            try
            {
                int size = input.Length;
                Console.WriteLine(size);
            }
            catch(System.NullReferenceException ex)
            {
                Console.WriteLine("input string is null");
            }
            
            catch (Exception ex)
            {
                Console.WriteLine("exception occured!!");
            }
            finally
            {
                Console.WriteLine("multiple catchs");
            }
        }
    }
}
