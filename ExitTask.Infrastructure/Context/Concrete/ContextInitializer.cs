namespace ExitTask.Infrastructure.Context.Concrete
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;

    using ExitTask.Domain.Entities.Concrete;
    using ExitTask.Domain.Entities.Concrete.Enums;

    public class ContextInitializer : DropCreateDatabaseIfModelChanges<EfContext>
    {
        protected override void Seed(EfContext db)
        {
            //var users = new List<User>()
            //{
            //    new User()
            //    {
            //        FirstName = "Sergey",
            //        LastName = "Nestertsov",
            //        Sex = Sex.Male,
            //        Role = Role.Admin
            //    },

            //    new User()
            //    {
            //        FirstName = "Andrey",
            //        LastName = "Nestertsov",
            //        Sex = Sex.Male,
            //        Role = Role.Admin
            //    },

            //    new User()
            //    {
            //        FirstName = "Alexandr",
            //        LastName = "Nestertsov",
            //        Sex = Sex.Male,
            //        Role = Role.Admin
            //    }
            //};

            //users.ForEach(u => db.Set<User>().Add(u));
            //db.SaveChanges();


            var tours = new List<Tour>()
            {
                new Tour()
                {
                    Name = "Super tour 1",
                    Type = TourType.Shopping,
                    Description = "This tour is fucking awesome!!",
                    StartDate = DateTime.Now,
                    NightNumber = 5,
                    Price = 577.0m

                },
                new Tour()
                {
                    Name = "Super tour 2",
                    Type = TourType.Shopping,
                    Description = "This tour is really fucking awesome!!",
                    StartDate = DateTime.Now,
                    NightNumber = 5,
                    Price = 577.0m
                }

            };

            tours.ForEach(t => db.Set<Tour>().Add(t));
            db.SaveChanges();
        }
    }
}
