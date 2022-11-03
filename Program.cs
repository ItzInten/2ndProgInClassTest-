class Program
{

    bool invalidinput = true;
    double temperature;
    int enterednumber;
    int menucheck = 1;

    static public void Main()
    {
        Program obj = new Program();
        obj.menu();
    }

    public void input()
    {
        while (invalidinput == true)
        {
            try
            {
                Console.Write("Please enter the temperature ");
                temperature = float.Parse(Console.ReadLine());
                break;
            }
            catch
            {
                Console.Write("Invalid input. ");
            }
        }
    }

    public void menu()
    {
        Program obj1 = new Program();
        obj1.input();
        Console.WriteLine("1. Conversion between a Celsius to Fahrenheit");
        Console.WriteLine("2. Conversion between a Fahrenheit to Celsius");
        Console.WriteLine("3. Conversion between a Celsius to Kelvin");
        Console.WriteLine("4. Conversion between a Fahrenheit to Kelvin");
        Console.WriteLine("5. Exit");
        Console.Write("Enter what do you want to do: ");
        while (menucheck >= 1 && menucheck <=5)
        {
            try
            {
                obj1.menucheck = int.Parse(Console.ReadLine());
                break;
            }
            catch
            {
                Console.Write("Invalid input. ");
            }
        }
        switch (obj1.menucheck)
        {
            case 1:
                double CelsiustoFahrenheit = (obj1.temperature * 9 / 5) + 32;
                Console.WriteLine("Your temperature in Fahrenheit now is " + CelsiustoFahrenheit);
                Console.Write("Click any button to continue: ");
                Console.ReadKey();
                Console.Clear();
                menu();
                break;
            case 2:
                double FahrenheittoCelsius = (obj1.temperature - 32) * 5 / 9;
                Console.WriteLine("Your temperature in Celsius now is " + FahrenheittoCelsius);
                Console.Write("Click any button to continue: ");
                Console.ReadKey();
                Console.Clear();
                menu();
                break;
            case 3:
                double CelsiustoKelvin = obj1.temperature + 273.15;
                Console.WriteLine("Your temperature in Kelvin now is " + CelsiustoKelvin);
                Console.Write("Click any button to continue: ");
                Console.ReadKey();
                Console.Clear();
                menu();
                break;
            case 4:
                double FahrenheittoKelvin = (obj1.temperature - 32) * 5 / 9 + 273.15;
                Console.WriteLine("Your temperature in Kelvin now is " + FahrenheittoKelvin);
                Console.Write("Click any button to continue: ");
                Console.ReadKey();
                Console.Clear();
                menu();
                break;
            case 5:
                break;
        }
    }
}