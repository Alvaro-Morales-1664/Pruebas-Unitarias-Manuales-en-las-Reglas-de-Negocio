public class CrudEmpleados
{
    private List<Empleado> _empleados = new List<Empleado>();
    private int _contadorId = 1;

    public void Crear(Empleado empleado)
    {
        Validaciones.ValidarCorreo(empleado.Correo);
        Validaciones.ValidarSalario(empleado.Salario);

        empleado.Id = _contadorId++;
        _empleados.Add(empleado);
    }

    public List<Empleado> Listar() => _empleados;
}
