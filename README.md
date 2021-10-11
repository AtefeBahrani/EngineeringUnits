[![NuGet](https://img.shields.io/nuget/v/EngineeringUnits)](https://www.nuget.org/packages/EngineeringUnits/)
[![NuGet](https://img.shields.io/nuget/dt/EngineeringUnits)](https://www.nuget.org/packages/EngineeringUnits/)
![Platform](https://img.shields.io/badge/Platform-64%2F32bit-brightgreen)
[![License](https://img.shields.io/github/license/MadsKirkFoged/SharpFluids)](https://github.com/MadsKirkFoged/EngineeringUnits/blob/master/LICENSE)

# EngineeringUnits


This is an (almost) interchangeable version of [UnitsNet](https://github.com/angularsen/UnitsNet) which mean you just have to change the *using* if you already use [UnitsNet](https://github.com/angularsen/UnitsNet)

```C#
//using UnitsNet;
//using UnitsNet.Units;

using EngineeringUnits;
using EngineeringUnits.Units;
```



## Comparing UnitsNet and EngineeringUnits


###### :heavy_check_mark: EngineeringUnits can handle mathematical operations (+-*/) between any unit

```C#
SpecificEntropy P1 = new SpecificEntropy(1, SpecificEntropyUnit.JoulePerKilogramKelvin);
MassFlow M1 = new MassFlow(1, MassFlowUnit.KilogramPerSecond);
Temperature T2 = new Temperature(10, TemperatureUnit.DegreeCelsius);
Temperature T1 = new Temperature(5, TemperatureUnit.DegreeCelsius);

//UnitsNet cant do this..
Power Q1 = M1 * P1 * (T2 - T1);
```

###### :heavy_check_mark: Temperature calculations are done just like any other unit (TemperatureDelta has been removed!)
###### :heavy_check_mark: Units can have alias. Ex *SpecificEnergy* and *Enthalpy* are the same thing and you can just choose the one you normally use. (No code duplication for this option!)
###### :heavy_check_mark: More precise convertions:
```C#
Length L2 = new Length(1, LengthUnit.Mile);

//Correct result in Inch:   63360
//EngineeringUnits in Inch: 63360
//UnitsNet in Inch:         63359.84251968504
```

###### :triangular_flag_on_post: Unit checks has been moved from Compile time to runtime. In [UnitsNet](https://github.com/angularsen/UnitsNet) if you do mathematical operations on units that doesnt turn into the expected unit, you're get an error before you compile the program. In EngineeringUnits you still have the same check but you will get the error when you run the program.



## Should I change from UnitsNet to EngineeringUnits?


###### :heavy_check_mark: If you are working with engineering-, physics- , chemical- equations then EngineeringUnits will make your life easier
###### :triangular_flag_on_post: If you are just making converions ( Meter -> Inch) and you dont care about the extra precision then UnitsNet and EngineeringUnits are identical.


## How to install

###### :heavy_check_mark: Nuget Package: EngineeringUnits

## Code examples

###### Get told if you mess up a calculation
```C#
Mass mass = new Mass(10, MassUnit.Kilogram);
Volume volume = new Volume(0, VolumeUnit.CubicMeter);

Density D1 = mass / volume; // 2.5 kg/m³
Density D2 = volume / mass; // WrongUnitException: 'This is NOT a [kg/m³] as expected! Your Unit is a [m³/kg]'
```
###### Absolute value
```C#
MassFlow M1 = new MassFlow(10, MassFlowUnit.HectogramPerSecond); //-10 kg/s
MassFlow M2 = M1.Abs(); //10 kg/s                   
```

###### To the power of
```C#
Length L1 = new Length(4.3, LengthUnit.Foot);
Area A1 = L1.Pow(2);  //1.718 m²                 
```

###### Get the min/max/Average/Sum
```C#
Mass M1 = new Mass(43, MassUnit.Kilogram);
Mass M2 = new Mass(2, MassUnit.Megapound);
Mass M3 = new Mass(77644, MassUnit.Milligram);
Mass M4 = new Mass(345, MassUnit.Pound);

Mass MinMass = UnitMath.Min(M1, M2, M3, M4);    //7.764e+04 mg
Mass MaxMass = UnitMath.Max(M1, M2, M3, M4);    //2 Mlb
Mass MaxAvg = UnitMath.Average(M1, M2, M3, M4); //2.268e+05 kg
Mass MaxSum = UnitMath.Sum(M1, M2, M3, M4);     //9.074e+05 kg

```

###### Force quantity In Range Of(min,max)
```C#
Power f1 = new(19, PowerUnit.KilojoulePerHour);
Power f2 = f1.InRangeOf(Power.FromWatts(-5), Power.FromWatts(5)); //5 W

Power f7 = new(-19, PowerUnit.KilojoulePerHour);
Power f8 = f7.InRangeOf(Power.FromWatts(-5), Power.FromWatts(5)); //-5 W

Power f9 = new(4, PowerUnit.Watt);
Power f10 = f9.InRangeOf(Power.FromWatts(-5), Power.FromWatts(5)); //4 W

```

