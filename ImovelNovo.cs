using System;

namespace exercicio2
{
    public class ImovelNovo:Imovel
    {
        public double calculaAdicional () 
        {
            return base.preco * 0.05;
            
        }
    }
}
