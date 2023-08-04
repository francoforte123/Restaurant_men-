using Restaurant_menù.Model;
using System.Collections.Generic;
using System.Text.Json;

namespace Restaurant_menù.Repository
{
    public class PlateRepository : IPlateRepository
    {
        private readonly JsonSerializerOptions options= new JsonSerializerOptions{WriteIndented = true};

        public void CreatePLate(Plate plate)
        {
            var plates= GetAllPlate().ToList();
            plates.Add(plate);
            File.WriteAllText("C:\\Users\\laduc\\OneDrive\\Desktop\\progetti_in_C#\\esercizi_C#\\Restaurant_menù\\Restaurant_menù\\File\\menù.json", JsonSerializer.Serialize(plates, options));

        }

        public IEnumerable<Plate> GetAllPlate()     
        {
            var getAll = File.ReadAllText("C:\\Users\\laduc\\OneDrive\\Desktop\\progetti_in_C#\\esercizi_C#\\Restaurant_menù\\Restaurant_menù\\File\\menù.json");
            return JsonSerializer.Deserialize<List<Plate>>(getAll, options);
        }

        public IEnumerable<Plate> GetByType(TypeOfPlate type)
        {
            var typeOfPlates = from plate in GetAllPlate() where plate.Type == type select plate;
            return typeOfPlates;
        }

        public IEnumerable<Plate> GetPlateByPrice()
        {
            var priceOfPlate = from plate in GetAllPlate() where plate.Price < 10 select plate;
            return priceOfPlate;
        }

        
    }
}
