using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw1551
{
    class CEncodeString
    {
        private string str;
        private int shiftValue;

        public CEncodeString()
        {
            str = "";
            shiftValue = 0;
        }

        public CEncodeString(string str, int shiftValue)
        {
            this.str = str;
            this.shiftValue = shiftValue;
        }

        public string getStr()
        {
            return str;
        }

        public string Encode()
        {
            return new string(str.Select(c =>
            {
                if (!char.IsLetter(c)) return c;
                char offset = 'A';
                return (char)(((c + shiftValue - offset + 26) % 26) + offset);
            }).ToArray());
        }

        public string Sort()
        {
            return new string(str.OrderBy(c => c).ToArray());
        }

        public string InputCode()
        {
            return string.Join("", str.Select(c => ((int)c).ToString()));
        }

        public string OutputCode()
        {
            string encoded = Encode();
            return string.Join("", encoded.Select(c => ((int)c).ToString()));
        }

        public string Output()
        {
            string output = "Input string: " + str +
                "\nShift value: " + shiftValue +
                "\n----------Result----------\n" +
                "Encoded: " + Encode() +
                "\nSorted: " + Sort() +
                "\nInputCode: " + InputCode() +
                "\nOutputCode: " + OutputCode() + "\n";
            return output;
        }
    }
}
