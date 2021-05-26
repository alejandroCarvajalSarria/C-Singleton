using System;
namespace widetech_1
{
    public class Kiwi:Fruit
    {
        static private Kiwi instance;
        private Kiwi() {
            name = "Kiwi";
            outerColor = "brown";
            treePomology = false;
            scientificName = "actinidia";
        }

        public override int getPercentageOfGlucose()
        {
            return 12;
        }

        public static Kiwi getInstance()
        {
            if (instance == null)
            {
                instance = new Kiwi();
            }
            return instance;
        }
    }
}
