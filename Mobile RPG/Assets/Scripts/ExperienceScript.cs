public class ExperienceScript
{
    static private float experience;

    public static void AddExp(float amount)
    {
        experience += amount;
    }
    public static float Exerience => experience;
}
