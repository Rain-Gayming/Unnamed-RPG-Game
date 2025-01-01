extends CharacterBody3D

@export_group("references")
@export var camera_holder: Node3D
@export var standing_collider: CollisionShape3D
@export var crouching_collider: CollisionShape3D

@export_group("ground movement")
@export var current_speed: float
@export var walk_speed: float
@export var run_speed: float
@export var sprint_speed: float
@export var crouch_speed: float
@export var acceleration: float
@export var current_movement: MovementType.Movement

@export_group("jumping")
@export var jump_height: float
var gravity = ProjectSettings.get_setting("physics/3d/default_gravity")

func _ready():
	change_movement_type(MovementType.Movement.running)

func _physics_process(delta: float) -> void:
	if not is_on_floor():
		velocity.y -= gravity * delta
	
	if Input.is_action_just_pressed("movement_jump") and is_on_floor():
		velocity.y = jump_height
	
	inputs()
	ground_movement(delta)
	move_and_slide()

func inputs():
	#if youre walking and press the walk key you run
	if Input.is_action_just_pressed("movement_walk") and current_movement == MovementType.Movement.walking:
		change_movement_type(MovementType.Movement.running)
	#if youre running and press the walk key you walk
	elif Input.is_action_just_pressed("movement_walk") and current_movement == MovementType.Movement.running:
		change_movement_type(MovementType.Movement.walking)
	
	#if youre not crouching then crouch
	#otherwise run
	if Input.is_action_just_pressed("movement_crouch") and current_movement != MovementType.Movement.crouching:
		change_movement_type(MovementType.Movement.crouching)
	elif Input.is_action_just_pressed("movement_crouch") and current_movement == MovementType.Movement.crouching:
		change_movement_type(MovementType.Movement.running)

	#if youre not sprinting then sprint
	#otherwise run
	if Input.is_action_just_pressed("movement_sprint") and current_movement != MovementType.Movement.sprinting:
		change_movement_type(MovementType.Movement.sprinting)
	elif Input.is_action_just_pressed("movement_sprint") and current_movement == MovementType.Movement.sprinting:
		change_movement_type(MovementType.Movement.running)

func ground_movement(delta: float):
	var input_direction = Input.get_vector("movement_left", "movement_right", "movement_forward", "movement_back")
	var direction = (transform.basis * Vector3(input_direction.x, 0, input_direction.y)).normalized()

	#slows down the player when moving backwards
	if input_direction.y < 0.001:
		if direction:
			#the quartering is so the player is slower moving left and right
			velocity.x = lerp(velocity.x, (direction.x * current_speed) / 1.5, acceleration * delta)
			velocity.z = lerp(velocity.z, direction.z * current_speed, acceleration * delta)
		else:
			velocity.x = lerp(velocity.x, 0.0, acceleration * delta)
			velocity.z = lerp(velocity.z, 0.0, acceleration * delta)
	else:
		if direction:
			velocity.x = lerp(velocity.x, (direction.x * current_speed) / 2, acceleration * delta)
			velocity.z = lerp(velocity.z, (direction.z * current_speed) / 2, acceleration * delta)
		else:
			velocity.x = lerp(velocity.x, 0.0, acceleration * delta)
			velocity.z = lerp(velocity.z, 0.0, acceleration * delta)


func change_movement_type(type: MovementType.Movement):
	current_movement = type
	match type:
		#walking
		MovementType.Movement.walking:
			current_speed = walk_speed
		#running
		MovementType.Movement.running:
			current_speed = run_speed
		#sprinting
		MovementType.Movement.sprinting:
			current_speed = sprint_speed
		#crouching
		MovementType.Movement.crouching:
			current_speed = crouch_speed
	
	#lowers the camera when crouching
	if type == MovementType.Movement.crouching:
		camera_holder.position.y = 1
		standing_collider.disabled = false
		crouching_collider.disabled = true
	else:
		camera_holder.position.y = 1.75
		standing_collider.disabled = true
		crouching_collider.disabled = false