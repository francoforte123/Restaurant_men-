using Restaurant_menù.Model;

namespace Restaurant_menù.Repository
{
    public class PlateRepository : IPlateRepository
    {
        private readonly List<Plate> plates;

        public PlateRepository()
        {
            plates = new List<Plate>()
            {
                new Plate()
                {
                    Name= "Carbonara",
                    Type= "Primo",
                    Price= 6.99,
                },
                new Plate()
                {
                    Name= "Risotto alla Milanese",
                    Type= "Primo",
                    Price= 9.99,
                },
                new Plate()
                {
                    Name= "Tiramisù",
                    Type= "Dolce",
                    Price= 6.99,
                },
                new Plate()
                {
                    Name= "Fette di pesce con contorno di verdura",
                    Type= "Contorno",
                    Price= 6.99,
                },
            };
        }

        public void CreatePLate(Plate plate)
        {
            this.plates.Add(plate);
        }

        /*public IEnumerable<Plate> GetAllPlate()     //mi da problemi
        {
            return this.GetAllPlate();
        }*/

        public IEnumerable<Plate> GetByType(string type)
        {
            var typeOfPlates= from plate in plates where (x => 
            return typeOfPlates;
        }

        public IEnumerable<Plate> GetPlateByPrice(double price)
        {
            throw new NotImplementedException();
        }
    }
}
