
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class PowerDensity : BaseUnit
    {

        public PowerDensity() { }
        public PowerDensity(decimal value, PowerDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public PowerDensity(double value, PowerDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public PowerDensity(int value, PowerDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public PowerDensity(UnknownUnit value) : base(value) { }

        public static PowerDensity From(double value, PowerDensityUnit unit) => new(value, unit);

        public static PowerDensity From(double? value, PowerDensityUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(PowerDensityUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public PowerDensity ToUnit(PowerDensityUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static PowerDensity Zero => new(0, PowerDensityUnit.SI);

        public static implicit operator PowerDensity(UnknownUnit Unit)
        {
            Unit.UnitCheck(PowerDensityUnit.SI);
            return new(Unit);        
        }

        public static implicit operator PowerDensity(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<PowerDensityUnit>(_unit);
	}
}

