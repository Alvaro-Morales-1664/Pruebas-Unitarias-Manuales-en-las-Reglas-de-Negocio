Console.WriteLine("=== Prueba: ValidarCorreo ===");
ProbarCorreo("juan.perez@correo.com", esperadoValido: true);
ProbarCorreo("correo_invalido", esperadoValido: false);

Console.WriteLine("\n=== Prueba: ValidarSalario ===");
ProbarSalario(4500m, esperadoValido: true);
ProbarSalario(-200m, esperadoValido: false);

static void ProbarCorreo(string correo, bool esperadoValido)
{
    try
    {
        Validaciones.ValidarCorreo(correo);
        Console.WriteLine(esperadoValido
            ? $"OK - '{correo}' fue aceptado como se esperaba"
            : $"FALLO - '{correo}' debió ser aceptado y no lo fue");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(esperadoValido
            ? $"FALLO - '{correo}' era válido pero fue rechazado: {ex.Message}"
            : $"OK - '{correo}' fue rechazado correctamente: {ex.Message}");
    }
}

static void ProbarSalario(decimal salario, bool esperadoValido)
{
    try
    {
        Validaciones.ValidarSalario(salario);
        Console.WriteLine(esperadoValido
            ? $"OK - salario {salario} aceptado como se esperaba"
            : $"FALLO - salario {salario} debió ser rechazado y no lo fue");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(esperadoValido
            ? $"FALLO - salario {salario} era válido pero fue rechazado: {ex.Message}"
            : $"OK - salario {salario} fue rechazado correctamente: {ex.Message}");
    }
}
