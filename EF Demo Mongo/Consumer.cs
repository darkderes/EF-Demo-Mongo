using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Demo_Mongo
{
    public class Consumer
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public Address? Address { get; set; }
        public List<Address> Addresses { get; set; }

    }
    public class  Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
    }
}
