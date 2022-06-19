using System;

namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine();
                Console.WriteLine("Choose data access type: {List, Mongo, SQL, [exit])");
                string accessType = Console.ReadLine();
                IDataAccess dataAccess = DataAccessFactory.GetDataAccessType(accessType);
                if (dataAccess != null)
                {
                    var products = dataAccess.LoadData();
                    Console.WriteLine();
                    Console.WriteLine($"{"Name",-20} | {"Price",-20}\r\n{new string('-', 43)}");
                    foreach (var product in products)
                    {
                        Console.WriteLine($"{product.Name,20} | {product.Price,20:$0.00}");
                    }
                    Console.WriteLine();
                    dataAccess.SaveData();
                }
                else
                {
                    return;
                }
            }
        }
    }
}
