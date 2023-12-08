using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFuncionarios.Entities
{
    internal class Employer
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employer() { }

        public Employer(string name, int hours, double valuePerHour) 
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment() 
        {
            return ValuePerHour * Hours;
        }

        public override string ToString()
        {
            return Name + " - R$ " + Payment().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
