using ClientMigratorRabobank.Repositories;
using Rabobank.GCOB.External;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientMigratorRabobank
{
    public class DataProcessor
    {
        ClientRepository repository = new ClientRepository();

        public DataProcessor()
        {
            var repository = new ClientRepository();
            this.repository = repository;
        }

        public void ProcessData()
        {
            var file = (new ReadData()).GetData();

            foreach (var l in file)
            {
                Client c;

                if (l[0] == "LegalEntity")
                {
                    c = new Client();
                    c.FullName = l[1];
                    c.EntityType = (EntityType)Enum.Parse(typeof(EntityType), l[9]);
                    c.Turnover = decimal.Parse(l[8]);
                    var a = new Address();
                    a.Line1 = l[2];
                    a.Line2 = l[3];
                    a.Line3 = l[4];
                    a.City = l[5];
                    a.PostCode = l[2];
                    a.Country = l[2];
                    c.Address = a;

                    var result = Robotics.ScreeningAsync(l[1], l[7]).Result;

                    if (result != "Failed") repository.UpdateClient(c);
                }
                else
                {
                    c = new Client();
                    c.FullName = l[1];
                    c.FirstName = l[1].Substring(0, l[1].LastIndexOf(" "));
                    c.LastName = l[1].Substring(l[1].LastIndexOf(" "));
                    c.EntityType = EntityType.Unknown;
                    var a = new Address();
                    a.Line1 = l[2];
                    a.Line2 = l[3];
                    a.Line3 = l[4];
                    a.City = l[5];
                    a.PostCode = l[6];
                    a.Country = l[7];
                    c.Address = a;
                }

                repository.UpdateClient(c);
            }
        }
    }
}
