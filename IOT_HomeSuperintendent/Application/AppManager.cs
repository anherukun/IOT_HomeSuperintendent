using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_HomeSuperintendent.Application
{
    public class AppManager
    {
        /// <summary>
        /// Genera un GUID aleatorio
        /// </summary>
        public static string GenerateGUID => Guid.NewGuid().ToString().ToUpper();
    }
}
