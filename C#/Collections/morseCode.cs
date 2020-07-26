using System;
using System.Text;
using System.Collections.Generic;

namespace Treehouse
{
    static class MorseCodeTranslator
    {

        private static Dictionary<char, string> _textToMorse = new Dictionary<char, string>
        {
            {' ', "/"},
            {'A', ".-"},
            {'B', "-..."},
            {'C', "-.-."},
            {'D', "-.."},
            {'E', "."},
            {'F', "..-."},
            {'G', "--."},
            {'H', "...."},
            {'I', ".."},
            {'J', ".---"},
            {'K', "-.-"},
            {'L', ".-.."},
            {'M', "--"},
            {'N', "-."},
            {'O', "---"},
            {'P', ".--."},
            {'Q', "--.-"},
            {'R', ".-."},
            {'S', "..."},
            {'T', "-"},
            {'U', "..-"},
            {'V', "...-"},
            {'W', ".--"},
            {'X', "-..-"},
            {'Y', "-.--"},
            {'Z', "--.."},
            {'1', ".----"},
            {'2', "..---"},
            {'3', "...--"},
            {'4', "....-"},
            {'5', "....."},
            {'6', "-...."},
            {'7', "--..."},
            {'8', "---.."},
            {'9', "----."},
            {'0', "-----"},
            {',', "--..--"},
            {'.', ".-.-.-"},
            {'?', "..--.."},
            {';', "-.-.-."},
            {':', "---..."},
            {'/', "-..-."},
            {'-', "-....-"},
            {'\'', ".----."},
            {'"', ".-..-."},
            {'(', "-.--."},
            {')', "-.--.-"},
            {'=', "-...-"},
            {'+', ".-.-."},
            {'@', ".--.-."},
            {'!', "-.-.--"},
            {'Á', ".--.-"},
            {'É', "..-.."},
            {'Ö', "---."},
            {'Ä', ".-.-"},
            {'Ñ', "--.--"},
            {'Ü', "..--"}
        };
        private static Dictionary<string, char> _morseToText = new Dictionary<string, char>();

        static MorseCodeTranslator()
        {
            foreach (KeyValuePair<char, string> code in _textToMorse)
            {
                _morseToText.Add(code.Value, code.Key);
            }
        }
        public static string ToMorse(string input)
        {
            List<string> output = new List<string>(input.Length);
            foreach (char character in input.ToUpper())
            {
                try
                {
                    string morseCode = _textToMorse[character];
                    output.Add(morseCode);
                }
                catch (KeyNotFoundException)
                {
                    output.Add("!");
                }
            }
            return string.Join(" ", output);
        }
    }
    public class LexicalAnalysis
    {
        public Dictionary<string, int> WordCount = new Dictionary<string, int>();

        public void AddWord(string word)
        {
            if (WordCount.ContainsKey(word))
            {
                WordCount[word]++;
            }
            else
            {
                WordCount.Add(word, 1);
            }
        }
        public Dictionary<string, int> WordsWithCountGreaterThan(int count)
        {
            Dictionary<string, int> collection = new Dictionary<string, int>();
            foreach (var key in WordCount.Keys)
            {
                if (WordCount[key] > count)
                {
                    collection.Add(key, WordCount[key]);
                }

            }
            return collection;
        }
    }
}