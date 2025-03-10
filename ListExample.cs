using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1Preparation
{
    class ListExample
    {
        //add elements to list
        public List<char> initial;
        public ListExample()
        {
            initial = new List<char>();
        }
        public void AddElement(char ch)
        {
            initial.Add(ch);
        }
        public void ChangeOccurence(char toreplace, char with)
        {
            for (int i = 0; i < initial.Count; i++)
            {
                if (initial[i] == toreplace)
                {
                    initial[i] = with;
                }
            }
            //foreach(char ch in initial)
            //{
            //    Console.WriteLine(ch);
            //}
            Console.WriteLine("change occurence funtion::[" + string.Join(",", initial) + "]");
        }

        public void ListIndex()
        {
            if (initial.Count == 0)
            {
                Console.WriteLine("empty list");
            }
            Console.WriteLine($"list index element::{initial[0]}");
        }

        public void AfterElement(char before,char after)
        {
            //for (int i = 0; i <initial.Count; i++)
            //{
            //    if (initial[i] == before)
            //    {
            //        if (i + 1 < initial.Count)
            //        {
            //            // initial[i + 1] = after;
            //            initial.Insert(i + 1, after);
            //        }
            //        else
            //        {
            //            initial.Add(after);
            //        }
            //        i++;
            //    }
            //}

            List<char> modifiedone = new List<char>();
            foreach(char ch in initial)
            {
                modifiedone.Add(ch);
                if (ch == before)
                {
                    modifiedone.Add(after);
                }
            }
            initial = modifiedone;
            Console.WriteLine("adding a letter after a specific element::[" + string.Join(",", initial) + "]");
        }
    }
}
