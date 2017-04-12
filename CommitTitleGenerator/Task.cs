using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CommitTitleGenerator
{
    class Task
    {
        public string Category {get; private set;}
        public string Specifier { get; private set; }
        public string Author { get; private set; }
        public string Description { get; private set; }
        public string BugNo { get; private set; }
        
        //Return Commit Description in specific format
        public string returnCommitDescription()
        {            
            return ("\nBug: #" + BugNo + "  " + Category + ": " + Specifier + " | " + "Author: " + Author + " - " + Description + "(Close Issue: #" +BugNo + ")");            
        }

        //Saves commit description to file
        public bool saveToFile()
        {
            string s = returnCommitDescription();

            if (s == null)
                return false;

            File.AppendAllText("commitStrings.txt", s);
            return true;
        }

        // Constr
        public Task(string category, string specifier, string author, string description, string bugNumber)
        {
            Category = category;
            Specifier = specifier;
            Author = author;
            Description = description;
            BugNo = bugNumber;
        }
        // Constr
        public Task(string category, string specifier, string author, string description):this(category, specifier, author, description, null) { }
        public Task() { }
    }
}
