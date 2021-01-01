using System;

namespace BTLinqVaArrayList

{
    public class staff
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int Id { get; set; }

        public staff(string name , int age , int id)
        {
            Name = name;
            Age = age;
            Id = id;
        }


        public string showInfo()
        {
            return $"ID:{Id}\tname:{Name}\t Age:{Age}";
        }    
    }
}