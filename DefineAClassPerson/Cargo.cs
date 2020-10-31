namespace DefiningClasses
{
    public class Cargo
    {
        

        
        public Cargo(int weight, Type type)
        {
            this.Weight = weight;
            this.Type = type;
        }

        public int Weight
        {
            get;
            set;
        }

        public Type Type { get; set; }
    }
}
