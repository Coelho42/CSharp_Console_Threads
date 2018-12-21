using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap11_MultiTask_01_Threads_Console
{
    /// <summary>
    /// Esta classe possuí 2 métodos
    /// - DoLongRunningStuffSync(): Simula um longo processamento em modo Síncrono
    /// - DoLongRunningStuffAsync(): Simula um longo processamento em modo Assíncrono
    /// O retorno de um método assíncrono
    /// </summary>
    class ClasseComMetodos
    {
        /// <summary>
        /// Simula um longo processamento em modo Síncrono
        /// </summary>
        public void DoLongRunningStuffSync()
        {
            int counter;
            for (counter = 0; counter < 50000; counter++)
            {
                Console.WriteLine(counter);
            }
            // return "Counter = " + counter;
        }

        /// <summary>
        /// Simula um longo processamento em modo Assíncrono
        /// </summary>
        /// <returns></returns>
        public async Task DoLongRunningStuffAsync()
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
