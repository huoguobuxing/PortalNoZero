using System.Data.Entity.Migrations;

namespace Prnewswire.PortalNoZero.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<PortalNoZero.EntityFramework.PortalNoZeroDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "PortalNoZero";
        }

        protected override void Seed(PortalNoZero.EntityFramework.PortalNoZeroDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
