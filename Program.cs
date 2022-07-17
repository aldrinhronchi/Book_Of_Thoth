﻿using Book_Of_Thoth.Work;
using Book_Of_Thoth.The_Great_Library_of_Alexandria;
using System;


namespace Book_Of_Thoth
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //Console.WriteLine("O falso amor de si mesmo transforma a solidão em prisão. \n\t\t\t\t\t\tFriedrich Nietzsche");
            //'=================================================================================================================================================='
            //                                                          Variaveis
            //'=================================================================================================================================================='
            string localpath = @"D:\work\xmlcompress\Book_Of_Thoth\Upload\";
            string separator = Generate.Separator("=");

            //'=================================================================================================================================================='
            //                                                         Metodos
            //'=================================================================================================================================================='
            //'--------------------------------------------------------------------------------------------------------------------------------------------------'
            //                                                          Cabeçalho
            //-'-------------------------------------------------------------------------------------------------------------------------------------------------'
            Edge(separator, "Green", "I am Running!");
            //'--------------------------------------------------------------------------------------------------------------------------------------------------'

            /* '-------------------------------------------------------------------------------------------------------------------------------------------------'
                                                                        NameToken
            
            string Token = Generate.NameToken();
            Console.WriteLine(Token);
            
               '-------------------------------------------------------------------------------------------------------------------------------------------------'
             */

            /* '-------------------------------------------------------------------------------------------------------------------------------------------------'
                                                                      Read Folder
 
            Read.FolderItems(localpath);
          
              '--------------------------------------------------------------------------------------------------------------------------------------------------'
            */
            /* '-------------------------------------------------------------------------------------------------------------------------------------------------'
                                                                     Kata Challenges
            */
            // StripComments();

            /*
              '--------------------------------------------------------------------------------------------------------------------------------------------------'
            */
            /* '-------------------------------------------------------------------------------------------------------------------------------------------------'
                                                                       Excel
            */
            Read.Xlsx(@"D:\work\afort\GestaoOperacoes\Upload\NotaFiscal\", "teste.xls");

            /*
              '--------------------------------------------------------------------------------------------------------------------------------------------------'
            */
            /*
             '--------------------------------------------------------------------------------------------------------------------------------------------------'
           */
            /* '-------------------------------------------------------------------------------------------------------------------------------------------------'
                                                                       Title
            */
            
            /*
              '--------------------------------------------------------------------------------------------------------------------------------------------------'
            */
            /*
             '--------------------------------------------------------------------------------------------------------------------------------------------------'
           */
            /* '-------------------------------------------------------------------------------------------------------------------------------------------------'
                                                                       Title
            */
            

            /*
              '--------------------------------------------------------------------------------------------------------------------------------------------------'
            */
            /*
             '--------------------------------------------------------------------------------------------------------------------------------------------------'
           */
            /* '-------------------------------------------------------------------------------------------------------------------------------------------------'
                                                                       Title
            */
           

            /*
              '--------------------------------------------------------------------------------------------------------------------------------------------------'
            */

            /* 
               '-------------------------------------------------------------------------------------------------------------------------------------------------'
                                                                     Compress
              
            string xmlpath = @"D:\work\XML ATTUAL 27052022";
            string extension = "*.xml";
            ZipCompress.Compress(localpath, xmlpath, extension);


               '-------------------------------------------------------------------------------------------------------------------------------------------------'
            */

            //'--------------------------------------------------------------------------------------------------------------------------------------------------'
            //                                                      Rodape
            //'--------------------------------------------------------------------------------------------------------------------------------------------------'

            Edge(separator,"Blue", "And done!");
            //'-------------------------------------------------------------------------------------------------------------------------------------------------'
        }
        static void Edge(string separator, string color, string msg)
        {
            if (Enum.TryParse(color, out ConsoleColor foreground))
            {
                Console.ForegroundColor = foreground;
            }
            Console.WriteLine(separator);
            Console.SetCursorPosition((Console.WindowWidth - msg.Length-10) / 2, Console.CursorTop);
            Console.WriteLine(msg);
            Console.WriteLine(separator);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void StripComments()
        {
            
            Console.WriteLine();
            if ((
                    "apples, pears\ngrapes\nbananas" ==
                    Kata.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new string[] { "#", "!" })))
            { Console.WriteLine("Pass"); }

            if (("a\nc\nd" == Kata.StripComments("a #b\nc\nd $e f g", new string[] { "#", "$" })))
                { Console.WriteLine("Pass"); }

        }
    }
}