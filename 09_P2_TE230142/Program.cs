Console.WriteLine("SISTEMA DE COMPARACIÓN DE BOMBAS ELÉCTRICAS");
Console.WriteLine();

BombaElectrica bomba1 = new BombaElectrica(); // se crea objeto bomba1
Console.WriteLine("--- DATOS DE LA BOMBA 1 ---");
Console.Write("Ingrese el identificador: ");
bomba1.Identificador = Console.ReadLine() ?? "Bomba 1";
Console.Write("Ingrese el voltaje (V): ");
bomba1.Voltaje = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la corriente (A): ");
bomba1.Corriente = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese el caudal (L/min): ");
bomba1.Caudal = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

BombaElectrica bomba2 = new BombaElectrica(); // se crea objeto bomba2
Console.WriteLine("--- DATOS DE LA BOMBA 2 ---");
Console.Write("Ingrese el identificador: ");
bomba2.Identificador = Console.ReadLine() ?? "Bomba 2";
Console.Write("Ingrese el voltaje (V): ");
bomba2.Voltaje = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la corriente (A): ");
bomba2.Corriente = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese el caudal (L/min): ");
bomba2.Caudal = Convert.ToDouble(Console.ReadLine());

double des1 = bomba1.CalcularDesempeno(); // calcula desempeño bomba 1
double des2 = bomba2.CalcularDesempeno(); // calcula desempeño bomba 2

Console.WriteLine();
Console.WriteLine($"Desempeño {bomba1.Identificador}: {des1:F4} (L/min)/W");
Console.WriteLine($"Desempeño {bomba2.Identificador}: {des2:F4} (L/min)/W");
Console.WriteLine();

if (des1 > des2) // compara cuál bomba rinde más
    Console.WriteLine($"La bomba {bomba1.Identificador} entrega más caudal por watt.");
else if (des2 > des1)
    Console.WriteLine($"La bomba {bomba2.Identificador} entrega más caudal por watt.");
else
    Console.WriteLine("Ambas bombas tienen exactamente el mismo desempeño.");

class BombaElectrica // se define la clase
{
    public string Identificador { get; set; } = "";
    public double Voltaje { get; set; }
    public double Corriente { get; set; }
    public double Caudal { get; set; }

    public double CalcularPotencia() => Voltaje * Corriente; // calcula potencia P = V * I

    public double CalcularDesempeno() // calcula caudal por watt
    {
        double potencia = CalcularPotencia();
        if (potencia == 0) return 0;
        return Caudal / potencia;
    }
}