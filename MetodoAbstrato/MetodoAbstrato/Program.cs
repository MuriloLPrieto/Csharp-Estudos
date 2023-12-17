using MetodoAbstrato;
using System.Globalization;

List<Shape> list = new List<Shape>();

Console.WriteLine("Enter the number of figures: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Shape #{i} data: ");
    Console.WriteLine($"Circle or Rectangle  (r/c): ");
    char option = char.Parse(Console.ReadLine().ToLower());
    Console.WriteLine("Color (Black/Blue/Red): ");
    Color color = Enum.Parse<Color>(Console.ReadLine());

    if (option == 'c')
    {
        Console.WriteLine("Radius: ");
        double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new Circle(r, color));
    }
    else if(option == 'r')
    {
        Console.WriteLine("Height: ");
        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Width: ");
        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        list.Add(new Rectangle(height, width, color));
    }
    else
    {
        Console.WriteLine("ERROR!");
    }

    Console.Clear();
}

Console.WriteLine("Shape Areas: ");

foreach (Shape area in list)
{
    Console.WriteLine(area.Area().ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine(area.Color);
}