
/* FountainProject is the top level within Fountain Design.  It expects a set of nozzles that 
 * create various effects.  (Inspiration https://www.fountainpeople.com/products.)
 * 
 * BIG CHALLENGE, I don't know how to set up get, set. 
 * 
 * SOMEDAY: static int ProjectCost = 10000;      // cost constraint in dollars
 *      
 */

// TODO Get the logger to work again, and make meaningful entries.
// string myMsg = Model_ID + ": " + effectHeight + " = " + thisPressure;
// Logger.logEntry("Info", myMsg);


using System;

//MARK You can globally rename a namespace using: Ctrl-R, Ctrl-R
namespace FountainPlanner
{
    public class FountainProject
    {
        public int MaxPressureTotal = 1500;   // engineering constraint in PSI
                                                   //  for simulating system-total pressure states

        public int countLineItem;
        //TODO Enable a varying number of line-items (requires change to array count)

        // https://stackoverflow.com/questions/18122528/creating-n-objects-and-adding-them-to-a-list

        //FixtureWater[] myWaterFixtures = new FixtureWater[3]; //FIXME 3 is a placeholder

        public void FountainProjectBegin()
        {
            FixtureWater[] myWaterFixtures = new FixtureWater[countLineItem]; //FIXME 3 is a placeholder
            for (int i = 0; i < countLineItem; i++)
            {
                //myPressure = myWaterFixtures[i].effectPressure;
                //myQuantity = myWaterFixtures[i].quantity;
                //myPressure *= myQuantity;
                //
                //totalPressure += myPressure;

                Console.WriteLine("   fixture " + i.ToString());
            }
        }

        //public int GetTotalPressure()
        //{
        //    int totalPressure = 0;
        //    int myPressure;
        //    int myQuantity;
        //    for (int i = 0; i < myWaterFixtures.Length; i++)
        //    {
        //        myPressure = myWaterFixtures[i].effectPressure;
        //        myQuantity = myWaterFixtures[i].quantity;
        //        myPressure *= myQuantity;

        //        totalPressure += myPressure;

        //        Console.WriteLine("   fixture " + i.ToString());
        //    }


        //    // Ensure MaxPressureTotal is not exceeded.
        //    //      TODO Raise flag in UI if it is exceeded.
        //    if ((int)totalPressure > MaxPressureTotal)
        //    {
        //        totalPressure = MaxPressureTotal;
        //    }

        //    return totalPressure;
        //}
    }

}