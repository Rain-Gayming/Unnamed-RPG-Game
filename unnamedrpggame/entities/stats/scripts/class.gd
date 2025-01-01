class_name Class
extends Resource

@export var level: int
@export_group("skills/magic")
#magic skills
@export var ritual_magic: Skill
@export var elemental_magic: Skill
@export var purity_magic: Skill
@export var alteration_magic: Skill
@export var corruption_magic: Skill
@export var enchanting_magic: Skill
@export var medium_armour: Skill

@export_group("skills/combat")
#combat skills
@export var spear_weapons: Skill
@export var long_blade_weapons: Skill
@export var blunt_weapons: Skill
@export var sharp_weapons: Skill
@export var marksman_weapons: Skill
@export var heavy_armour: Skill

@export_group("skills/stealth")
#stealth skills
@export var sneaking_stealth: Skill
@export var slight_of_hand_stealth: Skill
@export var poisoning_stealth: Skill
@export var throwing_weapons: Skill
@export var short_blade_weapons: Skill
@export var persuasion_charisma: Skill
@export var light_armour: Skill

func _init():
    var u_rm = ritual_magic.duplicate()
    ritual_magic = u_rm
    var u_elm = elemental_magic.duplicate()
    elemental_magic = u_elm
    var u_pm = purity_magic.duplicate()
    purity_magic = u_pm
    var u_am = alteration_magic.duplicate()
    alteration_magic = u_am
    var u_cm = corruption_magic.duplicate()
    corruption_magic = u_cm
    var u_em = enchanting_magic.duplicate()
    enchanting_magic = u_em
    var u_ma = medium_armour.duplicate()
    medium_armour = u_ma
    
    var u_spw = spear_weapons.duplicate()
    spear_weapons = u_spw
    var u_lbw = long_blade_weapons.duplicate()
    long_blade_weapons = u_lbw
    var u_bw = blunt_weapons.duplicate()
    blunt_weapons = u_bw
    var u_sw = sharp_weapons.duplicate()
    sharp_weapons = u_sw
    var u_mw = marksman_weapons.duplicate()
    marksman_weapons = u_mw
    var u_ha = heavy_armour.duplicate()
    heavy_armour = u_ha

    var u_ss = sneaking_stealth.duplicate()
    sneaking_stealth = u_ss
    var u_slohs = slight_of_hand_stealth.duplicate()
    slight_of_hand_stealth = u_slohs
    var u_ps = poisoning_stealth.duplicate()
    poisoning_stealth = u_ps
    var u_tw = throwing_weapons.duplicate()
    throwing_weapons = u_tw
    var u_sbw = short_blade_weapons.duplicate()
    short_blade_weapons = u_sbw
    var u_pc = persuasion_charisma.duplicate()
    persuasion_charisma = u_pc
    var u_la = light_armour.duplicate()
    light_armour = u_la