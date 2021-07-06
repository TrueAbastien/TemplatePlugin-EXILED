using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EAPI = Exiled.API.Features;

namespace TemplatePlugin.Handlers
{
    class Server
    {
        internal void OnStarting()
        {
            EAPI.Map.TurnOffAllLights(5f);
        }
    }
}
