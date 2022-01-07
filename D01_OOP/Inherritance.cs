using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_OOP
{

    class Inherritance
    {
        #region Properties
        public string Name { get; set; }
        #endregion

        #region Methods
        public void ListName()
        {
            Console.WriteLine($"Name:{ Name}");
        }
        #endregion

    }

    class InheritanceChild : Inherritance
    {
        #region Properties
        public string Surname { get; set; }
        #endregion

        #region Methods
        public void ListSurname()
        {
            Console.WriteLine($"surname: {Surname}");
        }
        #endregion

    }

    // properties:name, surname, fullname
    //constructors:vazio, passsar todos valores
    //methods: ListFullName
    class Person
    {
        #region Properties
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fullname { get; set; }
        #endregion

        #region Constructors


        public Person()
        {
            Name = string.Empty;
            Surname = string.Empty;
            Fullname = string.Empty;

        }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Fullname = $"{Name} {Surname}";
        }
        #endregion

        #region Methods
        public void ListFullName()
        {
            Console.WriteLine($"Full Name:{Fullname}");
        }
        #endregion


    }

    //inheritance:person
    //properties: course, location
    //construcors: aguadar
    //Methods: ListAll (all properties in 1 sentence)
    class Student : Person
    {
        #region Properties
        public string Course { get; set; }
        public string Location { get; set; }
        #endregion

        #region Constructors
        //mapear este construtor para o 1º construtor da base classe=construtor vazio de person
        public Student() : base()
        {
        }

        //mapear este construtor para o 2º da base classe
        public Student(string name, string surname) : base(name, surname)
        {

        }

        //Este e o novo construtor da propria classe
        public Student(string name, string surname, string course, string location)
        {
            Name = name;
            Surname = surname;
            Fullname=$"{name} { surname}";
            Course = course;
            Location = location;
        }
        #endregion

        #region Methods
        public void ListAll()
        {
           
            Console.WriteLine($"O formando {Fullname} mora {Location} e anda no curso {Course}.");
            Console.WriteLine($"O formando {Name}{Surname} mora {Location} e anda no curso {Course}.");
        }
        #endregion

    }


}