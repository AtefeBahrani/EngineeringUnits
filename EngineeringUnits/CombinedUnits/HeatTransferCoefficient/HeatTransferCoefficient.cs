
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class HeatTransferCoefficient : BaseUnit
    {

        public HeatTransferCoefficient() { }
        public HeatTransferCoefficient(decimal value, HeatTransferCoefficientUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public HeatTransferCoefficient(double value, HeatTransferCoefficientUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public HeatTransferCoefficient(int value, HeatTransferCoefficientUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public HeatTransferCoefficient(UnknownUnit value) : base(value) { }

        public static HeatTransferCoefficient From(double value, HeatTransferCoefficientUnit unit) => new(value, unit);

        public static HeatTransferCoefficient From(double? value, HeatTransferCoefficientUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(HeatTransferCoefficientUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public HeatTransferCoefficient ToUnit(HeatTransferCoefficientUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static HeatTransferCoefficient Zero => new(0, HeatTransferCoefficientUnit.SI);

        public static implicit operator HeatTransferCoefficient(UnknownUnit Unit)
        {
            Unit.UnitCheck(HeatTransferCoefficientUnit.SI);
            return new(Unit);        
        }

        public static implicit operator HeatTransferCoefficient(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<HeatTransferCoefficientUnit>(_unit);
	}
}

