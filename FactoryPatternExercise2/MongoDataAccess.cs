using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("Loading data from MongoDB");
            return new List<Product>
            {
                new Product() { Name="Mongo Light bulb", Price=1.45M },
                new Product() { Name="Mongo Paper plates", Price=23.12M },
                new Product() { Name="Mongo Lawn Mower", Price=2334.5M }
            };
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to MongoDB");
        }
    }
}
