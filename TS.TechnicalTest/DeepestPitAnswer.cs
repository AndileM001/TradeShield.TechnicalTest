namespace TS.TechnicalTest;

public class DeepestPitAnswer
{
    public static int Solution(int[] points)
    {
        var depth = -1;
        for (int i = 0; i < points.Length; i++) {
            //check if A[P] > A[P+1]
            var P = i;
            if (points[P] > points[P + 1])
            {

            }

        }
        return depth;
    }
}
