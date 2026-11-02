namespace SalaEventos;

public class ServicioCateringStrategy : IServicioAdicionalStrategy
{
    public decimal CalcularCosto(Cliente cliente, Sala sala, int horas)
    {
        return 8500m * sala.Capacidad;
    }
}

public class ServicioProyectorStrategy : IServicioAdicionalStrategy
{
    public decimal CalcularCosto(Cliente cliente, Sala sala, int horas)
    {
        if (cliente.Tipo == "CORPORATIVO" && horas >= 4)
        {
            return 0m;
        }
        return 15000m;
    }
}
