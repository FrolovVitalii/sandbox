using System;


namespace FirstSprint
{
    class TaskFunctions
    {

        private int TemporaryResult(int firstIndexOfArray, string[] inputArray)
        {
            int result = 0;

            for (int i = firstIndexOfArray; i < inputArray.Length; i++)
            {
                if (int.Parse(inputArray[i]) > 0)
                {
                    result = 1;
                    break;
                }

            }

            return result;
        }


        public int CompareVersions(string initialValue, string comparisonValue)
        {
            int result = 0;
            bool temporaryFlag = false;
            string[] initialValueArray;
            string[] comparisonValueArray;


            if (initialValue.Contains("."))
            {

                initialValueArray = initialValue.Split('.');
                int minLengthArray = initialValueArray.Length;
                comparisonValueArray = comparisonValue.Split('.');


                if (minLengthArray >= comparisonValueArray.Length)
                {
                    minLengthArray = comparisonValueArray.Length;
                    temporaryFlag = true;
                }


                for (int i = 0; i < minLengthArray; i++)
                {
                    if (int.Parse(initialValueArray[i]) > int.Parse(comparisonValueArray[i]))
                    {
                        result = 1;
                        break;
                    }
                    else if (int.Parse(initialValueArray[i]) < int.Parse(comparisonValueArray[i]))
                    {
                        result = -1;
                        break;
                    }

                }


                if (result == 0)
                {
                    if (temporaryFlag == false)
                    {
                        result = -1 * TemporaryResult(minLengthArray, comparisonValueArray);
                    }
                    else
                    {
                        result = TemporaryResult(minLengthArray, initialValueArray);
                    }

                }
            }


            return result;
        }
    }
}
