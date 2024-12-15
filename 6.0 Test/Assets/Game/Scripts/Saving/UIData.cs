
using UnityEngine;

[System.Serializable]
public class UIData
{
    [Header("map UI")]
    public Vector2 mapPosition = new Vector2(410, 575);
    public Vector2 mapScale = new Vector2(1500, 490);

    [Header("Inventory UI")]
    public Vector2 inventoryPosition = new Vector2(15, 575);
    public Vector2 inventoryScale = new Vector2(15, 575);

    [Header("Status UI")]
    public Vector2 statusPosition = new Vector2(575, 15);
    public Vector2 statusScale = new Vector2(395, 490);

    [Header("Magic UI")]
    public Vector2 magicPosition = new Vector2(1450, 15);
    public Vector2 magicScale = new Vector2(455, 560);
}