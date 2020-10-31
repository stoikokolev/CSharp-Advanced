using System;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        private string _model;
        private Engine _engine;
        private int _weight;
        private string _color;

        public int Weight
        {
            get => this._weight;
            set => this._weight = value;
        }

        public string Color {
            get => this._color;
            set => this._color = value;
        }

        public Engine Engine
        {
            get => this._engine;
            set => this._engine = value;
        }
        
        public string Model {
            get => this._model;
            set => this._model = value;
        }
        
        public Car(string model, Engine engine)
        {
            this._model = model;
            this._engine = engine;
        }

        

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{this._model}:");
            
            sb.AppendLine($" {this._engine.Model}:");
            
            sb.AppendLine($"  Power: {this._engine.Power}");
            
            sb.AppendLine(this._engine.Displacement != default
                ? $"  Displacement: {this.Engine.Displacement}"
                : $"  Displacement: n/a");

            sb.AppendLine(this._engine.Efficiency != default
                ? $"  Efficiency: {this.Engine.Efficiency}"
                : $"  Efficiency: n/a");

            sb.AppendLine(this._weight != default ? $" Weight: {this._weight}" : $" Weight: n/a");

            sb.AppendLine(this._color != default ? $" Color: {this._color}" : $" Color: n/a");


            return sb.ToString().Trim();
        }
    }

}
