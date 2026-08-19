using System.Text;

namespace Weekly_And_Biweekly_Contest.Weekly_Contest
{
    public class Weekly_Contest_515
    {
        public int NearestDrone(int[][] drones, int[] target)
        {
            int xCord = 0;
            int yCord = 1;
            int range = 2;
            int leastRange = 100;
            int counter = 0;
            int index = 0;

            // [[0,0,8], [2,2,9]]   /    [3,4]
            // [[2, 1, 5], [4, 4, 5], [6, 6, 8]]   /    [5,5]
            // [[4,4,5]]    /    [8,6]
            foreach (var drone in drones)
            {
                int x = 0;
                int y = 0;
                if (drone[xCord] > target[xCord])
                    x = drone[xCord] - target[xCord];
                else
                    x = target[xCord] - drone[xCord];

                if (drone[yCord] > target[yCord])
                    y = drone[yCord] - target[yCord];
                else
                    y = target[yCord] - drone[yCord];

                int distance = x + y;
                if (distance <= drone[range] && distance < leastRange)
                {
                    if (leastRange == distance)
                        continue;

                    leastRange = distance;
                    index = counter;
                }
                counter++;
            }

            return leastRange == 100 ? -1 : index;
        }

        public int MaximumGap(string skill, string station)
        {
            StringBuilder skillSB = new StringBuilder(skill);
            StringBuilder stationSB = new StringBuilder(station);

            int skillStart = 0;
            int skillEnd = skill.Length - 1;

            int stationStart = 0;
            int stationEnd = station.Length - 1;

            // aa, aaaa
            for (int i = skillStart; i < skill.Length; i++)
            {
                for (int j = stationStart; j < station.Length; j++)
                {
                    if (skill[skillStart] == station[stationStart])
                    {
                        stationSB[stationStart] = '0';
                        stationStart++;
                        skillStart++;
                    }
                    else
                    {
                        stationStart++;
                    }

                    if (skill[skillEnd] == station[stationEnd])
                    {
                        stationSB[stationEnd] = '0';
                        stationEnd--;
                        skillEnd--;
                    }
                }
            }

            return 0;
        }
    }
}