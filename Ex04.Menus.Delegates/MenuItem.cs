using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public abstract class MenuItem
    {
        protected readonly string r_Title;
        private MenuItem m_Parent;

        protected MenuItem(string i_MenuItemTitle)
        {
            this.r_Title = i_MenuItemTitle;
        }

        public string Title => this.r_Title;

        public MenuItem Parent
        {
            get => m_Parent;
            set => m_Parent = value;
        }

        protected internal abstract void Show();
    }
}
