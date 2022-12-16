using BlazorShoes.Models;

namespace BlazorShoes.Data
{
    /// <summary>
    /// Could be called InitialiseDb
    /// Adds seed data to the database to initialise it
    /// 
    /// </summary>
    public static class SeedData
    {
        public static void Initialise(ApplicationDbContext context)
        {
            
            seedAddresses(context);
        }

        private static void seedAddresses(ApplicationDbContext context)
        {
            if(context.Addresses.Any()) 
            {
                return;
            }

            var addresses = new Address[]
            {
                new Address()
                {   HouseNumber = 4, RoadName="High Street",
                    PostTown = "Watford", Postcode="WD5 8TY"
                },
                new Address()
                {
                    HouseNumber = 40, RoadName="Abbots Road",
                    PostTown = "Watford", Postcode="WD5 8TZ"
                },
                new Address()
                {
                    HouseNumber = 72, RoadName="River Street",
                    PostTown = "Aylesbury", Postcode="AY5 8ER"
                },
                new Address()
                {
                    HouseName = "Bueno Vista", RoadName="Long Road",
                    PostTown = "Amersham", Postcode="AM1 3UY"
                },
            };

            context.Addresses.AddRange(addresses);
            context.SaveChanges();
        }
    }
}
