using ByteBanckIO;
using System.Globalization;
using System.Text;

partial class Program
{
  static void CriandoArquivo()
  {
    //CriarArquivo();
    CriarArquivoComWriter();
    Console.ReadLine();
  }
  static void CriarArquivo()
  {

    var caminhoNovoArquivo = "C:\\Users\\Biel\\Documents\\workspaces\\vs\\ByteBanckIO\\contasExportadas.csv";

    using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
    {
      var contaComoString = "456,78945,4785.50,Gabriel Vieira";
      var encoding = Encoding.UTF8;
      var bytes = encoding.GetBytes(contaComoString);

      fluxoDeArquivo.Write(bytes, 0, bytes.Length);

    }
  }
  static void CriarArquivoComWriter()
  {
    var caminhoNovoArquivo = "C:\\Users\\Biel\\Documents\\workspaces\\vs\\ByteBanckIO\\contasExportadas.csv";

    using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
    using (var escritor = new StreamWriter(fluxoDeArquivo))
    {
      escritor.Write("456,65465,456.0,Pedro Vieira");
    }
  }
}

