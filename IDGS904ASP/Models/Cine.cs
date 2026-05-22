using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904ASP.Models
{
    public class Cine
    {
        public string Nombre { get; set; }
        public int CantidadCompradores { get; set; }
        public int CantidadBoletos { get; set; }
        public string UsaTarjeta { get; set; }
        public double TotalAPagar { get; set; }
        public string Mensaje { get; set; }

        public void CalcularTotal()
        {
            if (CantidadCompradores <= 0)
            {
                Mensaje = "Error: Ingresa una cantidad válida de compradores.";
                TotalAPagar = 0;
                return;
            }

            int limiteBoletos = CantidadCompradores * 7;

            if (CantidadBoletos > limiteBoletos)
            {
                Mensaje = $"Error: No puedes comprar más de {limiteBoletos} boletos en total para {CantidadCompradores} persona(s).";
                TotalAPagar = 0;
            }
            else if (CantidadBoletos > 0)
            {
                double precioBoleto = 12.0;
                double subtotal = CantidadBoletos * precioBoleto;
                double porcentajeDescuento = 0.0;

                if (CantidadBoletos > 5)
                {
                    porcentajeDescuento = 0.15; // 15%
                }
                else if (CantidadBoletos >= 3 && CantidadBoletos <= 5)
                {
                    porcentajeDescuento = 0.10; // 10%
                }
                else
                {
                    porcentajeDescuento = 0.0; // Sin descuento
                }

                double descuentoObtenido = subtotal * porcentajeDescuento;
                double totalParcial = subtotal - descuentoObtenido;

                if (UsaTarjeta == "Si")
                {
                    double descuentoTarjeta = totalParcial * 0.10;
                    totalParcial = totalParcial - descuentoTarjeta;
                }

                TotalAPagar = totalParcial;
                Mensaje = "Gracias por su compra";
            }
        }
    }
}