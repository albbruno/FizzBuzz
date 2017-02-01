using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz
    {

        public string[] mResults;
        private int mFBLength;
        private string mOutput;
        private int min;
        private int max;

        public FizzBuzz()
        {
            mFBLength = 15;
            mResults = new string[mFBLength];

            min = 1;
            max = mFBLength;

            CreateValues();
        }

        public FizzBuzz(int FBLength)
        {
            mFBLength = FBLength;
            mResults = new string[mFBLength];

            min = 1;
            max = mFBLength;

            CreateValues();
        }

        public FizzBuzz(int valOne, int valTwo)
        {
            if (valOne > valTwo)
            {
                max = valOne;
                min = valTwo;
            }

            else
            {
                max = valTwo;
                min = valOne;
            }

            mFBLength = max - min;
            mResults = new string[mFBLength];

            SetValues();
        }


        /*private void SetDefaultValues()
        {

            for (int i = 1; i <= mFBLength; i++)
            {
                mOutput = "";
                
                if(i%15 == 0)
                {
                    mOutput = "FizzBuzz";
                }
                else if(i % 3 == 0)
                {
                    mOutput += "Fizz";
                }
                else if (i % 5 == 0)
                {
                    mOutput += "Buzz";
                }
                else
                {
                    mOutput = i.ToString();
                }

                mResults[i-1] = mOutput;
            }

        }*/

        private void CreateValues()
        {
            int printVal;

            for (int i = 0; i < mFBLength; i++)
            {
                mOutput = "";

                if ((i+min) % 15 == 0)
                {
                    mOutput = "FizzBuzz";
                }
                else if ((i + min) % 3 == 0)
                {
                    mOutput += "Fizz";
                }
                else if ((i + min) % 5 == 0)
                {
                    mOutput += "Buzz";
                }
                else
                {
                    printVal = i + min;
                    mOutput = printVal.ToString();
                }

                mResults[i] = mOutput;
            }

        }

        public bool PrintResults()
        {

            foreach(string result in mResults)
            {
                Console.WriteLine(result);

                Console.WriteLine();
            }

            return true;
        }

        private void swap(ref int val1, ref int val2)
        {
            int tmp = val1;
            val1 = val2;
            val2 = tmp;
        }
    }
}
