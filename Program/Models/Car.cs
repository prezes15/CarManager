using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    internal class Car
    {
        string mark;
        string model;
        int yearOfProduction;
        bool accessibility = true;


        public int Id {get; set;}

        
        public string Mark
        {
            get { return mark; }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    mark = value;
                }
                else
                {
                    throw new ArgumentException("You didn't specify the brand");
                }
            }
        }
        public string Model
        {
            get { return model; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    model = value;
                }
                else
                {
                    throw new ArgumentException("You didn't specify the model");
                }
            }
        }
        public int YearOfProduction
        {
            get { return yearOfProduction; }
            set
            {
                if (value >= 1860 && value <= 2025)
                {
                    yearOfProduction = value;
                }
                else
                {
                    throw new ArgumentException("The wrong year of production was given");
                }
            }
        }
        public bool Accessibility
        {
            get { return accessibility; }
            set { accessibility = value; }
        }

        public Car(int id, string mark, string model, int yearOfProduction, bool accessibility)
        {
            Id = id;
            Mark = mark;
            Model = model;
            YearOfProduction = yearOfProduction;
            Accessibility = accessibility;

        }
        
    }
}
