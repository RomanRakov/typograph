using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace typograph
{
    public class Methods
    {
        //1 правило

        public string RemovingSpace(string input)
        {
            string output = Regex.Replace(input, @"\s{2,}", " ");

            return output;
        }

        //2 правило

        public string PlusMinus(string input)
        {
            string output = Regex.Replace(input, @"\(\+\,\-\)", "±");

            return output;
        }

        //3 правило

        public string Ellipses(string input)
        {
            string output = Regex.Replace(input, @"\.{3}", "…");

            return output;
        }

        //4 правило

        public string Quotes(string input)
        {
            string output = Regex.Replace(input, "\"(.*?)\"", "«$1»");

            return output;
        }

        //5 правило

        public string DashToMinus(string input)
        {
            string output = Regex.Replace(input, @"(\d)([-])(\d)", "$1-$3");

            return output;
        }

        public string SpacesAroundPlusMinus(string input)
        {
            string output = Regex.Replace(input, @"(\d)\s*([+])\s*(\d)", "$1 $2 $3");
            output = Regex.Replace(output, @"(\d)\s*([-])\s*(\d)", "$1 $2 $3");

            return output;
        }

        public string SpacesAroundEqual(string input)
        {
            string output = Regex.Replace(input, @"(\d)\s*([=])\s*(\d)", "$1 $2 $3");

            return output;
        }

        public string SpacesAroundMultilyDivision(string input)
        {
            string output = Regex.Replace(input, @"(\d)\s*([/])\s*(\d)", "$1 $2 $3");
            output = Regex.Replace(output, @"(\d)\s*([*])\s*(\d)", "$1 $2 $3");

            return output;
        }

        // свое правило: удаление лишних запятых

        public string ExtraCommas(string input)
        {
            string output = Regex.Replace(input, @",+", ",");

            return output;
        }

        // абсурдное правило: перед каждыми 5 символами ставится |
        public string Absurdity(string input)
        {
            string output = Regex.Replace(input, @"(.{5})", "|$1");

            return output;
        }
    }
}
