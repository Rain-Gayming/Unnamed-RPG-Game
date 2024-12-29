extends Node3D

@export var reach_distance: float
@export var raycast: RayCast3D

func _ready():
	raycast.target_position.y = -reach_distance
 
func _process(_delta: float):
	if Input.is_action_just_pressed("gameplay_interact"):
		if raycast.is_colliding():
			var hit = raycast.get_collider()
			if hit.has_method("interact"):
				print("^-^")