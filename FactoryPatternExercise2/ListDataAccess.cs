using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("Loading data from List");
            return new List<Product>
            {
                new Product() { Name="Paper plates",Price=2.12M},
                new Product() { Name="Light bulb", Price=0.95M},
                new Product() {Name="Lawn Mower", Price=934.5M}
            };
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a List");
        }
    }
}
