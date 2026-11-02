namespace SalaEventos;


// ¿Qué recibe?
// Recibe la instancia del cliente, la sala y las horas de la reserva.
// ¿Qué devuelve?
// El monto adicional en colones que se debe sumar al subtotal.
// ¿Qué garantiza?
//  Calcular correctamente el costo extra del servicio adicional sin modificar las reglas de otras zonas.
// ¿Qué promete NO hacer?
// No modificar los datos internos del cliente ni alterar los cálculos base de la tarifa de la sala.

public interface IServicioAdicionalStrategy
{
    decimal CalcularCosto(Cliente cliente, Sala sala, int horas);
}