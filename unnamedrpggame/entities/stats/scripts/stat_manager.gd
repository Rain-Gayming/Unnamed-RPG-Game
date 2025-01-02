class_name StatManager
extends Node

@export_group("attributes")
@export var strength: Attribute
@export var endurance: Attribute
@export var speed: Attribute
@export var inteligence: Attribute
@export var wisdom: Attribute
@export var willpower: Attribute
@export var personality: Attribute
@export var agility: Attribute

@export_group("leveling")
@export var level_up_points: int
@export var level_up_points_needed: int = 15
@export var can_level_up: bool

@export_group("class")
@export var my_class: Class

func _ready():
    make_stats_unique()

func _process(_delta):
    pass
    
    #debug code
    #if Input.is_action_just_pressed("debug_add_exp"):
    #    add_exp_to_skill(StatsEnum.Skills.ritual_magic, 15)

#this lets me customise stats per class for SOME reason
func make_stats_unique():
    var u_strength = strength.duplicate()
    strength = u_strength
    var u_endurance = endurance.duplicate()
    endurance = u_endurance
    var u_speed = speed.duplicate()
    speed = u_speed
    var u_inteligence = inteligence.duplicate()
    inteligence = u_inteligence
    var u_wisdom = wisdom.duplicate()
    wisdom = u_wisdom
    var u_willpower = willpower.duplicate()
    willpower = u_willpower
    var u_personality = personality.duplicate()
    personality = u_personality
    var u_agility = agility.duplicate()
    agility = u_agility

    var u_class: Class = my_class.duplicate()

    var u_rm = my_class.ritual_magic.duplicate()
    u_class.ritual_magic = u_rm
    var u_elm = my_class.elemental_magic.duplicate()
    u_class.elemental_magic = u_elm
    var u_pm = my_class.purity_magic.duplicate()
    u_class.purity_magic = u_pm
    var u_am = my_class.alteration_magic.duplicate()
    u_class.alteration_magic = u_am
    var u_cm = my_class.corruption_magic.duplicate()
    u_class.corruption_magic = u_cm
    var u_em = my_class.enchanting_magic.duplicate()
    u_class.enchanting_magic = u_em
    var u_ma = my_class.medium_armour.duplicate()
    u_class.medium_armour = u_ma
    
    var u_spw = my_class.spear_weapons.duplicate()
    u_class.spear_weapons = u_spw
    var u_lbw = my_class.long_blade_weapons.duplicate()
    u_class.long_blade_weapons = u_lbw
    var u_bw = my_class.blunt_weapons.duplicate()
    u_class.blunt_weapons = u_bw
    var u_sw = my_class.sharp_weapons.duplicate()
    u_class.sharp_weapons = u_sw
    var u_mw = my_class.marksman_weapons.duplicate()
    u_class.marksman_weapons = u_mw
    var u_ha = my_class.heavy_armour.duplicate()
    u_class.heavy_armour = u_ha

    var u_ss = my_class.sneaking_stealth.duplicate()
    u_class.sneaking_stealth = u_ss
    var u_slohs = my_class.slight_of_hand_stealth.duplicate()
    u_class.slight_of_hand_stealth = u_slohs
    var u_ps = my_class.poisoning_stealth.duplicate()
    u_class.poisoning_stealth = u_ps
    var u_tw = my_class.throwing_weapons.duplicate()
    u_class.throwing_weapons = u_tw
    var u_sbw = my_class.short_blade_weapons.duplicate()
    u_class.short_blade_weapons = u_sbw
    var u_pc = my_class.persuasion_charisma.duplicate()
    u_class.persuasion_charisma = u_pc
    var u_la = my_class.light_armour.duplicate()
    u_class.light_armour = u_la
    
    my_class = u_class

func add_exp_to_skill(skill: StatsEnum.Skills, amount: float):
    match skill:
        StatsEnum.Skills.ritual_magic:
            my_class.ritual_magic.add_exp(amount, self)

        StatsEnum.Skills.elemental_magic:
            my_class.elemental_magic.add_exp(amount, self)

        StatsEnum.Skills.purity_magic:
            my_class.purity_magic.add_exp(amount, self)

        StatsEnum.Skills.alteration_magic:
            my_class.alteration_magic.add_exp(amount, self)

        StatsEnum.Skills.corruption_magic:
            my_class.corruption_magic.add_exp(amount, self)

        StatsEnum.Skills.enchanting_magic:
            my_class.enchanting_magic.add_exp(amount, self)

        StatsEnum.Skills.medium_armour:
            my_class.medium_armour.add_exp(amount, self)

        StatsEnum.Skills.spear_weapons:
            my_class.spear_weapons.add_exp(amount, self)

        StatsEnum.Skills.long_blade_weapons:
            my_class.long_blade_weapons.add_exp(amount, self)

        StatsEnum.Skills.blunt_weapons:
            my_class.blunt_weapons.add_exp(amount, self)

        StatsEnum.Skills.sharp_weapons:
            my_class.sharp_weapons.add_exp(amount, self)

        StatsEnum.Skills.marksman_weapons:
            my_class.marksman_weapons.add_exp(amount, self)

        StatsEnum.Skills.heavy_armour:
            my_class.heavy_armour.add_exp(amount, self)

        StatsEnum.Skills.sneaking_stealth:
            my_class.sneaking_stealth.add_exp(amount, self)

        StatsEnum.Skills.slight_of_hand_stealth:
            my_class.slight_of_hand_stealth.add_exp(amount, self)

        StatsEnum.Skills.poisoning_stealth:
            my_class.poisoning_stealth.add_exp(amount, self)

        StatsEnum.Skills.throwing_weapons:
            my_class.throwing_weapons.add_exp(amount, self)

        StatsEnum.Skills.short_blade_weapons:
            my_class.short_blade_weapons.add_exp(amount, self)

        StatsEnum.Skills.persuasion_charisma:
            my_class.persuasion_charisma.add_exp(amount, self)

        StatsEnum.Skills.light_armour:
            my_class.light_armour.add_exp(amount, self)

func add_level_up_points():
    level_up_points += 1

    if level_up_points >= level_up_points_needed:
        can_level_up = true

func add_level_to_attribute(attribute: StatsEnum.Attribute):
    match attribute:
        StatsEnum.Attribute.strength:
            strength.level_points += 1
        StatsEnum.Attribute.endurance:
            endurance.level_points += 1
        StatsEnum.Attribute.speed:
            speed.level_points += 1
        StatsEnum.Attribute.inteligence:
            inteligence.level_points += 1
        StatsEnum.Attribute.wisdom:
            wisdom.level_points += 1
        StatsEnum.Attribute.willpower:
            willpower.level_points += 1
        StatsEnum.Attribute.personality:
            personality.level_points += 1
        StatsEnum.Attribute.agility:
            agility.level_points += 1