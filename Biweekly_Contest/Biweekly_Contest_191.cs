using System.Globalization;

namespace Weekly_And_Biweekly_Contest.Biweekly_Contest
{
    public class Biweekly_Contest_191
    {
        public int CountSpecialIntegers(int[] nums)
        {
            // 1,8,1,5,1,5,8,5
            int count = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                    dict[nums[i]]++;
                else
                    dict.Add(nums[i], 1);
            }

            foreach (var item in dict)
            {
                if (item.Value >= 3)
                {
                    int[] occ = new int[item.Value];
                    occ[0] = 1;

                    int index = 0;
                    for (int i = 0; i < nums.Length; i++)
                    {
                        if (nums[i] == item.Key)
                        {
                            occ[index] = i;
                            index++;
                        }
                    }
                    count = count + OccChecker(occ);
                }
            }

            return count;
        }

        public int OccChecker(int[] occ)
        {
            int sum = 1;

            for (int i = 0; i < occ.Length - 2; i++)
            {
                if ((occ[i + 1] - occ[i]) != (occ[i + 2] - occ[i + 1]))
                    return 0;
            }
            
            return sum;
        }

        public int MinDays(int n)
        {
            //int temp = n;
            //int sum = 0;

            //while(temp > 0)
            //{
            //    if (temp >= 6)
            //    {
            //        sum = sum + 3;
            //        temp = temp - 6;
            //    }
            //    else
            //    {
            //        if (temp == 1)
            //        {
            //            sum = sum + 1;
            //            temp--;
            //        }
            //        else if (temp == 2)
            //        {
            //            sum = sum + 2;
            //            temp = temp - 2;
            //        }
            //        else if (temp == 3)
            //        {
            //            sum = sum + 3;
            //            temp = temp - 3;
            //        }
            //    }
            //}

            //return sum;
            
            // ------------------------------------------------------------------
            
            //int temp = n;
            int temp = 12;
            int sum = 0;

            while (temp > 0)
            {
                if (temp >= 6)
                {
                    sum = sum + 3;
                    temp = temp - 6;
                }
                else
                {
                    //var test = temp % 3;
                    if (temp == 0)
                    {
                        sum = sum + 3;
                        temp = temp - 3;
                    }
                    else if (temp == 1)
                    {
                        sum = sum + 1;
                        temp = temp - 1;
                    }
                    else if (temp == 2)
                    {
                        sum = sum + 2;
                        temp = temp - 2;
                    }
                    else if (temp == 3)
                    {
                        sum = sum + 3;
                        temp = temp - 3;
                    }
                }
            }

            return sum;
        }
    }
}