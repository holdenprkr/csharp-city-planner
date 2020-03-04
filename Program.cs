using System;

namespace Planner
{
    class Program
    {
        static void Main (string[] args)
        {
            City Nashville = new City ("Nashville");
            Nashville.SetYearEstablished (1706);
            Nashville.SetMayor ("Holden Parker");

            Building FiveOneTwoEigth = new Building ("512 8th Avenue")
            {
                Width = 100,
                Depth = 200,
                Stories = 8
            };

            Building ThreeSixFiveTwentyFourth = new Building ("365 24th Avenue")
            {
                Width = 300,
                Depth = 150,
                Stories = 7
            };

            Building TwoOneJump = new Building ("21 Jump St")
            {
                Width = 50,
                Depth = 200,
                Stories = 3
            };

            FiveOneTwoEigth.Design ("Holden Parker");
            ThreeSixFiveTwentyFourth.Design ("Holden Parker");
            TwoOneJump.Design ("Holden Parker");

            FiveOneTwoEigth.Construct ();
            ThreeSixFiveTwentyFourth.Construct ();
            TwoOneJump.Construct ();

            FiveOneTwoEigth.Purchase ("Adam Sheaffer");
            ThreeSixFiveTwentyFourth.Purchase ("Brenda Long");
            TwoOneJump.Purchase ("Rose Wisotzky");

            FiveOneTwoEigth.Print ();
            ThreeSixFiveTwentyFourth.Print ();
            TwoOneJump.Print ();
        }
    }
}