public static class Darts
{
    public static int Score(double x, double y)
    {
        double distanceSquared = x * x + y * y;
        double distance = Math.Sqrt(distanceSquared);

        if (distance <= 1) {
            return 10;
        } else if (distance <= 5) {
            return 5;
        } else if (distance <= 10) {
            return 1;
        } else {
            return 0;
        }
    }
}
