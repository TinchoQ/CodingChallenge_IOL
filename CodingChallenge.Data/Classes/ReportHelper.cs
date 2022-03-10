using CodingChallenge.Data.Classes.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;

namespace CodingChallenge.Data.Classes
{
    public static class ReportHelper
    {
        
        public static Dictionary<string, string> CargarMensajesPorLenguaje(string archivo, string infoCode)
        {
            Dictionary<string, string> messages = new Dictionary<string, string>();
            try
            {
                ResourceManager rm = new ResourceManager(archivo, Assembly.GetExecutingAssembly());
                var resourceSet = rm.GetResourceSet(new CultureInfo(infoCode), true, true);
                var resourceDictionary = resourceSet.Cast<DictionaryEntry>().ToDictionary(r => r.Key.ToString(), r => r.Value.ToString());
                messages = resourceDictionary;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return messages;
        }

        public static string CalcularLanguageISOCode(int idioma)
        {
            switch (idioma)
            {
                case (int)IdiomaEnum.Español:
                    return @"es";
                case (int)IdiomaEnum.Inglés:
                    return @"en";
                case (int)IdiomaEnum.Portugués:
                    return @"br";
                default:
                    return "en";
            }
        }
    }
}
