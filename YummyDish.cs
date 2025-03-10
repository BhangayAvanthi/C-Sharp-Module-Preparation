using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace M1Preparation
{
    public class YummyDish
    {
        // public string dish;
        //take list add dishnames
        //add yummy to dishnames for only n number of dishes and retun rn the newdishnames

        public List<string> list1;
        public List<string> list2;
        public YummyDish()
        {
            list1 = new List<string>();
            list2 = new List<string>();
        }
        public void AddDish(string element)
        {
            list1.Add(element);
        }
        public void GetNewDishes(int n)
        {
            n = Math.Min(n, list1.Count);
            for (int i = 0; i < n; i++)
            {
                list2.Add("yummy"+list1[i]);
                //Console.WriteLine(list2[i]);
            }
            Console.WriteLine("modified::");
            foreach(var dish in list2)
            {
                Console.WriteLine(dish);
            }
        }

    }
}
