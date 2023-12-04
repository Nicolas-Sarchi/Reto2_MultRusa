

Console.WriteLine("Ingrese el valor del multiplicador: ");
int multiplicador = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el valor del multiplicando: ");
int multiplicando = Convert.ToInt32(Console.ReadLine());

int sum = 0;

while (multiplicador != 0) {
    if (multiplicador % 2 != 0)
    {
        sum += multiplicando;
    }
    multiplicador /= 2;
    multiplicando *= 2;
}

Console.WriteLine("resultado: " + sum);
