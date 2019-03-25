using System.Configuration;


namespace YpsilonBiometric.Parametros
{
    /// <summary>
    /// Contiene parámetros y valores predeterminados de uso general.
    /// Encapsula valores definidos en archivos config
    /// </summary>
    public static class Defaults
    {
        /// <summary>
        /// Horario de ingreso predeterminado de empleados
        /// </summary>
        /// <returns></returns>
            public static string HorarioIngreso()
        {
            //nota, esto puede dar excepciones. Manejarlas, y dar un valor predeterminado en duro de ultima.
            var v = ConfigurationManager.AppSettings["HorarioIngreso"];
            return v;
        }

        /// <summary>
        /// Horario de salida predeterminado de empleados
        /// </summary>
        /// <returns></returns>
        public static string HorarioEgreso()
        {
            //nota, esto puede dar excepciones. Manejarlas, y dar un valor predeterminado en duro de ultima.
            var v = ConfigurationManager.AppSettings["HorarioEgreso"];
            return v;
        }

        /// <summary>
        /// Nota a definir al cerrar el registro de asistencia
        /// </summary>
        /// <returns></returns>
        public static string RegistroCerradoNota()
        {
            //nota, esto puede dar excepciones. Manejarlas, y dar un valor predeterminado en duro de ultima.
            var v = ConfigurationManager.AppSettings["RegistroCerradoNota"];
            return v;
        }


        public static int CantidadFilasPorPagina()
        {
            //nota, esto puede dar excepciones. Manejarlas, y dar un valor predeterminado en duro de ultima.
            var v = ConfigurationManager.AppSettings["CantidadFilasPorPagina"];
            return int.Parse(v);
        }

    }
}
