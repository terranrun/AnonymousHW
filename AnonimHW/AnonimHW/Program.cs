namespace AnonimHW
{
    public delegate string PlanetValidator(string namePlanet);
    public class AnonimHW
    {
       
        static void Main()
        {
            int count = 0;
            // относится к программе 1
            var Venus = new { Name = "Venus", number = 2, EquatorLength = 38, PreviousPlanet = "Mercury" };
            var Earth = new { Name = "Earth", number = 3, EquatorLength = 40, PreviousPlanet = "Venus" };
            var Mars = new { Name = "Mars", number = 4, EquatorLength = 21, PreviousPlanet = "Earth" };
            Venus = new { Name = "Venus", number = 2, EquatorLength = 38, PreviousPlanet = "Mercury" };
            List<object> planets = new List<object> { Venus, Earth, Mars };

            var planet = new Planet((Venus.Name, Venus.number, Venus.EquatorLength, Venus.PreviousPlanet));// относится к программе 2// не понял зачем это


            List<(string Name, int number, double EquatorLength, string PreviousPlanet)> planets1 = new List<(string Name, int number, double EquatorLength, string PreviousPlanet)>();
            planets1.Add(("Venus",2,38, "Mercury"));
            planets1.Add(("Earth", 3,40, "Venus"));
            planets1.Add(("Mars", 4,21, "Earth"));

            PlanetCatalog planetCollection = new PlanetCatalog(planets1);
           
            // Программа 3
            Console.WriteLine(planetCollection.GetPlanet1((namePlanet) =>
            {
                count++;
                if(count > 2)
                {
                    return ("вы спрашиваете слишком часто");
                   
                }
                if (namePlanet == "Limonia")
                {
                    return ("Это запретная планета");
                    
                }
                return namePlanet;
            })); 
            Console.WriteLine(planetCollection.GetPlanet1((namePlanet) =>
            {
                count++;
                if(count > 2)
                {
                    return ("вы спрашиваете слишком часто");
                   
                }
                if (namePlanet == "Limonia")
                {
                    return ("Это запретная планета");
                    
                }
                return namePlanet;
            })); 
            Console.WriteLine(planetCollection.GetPlanet1((namePlanet) =>
            {
                count++;
                if(count > 2)
                {
                    return ("вы спрашиваете слишком часто");
                    
                }
                if (namePlanet == "Limonia")
                {
                    return ("Это запретная планета");
                    
                }
                return namePlanet;
            }));

            //Программа 2
            //Console.WriteLine(planetCollection.GetPlanet("Venus"));
            //Console.WriteLine(planetCollection.GetPlanet("Limon"));
            //Console.WriteLine(planetCollection.GetPlanet("Mars"));

            //Программа 1
            //bool Eqw = false;
            //foreach (var item in planets)
            //{
            //    if (item == Venus)
            //        Eqw = true;
            //    else Eqw = false;
            //    Console.WriteLine($"{item} соответствие венере {Eqw}");
            //}


        }
            
       
    }
    public class Planet// зачем нужен этот класс?
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
        
        int count = 0;

        public  PlanetCatalog(List<(string Name, int number, double EquatorLength, string PreviousPlanet)> planets)
        {
            this.planets.AddRange(planets);
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
                if (item.Name == nameP)
                    return (item.Name, item.number, item.EquatorLength);
                
    

            }
            return result;
        }
        public (string exception, int number, double EquatorLength) GetPlanet1(PlanetValidator planetValidator)// метод для программы3// я не уверен что это должно работать именно так
        {
            var result = (exception: "Не удалось найти планету", 0, 0);
            var namePlanet = planetValidator(Console.ReadLine());
            
            foreach (var item in planets)
            {

                if(namePlanet == item.Name)
                    return (item.Name, item.number, item.EquatorLength);


            }
            return (exception: namePlanet, 0, 0);
        }
     
    }
}

