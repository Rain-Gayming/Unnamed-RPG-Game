class_name StatManager
extends Node

@export_group("attributes")
@export var strength: int
@export var endurance: int
@export var speed: int
@export var inteligence: int
@export var wisdom: int
@export var willpower: int
@export var personality: int
@export var agility: int

@export_group("class")
@export var my_class: Class

func _ready():
    make_stats_unique()


#this lets me customise stats per class for SOME reason
func make_stats_unique():
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
