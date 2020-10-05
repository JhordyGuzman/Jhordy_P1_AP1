using System;
using System.Collections.Generic;

namespace Jhordy_P1_AP1.BLL
{
    public class Utilidades
    {
        public static int ToInt(string valor){
            int retorno = 0;

            int.TryParse(valor,out retorno);

            return retorno;
        }

        internal static int ToInt(object text)
        {
            throw new NotImplementedException();
        }
    }
}