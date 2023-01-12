/* Escrever um programa que recebe os produtos a serem comprados
 * Escolher a forma de pagamento
 * De acordo com a forma de pagamento escolhida, efetuar compra*/

using DesafioInterface;

List<string> listaProdutos = new List<string>();

Console.WriteLine("Digite três produtos a serem comprados:");

for(int i = 0; i < 3; i++)
{
    listaProdutos.Add(Console.ReadLine());
}

Console.WriteLine("Qual forma de pagamento você deseja? (Boleto, Cartão, Pix, Dinheiro)");

string formaDePagamento = Console.ReadLine();

switch (formaDePagamento)
{
    case "Boleto":
        Boleto boleto = new Boleto();
        boleto.EfetuarPagamento();
        break;
    case "Cartão":
        Cartao cartao = new Cartao();
        cartao.EfetuarPagamento();
        break;
    case "Pix":
        Pix pix = new Pix();
        pix.EfetuarPagamento();
        break;
    case "Dinheiro":
        Dinheiro dinheiro = new Dinheiro();
        break;
    default:
        Console.WriteLine("Método de pagamento não encontrado");
        break;
}