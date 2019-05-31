namespace Caelum.AvaliacaoIMC.WinFormsApp.Modelos
{
    public class AlturaEmMetros : Altura
    {
        public AlturaEmMetros(double valor) : base(valor)
        {
        }

        public static AlturaEmMetros operator * (AlturaEmMetros um, AlturaEmMetros outro)
        {
            return new AlturaEmMetros(um.Valor * outro.Valor);
        }
    }
}