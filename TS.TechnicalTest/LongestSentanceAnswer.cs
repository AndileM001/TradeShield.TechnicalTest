﻿
namespace TS.TechnicalTest;

public class LongestSentanceAnswer
{
    public static int Solution(string s)
    {
        int totalWords = 0 ;
        var sentences = s.Split(new char[] {'.', '?' , '!' });

        foreach (var sentence in sentences) {
            //split words in the sentence by space
            var words = sentence.Split(' ');
            int wordsLength = words.Length;

        }

        return totalWords ;
    }
}
