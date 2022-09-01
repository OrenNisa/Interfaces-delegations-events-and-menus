using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private readonly SubMenu r_Menu;

        public MainMenu(string i_MainMenuTitle)
        {
            r_Menu = new SubMenu(i_MainMenuTitle);
        }

        public void AddItem(MenuItem i_MenuItem)
        {
            r_Menu.AddItem(i_MenuItem);
        }

        public void RemoveItem(MenuItem i_MenuItem)
        {
            r_Menu.RemoveItem(i_MenuItem);
        }

        public void Show()
        {
            r_Menu.Show();
        }
    }
}
