/*--------------------------------------------------------------------------------------------------------------*/
// PROGRAMMER: WINSTON L. GUBANTES
// REFERENCES: VISUAL C# PROGRAMMING BY: BARBARA DOYLE
//             VISUAL BASIC .NET HOW TO PROGRAM BY: DEITEL & TIM R. NIETO
// PURPOSE: SIMPLE SYMMETRIC ENCRYPTION
// LANGUAGE: C# .NET
/*--------------------------------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Text;

namespace SalesAndMonitoring
{
    class clsEncryption
    {
        public static string encryptThis(string str, byte bt)
        {
            string encrypt = "" ;
            
            //USING COALESCING OPERATOR CONDITION
            bt = (bt>0 && bt<=13)? bt:Convert.ToByte(13);

            char[] chr = str.ToString().ToCharArray();

            for (int i = 0; i < str.Length; i++)
            {
                //CONVERTING CHAR TO INT
                int x = Convert.ToInt32(chr[i]);
                //CONVERTING INT TO CHAR
                encrypt = encrypt + Convert.ToChar((255 - (x + bt - i)));
            }
            return encrypt;
        }

        public static string decryptThis(string str, byte bt)
        {
            string encrypt="";

            //USING COALESCING OPERATOR CONDITION
            bt = (bt > 0 && bt <= 13) ? bt : Convert.ToByte(13);

            char[] chr = str.ToString().ToCharArray();

            for (int i = 0; i < str.Length; i++)
            {
                int x = Convert.ToInt32(chr[i]);
                encrypt = encrypt + Convert.ToChar(255 + (- x - bt + i));
            }
            return encrypt;
        }
    }
}
