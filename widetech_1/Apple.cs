using System;
namespace widetech_1
{
    public class Apple:Fruit
    {

        static private Apple instance;
        //public string color;
        
        private Apple() {
            name = "Apple";
            outerColor = "red";
            treePomology = true;
            scientificName = "malus domestica";

        }

        public override int getPercentageOfGlucose()
        {
            return 12;
        }

        public static Apple getInstance()
        {
            if (instance == null)
            {
                instance = new Apple();
            }
            return instance;
        }
    }
}





//using System;
//namespace widetech_1
//{
//    public class Fruit
//    {
//        static private Fruit instance;
//        private Fruit() { }

//        public static Fruit getInstance()
//        {
//            if (instance == null)
//            {
//                instance = new Fruit();
//            }
//            return instance;
//        }
//    }
//}
