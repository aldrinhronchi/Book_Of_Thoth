using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Of_Thoth.The_Great_Library_of_Alexandria
{
    internal class Generate
    {
        public static String NameToken()
        {
            string date = DateTime.Now.ToString("dd-MM-yyyy");
            string hour = DateTime.Now.ToString("hh_mm_ss");
            string code = Guid.NewGuid().ToString();
            code = code.Substring(0, 9);
            string token = date + "-" + code + hour;
            return token;
        }
        public static String Separator(string symbol)
        {
            string separator = symbol;
            do
            {
                separator += separator;
            } while (separator.Length < 63);
            separator += separator[..40];
            return separator;
        }
        public static void CNPJMestre(string Word)
        {
            char[] arrChar = Word.ToCharArray();
            Array.Reverse(arrChar);
            string invertida = new String(arrChar);
            Word = invertida.Substring(6);
            arrChar = Word.ToCharArray();
            Array.Reverse(arrChar);
            string CNPJ = new String(arrChar);
            Console.WriteLine(CNPJ);
        }
        public static String CnpjSemMascara()
        {
            String result = "";
            Int64 soma1, soma2, i, parte1, parte2, parte3, dig1, parte5, parte6, parte7, dig2;
            Int64[] numero = new Int64[13];
            Random rand = new Random();
            for (i = 1; i <= 8; i++)
            {
                numero[i] = (rand.Next()) % 9;
            }
            numero[9] = 0;
            numero[10] = 0;
            numero[11] = 0;
            numero[12] = (rand.Next()) % 9;
            //*==========================================*
            //|       Primeiro digito verificador        |
            //*==========================================*
            soma1 = ((numero[1] * 5) +
                  (numero[2] * 4) +
                  (numero[3] * 3) +
                  (numero[4] * 2) +
                  (numero[5] * 9) +
                  (numero[6] * 8) +
                  (numero[7] * 7) +
                  (numero[8] * 6) +
                  (numero[9] * 5) +
                  (numero[10] * 4) +
                  (numero[11] * 3) +
                  (numero[12] * 2));
            parte1 = (soma1 / 11);
            parte2 = (parte1 * 11);
            parte3 = (soma1 - parte2);
            dig1 = (11 - parte3);
            if (dig1 > 9) dig1 = 0;
            //*==========================================*
            //|        Segundo digito verificador        |
            //*==========================================*
            soma2 = ((numero[1] * 6) +
                  (numero[2] * 5) +
                  (numero[3] * 4) +
                  (numero[4] * 3) +
                  (numero[5] * 2) +
                  (numero[6] * 9) +
                  (numero[7] * 8) +
                  (numero[8] * 7) +
                  (numero[9] * 6) +
                  (numero[10] * 5) +
                  (numero[11] * 4) +
                  (numero[12] * 3) +
                  (dig1 * 2));
            parte5 = (soma2 / 11);
            parte6 = (parte5 * 11);
            parte7 = (soma2 - parte6);
            dig2 = (11 - parte7);
            if (dig2 > 9) dig2 = 0;
            //*==========================================*
            //|       Impressao do numero completo       | 
            //*==========================================*
            //ostrm.SetLength(0);
            for (i = 1; i <= 12; i++)
            {
                //numeros do CNPJ
                result += Convert.ToString(numero[i]);
            }
            // dois últimos digitos
            result += dig1 + "" + dig2;
            return result;
        }
        public static String CnpjComMascara()
        {
            string CNPJ = CnpjSemMascara();
            string result = Convert.ToUInt64(CNPJ).ToString(@"00\.000\.000\/0000\-00");
            return result;
        }
        public static String CpfSemMascara()
        {
            String result = "";
            Int64 soma1, soma2, i, erro, parte1, parte2, parte3, dig1, parte5, parte6, parte7, dig2;
            Int64[] numero = new Int64[13];
            Random rand = new Random();
            for (i = 1; i <= 9; i++)
            {
                erro = 1;
                do
                {
                    if (erro > 1)
                    {
                        //MessageBox.Show("Numero invalido.\n");
                        erro = 1;
                    }
                    numero[i] = (rand.Next()) % 9;
                    erro++;
                } while (numero[i] > 9 || numero[i] < 0);
            }
            //*==========================================*
            //|       Primeiro digito verificador        |
            //*==========================================*
            soma1 = ((numero[1] * 10) +
                  (numero[2] * 9) +
                  (numero[3] * 8) +
                  (numero[4] * 7) +
                  (numero[5] * 6) +
                  (numero[6] * 5) +
                  (numero[7] * 4) +
                  (numero[8] * 3) +
                  (numero[9] * 2));
            parte1 = (soma1 / 11);
            parte2 = (parte1 * 11);
            parte3 = (soma1 - parte2);
            dig1 = (11 - parte3);
            if (dig1 > 9) dig1 = 0;
            //*==========================================*
            //|        Segundo digito verificador        |
            //*==========================================*
            soma2 = ((numero[1] * 11) +
                  (numero[2] * 10) +
                  (numero[3] * 9) +
                  (numero[4] * 8) +
                  (numero[5] * 7) +
                  (numero[6] * 6) +
                  (numero[7] * 5) +
                  (numero[8] * 4) +
                  (numero[9] * 3) +
                  (dig1 * 2));
            parte5 = (soma2 / 11);
            parte6 = (parte5 * 11);
            parte7 = (soma2 - parte6);
            dig2 = (11 - parte7);
            if (dig2 > 9) dig2 = 0;
            //*==========================================*
            //|       Impressao do numero completo       | 
            //*==========================================*
            for (i = 1; i <= 9; i++)
            {
                //numeros do CPF
                result += Convert.ToString(numero[i]);
            }
            // dois últimos digitos
            result += dig1 + "" + dig2;
            return result;
        }
        public static String CpfComMascara()
        {
            string CPF = CpfSemMascara();
            string result = Convert.ToUInt64(CPF).ToString(@"000\.000\.000\-00");
            return result;
            
        }
    }
}
