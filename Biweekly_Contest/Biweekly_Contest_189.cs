namespace Weekly_And_Biweekly_Contest.Biweekly_Contest
{
    public class Biweekly_Contest_189
    {
        public int P1_ElevatorRequests(int n, int[] requests)
        {
            int sum = 0;
            int currentLocation = 0;

            // 2,1,4,3
            for (int i = 0; i < requests.Length; i++)
            {
                while (currentLocation != requests[i])
                {
                    if (currentLocation > requests[i])
                    {
                        sum++;
                        currentLocation--;
                    }

                    else if (currentLocation < requests[i])
                    {
                        sum++;
                        currentLocation++;
                    }

                }
                currentLocation = requests[i];
            }

            return sum;
        }

        public int P2_MinOperations(string s)
        {
            // abc
            char[] word = s.ToCharArray();
            int first = 0;
            int last = word.Length - 1;
            int sum = 0;

            char test = 'b';
            int test11 = (int)test;
            int btimes10 = test * 10;
            int btimes11 = test * 10 + 9;

            if (word.Length % 2 != 0)
            {
                while (first != last)
                {
                    sum = sum + (Math.Abs(word[first] - word[last]));
                }
                first++;
                last--;
            }
            else
            {
                while (first < last)
                {
                    sum = sum + (Math.Abs(word[first] - word[last]));
                }
                first++;
                last--;
            }

            return sum;
        }

        public long P4_ElevatorRequests(int n, int start, int[] requests)
        {
            int sum = 0;
            int currentLocation = start;

            // 2,1,4,3
            for (int i = 0; i < requests.Length; i++)
            {
                if (start == 0)
                {
                    while (currentLocation != requests[i])
                    {
                        if (currentLocation > requests[i])
                        {
                            sum++;
                            currentLocation--;
                        }

                        else if (currentLocation < requests[i])
                        {
                            sum++;
                            currentLocation++;
                        }

                    }
                }
                currentLocation = requests[i];
            }

            return sum;

            return 0;
        }
    }
}