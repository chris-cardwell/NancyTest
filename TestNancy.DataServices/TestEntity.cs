using System.Data.Entity;

namespace TestNancy.DataServices
{
    class TestEntity
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int? Year { get; set; }
        public string SomeNewColumn { get; set; }
    }
}
