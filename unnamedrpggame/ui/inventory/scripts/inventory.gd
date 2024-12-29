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
	#this removes a weird bug of items adding multiplicatively
	#1, 2, 4, 8, 16, 32, ect
	var n_item_to_add = InventoryItem.new()
	n_item_to_add.current_amount = item_to_add.current_amount
	n_item_to_add.current_item = item_to_add.current_item
	
	print("adding item")
	#does the container have the item?
	#if yes then add the amount
	#if no then add a new slot
	if items.has(n_item_to_add.current_item):
		#gets the items index
		var item_index = items.find(n_item_to_add.current_item)

		add_existing_item(n_item_to_add.current_amount, item_index)
	else:
		add_new_item(n_item_to_add)


#combines the amounts together
#then updates the slots
func add_existing_item(item_to_add: int, index: int):
	inventory_items[index].current_amount += item_to_add
	print("item " + items[index].item_name + " already exists combining the amounts to: " + str(inventory_items[index].current_amount))
	inventory_ui.add_existing_item(index)
	pass

#creates a new item slot,
#sets the item in the slot to the new one
#updates the slot manually
#adds the item to the arrays for tracking
func add_new_item(item_to_add: InventoryItem):
	#tracking stuff
	inventory_items.append(item_to_add)
	items.append(item_to_add.current_item)
	inventory_ui.add_new_item(item_to_add)
