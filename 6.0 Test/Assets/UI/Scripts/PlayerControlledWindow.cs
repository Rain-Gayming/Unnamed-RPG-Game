using RainGayming.Saving;
using UnityEngine;
using UnityEngine.EventSystems;

namespace RainGayming.UI
{
    public abstract class PlayerControlledWindow : MonoBehaviour, IDragHandler, IEndDragHandler, IPointerDownHandler
    {
        [Header("References")]
        public MenuManager menuManager;
        public Menu menu;
        public Canvas canvas;

        [Header("UI")]
        public RectTransform canvasRect;
        public RectTransform rectTransform;
        public DragDirection scaleDirection;

        private void Start()
        {
            menu = GetComponentInParent<Menu>();
            canvas = GetComponentInParent<Canvas>();
            menuManager = canvas.GetComponentInParent<MenuManager>();
            canvasRect = canvas.GetComponent<RectTransform>();
        }

        public abstract void OnDrag(PointerEventData eventData);

        public void OnEndDrag(PointerEventData eventData)
        {
            switch (menu.menuType)
            {
                case MenuType.map:
                    SaveManager.instance.saveData.uiData.mapPosition = rectTransform.position;
                    SaveManager.instance.saveData.uiData.mapScale = rectTransform.sizeDelta;
                    break;
                case MenuType.inventory:
                    SaveManager.instance.saveData.uiData.inventoryPosition = rectTransform.position;
                    SaveManager.instance.saveData.uiData.inventoryScale = rectTransform.sizeDelta;
                    break;
                case MenuType.status:
                    SaveManager.instance.saveData.uiData.statusPosition = rectTransform.position;
                    SaveManager.instance.saveData.uiData.statusScale = rectTransform.sizeDelta;
                    break;
                case MenuType.magic:
                    SaveManager.instance.saveData.uiData.magicPosition = rectTransform.position;
                    SaveManager.instance.saveData.uiData.magicScale = rectTransform.sizeDelta;
                    break;
            }
        }


        public void OnPointerDown(PointerEventData eventData)
        {
            //sets the menu to the top
            menuManager.SetMenuToTop(menu);
        }
    }
}