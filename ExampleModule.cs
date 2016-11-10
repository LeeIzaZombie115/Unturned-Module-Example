using SDG.Framework.Modules;
using SDG.Unturned;
using Steamworks;
using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading;
using UnityEngine;

namespace ExampleModule
{
    public class ExampleModule : MonoBehaviour, IModuleNexus
    {
        public void initialize()
        {
            Player.onPlayerCreated += (Player player) =>
                {
                    player.transform.gameObject.AddComponent<ExampleGUIClass>();
                };
        }

        public void shutdown()
        {

        }
    }
}
