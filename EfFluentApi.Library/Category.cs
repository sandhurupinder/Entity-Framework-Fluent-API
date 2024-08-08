using System.Collections.Generic;

namespace EfFluentApi.Library
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<Product> Products { get; set; }    // <-- - Use for one to many and many to many relationship
                                                        //     - Make virtual for lazy loading

        // public Product Product { get; set; }         // <-- Use for one to one relationship
        // public int ProductId { get; set; }           // <-- Use for one to one relationship
        
        public override string ToString()
        {
            return $"[Category] ID: {Id}, Name: {Name}";
        }
    }
}
