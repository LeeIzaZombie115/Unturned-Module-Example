using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ExampleModule
{
    public class ExampleGUIClass : PlayerCaller
    {
        public static ExampleGUIClass gui = null;
        public int Counter = 0;

        private void Start()
        {
            gui = this;
            DontDestroyOnLoad(gui);
        }

        void Update()
        {
            if (Input.GetKeyUp(KeyCode.F7))
            {
                Counter++;
            }
        }

        void OnGUI()
        {
            GUI.Window(0, new Rect(10, 10, 1000, 100), CreateWindow, "My Window...");
        }

        void CreateWindow(int id)
        {
            GUILayout.Label("Times F7 was pressed: " + Counter);
        }
    }
}
