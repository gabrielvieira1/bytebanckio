﻿using ByteBanckIO;
using System.Globalization;
using System.Text;

partial class Program
{
  static void UsandoStreamReader()
  {
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

        var contaCorrente = ConverterStringParaContaCorrente(linha);

        var msg = $"Conta número {contaCorrente.Numero}, ag {contaCorrente.Agencia}, Saldo {contaCorrente.Saldo}";

        Console.WriteLine(msg);
      }
    }
    Console.ReadLine();
  }
  static ContaCorrente ConverterStringParaContaCorrente(string linha)
  {
    // 375 4644 2483.13 Jonatan
    var campos = linha.Split(',');

    var agencia = campos[0];
    var numero = campos[1];
    var saldo = campos[2];
    var nomeTitular = campos[3];

    var agenciaComInt = int.Parse(agencia);
    var numeroComInt = int.Parse(numero);
    var saldoComDouble = double.Parse(saldo, CultureInfo.InvariantCulture);

    var titular = new Cliente();
    titular.Nome = nomeTitular;

    var resultado = new ContaCorrente(agenciaComInt, numeroComInt);
    resultado.Depositar(saldoComDouble);
    resultado.Titular = titular;

    return resultado;
  }
}

