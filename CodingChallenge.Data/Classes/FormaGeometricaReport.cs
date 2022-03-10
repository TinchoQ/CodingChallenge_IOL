using CodingChallenge.Data.Classes.Enums;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class FormaGeometricaReport
    {
        #region Report Labels

        private const string REPORT_HEADER = @"Report_Header";
        private const string REPORT_NOELEMENTS = @"Report_NoElements";
        private const string REPORT_ELEMENTS = @"Report_Elements";
        private const string REPORT_AREA = @"Report_Area";
        private const string REPORT_PERIMETER = @"Report_Perimeter";
        private const string REPORT_TOTAL = @"Report_Total";
        private const string REPORT_CIRCLE_SINGULAR = @"Shapes_Name_Circle_Singular";
        private const string REPORT_CIRCLE_PLURAL = @"Shapes_Name_Circle_Plural";
        private const string REPORT_RECTANGLE_SINGULAR = @"Shapes_Name_Rectangle_Singular";
        private const string REPORT_RECTANGLE_PLURAL = @"Shapes_Name_Rectangle_Plural";
        private const string REPORT_SQUARE_SINGULAR = @"Shapes_Name_Square_Singular";
        private const string REPORT_SQUARE_PLURAL = @"Shapes_Name_Square_Plural";
        private const string REPORT_TRAPEZE_SINGULAR = @"Shapes_Name_Trapeze_Singular";
        private const string REPORT_TRAPEZE_PLURAL = @"Shapes_Name_Trapeze_Plural";
        private const string REPORT_TRIANGLE_SINGULAR = @"Shapes_Name_Triangle_Singular";
        private const string REPORT_TRIANGLE_PLURAL = @"Shapes_Name_Triangle_Plural";

        #endregion

        public static string Imprimir(List<FormaGeometrica> formas, int idioma)
        {
            var sb = new StringBuilder();

            //Calculo el country ISO code segun el idioma que se registre así el ReportHelper trae el resource file de ese idioma
            string ISOCode = ReportHelper.CalcularLanguageISOCode(idioma);
            string resFile = ConfigurationManager.AppSettings["Resource_File"];
            Dictionary<string,string> mensajes = ReportHelper.CargarMensajesPorLenguaje(resFile, ISOCode);

            // Hay por lo menos una forma
            if (!formas.Any())
            {
                sb.Append($"<h1>{mensajes[REPORT_NOELEMENTS]}</h1>");
                return sb.ToString();
            }

            //HEADER
            int totalFormas = 0;
            decimal totalArea = 0;
            decimal totalPerimetro = 0;
            sb.Append($"<h1>{mensajes[REPORT_HEADER]}</h1>");

            List<IGrouping<int, FormaGeometrica>> distinctTypesOfShapes = formas.GroupBy(f => f.Tipo).ToList();

            foreach (var shape in distinctTypesOfShapes)
            {
                int numFormas = 0;
                decimal areaFormas = 0m;
                decimal perimetroFormas = 0m;

                List<FormaGeometrica> listFormas = formas.Where(f => f.Tipo == shape.Key).ToList();

                foreach (var forma in listFormas)
                {
                    numFormas++;
                    areaFormas += forma.CalcularArea();
                    perimetroFormas += forma.CalcularPerimetro();

                }

                sb.Append(ObtenerLinea(numFormas, areaFormas, perimetroFormas, shape.Key, mensajes));

                totalFormas += numFormas;
                totalArea += areaFormas;
                totalPerimetro += perimetroFormas;
            }            
            
            // FOOTER
            sb.Append($"{mensajes[REPORT_TOTAL]}:<br/>");
            sb.Append(totalFormas + " " + mensajes[REPORT_ELEMENTS] + " ");
            sb.Append(mensajes[REPORT_PERIMETER] + " " + (totalPerimetro).ToString("#.##") + " ");
            sb.Append(mensajes[REPORT_AREA] + " " + (totalArea).ToString("#.##"));

            return sb.ToString();
        }

        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, int tipo, Dictionary<string,string> mensajes)
        {
            if (cantidad <= 0) return string.Empty;
            
            return $"{cantidad} {TraducirForma(tipo, cantidad, mensajes)} | {mensajes[REPORT_AREA]} {area:#.##} | {mensajes[REPORT_PERIMETER]} {perimetro:#.##} <br/>";

        }
        private static string TraducirForma(int tipo, int cantidad, Dictionary<string, string> mensajes)
        {
            switch (tipo)
            {
                case (int)FormaGeometricaEnum.Cuadrado:
                    return cantidad == 1 ? mensajes[REPORT_SQUARE_SINGULAR] : mensajes[REPORT_SQUARE_PLURAL];
                case (int)FormaGeometricaEnum.Circulo:
                    return cantidad == 1 ? mensajes[REPORT_CIRCLE_SINGULAR] : mensajes[REPORT_CIRCLE_PLURAL];
                case (int)FormaGeometricaEnum.TrianguloEquilatero:
                    return cantidad == 1 ? mensajes[REPORT_TRIANGLE_SINGULAR] : mensajes[REPORT_TRIANGLE_PLURAL];
                case (int)FormaGeometricaEnum.Rectangulo:
                    return cantidad == 1 ? mensajes[REPORT_RECTANGLE_SINGULAR] : mensajes[REPORT_RECTANGLE_PLURAL];
                case (int)FormaGeometricaEnum.Trapecio:
                    return cantidad == 1 ? mensajes[REPORT_TRAPEZE_SINGULAR] : mensajes[REPORT_TRAPEZE_PLURAL];

            }

            return string.Empty;
        }


    }
    
}
