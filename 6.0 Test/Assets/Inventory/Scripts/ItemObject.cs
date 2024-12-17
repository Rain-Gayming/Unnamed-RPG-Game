using UnityEngine;

namespace RainGayming.Inventory
{
    [CreateAssetMenu(fileName = "item", menuName = "Inventory/Item")]
    public class ItemObject : ScriptableObject
    {
        public string itemName;
        public bool canStack;
    }
}