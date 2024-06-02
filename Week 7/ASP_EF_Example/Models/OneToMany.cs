namespace EFCoreExample.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        //This establishes a one-to-many relationship for the Category Class
        //A category can be associated with many products
        //We use the ICollection<> interface bc EF manages this relationship for us
        public ICollection<Product> Products { get; set; }
    }

    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        //Products can only have a single Category
        //Products will also hold the foreign key associated wiht the Category
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
