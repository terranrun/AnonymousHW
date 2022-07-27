namespace AnonimHW
{
    public class PlanetCatalog
    {
   
        List <Planet> planets = new List<Planet>();
        
        int count = 0;

        public  PlanetCatalog()
        {
            var Venus = new Planet { NamePlanet = "Venus", Number = 2, EquatorLength = 38, PreviousPlanet = "Mars" };
            var Earth = new Planet { NamePlanet = "Earth", Number = 3, EquatorLength = 40, PreviousPlanet = Venus.NamePlanet };
            var Mars = new Planet { NamePlanet = "Mars", Number = 4, EquatorLength = 21, PreviousPlanet = Earth.NamePlanet };

            planets.Add(Venus);
            planets.Add(Earth);
            planets.Add(Mars);
        }

       public (string exception,int number, double EquatorLength) GetPlanet(string nameP)// метод для программы 2
        {
            var result = (exception: "Не удалось найти планету", 0,0);
            count++;
            foreach (var item in planets)
            { 
                if(count > 2)
                {
                    return (exception: "вы спрашиваете слишком часто", number: 0, EquatorLength: 0);
                    break;
                }
                if (item.NamePlanet == nameP)
                    return (item.NamePlanet, item.Number, item.EquatorLength);
            }
            return result;
        }

        public (string exception, int number, double EquatorLength) GetPlanet1(string nameP,PlanetValidator planetValidator)// метод для программы3// я не уверен что это должно работать именно так
        {
            var planet = planetValidator(nameP);
            var result = (planet, 0, 0.0);
            foreach (var item in planets)
            {
                if (item.NamePlanet == planet)
                {
                    return (item.NamePlanet, item.Number, item.EquatorLength);
                }
            }
            return result;
        }
     
    }
}

