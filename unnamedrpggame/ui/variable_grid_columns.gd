extends GridContainer

@export var internal_object_size: float

var prev_size: float
var prev_pos: float

func _process(_delta: float):
	if prev_size != size.x or prev_pos != position.x:
		
		var raw_columns = (size.x + position.x) / (internal_object_size + get_theme_constant("h_separation"))

		columns = roundi(raw_columns)

		prev_size = size.x
		prev_pos = position.x