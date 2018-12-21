using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap11_MultiTask_01_Threads_Console
{
    /// <summary>
    /// Projeto de demonstração simples de multitarefa
    /// A Main do programa corre 2 ciclos.
    /// - Um a partir de um método sincrono ou assincrono 
    /// - Outro no final da main
    /// Em circunstâncias normais, executa 1º um ciclo e só depois o 2º.
    /// O método sincrono faz exatamente isso. É sequencial.
    /// Mas o método assíncrono coloca o 1º ciclo numa thread, o que resulta na execução simultânea com o 2º ciclo.
    /// Para efeitos de teste, os métodos síncrono e assíncrono estão duplicados:
    /// - Na própria Classe Program como static e private
    /// - Na ClasseComMetodos todos como public.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Executar apenas um dos métodos Locais ou da Classe:
            // DoLongRunningStuffSync();   // Método síncrono
            // DoLongRunningStuffAsync();   // Método Assíncrono

            ClasseComMetodos demo = new ClasseComMetodos();
            // demo.DoLongRunningStuffSync();    // Método síncrono
            demo.DoLongRunningStuffAsync();      // Método Assíncrono

            // Ciclo infinito. Quando é que é executado?
            while(true)
            {
                Console.WriteLine("A fazer coisas na Thread Principal ...............................");
            }
        }

        /// <summary>
        /// Simula um longo processamento em modo Síncrono
        /// </summary>
        static void DoLongRunningStuffSync()
        {
            int counter;
            for (counter = 0; counter < 50000; counter++)
            {
                Console.WriteLine(counter);
            }
        }

        /// <summary>
        /// Simula um longo processamento em modo Assíncrono
        /// </summary>
        /// <returns></returns>
        static async Task DoLongRunningStuffAsync()
        {
            await Task.Run(() =>
            {
                int counter;
                for (counter = 0; counter < 50000; counter++)
                {
                    Console.WriteLine(counter);
                }
            });
        }
    }
}
