using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using UnitsNet;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;
using EngineeringUnits.Units;

namespace UnitTests
{
    [TestClass]
    public class FuelEfficiencyTest
    {



        [TestMethod]
        public void FuelEfficiencyAutoTest()
        {
            var A1 = new UnitsNet.FuelEfficiency(1, UnitsNet.Units.FuelEfficiencyUnit.KilometerPerLiter);
            var A2 = new EngineeringUnits.FuelEfficiency(1, FuelEfficiencyUnit.KilometerPerLiter);

            int WorkingCompares = 0;


            foreach (var EU in Enumeration.ListOf<FuelEfficiencyUnit>())
            {


                double Error = 1E-5;
                double RelError = 1E-5;

                var UNList = UnitsNet.FuelEfficiency.Units.Where(x => x.ToString() == EU.QN);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    if (UN == UnitsNet.Units.FuelEfficiencyUnit.MilePerUkGallon) RelError = 4.135417875461006E-05;


                    Debug.Print($"");
                    Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                    Debug.Print($"EngineeringUnit: {EU.QN} {A2.As(EU)}");
                    Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                    Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                    //All units absolute difference
                    Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                    //All units relative difference
                    Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                            A1.As(UN)),
                                                            RelError);
                    //All units symbol compare
                    Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                    A1.ToUnit(UN).ToString("a")

                                    .Replace("L", "l")

                                    );

                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(3, WorkingCompares);

        }
    }
}