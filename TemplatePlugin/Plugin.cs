using CommandSystem;
using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EHandlers = Exiled.Events.Handlers;

namespace TemplatePlugin
{
    public class Plugin : Plugin<Config>
    {
        public override string Name { get; } = "Sample Plugin";
        public override string Prefix { get; } = "smp";
        public override string Author { get; } = "Your Name";

        private Handlers.Player player;
        private Handlers.Server server;

        private Data data;
        private Methods methods;

        public static Plugin Current { get; internal set; }
        public static Data Data { get => Current.data; }
        public static Methods Methods { get => Current.methods; }

        public override void OnEnabled()
        {
            base.OnEnabled();

            Current = this;
            data = new Data();
            methods = new Methods();

            player = new Handlers.Player();
            server = new Handlers.Server();

            RegisterEvents();
        }
        public override void OnDisabled()
        {
            base.OnDisabled();

            UnregisterEvents();

            player = null;
            server = null;

            methods = null;
            data = null;
            Current = null;
        }

        private void RegisterEvents()
        {
            EHandlers.Server.RoundStarted += server.OnStarting;
        }
        private void UnregisterEvents()
        {
            EHandlers.Server.RoundStarted -= server.OnStarting;
        }
    }
}
