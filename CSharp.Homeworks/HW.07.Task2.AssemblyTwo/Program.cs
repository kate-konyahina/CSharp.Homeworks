// See https://aka.ms/new-console-template for more information
using HW._07.Task2.AssemblyOne;

namespace hw07
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle moto1 = new Motorcycle();
            int speed = 100 + Motorcycle.MaxSpeed; // публичная константа Motorcycle.MaxSpeed доступна и в этой сборке, так как подключена к содержащей элмент сборке
            //int speedHonda = 100 + Motorcycle.MaxSpeedHonda; // protected константа MaxSpeedHonda не доступна и во второй сборке, так как доступна только в типе (классе), в котором определен, и в наследникахэтого типа 
            //int vinNum1 = Motorcycle.vinNumber; // приватное поле vinNumber недоступно, так как доступно только в том типе(класс Motorcycle), в котором определено.
            //moto1.odometer += 228; // protected internal поле не доступно в сборке не содержащей его 
            //moto1.Color = "red"; // private protected свойство недоступно, так как его доступ ограничен содержащимклассом или типами, которые являются производными (наследниками) от 
            //содержащего класса в текущей сборке.
            //moto1.StartEngine(); //  internal метод доступен только в той сборке, где описан.
        }
    }
    public class Scooter : Motorcycle
    {
        int speedsc = 100 + Motorcycle.MaxSpeed; // публичная константа Motorcycle.MaxSpeed доступна
        int speedHonda2 = 100 + Motorcycle.MaxSpeedHonda; // protected константа MaxSpeedHonda доступна, так как Scooter наследник Motorcycle
        //int vinNum1 = Motorcycle.vinNumber; // приватное поле vinNumber недоступно, так как доступно только в том типе(класс Motorcycle), в котором определено.
        internal void Access()
        {
            var sc1 = new SportBike();
            //sc1.Color = Color; // private protected свойство недоступно, так как как Scooter наследник Motorcycle, но находится в другой сборке 
        }
    }
}