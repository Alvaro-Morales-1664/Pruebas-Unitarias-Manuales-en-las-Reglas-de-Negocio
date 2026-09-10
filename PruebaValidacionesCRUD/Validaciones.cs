public static class Validaciones
{
    public static bool ValidarCorreo(string correo)
    {
        if (string.IsNullOrWhiteSpace(correo) || !correo.Contains("@") || !correo.Contains("."))
        {
            throw new ArgumentException("Correo inválido: " + correo);
        }
        return true;
    }

    public static bool ValidarSalario(decimal salario)
    {
        if (salario < 0)
        {
            throw new ArgumentException("El salario no puede ser negativo: " + salario);
        }
        return true;
    }
}
