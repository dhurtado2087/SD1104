using System;
using System.Text.RegularExpressions;

namespace ConsoleApp3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 3.3: Regular Expressions");

            //string textToSearch = "This is Sparta!";
            //string regex = "[a-z]";

            string textToSearch = "afgkk24679ggZXVFcatcat9970b02dogMaryxxxxbbbb22FHDFISHMOTHERfaskldjflasjfjasdfjzxcvxcEYERTR345262372546vbcvb0000000carTT2356236623732623462366johnxcxcxvbdfsdgvxcvC#00002499xbvvcfgooglecvcvxzvdfgsdjiiruewortuiwerioptunvxn990348590234523907854034sdnskfshwateririweotowyuwerituwreutpwetuwertueryuwertwerutpweurtpuweptnvmxcvnnxcxcxvb";
            string regex = "[a-z]at";

            MatchCollection matchResults = Regex.Matches(textToSearch, regex);

            foreach(Match m in matchResults)
            {
                Console.WriteLine(m);
            }


        }
    }
}
