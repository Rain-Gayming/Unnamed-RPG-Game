class_name ItemSlot
extends Node

@export_group("item")
@export var item: InventoryItem

@export_group("UI")
@export var item_icon: TextureRect
@export var item_amount: RichTextLabel

func update_slot():
	if item == null or item.current_amount <= 0 or item.current_item == null:
		self.queue_free()
		return
	
	item_icon.texture = item.current_item.item_icon
	item_amount.text = str(item.current_amount)
