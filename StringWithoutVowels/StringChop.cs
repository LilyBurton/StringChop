using System;
using System.Linq;
using System.Text;

namespace StringWithoutVowels;

public class StringChop
{
    internal string Chop(string input)
    {
        if (string.IsNullOrEmpty(input)) return "";

        var vowels = new HashSet<char>{ 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        var result = new String(input.Where(x => !vowels.Contains(x)).ToArray());

        return result;
    }
}

