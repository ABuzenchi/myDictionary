using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class Word
    {
        public string name { get; set; }
        public string description { get; set; }
        public string photoPath { get; set; }
        Category categoryWord { get; set; }

        public Word(string name, string description, string photoPath, Category categoryWord)
        {
            this.name = name;
            this.description = description;
            this.photoPath = photoPath; 
            this.categoryWord = categoryWord;
        }
    }
}
