using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterface
{
    public class FormaPagamento
    {
        public virtual void EfetuarPagamento() 
        {
            Console.WriteLine("Pagamento efetuado");
        }
    }

    public class Boleto : FormaPagamento
    {
        public override void EfetuarPagamento()
        {
            Console.WriteLine("Pagamento feito com boleto");
        }
    }

    public class Pix : FormaPagamento
    {
        public override void EfetuarPagamento()
        {
            Console.WriteLine("Pagamento feito com Pix");
        }
    }

    public class Cartao : FormaPagamento
    {
        public override void EfetuarPagamento()
        {
            Console.WriteLine("Pagamento feito com cartão");
        }
    }

    public class Dinheiro : FormaPagamento
    {
        public Dinheiro()
        {
            EfetuarPagamento();
        }
        public override void EfetuarPagamento()
        {
            Console.WriteLine("Pagamento feito com dinheiro");
        }
    }
}
