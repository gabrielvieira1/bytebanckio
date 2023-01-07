using ByteBanckIO;
using System.Globalization;
using System.Text;

partial class Program
{
  static void Main(string[] args)
  {
    //LidandoComFileStreamDiretamente();
    //UsandoStreamReader();
    //CriandoArquivo();
    //StreamBinary();
    //UsandoStreamDeEntradaDaConsole();

    // Auxiliares da classe File

    //Console.WriteLine("Digite seu nome:");
    //var nome = Console.ReadLine();

    var linhas = File.ReadAllLines("C:\\Users\\Biel\\Documents\\workspaces\\vs\\ByteBanckIO\\contas.txt");
    Console.WriteLine(linhas.Length);

    /*
    foreach (var linha in linhas)
    {
        Console.WriteLine(linha);
    }
    */

    var bytesArquivo = File.ReadAllBytes("C:\\Users\\Biel\\Documents\\workspaces\\vs\\ByteBanckIO\\contas.txt");
    Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length} bytes");

    File.WriteAllText("C:\\Users\\Biel\\Documents\\workspaces\\vs\\ByteBanckIO\\escrevendoComClasseFile.txt", "Testando File.WriteAllText");

    Console.WriteLine("Aplicação Finalizada ...");

    Console.ReadLine();

  }
}


