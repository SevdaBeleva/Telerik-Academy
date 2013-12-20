using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Creature
{
    enum Gender { Male, Female };

    public class Human
    {
        private Gender gender { get; set; }
        private string name { get; set; }
        private int age { get; set; }

        public void CreateHuman(int age)
        {
            Human human = new Human();
            human.age = age;

            if (age%2 == 0)
            {
                human.name = "Anton";
                human.gender = Gender.Male;
            }
            else
            {
                human.name = "Veselka";
                human.gender = Gender.Female;
            }      
        }
    }
}

