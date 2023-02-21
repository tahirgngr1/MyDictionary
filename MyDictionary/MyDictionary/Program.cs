using System;
using System.Collections.Generic;

namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList myList = new MyList();
            myList.Ekle();
        }
    }
    public class MyList
    {
        Dictionary<int, string> myDictionary = new Dictionary<int, string>();
        public void Ekle()
        {
            myDictionary.Add(1, "Tahir");
            myDictionary.Add(2, "Kenan");
            myDictionary.Add(3, "Ahmet");
            myDictionary.Add(4, "Mehmet");
            foreach (KeyValuePair<int, string> kvp in myDictionary)
            {
                Console.WriteLine(kvp);
            }

        }    
    }

}
