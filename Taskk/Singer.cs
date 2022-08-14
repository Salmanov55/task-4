using System;
using System.Collections.Generic;
using System.Text;

namespace Taskk
{
    internal class Singer
    {
        private string Name { get; set; }
        private string Surname { get; set; }
        private int Age { get; set; }

        public string _name
        {
            get     
            { 
             return _name; 
            }
            set
            {
                if (value.Length > 0 && value.Length <= 100) 
                _name = value;
            }
        }
        public string _surname
        {
            get 
            {
                return _surname; 
            }
            set
            {
                if (value.Length > 0 && value.Length <= 100) ;
            }
        }
        public int _age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 0 && value <= 170) ;
            }
        }
    }
}
