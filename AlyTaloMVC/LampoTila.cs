using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlyTaloMVC
{
    public class LampoTila
    {
        public int temperature { get; set; }
        public void SetTemperature(int newTemperature)
        {
            temperature = newTemperature;
        }
    }
}