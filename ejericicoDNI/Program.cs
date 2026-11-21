using System.Text.RegularExpressions;


string patron = (@"^\d{}[A-HJ-NP-TV-Z]$");
verificar("25S");

void verificar(string texto) 
{
   
    bool esValido = Regex.IsMatch(texto, patron);
    if (esValido)
    {
        Console.WriteLine("dni correcto");
    }
    else {
        Console.WriteLine("Dni incorrecto");
    }
}
