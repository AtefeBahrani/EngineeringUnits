
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class AmountOfSubstance : BaseUnit
    {

        public AmountOfSubstance() { }
        public AmountOfSubstance(decimal value, AmountOfSubstanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public AmountOfSubstance(double value, AmountOfSubstanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public AmountOfSubstance(int value, AmountOfSubstanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public AmountOfSubstance(UnknownUnit value) : base(value) { }

        public static AmountOfSubstance From(double value, AmountOfSubstanceUnit unit) => new(value, unit);

        public static AmountOfSubstance From(double? value, AmountOfSubstanceUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(AmountOfSubstanceUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public AmountOfSubstance ToUnit(AmountOfSubstanceUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static AmountOfSubstance Zero => new(0, AmountOfSubstanceUnit.SI);

        public static implicit operator AmountOfSubstance(UnknownUnit Unit)
        {
            Unit.UnitCheck(AmountOfSubstanceUnit.SI);
            return new(Unit);        
        }

        public static implicit operator AmountOfSubstance(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<AmountOfSubstanceUnit>(_unit);
	}
}

