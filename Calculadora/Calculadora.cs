using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Calculadora
    {
        public void Chamada()
        {
            var valoresInformados = new Entidades.operacoes();

            valoresInformados = Perguntas();

            valoresInformados = Calculos(valoresInformados);

            Resultados(valoresInformados);

        }

        public Entidades.operacoes Perguntas()
        {
            var valoresInformados = new Entidades.operacoes();

            Console.WriteLine("Informe o primeiro número:");
            valoresInformados.numero1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número:");
            valoresInformados.numero2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe a operação desejada:");
            Console.WriteLine("(1) - Soma");
            Console.WriteLine("(2) - Subtração");
            Console.WriteLine("(3) - Multiplicacao");
            Console.WriteLine("(4) - Divisão");
            valoresInformados.operacao = decimal.Parse(Console.ReadLine());

            return valoresInformados;

        }

        public Entidades.operacoes Calculos(Entidades.operacoes valoresInformados)
        {
            switch(valoresInformados.operacao)
            {
                case 1:

                    valoresInformados.resultado = valoresInformados.numero1 + valoresInformados.numero2;
                    break;

                case 2:

                    valoresInformados.resultado = valoresInformados.numero1 - valoresInformados.numero2;
                    break;

                case 3:

                    valoresInformados.resultado = valoresInformados.numero1 * valoresInformados.numero2;
                    break;

                case 4:

                    valoresInformados.resultado = valoresInformados.numero1 / valoresInformados.numero2;
                    break;
            }

            return valoresInformados;

        }

        public void Resultados(Entidades.operacoes valoresInformados)
        {
            Console.WriteLine("O resultado da sua operação é:" + valoresInformados.resultado);
        }


    }
}
