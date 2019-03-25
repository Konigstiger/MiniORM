using System;
using System.Configuration;


namespace YpsilonBiometric.Parametros
{
    /// <summary>
    /// Contiene parámetros y valores predeterminados de uso general.
    /// Encapsula valores definidos en archivos config
    /// </summary>
    public static class General
    {
        /// <summary>
        /// Formato utilizado para mostrar fecha horas (para usuarios)
        /// </summary>
        /// <returns></returns>
        public static string CadenaConexion()
        {
        /*
        ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
        if (settings != null) {
            foreach (ConnectionStringSettings csi in settings) {
                Console.WriteLine(csi.Name);
                Console.WriteLine(csi.ProviderName);
                Console.WriteLine(csi.ConnectionString);
            }
        }
        */
            //TODO: Agregar aca logueo si hay errores con la cadena de conexion

            //nota, esto puede dar excepciones. Manejarlas, y dar un valor predeterminado en duro de ultima.
            string cs = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
            //string cs = "Data Source=10.26.12.133,1433;Network Library=DBMSSOCN;Initial Catalog=Biometric;User ID=usr;Password=bio;";
            return cs;

        }

        public static string ComponerUriFromPath(string resourceName)
        {
            //TODO: Revisar si no se debe extraer este parametro.
            string espacioNombres = "NombreNamespace";
            return "pack://application:,,,/" + espacioNombres + ";component/Resources/" + resourceName;
            //TODO: Agregar alguna forma de validar si el recurso no existe, para las excepciones.
        }


        /// <summary>
        /// Formato utilizado para mostrar fecha horas
        /// </summary>
        /// <returns></returns>
        public static string FormatoTimeStamp()
        {
            //nota, esto puede dar excepciones. Manejarlas, y dar un valor predeterminado en duro de ultima.
            var v = ConfigurationManager.AppSettings["FormatoTimeStamp"];
            return v;
        }

        /// <summary>
        /// Formato utilizado para mostrar fecha horas
        /// </summary>
        /// <returns></returns>
        public static string FormatoColumnasFechaHora()
        {
            //nota, esto puede dar excepciones. Manejarlas, y dar un valor predeterminado en duro de ultima.
            var v = ConfigurationManager.AppSettings["FormatoColumnasFechaHora"];
            return v;
        }


    }
}
