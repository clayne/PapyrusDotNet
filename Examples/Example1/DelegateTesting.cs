﻿namespace Example1
{
    public class DelegateTesting
    {


        // -----------
        // The following code works.
        // -----------
        public delegate void HelloThereDelegate();
        public void UtilizeDelegate()
        {
            HelloThereDelegate awesome = () =>
            {
                PapyrusDotNet.Core.Debug.Trace("Awesome was used!", 0);
            };

            HelloThereDelegate secondAwesome = () =>
            {
                PapyrusDotNet.Core.Debug.Trace("Second awesome was used!", 0);
            };

            awesome();

            secondAwesome();
        }

        public delegate void SecondDelegate();
        public void UtilizeDelegate2()
        {
            string whatHorrorLiesHere = "test123";

            SecondDelegate arrr = () =>
            {
                PapyrusDotNet.Core.Debug.Trace("UtilizeDelegate2 was used!" + whatHorrorLiesHere, 0);
            };

            arrr();
        }

        public delegate void AnotherDelegate(string input);
        public void UtilizeDelegate3()
        {
            string horror = "test";

            AnotherDelegate awesome = (s) =>
            {
                PapyrusDotNet.Core.Debug.Trace("UtilizeDelegate3 was used!" + s, 0);
            };

            awesome(horror);
        }

        public delegate void HorribleDelegate();
        public void UtilizeDelegate4()
        {
            string magic = "helloo";
            HorribleDelegate awesome = () =>
            {
                AnotherDelegate awe2 = (s) =>
                {
                    PapyrusDotNet.Core.Debug.Trace("UtilizeDelegate4 was used!" + s, 0);
                };

                awe2(magic);

            };
            awesome();
        }
    }
}
