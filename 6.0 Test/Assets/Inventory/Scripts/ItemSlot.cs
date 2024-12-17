using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace RainGayming.Inventory
{
    public class ItemSlot : MonoBehaviour
    {
        [Header("Item")]
        public InventoryItem itemInSlot;
        public InventoryUI inventoryRelatedTo;

        [Header("UI")]
        public Image itemIcon;
        public TMP_Text amountText;

        public void Start()
        {
            UpdateSlot();
        }

        public void UpdateSlot()
        {
            //hide amount text
            amountText.gameObject.SetActive(true);

            //if theres more than one item
            //itemnSlot.item.canStack added as a failsafe incase a bug happens
            if (itemInSlot.amount > 1 && itemInSlot.item.canStack)
            {
                amountText.gameObject.SetActive(true);
                amountText.text = itemInSlot.amount.ToString();
            }
        }
    }
}