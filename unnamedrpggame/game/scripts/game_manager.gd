extends Node

@export var menus_open: int
@export var is_paused: bool
@export var last_paused: bool

@export_group("references")
@export var player_camera: Node3D

func _ready():
    SignalManager.open_menu.connect(menu_opened)
    SignalManager.close_menu.connect(menu_closed)

func _process(_delta):
    is_paused = menus_open >= 1
    if is_paused != last_paused:
        player_camera.is_paused = is_paused
        CursorManager.is_paused = is_paused
        last_paused = is_paused

func menu_opened():
    menus_open += 1

func menu_closed():
    menus_open -= 1