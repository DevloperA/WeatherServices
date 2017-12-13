public class Area :IIArea
{
   
    public double AreaofSquare(double sides)
    {
        return sides * sides;
    }
    public double AreaofRectangle(double length, double breadth)
    {
        return length * breadth;
    }
    public double GetSpeed(double distance, double time)
    {
        return distance / time;
    }
    public double GetDistance(double speed, double time)
    {
        return speed * time;
    }
}