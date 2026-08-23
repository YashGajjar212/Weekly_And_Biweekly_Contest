namespace Weekly_And_Biweekly_Contest.Weekly_Contest
{
    public class Weekly_Contest_516
    {
        public IList<IList<int>> FindDisappearedNumbers(int[] nums, int lower, int upper)
        {
            IList<IList<int>> result = new List<IList<int>>();

            if (nums.Contains(lower) && nums.Contains(upper))
                return result;

            Array.Sort(nums);
            int first = lower;
            int last = lower;
            //int i = 0;

            // 3,7,9 lower = 1, upper = 12
            while (last <= upper)
            {
                if (last == upper)
                {
                    List<int> seq = new List<int>();
                    seq.AddRange(first, last);
                    result.Add(seq);

                    first = ++last;
                }                
                else if (nums.Contains(last))
                {
                    List<int> seq = new List<int>();
                    seq.AddRange(first, last - 1);
                    result.Add(seq);

                    first = ++last;
                }
                else
                {
                    last++;
                }
            }

            return result;
        }
    }
}