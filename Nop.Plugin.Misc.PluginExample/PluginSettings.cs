using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;
//using Nop.Core.Plugins;
//using Nop.Services.Common;

namespace Nop.Plugin.Misc.PluginExample
{
    public class PluginSettings // : BasePlugin, IMiscPlugin
    {

        public void GetConfigurationRoute(out string actionName, out string controllerName, out RouteValueDictionary routeValues)
        {
            actionName = "Configure";
            controllerName = "Configuration";
            routeValues = new RouteValueDictionary { { "Namespaces", "$projectname$.Controllers" }, { "area", null } };
        }
    }
}
