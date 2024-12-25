class_name MenuManager
extends Control

@export var menus: Array[Control]

func set_on_top(to_set: Control):
    for menu in menus:
        if menu != to_set:
            menu.z_index -= 1
            menu.z_index = clamp(menu.z_index, -5, menus.size() + 1)
        else:
            print(to_set.name)
            to_set.z_index = menus.size() + 1