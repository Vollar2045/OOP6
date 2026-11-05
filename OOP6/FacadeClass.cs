using System;

namespace FacadeClasses
{
    public abstract class Property
    {
        public double Area { get; set; }
        public int Residents { get; set; }
        public int BuildYear { get; set; }
        public double WearPercentage { get; set; }
        public int InsuranceTerm { get; set; }
        public Property(double area, int residents, int buildYear, double wear, int term)
        {
            Area = area;
            Residents = residents;
            BuildYear = buildYear;
            WearPercentage = wear;
            InsuranceTerm = term;
        }
        public abstract double CalculateBaseCost();
        public abstract string GetPropertyType();
    }

    public class Apartment : Property
    {
        public Apartment(double area, int residents, int buildYear, double wear, int term)
            : base(area, residents, buildYear, wear, term) { }
        public override double CalculateBaseCost()
        {
            double baseRate = 500 * Area;
            double wearFactor = 1.0 - (WearPercentage / 100.0);
            return baseRate * wearFactor * InsuranceTerm;
        }

        public override string GetPropertyType() => "квартира";
    }

    public class Townhouse : Property
    {
        public Townhouse(double area, int residents, int buildYear, double wear, int term)
            : base(area, residents, buildYear, wear, term) { }
        public override double CalculateBaseCost()
        {
            double baseRate = 700 * Area;
            double wearFactor = 1.0 - (WearPercentage / 100.0);
            double residentsFactor = Residents > 3 ? 1.1 : 1.0;
            return baseRate * wearFactor * residentsFactor * InsuranceTerm;
        }
        public override string GetPropertyType() => "таун-хаус";
    }

    public class Cottage : Property
    {
        public Cottage(double area, int residents, int buildYear, double wear, int term)
            : base(area, residents, buildYear, wear, term) { }
        public override double CalculateBaseCost()
        {
            double baseRate = 1000 * Area;
            double wearFactor = 1.0 - (WearPercentage / 100.0);
            int age = DateTime.Now.Year - BuildYear;
            double ageFactor = age < 20 ? 1.2 : 1.0;
            return baseRate * wearFactor * ageFactor * InsuranceTerm;
        }
        public override string GetPropertyType() => "коттедж";
    }

    public class InsuranceFacade
    {
        public double CalculateInsurance(string type, double area, int residents, int buildYear, double wear, int term)
        {
            Property property = null;
            switch (type)
            {
                case "квартира":
                    property = new Apartment(area, residents, buildYear, wear, term);
                    break;
                case "таун-хаус":
                    property = new Townhouse(area, residents, buildYear, wear, term);
                    break;
                case "коттедж":
                    property = new Cottage(area, residents, buildYear, wear, term);
                    break;
                default:
                    throw new ArgumentException("Неизвестный тип недвижимости");
            }
            double total = property.CalculateBaseCost();
            return Math.Round(total, 2);
        }
    }
}