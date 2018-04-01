using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using BitmapAddition.Extensions;

namespace BitmapAddition
{
    public static class BitmapAdditionDllManager
    {
        public static Bitmap AddImages(Bitmap firstSource, Bitmap secondScource, int weight, bool revertNormalizationByFirstImage)
        {
            var (rValuesOfImage1, gValuesOfImage1, bValuesOfImage1) = firstSource.GetRgbValues();

            int rMin1 = FindMin(rValuesOfImage1);
            int rMax1 = FindMax(rValuesOfImage1);

            int gMin1 = FindMin(gValuesOfImage1);
            int gMax1 = FindMax(gValuesOfImage1);

            int bMin1 = FindMin(bValuesOfImage1);
            int bMax1 = FindMax(bValuesOfImage1);

            var (rValuesOfImage2, gValuesOfImage2, bValuesOfImage2) = secondScource.GetRgbValues();

            int rMin2 = FindMin(rValuesOfImage2);
            int rMax2 = FindMax(rValuesOfImage2);

            int gMin2 = FindMin(gValuesOfImage2);
            int gMax2 = FindMax(gValuesOfImage2);

            int bMin2 = FindMin(bValuesOfImage2);
            int bMax2 = FindMax(bValuesOfImage2);

            Normalize(rValuesOfImage1);
            Normalize(gValuesOfImage1);
            Normalize(bValuesOfImage1);

            Normalize(rValuesOfImage2);
            Normalize(gValuesOfImage2);
            Normalize(bValuesOfImage2);

            int[] rResult = AddWithWeight(rValuesOfImage1, rValuesOfImage2, weight);
            int[] gResult = AddWithWeight(gValuesOfImage1, gValuesOfImage2, weight);
            int[] bResult = AddWithWeight(bValuesOfImage1, bValuesOfImage2, weight);

            Normalize(rResult);
            Normalize(gResult);
            Normalize(bResult);

            if (revertNormalizationByFirstImage)
            {
                RevertNormalization(rResult, rMin1, rMax1);
                RevertNormalization(gResult, gMin1, gMax1);
                RevertNormalization(bResult, bMin1, bMax1);
            }
            else
            {
                RevertNormalization(rResult, rMin2, rMax2);
                RevertNormalization(gResult, gMin2, gMax2);
                RevertNormalization(bResult, bMin2, bMax2);
            }

            Bitmap result = new Bitmap(firstSource.Width, firstSource.Height);

            result.SetPixels(rResult, gResult, bResult);

            return result;
        }

        unsafe public static int FindMax(int[] array)
        {
            fixed(int* pointerToArray = &array[0])
            {
                return FindMax(pointerToArray, array.Length);
            }
        }

        unsafe public static int FindMin(int[] array)
        {
            fixed (int* pointerToArray = &array[0])
            {
                return FindMin(pointerToArray, array.Length);
            }
        }

        public static void Normalize(int[] array)
        {
            int max = FindMax(array);
            int min = FindMin(array);

            Normalize(array, min, max);
        }
         
        unsafe public static void Normalize(int[] array, int min, int max)
        {
            fixed (int* pointerToArray = &array[0])
            {
                Normalize(pointerToArray, array.Length, min, max);
            }
        }

        unsafe public static void RevertNormalization(int[] array, int min, int max)
        {
            fixed (int* pointerToArray = &array[0])
            {
                RevertNormalization(pointerToArray, array.Length, min, max);
            }
        }

        unsafe public static int[] AddWithWeight(int[] firstArray, int[] secondArray, int weight)
        {
            int[] result = new int[firstArray.Length];

            fixed (int* pointerToFirstArray = &firstArray[0], pointerToSecondArray = &secondArray[0], pointerToResult = &result[0])
            {
                AddWithWeight(pointerToFirstArray, pointerToSecondArray, pointerToResult, result.Length, weight);
            }

            return result;
        }

        [DllImport(@"..\..\..\BitmapAddition.DLL")]
        unsafe public static extern int FindMax(int* array, int length);

        [DllImport(@"..\..\..\BitmapAddition.DLL")]
        unsafe public static extern int FindMin(int* array, int length);

        [DllImport(@"..\..\..\BitmapAddition.DLL")]
        unsafe public static extern void Normalize(int* array, int length, int min, int max);

        [DllImport(@"..\..\..\BitmapAddition.DLL")]
        unsafe public static extern void RevertNormalization(int* array, int length, int min, int max);

        [DllImport(@"..\..\..\BitmapAddition.DLL")]
        unsafe public static extern void AddWithWeight(int* firstArray, int* secondArray, int* result, int length, int weight);
    }
}
