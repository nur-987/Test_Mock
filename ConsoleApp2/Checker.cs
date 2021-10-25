using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Checker
    {
        public void Check(string str)
        {
            Dictionary<int, char> myDictionary = new Dictionary<int, char>();
            
            string[] arrrayOfWords = str.Split(' ');

            int count = 0;
            for (int i = 0; i < arrrayOfWords.Length; i++)
            {
                foreach (char chr in arrrayOfWords[i])
                {

                    if (myDictionary.ContainsValue(chr))
                    {
                        //contains in dict 
                        //no need to add the letter in

                    }
                    else
                    {
                        //doesnt contain in dict, 
                        // new letter => add in dict
                        myDictionary.Add(count++, chr);
                    }

                }

                var myList = myDictionary.Values.ToList();
                foreach (char item in myList)
                {
                    Console.Write(item);
                }

                myDictionary.Clear();
                Console.Write(" ");

            }
        }
    }
}
