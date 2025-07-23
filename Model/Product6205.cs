namespace ProductAPI.Model
{
    public class Product6205
    {        
        public List<Dimension> Dimensions { get; set; }
        public List<Properties> Properties { get; set; }

    }

    public class Dimension
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public string Unit { get; set; }
        public string Symbol { get; set; }
    }

    public class Properties
    {
        public string Name { get; set; }
        public string Value { get; set; }
        
    }    
    
}
