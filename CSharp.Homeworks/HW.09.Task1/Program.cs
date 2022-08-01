// See https://aka.ms/new-console-template for more information
using HW._09.Task1;

Console.WriteLine("Hello, World!");

        Person person = new Person("Tom");
        person.Greet();

        Student student = new Student("Jim");
        student.SetAge(21);
        student.Greet();
        student.ShowAge();

        Teacher teacher = new Teacher("Jean");
        teacher.SetAge(30);
        teacher.Greet();
        teacher.Explain();