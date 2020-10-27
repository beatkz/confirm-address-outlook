using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confirm_Address_for_Outlook_2013
{
    class RegUtil
    {
        private const string regPath = @"HKEY_CURRENT_USER\Software\Meatian\Confirm-Address for Outlook";

        public string LoadRegString(string regName)
        {
            string loadedRegVal = (string)Microsoft.Win32.Registry.GetValue(
                regPath, regName, "");
            if (loadedRegVal == null)
            {
                Microsoft.Win32.Registry.SetValue(regPath, regName, "");
                loadedRegVal = (string)Microsoft.Win32.Registry.GetValue(regPath, regName, "");
            }

            return loadedRegVal;
        }

        public int LoadRegInt(string regName)
        {
            int loadedRegVal = (int)Microsoft.Win32.Registry.GetValue(
                regPath, regName, -1);
            if (loadedRegVal == -1)
            {
                Microsoft.Win32.Registry.SetValue(regPath, regName, 0);
                loadedRegVal = (int)Microsoft.Win32.Registry.GetValue(regPath, regName, -1);
            }

            return loadedRegVal;
        }
    }
}
