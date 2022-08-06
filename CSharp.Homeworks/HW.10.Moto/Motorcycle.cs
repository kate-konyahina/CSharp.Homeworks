using HW._10.Moto.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._10.Moto
{
    public class Motorcycle : BaseEntity
    {
        protected internal override Guid Id { get; set; }

        public string Name { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public int Odometer { get; set; }

        public Motorcycle(string name, string model, int year, int odometer)
        {
            Id = Guid.NewGuid();
            Name = name;
            Model = model;
            Year = year;
            Odometer = odometer;
        }
    }
}
