using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Sort
    {
        public static void changetuoicho(Cho cho)
        {
            Cho newcho = new Cho(cho.tuoi);
            newcho.tuoi = 939;
        }
        public static void Insert(int input)
        {
            input = 999;
        }
        public static void Insert(int[] input)
        {
            input[2] = 999;
        }
        public static int[] InsertionSort(int[] input)
        {
            //bat dau chay
            for (int i = 1; i < input.Length; i++)
            {
                int key = input[i];
                int j = i - 1;
                //kiem tra vi tri da dung hay chua, neu chua dung thi swap
                while (j >= 0 && input[j] > key)
                {
                    input[j + 1] = input[j];
                    j--;
                }
                //swap
                input[j + 1] = key;
            }
            return input;
        }

        public static int[] MergeSort(int[] input, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                //de quy ben trai
                MergeSort(input, left, middle);
                // de quy ben  phai
                MergeSort(input, middle + 1, right);

                //Merge
                //tao mang moi
                int[] leftArray = new int[middle - left + 1];
                int[] rightArray = new int[right - middle];

                Array.Copy(input, left, leftArray, 0, middle - left + 1);
                Array.Copy(input, middle + 1, rightArray, 0, right - middle);

                int i = 0;
                int j = 0;
                for (int k = left; k < right + 1; k++)//
                {
                    //kiem tra vi tri va swap
                    if (i == leftArray.Length)
                    {
                        input[k] = rightArray[j];
                        j++;
                    }
                    else if (j == rightArray.Length)
                    {
                        input[k] = leftArray[i];
                        i++;
                    }
                    else if (leftArray[i] <= rightArray[j])
                    {
                        input[k] = leftArray[i];
                        i++;
                    }
                    else
                    {
                        input[k] = rightArray[j];
                        j++;
                    }
                }
            }

            return input;
        }
    }
}
