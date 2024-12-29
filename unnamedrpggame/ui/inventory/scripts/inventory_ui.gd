class_name InventoryUI
extends ControllableMenu

@export_group("references")
@export var inventory: Inventory

@export_group("UI")
@export var item_slot: PackedScene
@export var item_grid: Control
@export var item_slots: Array[ItemSlot]


#combines the amounts together
#then updates the slots
func add_existing_item(index: int):
	item_slots[index].update_slot()

#creates a new item slot,
#sets the item in the slot to the new one
#updates the slot manually
#adds the item to the arrays for tracking
func add_new_item(item_to_add: InventoryItem):
	#slot creation
	var new_slot = item_slot.instantiate()
	new_slot.item = item_to_add
	item_grid.add_child(new_slot)
	new_slot.update_slot()

	#tracking stuff
	item_slots.append(new_slot)
