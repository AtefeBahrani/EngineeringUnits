﻿using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public record LapseRateUnit : UnitTypebase
    {

        public static readonly LapseRateUnit SI = new(TemperatureUnit.SI, LengthUnit.SI);
        public static readonly LapseRateUnit DegreeCelsiusPerKilometer = new(TemperatureUnit.Kelvin, LengthUnit.Meter, "∆°C/km");




        public LapseRateUnit(TemperatureUnit temperature, LengthUnit length, string NewSymbol = null)
        {
            Unit = new UnitSystem(temperature / length, NewSymbol);
        }

        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }

    }




}