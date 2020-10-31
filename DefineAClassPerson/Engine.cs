namespace DefiningClasses
{
    public class Engine
    {
        private int _displacement;
        private int _power;
        private string _model;
        private string _efficiency;

        public Engine(string name, int power,int displacement):this(name, power)
        {
            this._displacement = displacement;

        }

        public Engine(string name, int power,int displacement, string efficiency):this(name, power, displacement)
        {
            this._efficiency = efficiency;
        }

        public Engine(string name, int power)
        {
            this._model = name;
            this._power = power;
        }

        public string Model
        {
            get => this._model;
            set => this._model = value;
        }

        public string Efficiency {
            get => this._efficiency;
            set => this._efficiency = value;
        }

        public int Displacement
        {
            get => this._displacement;
            set => this._displacement = value;
        }

        public int Power
        {
            get => this._power;
            set => this._power = value;
        }
    }
}
