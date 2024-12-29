extends Interactable

@export var item: InventoryItem

func interact():
	SignalManager.emit_add_to_player_inventory(item)
	self.queue_free()