using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Properties
{
    class PersonModel
    {
        public string FirstName { private get; set; }
        public string LastName { get; private set; }


        //full properties. 

        private int _age;

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value>=0 && value <126)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value","age need to be in a valid range");
                }
            }
        }

        //Full properties.

        private string _ssn;

        public string SSN
        {
            get
            {
                //123-45-6789
                string codedSsn = "***-**-" + _ssn.Substring(_ssn.Length - 4);
                return codedSsn;

            }
            set
            {
                _ssn = value;
            }
        }



        private string _password;

        public string Password
        {
            
            set { _password = value; }
        }



        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }



        public PersonModel(string firstName,string lastname)
        {
            this.FirstName = firstName;
            LastName = lastname;
        }

        public PersonModel(string firstName,string lastName,int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }


    }
}
