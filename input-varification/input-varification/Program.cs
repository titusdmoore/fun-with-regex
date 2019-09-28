using System;
using System.Text.RegularExpressions;

namespace input_varification {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter your phone number: ");
            var correctInput = true;
            var phone = "";
            do {
                phone = Console.ReadLine();
                var match = @"1?\s?\(?(\d{3})\)?\s?-?\s?(\d{3})\s?-?\s?(\d{4})";
                Regex r = new Regex(match);
                correctInput = r.IsMatch(phone);
                if (!correctInput) {
                    Console.WriteLine("Please enter a valid number!");
                }
            } while (!correctInput);
            var cs = phone.ToCharArray();
            var _out = "";
            for (int i = 0; i < cs.Length; i++) {
                if (i == 0) {
                    if (cs[i] == '1') {
                        _out += "1 ";
                    }
                    _out += "(";
                }
                var i2 = i;
                _out += cs[i];
                while (i2 % 3 == 0) {
                    _out += " - ";
                }
            }
            Console.WriteLine(_out);
        }
    }
}
