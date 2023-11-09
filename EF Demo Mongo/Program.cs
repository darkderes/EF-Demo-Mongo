using EF_Demo_Mongo;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;

var customer = new Consumer
{
    Name = "John Doe",
    Address = new()
    {
        Street = "123 Main Street",
        City = "New York",
        ZipCode = "10001",
        Country = "USA"
    },
    Addresses = new List<Address>()
      {
          new ()
          {
              Street = "123 Main Street",
              City = "New York",
              ZipCode = "10001",
              Country = "USA"
          },
       
      }
};

var mongoDatabase = new MongoClient("mongodb://localhost:27017").GetDatabase("EFCoreMongoDemo");

var dbContextOption = new DbContextOptionsBuilder<dbContext>()
    .UseMongoDB(mongoDatabase.Client,mongoDatabase.DatabaseNamespace.DatabaseName);

var db = new dbContext(dbContextOption.Options);

db.Consumers.Add(customer);
db.SaveChanges();
    