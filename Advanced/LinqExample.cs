using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Advanced
{
    public class LinqExample
    {
        public void ShowmeLinq()
        {
            string[] names = { "Tom", "Don", "Harry", "Mary", "Jay", "selam", "Wende" };

            IEnumerable<string> query = names
            .Where(n => n.Contains("y") || n.Contains("b"))
            .OrderBy(n => n.Length)
            .Select(n => n.ToUpper());



            foreach (string name in query) Console.WriteLine(name);


        }
    }
}
