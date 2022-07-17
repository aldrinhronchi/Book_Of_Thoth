
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Mail;
using System.Security.Policy;
using System.Threading;
using System.Web;
using System.Text;



namespace Book_Of_Thoth.Work
{
    public class CronosScheduler
    {
        private Thread Processa = null;
        private string Estado = "Aguardando";
        private string Trabalho = "";
       
        private string Errors = "";
        private string StackErrors = "";

        public static CronosScheduler Current { get; private set; } = null;

        private CronosScheduler()
        {
            Current = this;
            IniciarThread();
           
        }
        public static void Iniciar()
        {
            if (Current == null)
            {
                Current = new CronosScheduler();
            }
            else if (Current.Processa == null || !Current.Processa.IsAlive)
            {
                Current.IniciarThread();
            }
        }

        private void IniciarThread()
        {

            Thread Zipar = new Thread(Current.Processar);
            Current.Processa = Zipar;
            Zipar.Start();
        }

        private void Processar()
        {
            
            //int ContadorExecs = 0;
            Errors = "";
            while (true)
            {
                try
                {
                    //Thread.Sleep(9000);
                    Trabalho = "";
                    //Console.WriteLine("ārdayad vṛtram akṛṇod ulokaṃ");
                    Errors = "";


                    DayOfWeek dow = DateTime.Now.DayOfWeek;

                    switch (dow)
                    {
                       
                        //Segunda
                        case DayOfWeek.Monday:
                            if (DateTime.Now.ToString("HH:mm") == "12:00")
                            {
                               
                            }
                            break;
                        // Terça
                        case DayOfWeek.Tuesday:
                            break;
                        //Quarta
                        case DayOfWeek.Wednesday:
                            break;
                        // Quinta
                        case DayOfWeek.Thursday:
                            break;
                        //Sexta
                        case DayOfWeek.Friday:
                            break;
                        // Sabado
                        case DayOfWeek.Saturday:
                            break;
                        //Domingo
                        case DayOfWeek.Sunday:
                            break;
                       
                           
                      
                    }

                    Console.WriteLine("Done!");

                }
                catch (Exception e)
                {
                    Errors = e.Message + "\n";
                    StackErrors = e.StackTrace;
                }
                Estado = "Aguardando";

                Thread.Sleep(1800000);
            }
        }

        public string EstadoAtual()
        {
            return Estado;
        }

        public string TrabalhoAtual()
        {
            return Trabalho;
        }

        public string GerErrors()
        {
            return Errors.Replace("\n", "<br />");
        }





    }
}
