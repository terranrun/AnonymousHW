delegate void Message();

var Venus = new { Name = "Venus", number = 2, EquatorLength = 38, PreviousPlanet = "Mercury" };
var Earth = new { Name = "Earth", number = 3, EquatorLength = 40, PreviousPlanet = "Venus" };
var Mars = new { Name = "Mars", number = 4, EquatorLength = 21, PreviousPlanet = "Earth" };
Venus = new { Name = "Venus", number = 2, EquatorLength = 38, PreviousPlanet = "Mercury" };
List<object> planets = new List<object> { Venus, Earth, Mars };

var planet = new Planet((Venus.Name, Venus.number, Venus.EquatorLength, Venus.PreviousPlanet));

List<(string Name, int number, double EquatorLength, string PreviousPlanet)> planets1 = new List<(string Name, int number, double EquatorLength, string PreviousPlanet)>();
planets1.Add(("Venus",2,38, "Mercury"));
planets1.Add(("Earth", 3,40, "Venus"));
planets1.Add(("Mars", 4,21, "Earth"));


PlanetCatalog cat = new PlanetCatalog(planets1);
string _namePlanet ;

for (int i = 0; i < 4; i++)
{
     _namePlanet = Console.ReadLine();
    if(i == 2)
    {
        Console.WriteLine("Вы спрашиваете слишком часто");
        break;
    }
    Console.WriteLine( cat.GetPlanet(_namePlanet));
}


bool Eqw = false;
foreach (var item in planets)
{
    if (item == Venus)
        Eqw = true;
    else Eqw = false;
    Console.WriteLine($"{item} соответствие венере {Eqw}");
}



public class Planet
{
    public string NamePlanet;
    public int Number;
    public double EquatorLength;
    public string PreviousPlanet;

    public Planet((string, int, double, string) tuple)
    {
        NamePlanet = tuple.Item1;
        Number = tuple.Item2;
        EquatorLength = tuple.Item3;
        PreviousPlanet = tuple.Item4;
    }

    
}

public class PlanetCatalog
{
    
    List <(string Name,int number, double EquatorLength,string PreviousPlanet)> planets = new List<(string Name, int number, double EquatorLength, string PreviousPlanet)>();


    public  PlanetCatalog(List<(string Name, int number, double EquatorLength, string PreviousPlanet)> planets)
    {
        this.planets.AddRange(planets);
    }

   public (string name,int number, double EquatorLength) GetPlanet(string name)// анонимный метод
    {
        var result = (name: "Не удалось найти планету",number: 0, EquatorLength: 0.0);
        foreach (var item in planets)
        {
            
             if (item.Name == name)
                return (item.Name, item.number, item.EquatorLength);
            

        }
        return result;
    }

}
