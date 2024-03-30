using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionLibrary
{
    public class Customer : Person, IPerson
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = "Bruce";

        public Customer()
        {

        }

        public void PrintAssamblies()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            Assembly callingAssambly = Assembly.GetCallingAssembly();

            Console.WriteLine($"Reflection library : {assembly.FullName}");
            Console.WriteLine($"Reflection library Calling Assambly : {callingAssambly.FullName}");

        }

        public Assembly GetExecutingAssambly()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            return assembly;
        }
    }
}
