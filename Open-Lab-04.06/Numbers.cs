using System;

namespace Open_Lab_04._06
{
    public class Numbers
    {
        public int[] NoOdds(int[] numbers)
        {
            int x = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i]%2 == 0)

                {
                    x++;
                }
            }
            int[] numbers2 = new int[x];
            int y = 0;
            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[j] % 2 == 0)
                {
                    numbers2[y] += numbers[j];
                    y++;
                }
            }
            return numbers2;
        }
    }
}
