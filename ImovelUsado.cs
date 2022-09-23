using System;

namespace exercicio2
{
    public class ImovelUsado: Imovel
    {
        public double calculaDesconto () 
        {
            return base.preco * 0.05;
            
        }
    }
   
}
