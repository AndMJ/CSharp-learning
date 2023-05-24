class Product
{
    private Guid id;
    private string name;
    private string description;
    private double price;

    public Product(string name, string desc, double price)
    {
        this.id = Guid.NewGuid();
        this.name = name;
        this.description = desc;
        this.price = price;
    }
    
    //Setters
    public void setName(string name){
        this.name = name;
    }

    public void setDescription(string description){
        this.description = description;
    }

    public void setPrice(double price){
        this.price = price;
    }

    //Getters
    public Guid getID()
    {
        return this.id;
    }
    public string getName()
    {
        return this.name;
    }

    public string getDescription()
    {
        return this.description;
    }

    public double getPrice()
    {
        return this.price;
    }

    public override string ToString()
    {
        return "id: " + this.getID() + ", name: " + this.getName() + ", desc: " + this.getDescription() + ", price: " + this.getPrice();
    }
}

