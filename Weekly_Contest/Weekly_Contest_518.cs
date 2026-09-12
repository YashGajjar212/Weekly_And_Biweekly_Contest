using System.Text;

namespace Weekly_And_Biweekly_Contest.Weekly_Contest
{
    public class Weekly_Contest_518
    {
        public int CountRotations(string s, int k)
        {
            int result = 0;
            char[] str = new char[s.Length + 1];

            for (int i = 0; i < str.Length; i++)
            {
                str[i] = s[i];
                if (i == str.Length - 1)
                    str[str.Length - 1] = '0';
            }

            for (int i = 0; i < str.Length; i++)
            {

            }


            return result;
        }
        public int CountGroups(int[] position, int[] speed, int distance)
        {
            // [1, 5, 6, 20], [4, 3, 2, 3], 1

            int result = 0;
            int groups = position.Length;
            int anchor = 0;
            int scout = position.Length - 1;
            int timer = 0;

            while (timer < 5)
            {
                for (int i = 0; i < position.Length - 1; i++)
                {
                    if (position[i] + distance >= position[i+1])
                    {
                        speed[i] = speed[i + 1];
                        groups--;
                    }
                }
                timer++;
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < position.Length - 1; j++)
                {
                    position[j] = position[j] + speed[j];

                    if (position[j] - position[j + 1] <= distance)
                    {
                        //result++;
                        groups--;
                        speed[j] = speed[j + 1];
                    }
                }
            }

            return groups;
        }
    }
}