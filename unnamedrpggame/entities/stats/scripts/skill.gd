class_name Skill
extends Resource

@export_range(1, 500) var level: int = 5
@export var is_major: bool
@export var is_minor: bool
@export var related_attribute: StatsEnum.Attribute
@export var stat_type: StatsEnum.StatType