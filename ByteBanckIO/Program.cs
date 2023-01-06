using System.Text;

var arquivo = "C:\\Users\\Biel\\Documents\\workspaces\\vs\\ByteBanckIO\\contas.txt";

var fluxoDoArquivo = new FileStream(arquivo, FileMode.Open);

var buffer = new byte[1024];

var quantidadeBytesLidos = -1;

while (quantidadeBytesLidos != 0)
{
  quantidadeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
  EscreverBuffer(buffer);
}


static void EscreverBuffer(byte[] buffer)
{
  var encoding = new UTF8Encoding();
  var texto = encoding.GetString(buffer);

  Console.Write(texto);

  //foreach (var meuByte in buffer)
  //{
  //  Console.Write(meuByte);
  //  Console.Write(" ");
  //}
}