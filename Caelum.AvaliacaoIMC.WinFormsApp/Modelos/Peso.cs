using System;

namespace Caelum.AvaliacaoIMC.WinFormsApp.Modelos
{
    /// <summary>
    /// Representa a massa de um corpo.
    /// </summary>
    public abstract class Peso
    {
        protected Peso(double valor)
        {
            if (valor < 0)
                throw new ArgumentException("Peso inválido");
            Valor = valor;
        }

        public double Valor { get; private set; }
    }
}