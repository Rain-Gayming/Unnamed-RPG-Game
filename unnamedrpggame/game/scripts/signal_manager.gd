extends Node

signal add_to_player_inventory(item)
signal open_menu
signal close_menu

func emit_add_to_player_inventory(item: InventoryItem):
    print("emitting")
    add_to_player_inventory.emit(item)

func emit_close_menu():
    close_menu.emit()
func emit_open_menu():
    open_menu.emit()