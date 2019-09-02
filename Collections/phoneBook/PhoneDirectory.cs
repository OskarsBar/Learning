using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string, string> _dataDictionary;
        

        public PhoneDirectory()
        {
            _dataDictionary = new SortedDictionary<string, string>();
            
            
        }

        private string Find(string name)
        {
            
                if (_dataDictionary.ContainsKey(name))
                {
                    return _dataDictionary[name];
                }
            
            return "None";
        }

        public string GetNumber(string name)
        {
            var position = Find(name);
            if (_dataDictionary.ContainsKey(name))
            {
                return _dataDictionary[name];
            }
            else
            {
                return null;
            }
        }

        public void PutNumber(string name, string number)
        {
            if (name == null || number == null)
            {
                throw new Exception("name and number cannot be null");
            }
            else
            {
                var i = Find(name);
                if (i == "none")
                {
                    _dataDictionary.Add(name, number);
                }
                else
                {
                    _dataDictionary[name] = number;
                }
            }
            
            
        }
    }
}
