using Caelum.AvaliacaoIMC.WinFormsApp.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caelum.AvaliacaoIMC.WinFormsApp
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void ValidaTextoDigitadoParaDouble(string texto, out double valor)
        {
            bool ok = Double.TryParse(texto, out valor);
            if (!ok)
            {
                MessageBox.Show("Texto digitado inválido!");
            }
        }

        private void btnIMC_Click(object sender, EventArgs e)
        {
            double peso = 0;
            double altura = 0;
            ValidaTextoDigitadoParaDouble(textoPeso.Text, out peso);
            ValidaTextoDigitadoParaDouble(textoAltura.Text, out altura);
            if (peso > 0 && altura > 0)
            {
                var imc = new CalculadorIMC(new PesoEmKg(peso), new AlturaEmMetros(altura));
                var avaliacao = imc.Calcula();
                MessageBox.Show("Avaliação: " + avaliacao.ToString());
            }
        }

        private void btnArquivo_Click(object sender, EventArgs e)
        {
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                using (var leitor = File.OpenText(openFileDlg.FileName))
                {
                    var linha = leitor.ReadLine();
                    while (linha != null)
                    {
                        var valores = linha.Split(';');
                        var imc = new CalculadorIMC(
                            new PesoEmKg(Convert.ToDouble(valores[1])),
                            new AlturaEmMetros(Convert.ToDouble(valores[2]))
                            );
                        var resultado = imc.Calcula();
                        listaPessoas.Items.Add($"{valores[0]}: {resultado.ToString()}");
                        linha = leitor.ReadLine();
                    }
                }
            }


        }
    }
}
