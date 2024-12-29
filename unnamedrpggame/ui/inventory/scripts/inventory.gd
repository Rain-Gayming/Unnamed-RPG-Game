extends Node

@export_group("UI")
@export var item_slot: PackedScene
@export var item_grid: Control
@export var item_slots: Array[ItemSlot]

@export_group("items")
@export var inventory_items: Array[InventoryItem]
@export var items: Array[BaseItem]

@export_group("debug")
@export var debug_item: InventoryItem

func _process(_delta):
	#this is just debug remove later
	if Input.is_action_just_pressed("ui_accept"):
		debug_add()

#debug code
func debug_add():
	add_item(debug_item)

func add_item(item_to_add: InventoryItem):
	#does the container have the item?
	#if yes then add the amount
	#if no then add a new slot
	if items.has(item_to_add.current_item):
		#gets the items index
		var item_index = items.find(item_to_add.current_item)

		add_existing_item(item_to_add.current_amount, item_index)
		return
	else:
		add_new_item(item_to_add)
		return

#combines the amounts together
#then updates the slots
func add_existing_item(item_to_add: int, index: int):
	inventory_items[index].current_amount += item_to_add
	item_slots[index].update_slot()
	print("item " + items[index].item_name + " already exists combining the amounts to: " + str(inventory_items[index].current_amount))

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
	inventory_items.append(item_to_add)
	items.append(item_to_add.current_item)
