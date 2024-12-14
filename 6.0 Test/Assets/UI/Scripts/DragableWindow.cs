using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;

namespace RainGayming.UI
{
    public class DragableWindow : MonoBehaviour, IDragHandler
    {
        public Canvas canvas;
        public RectTransform canvasRect;
        public RectTransform rectTransform;

        private void Start()
        {
            canvasRect = canvas.GetComponent<RectTransform>();
        }

        public void OnDrag(PointerEventData eventData)
        {
            rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
        }

        private void Update()
        {
            //checks if the rect is above the max height
            if ((rectTransform.anchoredPosition.y + rectTransform.sizeDelta.y) > canvasRect.sizeDelta.y)
            {
                Vector2 newPos = new Vector2(rectTransform.anchoredPosition.x, rectTransform.anchoredPosition.y);

                newPos.y = canvasRect.sizeDelta.y - rectTransform.sizeDelta.y;
                rectTransform.anchoredPosition = newPos;
            }
            //checks if the rect is below the min height
            if (rectTransform.anchoredPosition.y < 0)
            {
                Vector2 newPos = new Vector2(rectTransform.anchoredPosition.x, 0);
                rectTransform.anchoredPosition = newPos;
            }

            //checks if the rect is above the max weidth
            if ((rectTransform.anchoredPosition.x + rectTransform.sizeDelta.x) > canvasRect.sizeDelta.x)
            {
                Vector2 newPos = new Vector2(rectTransform.anchoredPosition.x, rectTransform.anchoredPosition.y);

                newPos.x = canvasRect.sizeDelta.x - rectTransform.sizeDelta.x;
                rectTransform.anchoredPosition = newPos;
            }
            //checks if the rect is below the min width
            if (rectTransform.anchoredPosition.x < 0)
            {
                Vector2 newPos = new Vector2(0, rectTransform.anchoredPosition.y);
                rectTransform.anchoredPosition = newPos;
            }
        }
    }
}