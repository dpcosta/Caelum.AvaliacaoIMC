﻿using System;

namespace Caelum.AvaliacaoIMC.WinFormsApp.Modelos
{
    /// <summary>
    /// Representa a altura de um corpo.
    /// </summary>
    public abstract class Altura
    {
        protected Altura(double valor)
        {
            if (valor < 0)
                throw new ArgumentException("Altura inválida.");
            Valor = valor;
        }

        public double Valor { get; private set; }
    }
}