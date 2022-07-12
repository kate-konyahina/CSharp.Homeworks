// See https://aka.ms/new-console-template for more information
using HW._07.Task2.AssemblyOne;

namespace hw07 
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle moto1 = new Motorcycle();
            int speed = 100 + Motorcycle.MaxSpeed; // публичная константа Motorcycle.MaxSpeed доступна в текущей сборке(и везде, где подключен класс Motorcycle)
            //int speedHonda = 100 + Motorcycle.MaxSpeedHonda; // protected константа MaxSpeedHonda не доступна, так как доступна только в типе (классе), в котором определен, и в наследниках этого типа 
            //int vinNum1 = Motorcycle.vinNumber; // приватное поле vinNumber недоступно, так как доступно только в том типе(класс Motorcycle), в котором определено
            // moto1.Color = "red"; // private protected свойство недоступно, так как его доступ ограничен содержащим классом  или типами, которые являются наследниками от содержащего класса в текущей сборке.
            moto1.odometer += 228; // protected internal поле доступно в содержащей его сборке без ограничений или типами, которые являются наследниками от одержащего класса в текущей сборке.
            moto1.StartEngine(); //  internal метод доступен без ограничений, в той сборке, где описан.
        }

    }
}