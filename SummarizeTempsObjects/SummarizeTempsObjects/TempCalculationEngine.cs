using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SummarizeTempsObjects
{
    public class TempCalculationEngine
    {
        List<int> _temperatures;
        public TempCalculationEngine(List<int> temperatures)
        {
            _temperatures = temperatures;
        }

        public int AverageTemperature()
        {
            // add logic to calculate the average
            int tempValue = 0;
            int tempCount = 0;
            int tempAve = 0;

            foreach (int line in _temperatures)
            {
                tempValue += line;
                tempCount += 1;

                tempAve = tempValue / tempCount;
            }

            return tempAve; // <-- Replace this with the actual average
        }

        public int TempsAboveThreshold(int threshold)
        {
            // add logic to calculate temps above the threshold
            int tempCountAbove = 0;

            foreach (int line in _temperatures)
            {
                if (line > threshold)
                {
                    tempCountAbove += 1;
                }
                else
                {

                }
            }
            return tempCountAbove; // <-- Replace this with the number
        }

        public int TempsBelowThreshold(int threshold)
        {
            // add logic to calculate and return temps below the threshold
            int tempCountBelow = 0;

            foreach (int line in _temperatures)
            {
                if(line < threshold)
                {
                    tempCountBelow += 1;
                }
                else
                {

                }
            }
            return tempCountBelow; // <-- Replace this with the number
        }

        public int TempsAtThreshold(int threshold)
        {
            // add logic to calculate and return temps at the threshold
            int tempIsThresholdCount = 0;

            foreach(int line in _temperatures)
            {
                if(line == threshold)
                {
                    tempIsThresholdCount += 1;
                }
                else
                {

                }
            }
            return tempIsThresholdCount; // <-- Replace this with the number
        }

        public int NumberOfTemperatures()
        {
            // add logic to return the number of temparature readings

            int tempCount = 0;

            foreach (int line in _temperatures)

            {
                tempCount += 1;
            }

            return tempCount;// <-- Replace this with the number
            
            
        }
    }
}
