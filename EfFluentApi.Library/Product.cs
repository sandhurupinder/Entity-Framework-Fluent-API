using System.Collections.Generic;

namespace EfFluentApi.Library
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int CategoryId { get; set; }                 // <-- Use for one to many and one to one relationships
        public Category Category { get; set; }              // <-- - Use for one to many and one to one relationships
                                                            //     - Make virtual for lazy loading

        // public IList<Category> Categories { get; set; }  // <-- Use for many to many relationships

        public override string ToString()
        {
            return $"[Product] ID: {Id}, Name: {Name}, Description: {Description}";
        }
    }
}
