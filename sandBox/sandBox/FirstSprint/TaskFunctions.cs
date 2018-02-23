using System;


namespace FirstSprint
{
    class TaskFunctions
    {

        private int flag = 0;
        private int valueFlag = 0;
        private string[] InitialValueArray;
        private string[] ComparisonValueArray;

        public int CompareVersions(string InitialValue, string ComparisonValue)
        {
            if (InitialValue.Contains("."))
            {

                InitialValueArray = InitialValue.Split('.');

                int minLengthArray = InitialValueArray.Length;

                ComparisonValueArray = ComparisonValue.Split('.');

                if (minLengthArray >= ComparisonValueArray.Length)
                {
                    minLengthArray = ComparisonValueArray.Length;
                    valueFlag = 1;
                }



                for (int i = 0; i < minLengthArray; i++)
                {
                    if (int.Parse(InitialValueArray[i]) > int.Parse(ComparisonValueArray[i]))
                    {
                        flag = 1;
                        break;
                    }
                    else if (int.Parse(InitialValueArray[i]) < int.Parse(ComparisonValueArray[i]))
                    {
                        flag = -1;
                        break;
                    }

                }


                if (flag == 0)
                {
                    if (valueFlag == 0)
                    {
                        for (int i = minLengthArray; i < ComparisonValueArray.Length; i++)
                        {
                            if (int.Parse(ComparisonValueArray[i]) > 0)
                            {
                                flag = -1;
                                break;
                            }

                        }
                    }
                    else
                    {
                        for (int i = minLengthArray; i < InitialValueArray.Length; i++)
                        {
                            if (int.Parse(InitialValueArray[i]) > 0)
                            {
                                flag = 1;
                                break;
                            }

                        }
                    }

                }
            }


            return flag;
        }
    }
}
