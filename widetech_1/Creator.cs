using System;
namespace widetech_1
{
    public class Creator
    {


        public const int APPLE = 1;
        public const int BANANA = 2;
        public const int KIWI = 3;

        public static Fruit FruitCreator(int Type)
        {
            switch (Type)
            {
                case APPLE:
                    return Apple.getInstance();
                case BANANA:
                    return Banana.getInstance();
                case KIWI:
                    return Kiwi.getInstance();

                default: return null;
            }
            
        }

    }
}
