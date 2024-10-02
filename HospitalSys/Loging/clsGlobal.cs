using clsBusineesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSys.Loging
{
    public class clsGlobal
    {
        public static clsUsers User { get; set; }

        public static void SetCurrentUser(clsUsers user)
        {
            User = user;
        }

    }
}
