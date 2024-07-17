namespace TS.TechnicalTest;

public class DeepestPitAnswer
{
    public static int Solution(int[] points)
    {
        var depth = 0;
        bool tripletsFound = false;
        for (int i = 0; i < points.Length -1; i++) {
            //check if A[P] > A[P+1]
            var P = i;
            Nullable<int> Q = null;
            Nullable<int> R = null;
            if (points[P] > points[P + 1])
            {
                Q = P + 1;
            }
            //check if Q is assigned 
            if (Q.HasValue) {
                // check if A[Q] < A[Q+1]
                if (points[Q.Value] < points[Q.Value + 1])
                {
                    R = Q.Value + 1;
                }
            }

            if(Q.HasValue && R.HasValue)
            {
                //calculate the depth using the triplets P, Q and R
                var depthValue = CalculateDepth(points, P, Q.Value, R.Value);
                if(depthValue > depth)
                {
                    depth = depthValue;
                }
                tripletsFound = true;
            }
            //case if A[Q+2] index is within index bounds & A[Q+2] < A[Q]
            if (Q.HasValue && R.HasValue && R.Value + 1 <= points.Length)
            {
                if (points[Q.Value] < points[R.Value + 1])
                {
                    R = R.Value + 1;
                }
                var depthValue = CalculateDepth(points, P, Q.Value, R.Value);
                if (depthValue > depth)
                {
                    depth = depthValue;
                }
                tripletsFound = true;
            }
        }
        if (!tripletsFound) 
        {
            return -1;
        }

        return depth;
    }

     private static int CalculateDepth(int[] points, int P, int Q, int R ) {
        //min{A[P] − A[Q], A[R] − A[Q]}.
        return Math.Min(points[P] - points[Q], points[R] - points[Q] );
    }
}
