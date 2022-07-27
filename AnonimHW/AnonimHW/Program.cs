namespace AnonimHW
{
    public delegate string PlanetValidator(string namePlanet);
    public class AnonimHW
    {
       
        static public int count { get; set; }
        static void Main()
        {
            // относится к программе 1
            var Venus = new { Name = "Venus", number = 2, EquatorLength = 38, PreviousPlanet =(string) null};
            var Earth = new { Name = "Earth", number = 3, EquatorLength = 40, PreviousPlanet = Venus };
            var Mars = new { Name = "Mars", number = 4, EquatorLength = 21, PreviousPlanet = Earth };
           var  Venus1 = new { Name = "Venus", number = 2, EquatorLength = 38, PreviousPlanet = Mars};

            dynamic obj = Venus1;


            //do
            //{
            //    Console.WriteLine(obj.Name, obj.number);
            //    obj = obj.PreviousPlanet;
            //} while (obj != null);
            //Console.ReadLine();


           // Программа 2
            //Console.WriteLine(planetCollection.GetPlanet("Venus"));
            //Console.WriteLine(planetCollection.GetPlanet("Limon"));
            //Console.WriteLine(planetCollection.GetPlanet("Mars"));


            // Программа 3
            PlanetCatalog planetCollection = new PlanetCatalog();
            Console.WriteLine(planetCollection.GetPlanet1("Venus", PV)) ;
            Console.WriteLine(planetCollection.GetPlanet1("Limia", PV)) ;
            Console.WriteLine(planetCollection.GetPlanet1("Limonia", PV)) ;
            Console.WriteLine(planetCollection.GetPlanet1("Mars", PV)) ;
        


        }

   
        static string PV(string namePlanet)
        {
           
            count++;
            if (count > 2)
            {
                return ("вы спрашиваете слишком часто");
            }
            if (namePlanet == "Limonia")
            {
                return ("Это запретная планета");
            }
            if (namePlanet == "Venus" || namePlanet == "Mars" || namePlanet == "Earth")
                return namePlanet;
           
            return null;
        }


    }
}

