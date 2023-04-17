using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionElectronica
{
    public class clsPrintPDF
    {
        public static string PrintPDFs(string pdfFileName, string pRutaAdobe, string pEjecutable)
        {
            try
            {
                Process proc = new Process();
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc.StartInfo.Verb = "print";

                proc.StartInfo.FileName = pRutaAdobe;
                proc.StartInfo.Arguments = String.Format(@"/p /h {0}", pdfFileName);
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.CreateNoWindow = true;

                proc.Start();
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                if (proc.HasExited == false)
                {
                    proc.WaitForExit(5000); //10000
                }

                proc.EnableRaisingEvents = true;

                proc.Close();
                KillAdobe(pEjecutable.ToString());

                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string PrintPDFsFoxit(string sFileName, string pRutaAdobe, string sPrinter)
        {
            try
            {
                string sArgs = " /t \"" + sFileName + "\" \"" + sPrinter + "\"";
                System.Diagnostics.ProcessStartInfo startInfo = new ProcessStartInfo();
                //startInfo.FileName = @"C:\Program Files (x86)\Foxit Software\Foxit Reader\Foxit Reader.exe";
                startInfo.FileName = pRutaAdobe;
                startInfo.Arguments = sArgs;
                startInfo.CreateNoWindow = true;
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                System.Diagnostics.Process proc = Process.Start(startInfo);
                proc.WaitForExit(10000); // Wait a maximum of 10 sec for the process to finish
                if (!proc.HasExited)
                {
                    proc.Kill();
                    proc.Dispose();
                    return "OK";
                }
            }
            catch (Exception ex)
            {
                return "";
            }
            return "OK";
        }

        public static string PrintPDFsImpreSeleccionada(string pdfFileName, string pRutaAdobe, string pEjecutable, string pImpresora)
        {
            try
            {
                Process proc = new Process();
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc.StartInfo.Verb = "print";

                //Define location of adobe reader/command line
                //switches to launch adobe in "print" mode
                ////proc.StartInfo.FileName =
                ////  @"C:\Program Files (x86)\Adobe\Reader 11.0\Reader\AcroRd32.exe";
                proc.StartInfo.FileName = pRutaAdobe;
                
                ////proc.StartInfo.Arguments = String.Format(@"/p /h {0}", pdfFileName); // ESTE ANDA BIEN

                if (!String.IsNullOrEmpty(pImpresora.ToString())) // Si le pasa una impresora predeterminada
                    proc.StartInfo.Arguments = String.Format("/h /t \"{0}\" \"{1}\"", pdfFileName, pImpresora);

                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.CreateNoWindow = true;

                proc.Start();
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                if (proc.HasExited == false)
                {
                    proc.WaitForExit(5000); //10000
                }

                proc.EnableRaisingEvents = true;

                proc.Close();
                KillAdobe(pEjecutable.ToString());

                ////ProcessHelper ph = new ProcessHelper();
                ////string domainUser = ph.GetProcessOwner(proc.Id); // Le paso el id del proceso
                ////ph.KillProcessByNameAndUser(pEjecutable.ToString(), domainUser.ToString(), 0);

                ////proc.Close();

                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //For whatever reason, sometimes adobe likes to be a stage 5 clinger.
        //So here we kill it with fire.
        private static bool KillAdobe(string name)
        {
            foreach (Process clsProcess in Process.GetProcesses().Where(
                         clsProcess => clsProcess.ProcessName.StartsWith(name)))
            {
                clsProcess.Kill();
                return true;
            }
            return false;
        }

        public static void kill()
        {
            foreach (Process proc in Process.GetProcesses())
            {
                if (proc.ProcessName.StartsWith("Acro"))
                {
                    string proname = proc.ProcessName.ToString();
                    if (proc.HasExited == false)
                    {
                        proc.WaitForExit(10000);
                        string title = proc.MainWindowTitle.ToString();
                        if (title == "Adobe Reader" && proname == "AcroRd32")
                        {
                            proc.Kill();
                            break;
                        }
                        else
                        {
                            string title2 = proc.MainWindowTitle.ToString();
                            if (title2 == "Adobe Reader" && proname == "AcroRd32")
                            {
                                proc.Kill();
                                break;
                            }
                        }

                    }
                    else
                    {
                        try
                        {
                            proc.Kill();
                            break;
                        }
                        catch
                        {
                            break;
                        }
                    }
                }
            }
        }
    }

}//END Namespace