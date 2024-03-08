using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndDictionaryInCSharp
{
    internal class Author
    {
        private string _name;
        private string _title;
        private bool _mvp;
        private DateTime _pubdate;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }
        public bool Mvp
        {
            get
            {
                return _mvp;
            }
            set
            {
                _mvp = value;
            }
        }
        
        public DateTime Pubdate
        {
            get
            {
                return _pubdate;
            }
            set
            {
                _pubdate = value;
            }
        }
    
    public void ManipulateList()
    {
        List<Author> list = new List<Author>();
        list.Add(new Author { Name="Winner", Title="Haunted House", Mvp=true, Pubdate = new DateTime(2024, 5, 5)});
        list.Add(new Author { Name = "Maryann", Title = "Red Roses", Mvp = false, Pubdate = new DateTime(2015, 7, 5)});
        list.Add(new Author { Name = "Ikechukwu", Title = "Ike goes to School", Mvp = true, Pubdate = new DateTime(1997, 1, 8)});
        list.Add(new Author { Name = "Sophia", Title = "Sohia the First", Mvp = true, Pubdate = new DateTime(2002, 5, 5) });
        list.Add(new Author { Name = "John", Title = "The Last Bender", Mvp = true, Pubdate = new DateTime(2020, 5, 5) });

        foreach (Author author in list)
        {
                Console.WriteLine("The Name of the Author is {0}, Title is {1}, Mvp is {2} and Pubdate is {3}",
                author._name, author._title, author._mvp, author._pubdate);
        }

    }
        public void ManipulationDict()
        {
            string[] fruits = { "Mango", "Banana", "PineApple", "Apple", "Orange", "WaterMelon"};
            Dictionary<string, int> myDict = new Dictionary<string, int>();
            myDict.Add(fruits[0], 12);
            myDict.Add(fruits[1], 15);
            myDict.Add(fruits[2], 17);
            myDict.Add(fruits[3], 22);
            myDict.Add(fruits[4], 45);
            myDict.Add(fruits[5], 98);

            foreach(KeyValuePair<string, int> pair in myDict)
            {
                Console.WriteLine(pair.Key); 
            }
        }
    
    }
}
