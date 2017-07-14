using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Text;
using System;
using System.IO;


namespace BLL
{
    public class Arquivo
    {
        public static string Processamento(FileInfo[] _arquivos)
        {
            try
            {
                string _newFile = string.Empty;
                PdfReader _reader;
                PdfReaderContentParser _parser;
                FileInfo _fs;
                StreamWriter _sw;

                foreach (var _arquivo in _arquivos)
                {
                    _reader = new PdfReader(_arquivo.FullName);
                    _parser = new PdfReaderContentParser(_reader);
                    _newFile = _arquivo.Directory + @"\" + System.IO.Path.GetFileNameWithoutExtension(_arquivo.FullName)+".txt";
                    _fs = new FileInfo(_newFile);
                    _sw = _fs.AppendText();

                    for (int i = 1; i <= _reader.NumberOfPages; i++)
                    {
                        _sw.Write(PdfTextExtractor.GetTextFromPage(_reader, i));
                     }

                    _sw.Flush();
                    _sw.Close();
                }
                return "Arquivos processados";
            }
            catch (Exception ex)
            {
                Log.LogarError(ex.StackTrace, "Arquivo.cs", DateTime.Now);
                return "Falha no processamento";
            }
        }
    }
}
