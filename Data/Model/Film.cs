using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Film
    {
        public int Id { get; set; }

        private string title;

        public string Title
        {
            get { return title; }
            set
            {
                if(string.IsNullOrEmpty(value) || value.Length < 1)
                {
                    throw new ArgumentException("Film's title must be at least 1 symbol long.");
                }
                this.title = value;
            }
        }

        public string Description { get; set; }

        private int year;

        public int Year
        {
            get { return year; }
            set
            {
                if(value > DateTime.Now.Year)
                {
                    throw new ArgumentException("Please enter a valid year.");
                }
                this.year = value;
            }
        }

        public string Genre { get; set; }
    }
}
