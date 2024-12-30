extends Inventory

func _ready():
    SignalManager.add_to_player_inventory.connect(add_item)