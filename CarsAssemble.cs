using System;

static class AssemblyLine
{
    const int CARS_PODUCED_PER_HOUR = 221;
    const int MINUTES_PER_HOUR = 60;

    /// <summary>
    /// Calculates the ratio of an item being created without error for a given 
    /// speed. The following table shows how speed influences the success rate:
    /// 0: 0% success rate.
    /// 1 to 4: 100% success rate.
    /// 5 to 8: 90% success rate.
    /// 9: 80% success rate.
    /// 10: 77% success rate.
    /// </summary>
    /// <param name="speed">The speed of the assembly line as a integer value.</param>
    /// <returns>The success rate percentage as a double value.</returns>
    /// <exception cref="NotImplementedException">NotImplementedException</exception>
    public static double SuccessRate(int speed)
    {
        double successRate = 0;

        switch (speed)
        {
            default:
            {
                successRate = 0;
                break;
            }
            case 1:
            case 2:
            case 3:
            case 4:
            {
                successRate = 1.00;
                break;
            }
            case 5:
            case 6:
            case 7:
            case 8:
            {
                successRate = 0.90;
                break;
            }
            case 9:
            {
                successRate = 0.80;
                break;
            }
            case 10:
            {
                successRate = 0.77;
                break;
            }
        }
            
        return successRate;

        throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");
    }

    /// <summary>
    /// Calculates the assembly line's production rate per hour,
    /// taking into account its success rate.
    /// </summary>
    /// <param name="speed">The speed of the assembly line as a integer value.</param>
    /// <returns>The production rate per hour as a double value.</returns>
    /// <exception cref="NotImplementedException"></exception>
    public static double ProductionRatePerHour(int speed)
    {
        return CARS_PODUCED_PER_HOUR * speed * SuccessRate(speed);

        throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int) Math.Floor(ProductionRatePerHour(speed) / MINUTES_PER_HOUR);

        throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
    }
}
