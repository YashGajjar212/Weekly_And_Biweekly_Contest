namespace Weekly_And_Biweekly_Contest.Weekly_Contest
{
    public class Weekly_Contest_517
    {
        public int CountSpecialIntegers(int[] nums)
        {
            if (nums.Length == 1)
                return 1;

            int anchor = 0;
            int scout = 0;
            int result = 0;
            //int[] sets = new int[nums.Length];
            HashSet<int> test = new HashSet<int>();

            Dictionary<int, int> test1 = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (test1.ContainsKey(item))
                    test1[item]++;
                else
                    test1.Add(item, 1);
            }

            // [1,2,2,1]
            // [3,3,1,2,2,1]
            // [25,25,25,35,25]
            // [35,35]
            // [1,2]
            // [9, 62, 62, 75, 75, 75, 96, 96, 96, 96, 96, 96, 96, 96, 9, 9, 9, 9, 9, 75, 75, 75, 9, 9]
            while (scout < nums.Length)
            {
                while(scout < nums.Length && nums[anchor] == nums[scout])
                {
                    scout++;
                }
                //result++;


                if (test.Contains(nums[anchor]))
                {
                    result--;
                }
                else
                {
                    result++;
                }
                test.Add(nums[anchor]);
                anchor = scout;
                //scout++;
            }

            return result;
        }
    }
}