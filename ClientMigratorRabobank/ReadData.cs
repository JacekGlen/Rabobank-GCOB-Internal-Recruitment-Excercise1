using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientMigratorRabobank
{
    public class ReadData
    {
        public List<string[]> GetData()
        {
            var a = System.IO.File.ReadAllLines("Data.csv", Encoding.Default);
            var b = a.Select(r => r.Split(',')).ToList();

            return b;
        }
    }
}
