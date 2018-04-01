using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using BitmapAddition;

namespace Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public unsafe void Can_Find_Max()
        {
            int[] array = new int[] { 4, 20, 200, 100, 10 };

            int resultMax;

            fixed (int* pointerToArray = &array[0])
            {
                resultMax = BitmapAdditionDllManager.FindMax(pointerToArray, array.Length);
            }

            Assert.AreEqual(array.Max(), resultMax);
        }

        [TestMethod]
        public unsafe void Can_Find_Min()
        {
            int[] array = new int[] { 4, 20, 200, 100, 10 };

            int resultMin;

            fixed (int* pointerToArray = &array[0])
            {
                resultMin = BitmapAdditionDllManager.FindMin(pointerToArray, array.Length);
            }

            Assert.AreEqual(array.Min(), resultMin);
        }

        [TestMethod]
        public unsafe void Can_Normalize()
        {
            int[] arrayForNormalization = new int[] { 4, 20, 200, 100, 10 };
            int min = arrayForNormalization.Min();
            int max = arrayForNormalization.Max();

            fixed (int* pointerToArray = &arrayForNormalization[0])
            {
                BitmapAdditionDllManager.Normalize(pointerToArray, arrayForNormalization.Length, min, max);
            }

            int[] expectedArray = new int[] { 4, 20, 200, 100, 10 };
            for (int i  = 0; i < expectedArray.Length; i++)
            {
                expectedArray[i] = (expectedArray[i] - min) * 255 / (max - min);
            }

            Assert.IsTrue(Math.Abs(expectedArray[0] - arrayForNormalization[0]) <= 1);
            Assert.IsTrue(Math.Abs(expectedArray[1] - arrayForNormalization[1]) <= 1);
            Assert.IsTrue(Math.Abs(expectedArray[2] - arrayForNormalization[2]) <= 1);
            Assert.IsTrue(Math.Abs(expectedArray[3] - arrayForNormalization[3]) <= 1);
            Assert.IsTrue(Math.Abs(expectedArray[4] - arrayForNormalization[4]) <= 1);
        }

        [TestMethod]
        public unsafe void Can_Revert_Normalization()
        {
            int[] revertedNormalizationArray = new int[] { 4, 20, 200, 100, 10 };
            int min = revertedNormalizationArray.Min();
            int max = revertedNormalizationArray.Max();


            fixed (int* pointerToArray = &revertedNormalizationArray[0])
            {
                BitmapAdditionDllManager.Normalize(pointerToArray, revertedNormalizationArray.Length, min, max);
                BitmapAdditionDllManager.RevertNormalization(pointerToArray, revertedNormalizationArray.Length, min, max);
            }

            int[] originalArray = new int[] { 4, 20, 200, 100, 10 };

            Assert.IsTrue(Math.Abs(originalArray[0] - revertedNormalizationArray[0]) <= 1);
            Assert.IsTrue(Math.Abs(originalArray[1] - revertedNormalizationArray[1]) <= 1);
            Assert.IsTrue(Math.Abs(originalArray[2] - revertedNormalizationArray[2]) <= 1);
            Assert.IsTrue(Math.Abs(originalArray[3] - revertedNormalizationArray[3]) <= 1);
            Assert.IsTrue(Math.Abs(originalArray[4] - revertedNormalizationArray[4]) <= 1);
        }

        [TestMethod]
        public unsafe void Can_Add_With_Weight()
        {
            int[] firstArray = new int[] { 10, 100, 200 };
            int[] secondArray = new int[] { 5, 50, 40 };
            int[] result = new int[3];

            int weight = 30;
            int[] expexpectedResult = new int[]
            {
                (int) (0.3*firstArray[0] + 0.7*secondArray[0]),
                (int) (0.3*firstArray[1] + 0.7*secondArray[1]),
                (int) (0.3*firstArray[2] + 0.7*secondArray[2])
            };        

            fixed(int* pointerToFirst = &firstArray[0], pointerToSecond = &secondArray[0], pointerToResult = &result[0])
            {
                BitmapAdditionDllManager.AddWithWeight(pointerToFirst, pointerToSecond, pointerToResult, firstArray.Length, weight);
            }
           
            Assert.IsTrue(Math.Abs(expexpectedResult[0] - result[0]) <= 1);
            Assert.IsTrue(Math.Abs(expexpectedResult[1] - result[1]) <= 1);
            Assert.IsTrue(Math.Abs(expexpectedResult[2] - result[2]) <= 1);
        }
    }
}
