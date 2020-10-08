namespace AluminiumTech.DevKit.DeveloperKit.StringManipulation
{
    public class ResultsAveraging
    {
        

        public double AverageResults(double[] results)
        {
            double average = 0;

            foreach (var result in results)
            {
                average += result;
            }

            average = average / results.Length;
            return average;
        }
    
        public bool IsAllPositive(bool[] results)
        {
            foreach (var result in results)
            {
                if (result.Equals(false))
                {
                    return false;
                }
                else
                {
                    
                }
            }

            return true;
        }

        public bool IsAllNegative(bool[] results)
        {
            foreach (var result in results)
            {
                if (result.Equals(true))
                {
                    return false;
                }
                else
                {
                    
                }
            }
            return true;
        }
        
        public bool AverageResults(bool[] results)
        {
            int trueCounter = 0;
            int falseCounter = 0;
            
            foreach (bool b in results)
            {
                if (b.Equals(true))
                {
                    trueCounter++;
                }
                else
                {
                    falseCounter++;
                }
            }

            return (trueCounter > falseCounter);
        }

    }
}