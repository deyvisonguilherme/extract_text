using System;
using System.IO;
using System.Text;

namespace BLL
{
    public class Log
    {
        public static void LogarError(string _linha, string _classe, DateTime _dataHora)
        {
            try
            {
                using (StreamWriter _swt = new StreamWriter(".", true, Encoding.UTF8))
                {
                    _swt.WriteLine(_linha);
                    _swt.WriteLine(_classe);
                    _swt.WriteLine(_dataHora);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de escrita de arquivo de log :"+ ex.Message);
            }
        }
    }
}
