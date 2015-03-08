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

namespace Aprendendo
{
    public partial class EditorDeTexto : Form
    {
        public EditorDeTexto()
        {
            InitializeComponent();
        }

        private void textoConteudo_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditorDeTexto_Load(object sender, EventArgs e)
        {
            if (File.Exists("D:\\teste.log"))
            {
                using (Stream entrada = File.Open("D:\\teste.log", FileMode.Open))
                using (StreamReader leitor = new StreamReader(entrada))
                {
                    string linha = leitor.ReadToEnd();
                    textoConteudo.Text += linha;
                }
            }
        }

        private void botaoGrava_Click(object sender, EventArgs e)
        {
            using(Stream saida = File.Open("D:\\teste.log",FileMode.Create))
            using (StreamWriter escritor = new StreamWriter(saida))
            {
                escritor.Write(textoConteudo.Text);
            }
        }

    }
}
