using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    internal static class Conversoes
    {
        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }

        public enum ConversaoDistancias
        {
            Nulo = 0,
            MetrosMilhas,
            MilhasMetros
        }

        public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura * 1.8 + 32);
            }
            else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
            {
                return (temperatura - 32) / 1.8;
            }

            return -1;
        }

        public static double ConverterDistancias(ConversaoDistancias conversao, double distancia)
        {
            if (conversao == ConversaoDistancias.MetrosMilhas)
            {
                return (distancia * 0.0006213712);
            }
            else if (conversao == ConversaoDistancias.MilhasMetros)
            {
                return (distancia * 1609.344);
            }

            return -1;
        }
    }
}
