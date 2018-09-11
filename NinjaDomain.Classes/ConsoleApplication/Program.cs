using System;
using NinjaDomain.Classes;
using NinjaDomain.DataModel;

namespace ConsoleApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            InsertNinja();
            //InsertMultipleNinjas();
            //InsertNinjaWithEquipment();
            //InsterNinjaQuery();
            //InstertNinjaGraphQuery();
            //QueryAndUpdateNinja();
            //QueryAndUpdateNinjaDisconnected();
            //DeleteNinja();
            Console.ReadKey();
        }
        
        private static void InsertNinja()
        {
            var ninja = new Ninja
            {
                Name = "JulieSan",
                ServedInOniwaban = false,
                DateOfBirth = new DateTime(1980, 1, 1),
                ClanId = 1,
            };
            using (var context = new NinjaContext())
            {
                context.Database.Log = Console.Write;
                context.Ninjas.Add(ninja);
                context.SaveChanges();
            }
        }
    }
}
