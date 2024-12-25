class_name BaseItem
extends Resource

@export_group("item information")
@export var item_name: String
@export var item_icon: Texture2D
@export_multiline var item_description: String
@export var can_stack: bool