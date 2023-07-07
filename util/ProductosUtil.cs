namespace SeDes {
    public class ProductosUtil {
        //Metodo para generar un arreglo de productos.
        public List<Product> GenerarProductos() {
            List<Product> products = new List<Product>();
            for (int i=1;i<=50;++i) {
                Product product = new Product{
                        ID = Faker.RandomNumber.Next(), 
                        Name = Faker.Company.Name(),
                        Price = Faker.RandomNumber.Next()
                    };
                products.Add(product);
            }
            return products;
         }
    }
}