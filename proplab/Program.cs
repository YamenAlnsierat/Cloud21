//Car car = new Car();

//car.SetLicenseNumber("drr999");
//Console.WriteLine(car.GetLicenseNumber());

//Console.WriteLine();

//car.SetColor("blue");
//Console.WriteLine(car.GetColor());

//Console.WriteLine();

Car[] cars = new Car[100];

int i = 0;
while (cars.Length <= 100)
{
    cars[i].AddCar();
    i++;
}

foreach (var car in cars)
{
    Console.WriteLine(car.GetLicenseNumber());

    Console.WriteLine();

    Console.WriteLine(car.GetColor());

}
