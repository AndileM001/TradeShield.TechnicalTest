
namespace TS.TechnicalTest;

public class LongestSentanceAnswer
{
    public static int Solution(string s)
    {
        int totalWords = 0 ;
        var sentences = s.Split(new char[] {'.', '?' , '!' });

        foreach (var sentence in sentences) {
            //split words in the sentence by space, remove blank space as well
            var words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int wordsLength = words.Length;

            if (totalWords < wordsLength) {
                totalWords = wordsLength;
            }
        }

        return totalWords ;
    }
}
