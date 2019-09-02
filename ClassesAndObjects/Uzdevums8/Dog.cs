using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzdevums8
{
    class Dog
    {
        private string _name;
        private string _sex;
        private Dog _mother;
        private Dog _father;

        public Dog Mother
        {
            get
            {
                return _mother;
            }
            set
            {
                _mother = value;
            }
        }
        public bool HasSameMotherAs(Dog otherDog)
        {
            return _mother._name == otherDog._mother._name;
        }
        public string FathersName()
        {
            return _father._name;
        }

        public Dog Father
        {
            get
            {
                return _father;
            }
            set
            {
                _father = value;
            }
        }
        public Dog(string name,string sex)
        {
            _name = name;
            _sex = sex;
        }
    }
}
