class_name Skill
extends Resource

@export_range(1, 500) var level: int = 5
@export var is_major: bool
@export var is_minor: bool
@export var related_attribute: StatsEnum.Attribute
@export var stat_type: StatsEnum.StatType
@export var experience: float
@export var exp_to_level: float = 100

func add_exp(amount: float, manager_from: StatManager):
    experience += amount
    if experience >= exp_to_level:
        level += 1
        experience = 0
        exp_to_level = exp_to_level * 1.1
        
        manager_from.add_level_to_attribute(related_attribute)

        if is_major:
            manager_from.add_level_up_points()
