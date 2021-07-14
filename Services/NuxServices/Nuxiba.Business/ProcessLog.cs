using Nuxiba.Services.Entity;
using Nuxiba.Services.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nuxiba.Services.Business
{
    public static class ProcessLog
    {
        public static async Task<bool> LogInformation(LogInformation log, LogType logType, string storageConn)
        {
            try
            {
               //Enviar log a algun lugar
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public static async Task<bool> LogError(LogError log, LogType logType, string storageConn)
        {
            try
            {
               //enviar error a algun lugar
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
