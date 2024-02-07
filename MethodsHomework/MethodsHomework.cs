using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MethodsHomework
{
    [TestClass]
    public class MethodsHomework
    {
        [TestMethod]
        public void WritingMethods()
        {
            //READ ME
            // This test "WritingMethods is all about you taking the contracts below and
            // writing the methods needed to satisfy them.
            // You are NOT allowed to change any code in here at all. 
            // You are only allowed to write methods in the YourAnswers class below.


            //YourAnswers.DoNothing();

            int shouldBe25 = YourAnswers.ReturnIntWithValue25();
            Grading.ReturnIntWithValue25(shouldBe25);

            int shouldBeAdded = YourAnswers.AddTwoNumbers(6, 10);
            Grading.AddTwoNumbers(shouldBeAdded);

            int valueToBeIncremented = 6;
            int incremented = YourAnswers.IncrementMe(valueToBeIncremented);
            Grading.IncrementMe(incremented);

            int valueToBeDecremented = 6;
            int decremented = YourAnswers.DecrementMe(valueToBeDecremented);
            Grading.DecrementMe(decremented);

            double valueToBeCasted = 27.6;
            int casted = YourAnswers.CastDoubleToInt(valueToBeCasted);
            Grading.CastDoubleToInt(casted);

            int valueToBeConverted = 19;
            double converted = YourAnswers.ConvertIntToDouble(valueToBeConverted);
            Grading.ConvertIntToDouble(converted);

            double valueToBeCastedIntoString = 27.6;
            string castedString = YourAnswers.CastMeIntoAString(valueToBeCastedIntoString);
            Grading.CastMeIntoAString(castedString);

            string valueToBeParsed = "27.6";
            double parsed = YourAnswers.ParseMeIntoADouble(valueToBeParsed);
            Grading.ParseMeIntoADouble(parsed);

            int max = YourAnswers.ReturnMaxIntValue();
            Grading.ReturnMaxIntValue(max);

            bool amITrue = YourAnswers.CheckIfIAmTrue(false);
            Grading.CheckIfIAmTrue(amITrue);

            int positiveAndEven = 2;
            bool result = YourAnswers.ReturnTrueOnlyIfIamBothPositiveAndEven(positiveAndEven);
            Grading.ReturnTrueOnlyIfIamBothPositiveAndEvenTrue(result);

            int positiveAndOdd = 3;
            result = YourAnswers.ReturnTrueOnlyIfIamBothPositiveAndEven(positiveAndOdd);
            Grading.ReturnTrueOnlyIfIamBothPositiveAndEvenFalse(result);

            int negativeAndEven = -2;
            result = YourAnswers.ReturnTrueOnlyIfIamBothPositiveAndEven(negativeAndEven);
            Grading.ReturnTrueOnlyIfIamBothPositiveAndEvenFalse(result);

            int negativeAndOdd = -3;
            result = YourAnswers.ReturnTrueOnlyIfIamBothPositiveAndEven(negativeAndOdd);
            Grading.ReturnTrueOnlyIfIamBothPositiveAndEvenFalse(result);

            int[] array = { 4, 5, 6, 8, 12, 17 };
            // Sum means to add the contents of the array all together.
            int sum = YourAnswers.SumTheContentsOfTheArray(array);
            Grading.SumTheContentsOfTheArray(sum);

            int[] array3 = { 4, 5, 6, 8, 12, 17 };
            int value = YourAnswers.GetValueAtPosition3(array3);
            Grading.GetValueAtPosition3(value);

            int length = YourAnswers.GetLengthOfArray(array3);
            Grading.GetLengthOfArray(length);

            int[] array4 = { 3, 3, 3, 3, 3, 3 };
            bool allValuesAre3 = YourAnswers.CheckAllValuesAre3(array4);
            Grading.CheckAllValuesAre3(allValuesAre3);

            int[] arraySwapped = YourAnswers.SwapFirstValueWithLastValue(array3);
            Grading.SwapFirstValueWithLastValue(arraySwapped);

        }

        [TestMethod]
        public void UsingMethods()
        {
            ////    //READ ME
            ////    // This test "UsingMethods" is all about discovering Methods on types you already know about.
            ////    // This will help you learn to read Method contracts and use them appropriately.
            ////    // This WILL require research of the types you are being asked about. You have not
            ////    // seen many of them in class. Its important to be able to research a method youve not
            ////    // seen before but need to use.
            ////    // In this section you are allowed to touch the code, but, ONLY the methods.
            
            
            ////    // Find a method to reverse this list of ages.
            ////    // hint, uses the dot operatore on ages. like ages.SomeMethod()
            ////    // use method here
            ///
            List<int> ages = new List<int> { 15, 27, 43, 12, 19, 51 };
            ages.Reverse();
            Grading.ListIsReversed(ages);

            ////    // find a method to add a value to the list ages at the end.
            int addMeIntoList = 12;
            ////    // use method here
            ///
            ages.Add(addMeIntoList);
            Grading.TwelveWasAdded(ages);

            ////    // find a method to add a value to the list at the front of the list ages, ie, the start of it, or first value.
            int addMeToTheListAtTheVeryFront = 1;
            ////    // use method here
            ///
            ages.Insert(0, addMeToTheListAtTheVeryFront);
            Grading.OneWasAddedToTheFront(ages);

            ////    // find a method to clear the list ages.
            ////    // use method here
            ///
            ages.Clear();
            Grading.AgesIsNowEmpty(ages);

            ////    // find a method to check if the double amount is negative.
            double amount = 29.3;
            //////    // you must capture the result of the found method;\
            /////
           bool isNegative = double.IsNegative(amount); /*/ use method here*/
                Grading.AmountIsNotNegative(isNegative);

            ////    // Find a method to tell you if the sentence contains the work fox
            string sentence = "The quick brown fox.";
            ////    // you must capture the result of the found method;
            bool doesContaintFox = sentence.Contains("fox");// use method here
            Grading.ContainsFox(doesContaintFox);

            ////    // Find a method to replace the word quick, with the word slow
            ////    // you must capture the result of the found method;
            string newSentence = sentence.Replace("quick", "slow");// use method here
            Grading.ReplacedTheWord(newSentence);

            ////    // Find a method to Convert this word to lowercase;
            string word = "UPPER";
            ////    // you must capture the result of the found method;
            ///
            string lowered = word.ToLower();// use method here
            Grading.StringWasLowercased(lowered);
            ////    // Find a method to Convert this word to lowercase;
            ///

            string needsSplit = "I,Need,These,Seperate";
            ////    // you must capture the result of the found method;
            string[] split = needsSplit.Split(',');// use method here
            Grading.StringWasSplit(split);


            // I hope by now you see the power of what the types already do for you.

        }

        public class YourAnswers
    {
            //READ ME
            // You write all your methods here.
            //READ ME
            // This test "WritingMethods is all about you taking the contracts below and
            // writing the methods needed to satisfy them.
            // You are NOT allowed to change any code in here at all. 
            // You are only allowed to write methods in the YourAnswers class below.


           
        static public int ReturnIntWithValue25()
        {
            int shouldBe25 = 25;
            return shouldBe25;

        }

        static public int AddTwoNumbers(int a, int b)
        {
            int shouldBeAdded = a + b;
            return shouldBeAdded;

        }
        
        static public int IncrementMe(int c)
        {
            c++;
            return c;
        }

        static public int DecrementMe(int d)
        {
                d--;
            return d;
        }

        static public int CastDoubleToInt(double e)
        {           
            return (int)e;
        }
    
        static public double ConvertIntToDouble(int f)
        {            
            double converted = Convert.ToDouble(f);
            return converted;
        }
      
        static public string CastMeIntoAString(double g)
        {            
            string castedString = Convert.ToString(g);
            return castedString;
        }

        static public double ParseMeIntoADouble(string toBeParsed)
        {            
            double parsed = double.Parse(toBeParsed);
            return parsed;
        }

        static public int ReturnMaxIntValue()
        {                
            return int.MaxValue;
        }

//test
        static public bool CheckIfIAmTrue(bool toBeChecked)
        {
                if (toBeChecked == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
        }

        static public bool ReturnTrueOnlyIfIamBothPositiveAndEven(int h)
        {                        
            if (h > 0 && h % 2 == 0)
            {
                return true;
            }                      
            else
            {
                return false;
            }
        }

        static public int SumTheContentsOfTheArray(int[] array)
        {            
            int sum = array.Sum();
            return sum;

        }


        static public int GetValueAtPosition3 (int[]array2)
        {           
            int j = array2[2];
            return j;          
        }


        static public int GetLengthOfArray(int[]array)
        {           
            int k = array.Length;
            return k;
        }

            static public bool CheckAllValuesAre3(int [] array)
            {

               for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] != 3)
                    {
                        return false;
                    }
                }
                return true;

            }    
            
            static public int[] SwapFirstValueWithLastValue(int[]array)
            {
                int l = array.Length-1;
                (array[0], array[l]) = (array[l], array[0]);
                return array;
            }



        }

        public class Grading
        {
            static public void AddTwoNumbers(int result)
            {
                Assert.IsTrue(result == 16);
            }

            static public void ReturnIntWithValue25(int result)
            {
                Assert.IsTrue(result == 25);
            }

            static public void CastDoubleToInt(int result)
            {
                Assert.IsTrue(result == 27);
            }

            static public void ConvertIntToDouble(double result)
            {
                Assert.IsTrue(result == 19.0d);
            }

            static public void IncrementMe(int result)
            {
                Assert.IsTrue(result == 7);
            }

            static public void DecrementMe(int result)
            {
                Assert.IsTrue(result == 5);
            }

            static public void CastMeIntoAString(string result)
            {
                Assert.IsTrue(result == "27.6");
            }
            static public void ParseMeIntoADouble(double result)
            {
                Assert.IsTrue(result == 27.6);
            }

            static public void ReturnMaxIntValue(int result)
            {
                Assert.IsTrue(result == int.MaxValue);
            }

            static public void CheckIfIAmTrue(bool result)
            {
                Assert.IsTrue(result == false);
            }

            static public void ReturnTrueOnlyIfIamBothPositiveAndEvenTrue(bool result)
            {
                Assert.IsTrue(result == true);
            }

            static public void ReturnTrueOnlyIfIamBothPositiveAndEvenFalse(bool result)
            {
                Assert.IsTrue(result == false);
            }


            static public void SumTheContentsOfTheArray(int result)
            {
                Assert.IsTrue(result == 52);
            }

            static public void GetValueAtPosition3(int result)
            {
                Assert.IsTrue(result == 6);
            }

            static public void GetLengthOfArray(int length)
            {
                Assert.IsTrue(length == 6);
            }

            static public void CheckAllValuesAre3(bool result)
            {
                Assert.IsTrue(result);
            }

            static public void SwapFirstValueWithLastValue(int[] array)
            {
                Assert.IsTrue(array[0] == 17);
                Assert.IsTrue(array[array.Length - 1] == 4);
            }

            static public void ListIsReversed(List<int> list)
            {
                List<int> reversed = new List<int> { 51, 19, 12, 43, 27, 15 };
                Assert.IsTrue(list.SequenceEqual(reversed));
            }

            static public void TwelveWasAdded(List<int> list)
            {
                Assert.IsTrue(12 == list[list.Count - 1]);
            }

            static public void OneWasAddedToTheFront(List<int> list)
            {
                Assert.IsTrue(list[0] == 1);
            }

            static public void AgesIsNowEmpty(List<int> list)
            {
                Assert.IsTrue(list.Count == 0);
            }

            static public void AmountIsNotNegative(bool result)
            {
                Assert.IsFalse(result);
            }
            static public void ContainsFox(bool result)
            {
                Assert.IsTrue(result);
            }

            static public void ReplacedTheWord(string replaces)
            {
                string sentence = "The slow brown fox.";
                Assert.IsTrue(replaces == sentence);
            }

            static public void StringWasLowercased(string replaces)
            {
                Assert.IsTrue(replaces == "upper");
            }

            static public void StringWasSplit(string[] replaces)
            {
                string[] split = { "I", "Need", "These", "Seperate" };
                Assert.IsTrue(replaces.SequenceEqual(split));
            }
        }

    }
}
