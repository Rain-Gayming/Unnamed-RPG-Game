class_name MenuManager
extends Control

@export var menus: Array[Control]
@export var visual_controller: Control
@export var toggle_key: String

func _process(_delta):
    if Input.is_action_just_pressed(toggle_key):
        visual_controller.visible = !visual_controller.visible

        if visual_controller.visible:
            SignalManager.emit_open_menu()
        else:
            SignalManager.emit_close_menu()

func set_on_top(to_set: Control):
    for menu in menus:
        if menu != to_set:
            menu.z_index -= 1
            menu.z_index = clamp(menu.z_index, -5, menus.size() + 1)
        else:
            print(to_set.name)
            to_set.z_index = menus.size() + 1