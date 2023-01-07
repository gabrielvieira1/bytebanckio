using System.Text;

partial class Program
{
  static void LidandoComFileStreamDiretamente()
  {
    var enderecoDoArquivo = "C:\\Users\\Biel\\Documents\\workspaces\\vs\\ByteBanckIO\\contas.txt";

    // Antigo

    //var fluxoDoArquivo = new FileStream(arquivo, FileMode.Open);

    //var buffer = new byte[1024];

    //var quantidadeBytesLidos = -1;

    //while (quantidadeBytesLidos != 0)
    //{
    //  quantidadeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
    //  EscreverBuffer(buffer);
    //}

    using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
    {
      var buffer = new byte[1024]; // 1 kb
      var numeroDeBytesLidos = -1;

      while (numeroDeBytesLidos != 0)
      {
        numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
        EscreverBuffer(buffer, numeroDeBytesLidos);
      }

      fluxoDoArquivo.Close();

      Console.ReadLine();
    }
  }
  static void EscreverBuffer(byte[] buffer, int bytesLidos)
  {
    var encoding = new UTF8Encoding();
    var texto = encoding.GetString(buffer, 0, bytesLidos);

    Console.Write(texto);

    //foreach (var meuByte in buffer)
    //{
    //  Console.Write(meuByte);
    //  Console.Write(" ");
    //}
  }
}

