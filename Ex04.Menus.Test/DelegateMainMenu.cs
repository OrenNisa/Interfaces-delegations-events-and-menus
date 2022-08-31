using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    internal class DelegateMainMenu
    {
        private MainMenu m_MainMenu;

        public DelegateMainMenu()
        {
            m_MainMenu = new MainMenu("Delegates Main Menu");
            exampleInitialize();
        }

        private void exampleInitialize()
        {
            SubMenu versionAndSpacesSubMenu = new SubMenu("Version and Spaces");
            Function countSpacesMenuItem = new Function("Count Spaces", new ExampleFunctions.VersionAndSpaces().CountSpaces);
            Function showVersionMenuItem = new Function("Show Version", new ExampleFunctions.VersionAndSpaces().ShowVersion);
            versionAndSpacesSubMenu.AddItem(countSpacesMenuItem);
            versionAndSpacesSubMenu.AddItem(showVersionMenuItem);
            m_MainMenu.AddItem(versionAndSpacesSubMenu);

            SubMenu showDateOrTimeSubMenu = new SubMenu("Show Date/Time");
            Function showTimeMenuItem = new Function("Show Time", new ExampleFunctions.ShowDateTime().ShowTime);
            Function showDateMenuItem = new Function("Show Date", new ExampleFunctions.ShowDateTime().ShowDate);
            showDateOrTimeSubMenu.AddItem(showTimeMenuItem);
            showDateOrTimeSubMenu.AddItem(showDateMenuItem);
            m_MainMenu.AddItem(showDateOrTimeSubMenu);
        }

        public void Start()
        {
            m_MainMenu.Show();
        }
    }
}
