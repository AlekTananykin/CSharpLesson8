using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

/* Тананыкин
 * 
 * С помощью рефлексии выведите все свойства структуры DateTime
 */
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Список свойств структуры DateTime. \n");

            Type dataTimeType = typeof(DateTime);

            PropertyInfo[] properties = dataTimeType.GetProperties();
            for (int i = 0; i < properties.Length; ++i)
                Console.WriteLine(properties[i].Name);
            
            Console.ReadKey();
        }
    }
}
