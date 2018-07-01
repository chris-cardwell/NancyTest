using System.Data.Entity;

namespace TestNancy.DataServices
{
    class TestContext : DbContext
    {
        public DbSet<TestEntity> TestEntities { get; set; }

        public TestContext() : base(nameOrConnectionString: "Default") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");

            modelBuilder.Entity<TestEntity>().ToTable("TestEntities");

            base.OnModelCreating(modelBuilder);
        }
    }
}
