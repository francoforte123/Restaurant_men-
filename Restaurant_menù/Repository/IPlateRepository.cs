using Restaurant_menù.Model;

namespace Restaurant_menù.Repository
{
    public interface IPlateRepository
    {
        void CreatePLate(Plate plate);
        IEnumerable<Plate> GetAllPlate();
        IEnumerable<Plate> GetByType(string type);
        IEnumerable<Plate> GetPlateByPrice(double price);
    }
}
