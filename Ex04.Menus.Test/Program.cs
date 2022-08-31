using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            DelegateMainMenu delegateMainMenu = new DelegateMainMenu();
            InterfaceMainMenu interfaceMainMenu = new InterfaceMainMenu();

            delegateMainMenu.Start();
            interfaceMainMenu.Start();
        }
    }
}