using RainGayming.Saving;
using UnityEngine;

namespace RainGayming.UI
{
    public class Menu : MonoBehaviour
    {
        public MenuType menuType;
        public Canvas canvas;
        public RectTransform rect;

        public void Start()
        {
            switch (menuType)
            {
                case MenuType.map:
                    break;
                case MenuType.inventory:
                    rect.position = SaveManager.instance.saveData.uiData.inventoryPosition;
                    rect.sizeDelta = SaveManager.instance.saveData.uiData.inventoryScale;
                    break;
                case MenuType.status:
                    break;
                case MenuType.magic:
                    break;
            }
        }
    }
}