namespace Weekly_And_Biweekly_Contest.Weekly_Contest
{
    public class Weekly_Contest_520
    {
        public int CountIntersectingIntervals(int[][] intervals)
        {
            int count = 0;
            int x = 0;

            // [[1,5],[2,4],[3,6]]
            // [[97,100],[61,61]]

            while (x < intervals.Length - 1)
            {
                var test = intervals[0][1];
                var test2 = intervals[1][0];

                //var test5 = intervals[0][1];
                //var test6 = intervals[2][0];

                //var test3 = intervals[1][1];
                //var test4 = intervals[2][0];

                int y =  x + 1;

                if (intervals[x][0] < intervals[x][1] && intervals[x+1][0] < intervals[x+1][1])
                {
                    while (y < intervals.Length)
                    {
                        if (intervals[y][0] <= intervals[x][1])
                            count++;
                        y++;
                    }
                }
                x++;
            }

            return count;
        }
    }
}