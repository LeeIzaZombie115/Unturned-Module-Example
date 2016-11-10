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
    public class ExampleModule : MonoBehaviour, IModuleNexus //Interface required <-----
    {
        //Use this as the local player SteamID. (Person that is playing the game) 
        public CSteamID LocalClient;

        //Called when MODULE is loaded
        public void initialize()
        {
            LocalClient = Provider.client;

            //Capture event when player is create. Example: Joins server/singleplayer and map loads.
            Player.onPlayerCreated += (Player player) =>
                {
                    //Adding class this player's GameObject is the same as adding a script inside Unity
                    player.transform.gameObject.AddComponent<ExampleGUIClass>();
                };
        }

        //Called when MODULE is unloaded
        public void shutdown() { }
    }
}
