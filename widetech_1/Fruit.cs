using System;
namespace widetech_1
{
    public abstract class Fruit
    {
        public string name;
        public string outerColor;
        public bool treePomology;
        public string scientificName;
        public Fruit() {}


        public abstract int getPercentageOfGlucose();

        public bool hasSeeds() {
            return true;
        }

        public bool growsOnTree()
        {
            return treePomology;
        }

        public string getScientificName()
        {
            return scientificName;
        }


    }
}
