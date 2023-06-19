using Software2KnowledgeCheck1;

public class Program
{
    public static void Main(string[] args)
    {
        var constructionLogic = new ConstructionLogic();
        var apartment = new Apartment();
        var highRise = new HighRise(); 
        var building = new Building();

        var buildings = new List<Building>() { highRise, building };

        

        constructionLogic.CreateBuilding(apartment, buildings);
    }
}