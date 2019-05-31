using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.AvaliacaoIMC.WinFormsApp.Modelos
{
    /// <summary>
    /// Calcula o índice de massa corporal (IMC) a partir do peso e altura de uma pessoa.
    /// </summary>
    public class CalculadorIMC
    {
        public CalculadorIMC(PesoEmKg peso, AlturaEmMetros altura)
        {
            Peso = peso;
            Altura = altura;
        }

        public PesoEmKg Peso { get; private set; }
        public AlturaEmMetros Altura { get; private set; }

        public Avaliacao Calcula()
        {
            var alturaAoQuadrado = Altura * Altura;
            return new Avaliacao(Peso.Valor / alturaAoQuadrado.Valor);
        }
    }
}
