// See https://aka.ms/new-console-template for more information
using HW._09.Task2;

Console.WriteLine("Hello, World!");

SmallApartment apart = new SmallApartment();
apart.door = new House.Door("green");
Person person = new Person("Tom");
person.house = apart;
person.ShowData();
