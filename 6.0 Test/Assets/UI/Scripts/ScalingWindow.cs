using RainGayming.Saving;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;

namespace RainGayming.UI
{
    public enum DragDirection
    {
        north,
        northEast,
        northWest,
        east,
        south,
        southEast,
        southWest,
        west,
    }
    public class ScalingWindow : MonoBehaviour, IDragHandler, IEndDragHandler
    {
        public MenuType menuType;
        public Canvas canvas;
        public RectTransform canvasRect;
        public RectTransform rectTransform;
        public DragDirection scaleDirection;

        private void Start()
        {
            canvas = GetComponentInParent<Canvas>();
            canvasRect = canvas.GetComponent<RectTransform>();
        }

        public void OnDrag(PointerEventData eventData)
        {
            Vector2 newSize = new Vector2(rectTransform.sizeDelta.x, rectTransform.sizeDelta.y);
            Vector2 newPos = new Vector2(rectTransform.position.x, rectTransform.position.y);
            switch (scaleDirection)
            {
                case DragDirection.north:
                    newSize.y += eventData.delta.y;
                    break;
                case DragDirection.northEast:
                    newSize.x += eventData.delta.x;
                    newSize.y += eventData.delta.y;
                    break;
                case DragDirection.northWest:
                    newSize.y += eventData.delta.y;
                    newSize.x -= eventData.delta.x;
                    newPos.x += eventData.delta.x;
                    break;
                case DragDirection.east:
                    newSize.x += eventData.delta.x;
                    break;
                case DragDirection.south:
                    newSize.y -= eventData.delta.y;
                    newPos.y += eventData.delta.y;
                    break;
                case DragDirection.southEast:
                    newSize.y -= eventData.delta.y;
                    newSize.x += eventData.delta.x;
                    newPos.y += eventData.delta.y;
                    break;
                case DragDirection.southWest:
                    newSize.y -= eventData.delta.y;
                    newSize.x -= eventData.delta.x;
                    newPos.x += eventData.delta.x;
                    newPos.y += eventData.delta.y;
                    break;
                case DragDirection.west:
                    newSize.x -= eventData.delta.x;
                    newPos.x += eventData.delta.x;
                    break;
            }

            newSize.x = Mathf.Clamp(newSize.x, 100, 1920);
            newSize.y = Mathf.Clamp(newSize.y, 100, 1080);
            rectTransform.sizeDelta = newSize;
            rectTransform.position = newPos;

            SaveManager.instance.SaveData();
        }

        private void Update()
        {
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            switch (menuType)
            {
                case MenuType.map:
                    break;
                case MenuType.inventory:
                    SaveManager.instance.saveData.uiData.inventoryPosition = rectTransform.position;
                    SaveManager.instance.saveData.uiData.inventoryScale = rectTransform.sizeDelta;
                    break;
                case MenuType.status:
                    break;
                case MenuType.magic:
                    break;
            }
        }
    }
}