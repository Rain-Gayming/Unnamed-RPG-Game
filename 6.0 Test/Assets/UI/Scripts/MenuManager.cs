using System;
using System.Collections.Generic;
using UnityEngine;

namespace RainGayming.UI
{
    public class MenuManager : MonoBehaviour
    {
        public List<Menu> menus;
        public void Start()
        {
            Menu[] menusInUI = GetComponentsInChildren<Menu>();
            for (int i = 0; i < menusInUI.Length; i++)
            {
                menus.Add(menusInUI[i]);
            }
        }

        public void SetMenuToTop(Menu menu)
        {
            for (int i = 0; i < menus.Count; i++)
            {
                menus[i].canvas.sortingOrder--;
                menus[i].canvas.sortingOrder = Mathf.Clamp(menus[i].canvas.sortingOrder, 0, menus.Count);
            }
            menu.canvas.sortingOrder = menus.Count;
        }

    }
}