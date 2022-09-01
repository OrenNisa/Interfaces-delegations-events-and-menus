using System;

namespace Ex04.Menus.Test
{
    internal class ExampleFunctions
    {
        internal class ShowDateTime
        {
            public void ShowTime()
            {
                Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
            }

            public void ShowDate()
            {
                Console.WriteLine(DateTime.Now.ToString("dd-MM-yyyy"));
            }
        }

        internal class VersionAndSpaces
        {
            public void CountSpaces()
            {
                Console.WriteLine("Please enter your sentence:");
                string userSentence = Console.ReadLine();
                int numOfSpaces = 0;

                foreach (char charInSentence in userSentence)
                {
                    if (char.IsWhiteSpace(charInSentence))
                    {
                        numOfSpaces++;
                    }
                }

                Console.WriteLine("There are {0} Spaces in your sentence.", numOfSpaces);
            }

            public void ShowVersion()
            {
                Console.WriteLine("Version: 22.3.4.8650");
            }
        }
    }
}
