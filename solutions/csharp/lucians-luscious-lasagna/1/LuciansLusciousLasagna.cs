class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() {
        int time = 40;
        return time;
    }
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int ovenTime) {
        int remainingTime = ExpectedMinutesInOven() - ovenTime;
        return remainingTime;
    }
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers) {
        int preparationTime = layers * 2;
        return preparationTime;
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int ovenTime) {
        int worktime = (layers * 2) + ovenTime;
        return worktime;
    }
}
