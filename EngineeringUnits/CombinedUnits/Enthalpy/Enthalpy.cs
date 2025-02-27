
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class Enthalpy : BaseUnit
    {

        public Enthalpy() { }
        public Enthalpy(decimal value, EnthalpyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Enthalpy(double value, EnthalpyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Enthalpy(int value, EnthalpyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Enthalpy(UnknownUnit value) : base(value) { }

        public static Enthalpy From(double value, EnthalpyUnit unit) => new(value, unit);

        public static Enthalpy From(double? value, EnthalpyUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(EnthalpyUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public Enthalpy ToUnit(EnthalpyUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static Enthalpy Zero => new(0, EnthalpyUnit.SI);

        public static implicit operator Enthalpy(UnknownUnit Unit)
        {
            Unit.UnitCheck(EnthalpyUnit.SI);
            return new(Unit);        
        }

        public static implicit operator Enthalpy(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<EnthalpyUnit>(_unit);
	}
}

