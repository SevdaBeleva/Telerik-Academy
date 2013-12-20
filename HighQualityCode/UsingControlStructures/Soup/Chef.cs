using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soup
{
    public class Chef
    {
        //create bool fields for the second task If Statements
        private bool IsPeeled { get; set; }
        private bool IsRotten { get; set; }

        public Chef()
        {
        }

        //Create methods for cooking soup
        private Carrot GetCarrot()
        {
            Carrot carrot = new Carrot();

            return carrot;
        }

        private Potato GetPotato()
        {
            Potato potato = new Potato();

            return potato;
        }

        private Bowl GetBowl()
        {
            Bowl bowl = new Bowl();

            return bowl;
        }

        private void Peel(Vegetable potato)
        {
            //...
        }

        private void Cut(Vegetable potato)
        {
            //...
        }

        public void Cook()
        {
            //method Cook uses all other methods. Different actions are separated by empty line
            Potato potato = GetPotato();
            Carrot carrot = GetCarrot();
            Bowl bowl = GetBowl();

            Peel(potato);
            Peel(carrot);

            Cut(potato);
            Cut(carrot);

            bowl.Add(potato); 
            bowl.Add(carrot);
        }

        //Create a method that checks if potato is good for cooking - task 2
        public void CheckPotato(Vegetable potato)
        {
            if (potato != null)
            {
                if (IsPeeled && IsRotten)
                {
                    Cook();
                }
            }
        }
    }
}
