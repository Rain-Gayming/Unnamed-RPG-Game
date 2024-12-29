class_name Inventory
extends Node

@export_group("references")
@export var inventory_ui: InventoryUI

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
	print("adding item")
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
	print("item " + items[index].item_name + " already exists combining the amounts to: " + str(inventory_items[index].current_amount))
	inventory_ui.add_existing_item(index)

#creates a new item slot,
#sets the item in the slot to the new one
#updates the slot manually
#adds the item to the arrays for tracking
func add_new_item(item_to_add: InventoryItem):
	#tracking stuff
	inventory_items.append(item_to_add)
	items.append(item_to_add.current_item)
	inventory_ui.add_new_item(item_to_add)
