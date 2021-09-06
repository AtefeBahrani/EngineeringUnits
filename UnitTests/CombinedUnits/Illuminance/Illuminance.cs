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
    public class IlluminanceTest
    {



        [TestMethod]
        public void IlluminanceAutoTest()
        {
            var A1 = new UnitsNet.Illuminance(1, UnitsNet.Units.IlluminanceUnit.Lux);
            var A2 = new EngineeringUnits.Illuminance(1, IlluminanceUnit.Lux);

            int WorkingCompares = 0;


            foreach (var EU in Enumeration.ListOf<IlluminanceUnit>())
            {


                double Error = 1E-4;
                double RelError = 1E-3;

                var UNList = UnitsNet.Illuminance.Units.Where(x => x.ToString() == EU.QN);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    //if (UN == UnitsNet.Units.IlluminanceUnit.CaloriePerSecondSquareCentimeter) RelError = 0.06687685105569595;
                    

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


                                    );

                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(4, WorkingCompares);

        }
    }
}