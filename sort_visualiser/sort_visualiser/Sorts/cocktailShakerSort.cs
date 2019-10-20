using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_visualiser.Sorts
{
    class cocktailShakerSort:Sort
    {
        public cocktailShakerSort ()
        {
            name = "Cocktail Sort";
            id = 1;
        }

        public override void run()
        {
            CocktailShakerSort(array);
        }

        public void CocktailShakerSort(int[] ac)
        {
            int i = 0;
            while (i < ac.Length / 2)
            {
                for (int j = i; j < ac.Length - i - 1; j++)
                {

                    if (ac[j] > ac[j + 1])
                        Util. swap(ac, j, j + 1);
                }
                for (int j = ac.Length - i - 1; j > i; j--)
                {

                    if (ac[j] < ac[j - 1])
                        Util. swap(ac, j, j - 1);
                }
                i++;
            }
        }
    }
}
