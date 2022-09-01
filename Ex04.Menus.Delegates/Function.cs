using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public delegate void FunctionSelected();

    public class Function : MenuItem
    {
        private readonly FunctionSelected r_FunctionSelected;

        public Function(string i_MenuItemTitle, FunctionSelected i_ExecutableAction)
            : base(i_MenuItemTitle)
        {
            r_FunctionSelected += i_ExecutableAction;
        }

        protected internal override void Show()
        {
            r_FunctionSelected?.Invoke();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
