namespace TS.TechnicalTest;

public class DeepestPitAnswer
{
    public static int Solution(int[] points)
    {
        var depth = -1;
        for (int i = 0; i < points.Length; i++) {
            //check if A[P] > A[P+1]
            var P = i;
            Nullable<int> Q = null;
            Nullable<int> R = null;
            if (points[P] > points[P + 1])
            {
                Q = P + 1;
            }
            //check if Q is assigned 
            if (Q != null) {
                // check if A[Q] < A[Q+1]
                if (points[Q.Value] < points[Q.Value + 1])
                {
                    R = Q.Value + 1;
                }
            }

        }
        return depth;
    }
}
