﻿using System.Data.Entity;

namespace HomeControlServer.DAL
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            context.SaveChanges();
        }
    }
}