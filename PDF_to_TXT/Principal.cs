using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace PDF_to_TXT
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        FileInfo[] _arq;
        private void btnDiretorio_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog _dlg = new FolderBrowserDialog())
                {
                    if (_dlg.ShowDialog() != DialogResult.OK)
                        return;

                    DirectoryInfo _info = new DirectoryInfo(_dlg.SelectedPath);
                    _arq = _info.GetFiles();

                    txtDiretorio.Text = _arq[0].Directory.ToString();
                }
            }
            catch (Exception ex)
            {
                BLL.Log.LogarError(ex.StackTrace, "Principal => View", DateTime.Now);
            }
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            string _retorno = string.Empty;

            if (_arq == null)
                MessageBox.Show("Erro: nenhum arquivo encontrado", "Mesangem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                lblStatus.Text = "PROCESSANDO ARQUIVOS";


                new Thread(() =>
                {
                    _retorno = BLL.Arquivo.Processamento(_arq);
                }).Start();
                lblStatus.Text = "";
                MessageBox.Show(_retorno, "Mesangem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
