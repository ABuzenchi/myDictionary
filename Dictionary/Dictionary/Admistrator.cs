using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dictionary
{
    internal class Admistrator
    {
        private Dictionary<string, string> administrator  = new Dictionary<string, string>();
        public Admistrator()
        {
            LoadUserCredentials(); 
        }
        private void LoadUserCredentials()
        {
            string[] lines = File.ReadAllLines("E:\\AnulII\\MAP\\Dictionary\\Dictionary\\administrators.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(' ');
                if (parts.Length == 2)
                {
                    administrator.Add(parts[0], parts[1]);
                }
            }
        }
        public bool Authenticate(string username, string password)
        {
            if (administrator.ContainsKey(username))
            {
                if (administrator[username] == password)
                {
                    return true; 
                }
            }
            return false; 
        }
        void test()
        {
            //empty
        }
    }
   
}
