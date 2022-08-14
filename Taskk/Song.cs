using System;
using System.Collections.Generic;
using System.Text;

namespace Taskk
{
    internal class Song:Singer
    {
        public string Name { get; set; }
        private string Genre { get; set; }
        private string Singer { get; set; }

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
        public string _singer
        {
            get
            {
                return Singer;
            }
            set
            {
                
                    _singer = value;
            }
        }
           
    }
}
