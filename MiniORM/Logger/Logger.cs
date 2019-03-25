using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YpsilonBiometric
{
    /// <summary>
    /// Logger general. Implementado con nLog. Brinda métodos static para registrar.
    /// </summary>
    public static class Logger
    {
        //TODO: El metodo inferior, al estarse en una clase externa, mostrará esta clase, la del logger, 
        //no donde se produjo la necesidad de loguear.
        //Tendria que buscar acerca de esto, o pasar la ubicación como un string, que es un fastidio.
        //TODO: Verificar que archivo de configuracion de logger NLog.config se está usando en cada caso. 
        //Se usa el de este proyecto.
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public static void LogThisDebug(string msg)
        {
            logger.Error(msg);
        }

        public static void LogThisDebug(Exception ex)
        {
            logger.Error(ComponerLogError(ex));
        }


        public static void LogThisInfo(string msg)
        {
            logger.Info(msg);
        }
        public static void LogThisInfo(Exception ex)
        {
            logger.Info(ComponerLogError(ex));
        }


        public static void LogThisError(string msg)
        {
            logger.Error(msg);
        }

        public static void LogThisError(Exception ex)
        {
            logger.Error(ComponerLogError(ex));
        }

        public static string ComponerLogError(Exception ex)
        {
            var sb = new StringBuilder();
            sb.Append(ex.Message);
            sb.Append(" - ");
            sb.Append(ex.StackTrace);
            return sb.ToString();
        }

        public static string GetCurrentTimestamp()
        {
            return "[" + DateTime.Now.ToString(Parametros.General.FormatoTimeStamp()) + "]";
        }

    }
}
