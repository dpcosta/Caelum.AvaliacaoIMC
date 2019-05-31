namespace Caelum.AvaliacaoIMC.WinFormsApp.Modelos
{
    public class Avaliacao
    {
        public Avaliacao(double resultadoIMC)
        {
            NumeroIMC = resultadoIMC;
        }

        public FaixaDePeso Resultado
        {
            get
            {
                if (NumeroIMC < 25) return FaixaDePeso.AbaixoPesoIdeal;
                if (NumeroIMC >= 25 && NumeroIMC < 30) return FaixaDePeso.PesoNormal;
                return FaixaDePeso.Sobrepeso;
            }
        }
        public double NumeroIMC { get; }

        public override string ToString()
        {
            return Resultado.ToString();
        }
    }
}