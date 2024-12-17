using System.Collections.Generic;
using UnityEngine;

namespace RainGayming.Inventory
{
    public class InventoryUI : MonoBehaviour
    {
        [Header("UI")]
        public Transform inventoryGrid;
        public GameObject itemSlotPrefab;
        public List<GameObject> itemSlots;

        [Header("Debug")]
        public InventoryItem debugItem;

        public void Start()
        {

        }

        [ContextMenu("Add Debug Item")]
        public void AddDebugItem()
        {
            AddSlot(debugItem);
        }

        public void AddSlot(InventoryItem itemToAdd)
        {
            GameObject newItemSlot = Instantiate(itemSlotPrefab, inventoryGrid);
            newItemSlot.GetComponent<ItemSlot>().itemInSlot = itemToAdd;
            itemSlots.Add(newItemSlot);
        }
        public void RemoveSlot()
        {

        }
    }
}