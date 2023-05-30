using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz11
{
    public class Shop : IDisposable
    {
        public StringBuilder title { get; set; }
        public StringBuilder address { get; set; }
        public Type type { get; set; }

        public void Show()
        {
            Console.WriteLine("Shop characteristics:");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Type: {type}");
        }
        public void Dispose()
        {
            title.Clear();
            address.Clear();
            type = 0;
            Console.WriteLine("delete");
        }
        public Shop(string Title, string Address, string Type)
        {
            title = new StringBuilder(Title);
            address = new StringBuilder(Address);
            type = (Type)Enum.Parse(typeof(Type), Type);
            Console.WriteLine(" create");
        }
    }
    public enum Type
    {
        Clothing,
        Shoes,
        Grocery,

    }
}