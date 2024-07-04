using JSON__car_;

class Program
{
    static void Main(string[] args)
    {
        CarGallery gallery = new CarGallery
        {
            Name = "Auto Gallery"
        };


        //gallery.JsonDeserializeMethod();





        while (true)
        {
            Console.WriteLine("1) Add Car");
            Console.WriteLine("2) Remove Car");
            Console.WriteLine("3) Get All");
            Console.WriteLine("4) GetCarByID");
            Console.WriteLine("5) Save");
            Console.WriteLine("6) Exit");
            Console.WriteLine("Choice:");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Car car = new Car();
                Console.WriteLine("Enter id:");
                car.Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Marka:");
                car.Marka = Console.ReadLine();
                Console.WriteLine("Model:");
                car.Model = Console.ReadLine();
                Console.WriteLine("Car year:");
                car.Year = int.Parse(Console.ReadLine());
                gallery.AddCar(car);

            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter remove id:");
                int removee = int.Parse(Console.ReadLine());
                gallery.RemoveCar(removee);
            }
            else if (choice == 3)
            {
                foreach (var car in gallery.GetAll())
                {
                    Console.WriteLine(car);
                }
            }
            else if (choice == 4)
            {
                Console.WriteLine("Enter Id:");
                int id = int.Parse(Console.ReadLine());
                Car car = gallery.GetById(id);
                if (car != null)
                {
                    Console.WriteLine(car);
                }
                else
                {
                    Console.WriteLine("Car not found.");
                }

            }
            else if (choice == 5)
            {
                gallery.JsonSerializeMethod();
            }
            else if(choice== 6)
            {
                break;
            }

        }




    }
}