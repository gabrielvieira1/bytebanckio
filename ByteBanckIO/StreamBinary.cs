using ByteBanckIO;
using System.Globalization;
using System.Text;

partial class Program
{
  static void StreamBinary()
  {
    EscritaBinaria();
    LeituraBinaria();
    Console.ReadLine();
  }
  static void EscritaBinaria()
  {
    /*
     O BinaryWriter grava tipos primitivos em binário em um fluxo e com isso irá usar 
     o formato binário de números inteiros e nesse caso, seu arquivo possuirá 4 bytes de tamanho.
    */
    using (var fs = new FileStream("C:\\Users\\Biel\\Documents\\workspaces\\vs\\ByteBanckIO\\contaCorrente.txt", FileMode.Create))
    using (var escritor = new BinaryWriter(fs))
    {
      escritor.Write(456);           //número da Agência
      escritor.Write(546544);   //número da conta
      escritor.Write(4000.50); //Saldo
      escritor.Write("Gabriel Vieira");
    }
  }
  static void LeituraBinaria()
  {
    using (var fs = new FileStream("C:\\Users\\Biel\\Documents\\workspaces\\vs\\ByteBanckIO\\contaCorrente.txt", FileMode.Open))
    using (var leitor = new BinaryReader(fs))
    {
      var agencia = leitor.ReadInt32();
      var numeroConta = leitor.ReadInt32();
      var saldo = leitor.ReadDouble();
      var titular = leitor.ReadString();

      Console.WriteLine($"{agencia}/{numeroConta} {titular} {saldo}");
    }
  }
}

