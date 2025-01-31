﻿using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        protected readonly List<MenuItem> r_ItemsList = new List<MenuItem>();
        protected string m_ItemName;
        protected MainMenu m_MainMenu;

        public MenuItem(string i_ItemName)
        {
            m_ItemName = i_ItemName;
        }

        public MenuItem(string i_ItemName, MainMenu i_MainMenu)
        {
            m_ItemName = i_ItemName;
            m_MainMenu = i_MainMenu;
        }

        public string ItemName
        {
            get
            {
                return m_ItemName;
            }
        }

        public void AddItem(MenuItem i_Item)
        {
            r_ItemsList.Add(i_Item);
        }

        public void RemoveItem(MenuItem i_Item)
        {
            r_ItemsList.Remove(i_Item);
        }

        public void OnSelected()
        {
            m_MainMenu.OnSelection(this);
        }

        public virtual void Show()
        {
            bool backPressed;
            int counter;
            int choice;

            do
            {
                Console.Clear();
                counter = 1;
                Console.WriteLine(string.Format("**{0}**", m_ItemName));
                Console.WriteLine("----------------------");
                foreach (MenuItem item in r_ItemsList)
                {
                    Console.WriteLine(string.Format("{0} -> {1}", counter, item.ItemName));
                    counter++;
                }

                Console.WriteLine("0 -> Back");
                Console.WriteLine("----------------------");
                Console.WriteLine(string.Format("Enter your request: ({0} to {1} or press '0' to Back).", 1, r_ItemsList.Count));
                choice = askInputFromUser(out backPressed);
                if (choice != 0)
                {
                    choice -= 1;
                    r_ItemsList[choice].OnSelected();
                }
            }
            while (!backPressed);
        }

        private int askInputFromUser(out bool io_BackPressed)
        {
            io_BackPressed = false;
            bool isInputIncorrect = true;
            string inputStr;
            int choiceInt;

            do
            {
                inputStr = Console.ReadLine();
                if (int.TryParse(inputStr, out choiceInt))
                {
                    if (choiceInt >= 0 & choiceInt <= r_ItemsList.Count)
                    {
                        isInputIncorrect = false;
                        if (choiceInt == 0)
                        {
                            io_BackPressed = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong choice, Try Again!");
                    }
                }
                else
                {
                    Console.WriteLine("Input Incorrect, Try Again!");
                }
            }
            while (isInputIncorrect);

            return choiceInt;
        }
    }
}
