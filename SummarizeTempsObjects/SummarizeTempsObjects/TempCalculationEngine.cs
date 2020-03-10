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
            int _tempValue = 0;
            int _tempCount = 0;
            int _tempAve = 0;

            foreach (int line in _temperatures)
            {
                _tempValue += line;
                _tempCount += 1;

                _tempAve = _tempValue / _tempCount;
            }

            return _tempAve; // <-- Replace this with the actual average
        }

        public int TempsAboveThreshold(int threshold)
        {
            // add logic to calculate temps above the threshold
            int _tempCountAbove = 0;

            foreach (int line in _temperatures)
            {
                if (line > threshold)
                {
                    _tempCountAbove += 1;
                }
                else
                {

                }
            }
            return _tempCountAbove; // <-- Replace this with the number
        }

        public int TempsBelowThreshold(int threshold)
        {
            // add logic to calculate and return temps below the threshold
            int _tempCountBelow = 0;

            foreach (int line in _temperatures)
            {
                if(line < threshold)
                {
                    _tempCountBelow += 1;
                }
                else
                {

                }
            }
            return _tempCountBelow; // <-- Replace this with the number
        }

        public int TempsAtThreshold(int threshold)
        {
            // add logic to calculate and return temps at the threshold
            int _tempIsThresholdCount = 0;

            foreach(int line in _temperatures)
            {
                if(line == threshold)
                {
                    _tempIsThresholdCount += 1;
                }
                else
                {

                }
            }
            return _tempIsThresholdCount; // <-- Replace this with the number
        }

        public int NumberOfTemperatures()
        {
            // add logic to return the number of temparature readings

            int _tempCount = 0;

            foreach (int line in _temperatures)

            {
                _tempCount += 1;
            }

            return _tempCount;// <-- Replace this with the number
            
            
        }
    }
}
