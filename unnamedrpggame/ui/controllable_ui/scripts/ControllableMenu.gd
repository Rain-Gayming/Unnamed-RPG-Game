class_name ControllableMenu
extends Control

var current_drag: UiDirections.Direction
var is_dragging: bool

func dragMenu(direction: UiDirections.Direction):
    current_drag = direction
    is_dragging = true

func stopDrag():
    is_dragging = false

func _input(event):
    if (is_dragging):
        if event is InputEventMouseMotion:
            pivot_offset.x = size.x / 2
            pivot_offset.y = size.y / 2
            print(current_drag)
            match current_drag:
                UiDirections.Direction.n:
                    size.y -= event.relative.y
                    position.y += event.relative.y
                UiDirections.Direction.ne:
                    size.y -= event.relative.y
                    size.x += event.relative.x
                    position.y += event.relative.y
                UiDirections.Direction.e:
                    size.x += event.relative.x
                UiDirections.Direction.se:
                    size.y += event.relative.y
                    size.x += event.relative.x
                UiDirections.Direction.s:
                    size.y -= -event.relative.y
                UiDirections.Direction.sw:
                    size.y += event.relative.y
                    size.x -= event.relative.x
                    position.x += event.relative.x
                UiDirections.Direction.w:
                    size.x -= event.relative.x
                    position.x += event.relative.x
                UiDirections.Direction.nw:
                    size.y -= event.relative.y
                    size.x += -event.relative.x
                    position.x += event.relative.x
                    position.y += event.relative.y
                UiDirections.Direction.drag:
                    position.x += event.relative.x
                    position.y += event.relative.y