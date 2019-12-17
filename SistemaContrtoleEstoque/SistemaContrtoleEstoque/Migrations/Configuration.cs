namespace SistemaContrtoleEstoque.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SistemaContrtoleEstoque.Model.SistemaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SistemaContrtoleEstoque.Model.SistemaContext";
        }

        protected override void Seed(SistemaContrtoleEstoque.Model.SistemaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
