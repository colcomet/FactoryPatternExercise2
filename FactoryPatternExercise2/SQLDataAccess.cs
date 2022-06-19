using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("Loading data from SQL Server");
            return new List<Product>
            {
                new Product() { Name="SQL Paper plates",Price=23.12M},
                new Product() { Name="SQL Light bulb", Price=12.45M},
                new Product(){Name="SQL Lawn Mower", Price=23334.5M}
            };
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to SQL");
        }
    }
}
