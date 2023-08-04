using Restaurant_menù.Model;

namespace Restaurant_menù.Repository
{
    public interface IPlateRepository
    {
        void CreatePLate(Plate plate);
        IEnumerable<Plate> GetAllPlate();
        IEnumerable<Plate> GetByType(TypeOfPlate type);
        IEnumerable<Plate> GetPlateByPrice();
    }
}
