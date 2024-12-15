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

        public abstract void OnEndDrag(PointerEventData eventData);

        public void OnPointerDown(PointerEventData eventData)
        {
            //sets the menu to the top
            menuManager.SetMenuToTop(menu);
        }
    }
}