using System;

namespace Properties_Get_Set
{
    public class Person
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public DateTime BrithDate { get; private set; }


        public Person(DateTime birthdate)
        {
            BrithDate = birthdate;

        }
        

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - BrithDate;
                
                var years = timeSpan.Days / 365;
                return years;
            }
            
        }
    }
}