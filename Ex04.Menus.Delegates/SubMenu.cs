using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class SubMenu : MenuItem
    {
        private const string k_QuitOptionNum = "0";
        private readonly List<MenuItem> r_MenuItems;

        public SubMenu(string i_MenuItemTitle)
            : base(i_MenuItemTitle)
        {
            r_MenuItems = new List<MenuItem>();
        }

        public void AddItem(MenuItem i_MenuItem)
        {
            r_MenuItems.Add(i_MenuItem);
            i_MenuItem.Parent = this;
        }

        public void RemoveItem(MenuItem i_MenuItem)
        {
            r_MenuItems.Remove(i_MenuItem);
            i_MenuItem.Parent = null;
        }

        protected internal override void Show()
        {
            int maxChoices = r_MenuItems.Count;
            bool isQuitChosen = false;

            do
            {
                Console.Clear();
                string menu = this.ToString();
                Console.WriteLine(menu);
                string choice = getUserChoice(maxChoices);
                if (choice == k_QuitOptionNum)
                {
                    isQuitChosen = true;
                }
                else
                {
                    MenuItem chosenMenuItem = r_MenuItems[int.Parse(choice) - 1];
                    chosenMenuItem.Show();
                }
            }
            while (!isQuitChosen);

            Parent?.Show();
        }

        public override string ToString()
        {
            int index = 1;
            StringBuilder menuMessage = new StringBuilder();
            menuMessage.AppendFormat("**{0}**", this.r_Title);
            menuMessage.Append(Environment.NewLine);
            menuMessage.AppendLine("--------------------------");
            foreach (MenuItem menuItem in r_MenuItems)
            {
                menuMessage.AppendFormat("{0} -> {1}", index, menuItem.Title);
                menuMessage.Append(Environment.NewLine);
                index++;
            }

            menuMessage.AppendLine(Parent != null ? "0 -> Back" : "0 -> Exit");
            menuMessage.Append("--------------------------");

            return menuMessage.ToString();
        }

        private string getUserChoice(int i_MaxChoices)
        {
            bool isValid;
            string userInput;
            string zeroChoiceText = Parent != null ? "Back" : "Exit";
            Console.WriteLine("Enter your request: (1 to {0} or press '0' to {1}).", i_MaxChoices, zeroChoiceText);
            do
            {
                userInput = Console.ReadLine();
                isValid = int.TryParse(userInput, out int inputAsInt) && inputAsInt >= 0 && inputAsInt <= i_MaxChoices;

                if (!isValid)
                {
                    Console.WriteLine("Invalid input. please try again.");
                }
            }
            while (!isValid);

            return userInput;
        }
    }
}
