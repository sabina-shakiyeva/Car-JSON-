using System.Text.Json;

namespace JSON__car_;

public class CarGallery
{
    public string Name { get; set; }
    public List<Car> Cars { get; set; } = new List<Car>();

    public void AddCar(Car car)
    {
        Cars.Add(car);
    }

    public void RemoveCar(int carId)
    {
        Cars.RemoveAll(car=>car.Id==carId);

      
    }

    public List<Car> GetAll()
    {
        return Cars;
    }
    public Car GetById(int id)
    {
        return Cars.Find(car => car.Id == id);
    }

    public void JsonSerializeMethod()
    {
        JsonSerializerOptions op = new JsonSerializerOptions();
        op.WriteIndented = true;
        var jsonString = JsonSerializer.Serialize(Cars, op);
        File.WriteAllText("cars.json", jsonString);

    }
    public void JsonDeserializeMethod()
    {
        using FileStream fs = new FileStream("cars.json", FileMode.Open);
        Cars = JsonSerializer.Deserialize<List<Car>>(fs);
    }
}