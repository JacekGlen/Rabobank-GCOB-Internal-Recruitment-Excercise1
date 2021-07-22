using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientMigratorRabobank.Repositories
{
    public class ClientRepository
    {
        public void UpdateClient(Client client)
        {
            // Update client in the database, code removed for brevity
        }
    }

    public class Client
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public decimal? Turnover { get; set; }
        public EntityType EntityType { get; set; }
    }

    public class Address
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostCode { get; set; }
    }

    public enum EntityType
    {
        Unknown,
        Listed,
        Unlisted,
        Charity,
    }
}
