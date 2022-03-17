using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace LogicaDeNegocios
{/// <summary>
/// Class imprimir
/// </summary>
    public class Imprimir
    {
        /// <summary>
        /// Metodo para imprimir
        /// </summary>
        /// <param name="ruta"></param>
public void printPDFWithAcrobat(string ruta)
    {
        string Filepath = ruta;

        using (PrintDialog Dialog = new PrintDialog())
        {
            Dialog.ShowDialog();

            ProcessStartInfo printProcessInfo = new ProcessStartInfo()
            {
                Verb = "print",
                CreateNoWindow = true,
                FileName = Filepath,
                WindowStyle = ProcessWindowStyle.Hidden
            };

            Process printProcess = new Process();
            printProcess.StartInfo = printProcessInfo;
            printProcess.Start();
            printProcess.WaitForInputIdle();

            Thread.Sleep(3000);

            if (false == printProcess.CloseMainWindow())
            {
                printProcess.Kill();
            }
        }
    }
}
}
