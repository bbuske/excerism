static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed == 0) {
            return 0.0;
        } 
        else if (speed > 0 && speed <= 4) {
            return 1.0;    
        }
        else if (speed > 4 && speed <= 8) {
            return 0.90;
        }
        else if (speed == 9) {
            return 0.80;
        }
        else {
            return 0.77;
        }
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        if (speed == 0) {
            return 0;
        }
        else if (speed > 0 && speed <= 4) {
            return speed * 221 * 1.0;
        }
        else if (speed > 4 && speed <= 8) {
            return speed * 221 * 0.90;
        }
        else if (speed == 9) {
            return speed * 221 * 0.80;
        }
        else {
        return speed * 221 * 0.77;
        }
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        if (speed == 0) {
            return (int)0;
        }
        else if (speed > 0 && speed <= 4) {
            return (int)speed * 221 / 60;
        }
        else if (speed > 4 && speed <= 8) {
            return (int)(speed * 221 * 0.9) / 60;
        }
        else if (speed == 9) {
            return (int)(speed * 221 * 0.8) / 60;
        }
        else {
            return (int)(speed * 221 * 0.77) / 60;
        }
    }
}
