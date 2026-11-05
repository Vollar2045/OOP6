using System;

namespace AdapterClasses
{
    public class GasCylinder
    {
        public double Volume { get; set; }
        public double Mass { get; set; }
        public double Molar { get; set; }
        public GasCylinder(double volume, double mass, double molar)
        {
            Volume = volume;
            Mass = mass;
            Molar = molar;
        }
        private const double R = 8.314;
        public double GetPressure(int T)
        {
            double amountOfMatter = AmountOfMatter();
            if (Volume <= 0) return 0;
            return (amountOfMatter * R * T) / Volume;
        }
        public double AmountOfMatter()
        {
            if (Molar <= 0) return 0;
            return Mass / Molar;
        }
        public override string ToString()
        {
            return $"Баллон: Объем={Volume:F2} м^3, Масса={Mass:F2} кг, Молярная масса={Molar:F2} кг/моль";
        }
    }

    public interface IGasTarget
    {
        double CalculateDp(int T0, int dT);
        void ModifMass(double dm);
        string GetData();
    }

    public class GasObjectAdapter : IGasTarget
    {
        private GasCylinder _cylinder;
        public GasObjectAdapter(GasCylinder cylinder)
        {
            _cylinder = cylinder ?? throw new ArgumentNullException(nameof(cylinder));
        }
        public double CalculateDp(int T0, int dT)
        {
            double p1 = _cylinder.GetPressure(T0);
            double p2 = _cylinder.GetPressure(T0 + dT);
            return p2 - p1;
        }
        public void ModifMass(double dm)
        {
            _cylinder.Mass += dm;
            if (_cylinder.Mass < 0) _cylinder.Mass = 0;
        }
        public string GetData()
        {
            return _cylinder.ToString();
        }
    }
}