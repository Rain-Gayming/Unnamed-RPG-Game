extends Inventory

func _ready():
    SignalManager.add_to_player_inventory.connect(add_item)
    print("connected")

func p_add_item(item: InventoryItem):
    print("signal called")
    add_item(item)