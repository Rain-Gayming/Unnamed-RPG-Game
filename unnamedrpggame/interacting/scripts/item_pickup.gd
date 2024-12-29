extends Interactable

@export var item: InventoryItem

func _ready():
	var stored_item = item
	item = InventoryItem.new()
	item.current_amount = stored_item.current_amount
	item.current_item = stored_item.current_item

func interact():
	SignalManager.emit_add_to_player_inventory(item)
	self.queue_free()