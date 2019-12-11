using EF_TEST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new WeekrptMVCEntities())
            {
                var p = db.Project.FirstOrDefault();
                p.Name = "TEST";

                var enities = db.ChangeTracker.Entries();
                Console.WriteLine($"Enities Count: {enities.Count()}");
                foreach (var entry in enities)
                {
                    Console.WriteLine($"Table Name: {entry.Entity.GetType().Name}");
                    Console.WriteLine($"State: {entry.State}");

                    var propertyNames = entry.Entity.GetType().GetProperties();
                    foreach (var propertyInfo in propertyNames)
                    {
                        var name = propertyInfo.Name;

                        var oriValue = Convert.ToString(entry.OriginalValues[name]);
                        var currValue= Convert.ToString(entry.CurrentValues[name]);

                        Console.WriteLine($"-------------------");
                        Console.WriteLine($"Property Name: {name}");
                        Console.WriteLine($"Original Value: {oriValue}");
                        Console.WriteLine($"Current Value: {currValue}");
                    }
                }

                //db.SaveChanges();
            }
        }
    }
}
