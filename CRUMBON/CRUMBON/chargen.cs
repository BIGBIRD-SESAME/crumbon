using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUMBON
{
    public class chargen
    {
        public static string gen()
        {
            Random rand;
            rand = new Random();
            char[] rnd_char = {
                '»', '«', '⁁', '⌀', '±', '⁒', '⁊', '⸘',
                '℗', '₲', '$', '↪', '◓', '∮', '⋨', '⨙', '1',
                '2', '3', '4', '5', '6', '7', '8', '9', '0',
                'π', 'ξ', 'Ϡ', 'ᾮ', 'ϖ', 'ʞ', '-', '¶', '╬',
                '╠', '╡', '╢', '╚', '╣', '▀', '▍', '▇', '▓',
                '▒', '░', '▰', 'ă', 'Æ', '¤', '¥', '£', 'µ',
                'Ð', 'æ', 'ƃ', 'ĉ', 'đ', 'ĕ', 'ƒ', 'ĝ', 'ĥ',
                'Ĩ', 'ĭ', 'ķ', 'Ł', 'Ɯ', 'ń', 'ŏ', 'Œ', 'œ',
                'ƥ', 'ŕ', 'ś', 'ţ', 'ũ', 'ŵ', 'ŷ', 'ž', 'Ă',
                'Ć', 'Ď', 'Ē', 'Ĝ', 'Ĥ', 'Ĵ', 'ĵ', 'Ķ', 'Ĺ',
                'Ņ', 'Ŏ', 'Ŕ', 'Ś', 'Ŧ', 'Ũ', 'Ŵ', 'Ÿ', 'Ż',
                '⑇', '╭', '▚', '▞', '▨', '⌘', '⏭', '⍢', '⌄', '⍭', '='};
            string rnd_name;
            string rnd_str = "";
            for (int num = 0; num < 30; num++)
            {
                rnd_name = rnd_char[rand.Next(rnd_char.Length)].ToString();
                rnd_str = rnd_str + rnd_name;
            }
            return rnd_str;
        }
    }
}