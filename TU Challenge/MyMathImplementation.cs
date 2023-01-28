using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int IsInOrderDesc(int a, int b)
        {
            if (a > b)
            {
                return 1;
            }
            else if (a < b)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static bool IsMajeur(int age)
        {
            if (age <0 || age>140)
            {
                throw new NotImplementedException("abuse pas frerot");
            }
            

            if (age>=18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsEven(int a)
        {
            if (a%2==0)
            {
                return true;
            }
            else { return false; }
        }
        public static bool IsDivisible(int a, int b)
        {
            return (a % b == 0);

        }
        public static bool IsPrimary(int a)
        {
            int num = 0;
            for (int i = 0; i <= a; i++)
            {
                num++;
            }
            throw new NotImplementedException();
        }
        public static int Power(int a, int b)
        {
            int p = a;
            for (int i = 0; i < b; i++)
            {
                p = p * a;
            }
            return p;
        }

        public static int Power2(int a)
        {
            return a * a;
        }

        public static List<int> GetAllPrimary(int a)
        {
            throw new NotImplementedException();
        }

        public static int IsInOrder(int a, int b)
        {
            if (a < b)
            {
                return 1;
            }
            else if (a > b)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public static bool IsListInOrder(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        public static List<int> Sort(List<int> list)
        {
            List<int> sortedList = new List<int>();

            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] < list[i + 1])
                {
                    sortedList.Add(list[i]);    
                    list.RemoveAt(i);
                    i = 0;
                }
            }
            return sortedList;
        }

        /*public static List<int> GenericSort(List<int> toSort, Func<int, int, int> isInOrder)
        {
            throw new NotImplementedException();
        }*/
    }
}
