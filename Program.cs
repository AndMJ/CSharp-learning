using System;

namespace leaning
{
    class Person
    {
        private Guid id;
        private string name;
        private List<Product> boughtProducts = new List<Product>();

        public Person(string name, List<Product> products)
        {
            this.id = Guid.NewGuid();
            this.name = name;

            foreach (Product product in products) {
                this.boughtProducts.Add(product);
            }
        }

        //Getters
        public Guid getID(){
            return this.id;
        }

        public string getName(){
            return this.name;
        }

        //Setters
        public void setName(string name){
            this.name = name;
        }

        //Custom ToString()
        public override string ToString()
        {
            string prods = string.Join(",", this.boughtProducts);
            return "id: " + this.getID() + ", name: " + this.getName() + ", Products: [" + prods + "]";
        }
    }

    class Program
    {
        static void Main(string[] args)
        { 
            Person p1 = new Person("Diogo Mourinho", new List<Product> { new Product("WD40", "Lubrificar", 14.99), new Product("Cuecas", "porque as outras estao cagadas", 5) });
            Console.WriteLine(p1.ToString());
        }
    }
}

