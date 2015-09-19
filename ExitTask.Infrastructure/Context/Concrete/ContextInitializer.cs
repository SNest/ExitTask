namespace ExitTask.Infrastructure.Context.Concrete
{
    using System.Collections.Generic;
    using System.Data.Entity;

    using ExitTask.Domain.Entities.Concrete;
    using ExitTask.Domain.Entities.Concrete.Enum;

    public class ContextInitializer : DropCreateDatabaseIfModelChanges<EfContext>
    {
        protected override void Seed(EfContext db)
        {
            var users = new List<User>()
            {
                new User()
                {
                    FirstName = "Sergey",
                    LastName = "Nestertsov",
                    Sex = UserSex.Male,
                    Role = UserRole.Admin,
                    Password = "1234",
                    Email = "n@gmail.com"
                },

                new User()
                {
                    FirstName = "Andrey",
                    LastName = "Nestertsov",
                    Sex = UserSex.Male,
                    Role = UserRole.Admin,
                    Password = "1234",
                    Email = "na@gmail.com"
                },

                new User()
                {
                    FirstName = "Alexandr",
                    LastName = "Nestertsov",
                    Sex = UserSex.Male,
                    Role = UserRole.Admin,
                    Password = "1234",
                    Email = "nga@gmail.com"
                }
            };

            users.ForEach(u => db.Set<User>().Add(u));
            db.SaveChanges();


            //var tours = new List<Tour>()
            //{
            //    new Tour()
            //    {
            //        Name = "Super tour 1",
            //        Type = TourType.Shopping,
            //        Description = "This tour is fucking awesome!!",
            //        StartDate = DateTime.Now,
            //        NightNumber = 5,
            //        Price = 577.0m

            //    },
            //    new Tour()
            //    {
            //        Name = "Super tour 2",
            //        Type = TourType.Shopping,
            //        Description = "This tour is really fucking awesome!!",
            //        StartDate = DateTime.Now,
            //        NightNumber = 5,
            //        Price = 577.0m
            //    }

            //};

            //tours.ForEach(t => db.Set<Tour>().Add(t));
            //db.SaveChanges();
        }
    }
}
