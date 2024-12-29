extends Node

signal add_to_player_inventory(item)

func emit_add_to_player_inventory(item: InventoryItem):
    print("emitting")
    add_to_player_inventory.emit(item)