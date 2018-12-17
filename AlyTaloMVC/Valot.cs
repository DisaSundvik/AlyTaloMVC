using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlyTaloMVC
{
    public class Valot
    {
        public bool Switched { get; set; }
        public string Dimmer { get; set; }

        public void LightsOff()
        {
            Switched = false;
        }

        public void LightsOn()
        {
            Switched = true;
        }

    }
}