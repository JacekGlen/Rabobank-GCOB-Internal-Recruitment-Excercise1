using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientMigratorRabobank.Repositories;

namespace ClientMigratorRabobank
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataProcessor = new DataProcessor();
            dataProcessor.ProcessData();
        }
    }
}
