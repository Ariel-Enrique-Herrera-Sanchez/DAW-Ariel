using System.Text.RegularExpressions;

//Probando git en este comentario

Console.WriteLine("Introduzca dni");

string dni = Console.ReadLine()?.Trim().ToUpper();

string patronRegex = @"^[0-9]{8}[A-Z]$";

//Comprobamos si el formato coincide con la Regex
if (!Regex.IsMatch(dni, patronRegex))
{
    Console.WriteLine("Error el formato deben ser 8 numeros y una letra");
    return;
}

string numerosStr = dni.Substring(0, 8);

char letraUsuario = dni[8];

int numeroDni = int.Parse(numerosStr);

char letraCorrecta = CalcularLetraDNI(numeroDni);

if (letraUsuario == letraCorrecta)
{
    Console.WriteLine("Dni Valido");
}
else
{
    Console.WriteLine($"Dni Invalido para el numero {numerosStr}la letra deberia ser{letraCorrecta} ");
}

static char CalcularLetraDNI (int dni)
{
    string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
    int indice = dni % 23;
    return letras[indice];

}


