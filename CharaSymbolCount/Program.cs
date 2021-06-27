using System;

namespace CharaSymbolCount
{
    class Program
    { //the following code goes through our chosen string object and counts the characters within it
        static void Main(string[] args)
        {
            int count = 0;
            for (int i= 0; i<DataSet.seus.Length; i++)
            {
                if (DataSet.seus[i] != ' ')
                {
                    count++;
                }
                Console.WriteLine("Total number of characters in the data set selected:" + count);
            }


        }
    }
}
