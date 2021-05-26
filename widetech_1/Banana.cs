using System;
namespace widetech_1
{
    public class Banana:Fruit
    {
        static private Banana instance;
        private Banana() {
            name = "Banana";
            outerColor = "yellow";
            treePomology = true;
            scientificName = "musa";
        }

        public override int getPercentageOfGlucose()
        {
            return 23;
        }

        public static Banana getInstance()
        {
            if (instance == null)
            {
                instance = new Banana();
            }
            return instance;
        }
    }
}

