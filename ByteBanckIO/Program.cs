partial class Program
{
  static void Main(string[] args)
  {
    //LidandoComFileStreamDiretamente();

    var enderecoDoArquivo = "C:\\Users\\Biel\\Documents\\workspaces\\vs\\ByteBanckIO\\contas.txt";

    using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
    {
      var leitor = new StreamReader(fluxoDoArquivo);

      //var linha = leitor.ReadLine();

      //var texto = leitor.ReadToEnd();

      //var numero = leitor.Read();

      //Console.WriteLine(linha);
      //Console.WriteLine(texto);
      //Console.WriteLine(numero);

      while (!leitor.EndOfStream)
      {
        var linha = leitor.ReadLine();
        Console.WriteLine(linha);
      }
    }
    Console.ReadLine();
  }
}


