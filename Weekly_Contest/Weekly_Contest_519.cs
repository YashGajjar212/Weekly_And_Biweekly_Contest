namespace Weekly_And_Biweekly_Contest.Weekly_Contest
{
    public class Weekly_Contest_519
    {
        public long MinOperations(int[] nums)
        {
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                while (nums[i] % 9 != 0 || nums[i] % 11 != 0)
                {
                    int mod9 = nums[i] % 9;
                    int mod11 = nums[i] % 11;

                    if (mod9 < mod11)
                    {
                        nums[i] = nums[i] - mod9;
                        count = count + (mod9 % 2);
                        break;
                    }
                    else
                    {
                        nums[i] = nums[i] + mod11;
                        count = count + (mod9 % 2);
                        break;
                    }
                }
            }

            return count;
        }
    }
}