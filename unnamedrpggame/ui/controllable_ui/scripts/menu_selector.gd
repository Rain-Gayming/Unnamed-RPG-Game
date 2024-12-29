extends Node

@export var direction: UiDirections.Direction
@export var menu: ControllableMenu
@export var is_hovered: bool
@export var debug_display: Control

func _ready() -> void:
	debug_display.visible = false
	name = "selector " + str(direction)


func _process(_delta):
	if is_hovered:
		if Input.is_action_just_pressed("left_mouse"):
			menu.dragMenu(direction)
			menu.set_on_top()
	
	if Input.is_action_just_released("left_mouse"):
		menu.stopDrag()


func _on_mouse_exited() -> void:
	is_hovered = false

func _on_mouse_entered() -> void:
	is_hovered = true
