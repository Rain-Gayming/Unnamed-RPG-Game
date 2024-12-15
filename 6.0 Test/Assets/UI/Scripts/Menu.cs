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
                    rect.position = SaveManager.instance.saveData.uiData.mapPosition;
                    rect.sizeDelta = SaveManager.instance.saveData.uiData.mapScale;
                    break;
                case MenuType.inventory:
                    rect.position = SaveManager.instance.saveData.uiData.inventoryPosition;
                    rect.sizeDelta = SaveManager.instance.saveData.uiData.inventoryScale;
                    break;
                case MenuType.status:
                    rect.position = SaveManager.instance.saveData.uiData.statusPosition;
                    rect.sizeDelta = SaveManager.instance.saveData.uiData.statusScale;
                    break;
                case MenuType.magic:
                    rect.position = SaveManager.instance.saveData.uiData.magicPosition;
                    rect.sizeDelta = SaveManager.instance.saveData.uiData.magicScale;
                    break;
            }
        }
    }
}