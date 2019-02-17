namespace KSH.Babbages.Data.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Data\Migrations";
            MigrationsNamespace = "KSH.Babbages.Data.Migrations";
        }

        protected override void Seed(AppDbContext context)
        {

        }
    }
}
