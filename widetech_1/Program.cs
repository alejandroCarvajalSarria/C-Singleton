using System;

namespace widetech_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string personName = "Alek";


            Fruit xFruit = Creator.FruitCreator(Creator.KIWI);
            Console.WriteLine(xFruit.growsOnTree());

            theFruitStory(
                personName,
                xFruit.name,
                xFruit.outerColor,
                xFruit.getScientificName(),
                xFruit.growsOnTree()
                ); ;
        }

       static void theFruitStory(
           string person,
           string fruitName,
           string fruitColor,
           string scientificName,
           bool treePomology
           )
        {
            string storyPartOne = "One day, " +
                person +
            " was walking around the farm, and they found a weird " +
            fruitColor +
            " object. ";


            storyPartOne += person +
                    " didn't know what it was, so he asked the farmer! " +
                    " The farmer then said, \"" +
                    person +
                    ", this is a " +
                    fruitName +
                    ". it's a fruit referred to as "+
                    scientificName+
                    " by scientists. ";

            if (treePomology)
            {
            storyPartOne += "Fun fact for you, it grows on trees. ";

            }

            storyPartOne += "Go on, take a bite!\"";




            string storyPartTwo = person +
                " loved it, and he knew that there were many more fruits like the " +
                fruitName +
                " to explore";

                if (treePomology)
                {
                storyPartTwo += ". Especially, arround the trees!";
                }else{
                storyPartTwo += ".";
                }




            ;
            Console.WriteLine(storyPartOne);
            Console.WriteLine(storyPartTwo);
            Console.ReadLine();
        }
       
    }


}
