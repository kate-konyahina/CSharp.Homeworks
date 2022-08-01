using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._07.Task2.AssemblyOne
{
    public class Motorcycle
    {
        public const ushort MaxSpeed = 300;
        protected const ushort MaxSpeedHonda = 350;
        private int vinNumber = 123;
        protected internal int odometer = 200_000;

        internal void StartEngine()
        {

        }
        private protected string Color { get; set; }
       
    }
    public class SportBike : Motorcycle
    {
        int speedsp = 100 + Motorcycle.MaxSpeed; // публичная константа Motorcycle.MaxSpeed доступна везде, где подключен Motorcycle
        int speedHonda = 100 + Motorcycle.MaxSpeedHonda; // protected константа MaxSpeedHonda доступна, так как SportBike наследник Motorcycle
        //int vinNum1 = Motorcycle.vinNumber; // приватное поле vinNumber недоступно, так как доступно только в том типе(класс Motorcycle), в котором определено.
       internal void Access()
        {
            var sp1 = new SportBike();
            sp1.Color = Color; // private protected свойство доступно, так как как SportBike наследник Motorcycle в текущей сборке 
        }

    }

}
