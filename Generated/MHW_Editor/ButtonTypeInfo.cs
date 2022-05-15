using System;
using System.Collections.Generic;

namespace MHW_Editor {
    public static class ButtonTypeInfo {
        public static readonly List<string> TYPES_WITH_BUTTONS = new List<string> {
            "Ammo",
            "Ammo_Box",
            "ArenaEquipment",
            "Armor",
            "Armors",
            "ASkill",
            "AwakenedLimitBreak",
            "Bounty",
            "CustomOuterRecipe",
            "CustomOuterWeapon",
            "CustomPartsR",
            "DecoGradeLottery",
            "DecoLottery",
            "Decorations",
            "Entries",
            "EqCrt",
            "EqCus",
            "GcData",
            "Gem",
            "GunnerReload",
            "GunnerShoot",
            "InnerItem",
            "Item_Box",
            "ItemDelivery",
            "ItemList",
            "ItemLottery",
            "ItemMake",
            "Items",
            "ItemTg",
            "KulveGradeLottery",
            "KulveItemLottery",
            "LimitBreakMaterialBase",
            "LimitBreakMaterialSkill",
            "Mantles",
            "MelderExchange",
            "MelderItem",
            "Melee",
            "Monster_Damage_Attributes_1_",
            "Monster_Parts",
            "Monster_Rage",
            "Monster_Stamina_1_",
            "MonsterDamageAttributes",
            "MonsterEnrage",
            "MonsterParts",
            "MonsterRandomSize",
            "Monsters",
            "MonsterStamina",
            "NewLimitBreakR",
            "Pendant",
            "PlantItem",
            "QuestReward",
            "QuestRewardCustomView",
            "Ranged",
            "RoomAnimal",
            "RoomFurniture",
            "SafiItemGradeLottery",
            "SafiItemLottery",
            "ShellTable",
            "ShopList",
            "ShopSed",
            "Size_Settings",
            "SkillDat",
            "SmallMonsterSizeParams",
            "SteamRewardList",
            "SupplyData",
            "SwapItem",
            "SwapN",
            "Treasure",
            "ValueTrader",
            "Weapon",
        };

        public static readonly List<string> BUTTON_NAMES = new List<string> {
            "Ammo_Id_button",
            "Armor_Id_button",
            "Armor_Rec_Amnt_button",
            "Armor_Rel_Spd_button",
            "armorId_button",
            "Cluster_1_Rec_Amnt_button",
            "Cluster_1_Rel_Spd_button",
            "Cluster_2_Rec_Amnt_button",
            "Cluster_2_Rel_Spd_button",
            "Cluster_3_Rec_Amnt_button",
            "Cluster_3_Rel_Spd_button",
            "Deco_1_button",
            "Deco_2_button",
            "Deco_3_button",
            "Decoration_Reward_button",
            "Demon_Rec_Amnt_button",
            "Demon_Rel_Spd_button",
            "Dragon_Rec_Amnt_button",
            "Dragon_Rel_Spd_button",
            "Equip_Id_button",
            "Equipment_Index_Armor_button",
            "Equipment_Index_Weapon_button",
            "Exhaust_1_Rec_Amnt_button",
            "Exhaust_1_Rel_Spd_button",
            "Exhaust_2_Rec_Amnt_button",
            "Exhaust_2_Rel_Spd_button",
            "Flaming_Rec_Amnt_button",
            "Flaming_Rel_Spd_button",
            "Freeze_Rec_Amnt_button",
            "Freeze_Rel_Spd_button",
            "Hidden_Skill_button",
            "Id_button",
            "Item_1_Id_button",
            "Item_2_Id_button",
            "Item_button",
            "Item_Id_1_button",
            "Item_Id_2_button",
            "Item_Id_3_button",
            "Item_Id_button",
            "itemId_button",
            "Mantle_Id_button",
            "Mantle_Item_Id_button",
            "Mat_1_Id_button",
            "Mat_2_Id_button",
            "Mat_3_Id_button",
            "Mat_4_Id_button",
            "Mod_1_button",
            "Mod_2_button",
            "Mod_3_button",
            "Mod_4_button",
            "Monster_Id_button",
            "Monster_Unlock_button",
            "Needed_Item_Id_to_Unlock_button",
            "No_Mods_button",
            "Normal_1_Rec_Amnt_button",
            "Normal_1_Rel_Spd_button",
            "Normal_2_Rec_Amnt_button",
            "Normal_2_Rel_Spd_button",
            "Normal_3_Rec_Amnt_button",
            "Normal_3_Rel_Spd_button",
            "Paralysis_1_Rec_Amnt_button",
            "Paralysis_1_Rel_Spd_button",
            "Paralysis_2_Rec_Amnt_button",
            "Paralysis_2_Rel_Spd_button",
            "pendantId_button",
            "Pierce_1_Rec_Amnt_button",
            "Pierce_1_Rel_Spd_button",
            "Pierce_2_Rec_Amnt_button",
            "Pierce_2_Rel_Spd_button",
            "Pierce_3_Rec_Amnt_button",
            "Pierce_3_Rel_Spd_button",
            "Poison_1_Rec_Amnt_button",
            "Poison_1_Rel_Spd_button",
            "Poison_2_Rec_Amnt_button",
            "Poison_2_Rel_Spd_button",
            "Recover_1_Rec_Amnt_button",
            "Recover_1_Rel_Spd_button",
            "Recover_2_Rec_Amnt_button",
            "Recover_2_Rel_Spd_button",
            "Result_Id_button",
            "Result_Item_Id_button",
            "Set_Skill_1_button",
            "Skill_1_button",
            "Skill_2_button",
            "Skill_3_button",
            "Skill_button",
            "Skill_Id_button",
            "Sleep_1_Rec_Amnt_button",
            "Sleep_1_Rel_Spd_button",
            "Sleep_2_Rec_Amnt_button",
            "Sleep_2_Rel_Spd_button",
            "Slicing_Rec_Amnt_button",
            "Slicing_Rel_Spd_button",
            "Source_Item_Id_button",
            "Spread_1_Rec_Amnt_button",
            "Spread_1_Rel_Spd_button",
            "Spread_2_Rec_Amnt_button",
            "Spread_2_Rel_Spd_button",
            "Spread_3_Rec_Amnt_button",
            "Spread_3_Rel_Spd_button",
            "Sticky_1_Rec_Amnt_button",
            "Sticky_1_Rel_Spd_button",
            "Sticky_2_Rec_Amnt_button",
            "Sticky_2_Rel_Spd_button",
            "Sticky_3_Rec_Amnt_button",
            "Sticky_3_Rel_Spd_button",
            "Thunder_Rec_Amnt_button",
            "Thunder_Rel_Spd_button",
            "Tranq_Rec_Amnt_button",
            "Tranq_Rel_Spd_button",
            "Unknown_1_Rec_Amnt_button",
            "Unknown_1_Rel_Spd_button",
            "Unknown_2_Rec_Amnt_button",
            "Unknown_2_Rel_Spd_button",
            "Unlock_Skill_1_button",
            "Unlock_Skill_2_button",
            "Unlock_Skill_3_button",
            "Unlock_Skill_4_button",
            "Unlock_Skill_5_button",
            "Unlock_Skill_6_button",
            "Water_Rec_Amnt_button",
            "Water_Rel_Spd_button",
            "Weapon_Id_button",
            "weaponId_button",
            "Wyvern_Rec_Amnt_button",
            "Wyvern_Rel_Spd_button",
        };

        public static readonly Dictionary<Type, List<string>> TYPE_AND_NAME = new Dictionary<Type, List<string>> {
            {typeof(MHW_Editor.Structs.Items.TimeGate.Models.Armor), new List<string> {
                "armorId",
            }},
            {typeof(MHW_Editor.Structs.Items.TimeGate.Models.Pendant), new List<string> {
                "pendantId",
            }},
            {typeof(MHW_Editor.Structs.Items.TimeGate.Models.ItemTg), new List<string> {
                "itemId",
            }},
            {typeof(MHW_Editor.Structs.Items.TimeGate.Models.Weapon), new List<string> {
                "weaponId",
            }},
            {typeof(MHW_Editor.Structs.Weapons.ArenaEquipment.Entries), new List<string> {
                "Weapon_Id",
            }},
            {typeof(MHW_Editor.Structs.Weapons.AwakenedLimitBreak.Entries), new List<string> {
                "Skill_Id",
            }},
            {typeof(MHW_Editor.Structs.Weapons.CustomOuterRecipe.Entries), new List<string> {
                "Needed_Item_Id_to_Unlock",
                "Mat_1_Id",
                "Mat_2_Id",
                "Mat_3_Id",
                "Mat_4_Id",
            }},
            {typeof(MHW_Editor.Structs.Weapons.CustomOuterWeapon.Entries), new List<string> {
                "Weapon_Id",
            }},
            {typeof(MHW_Editor.Structs.Weapons.CustomPartsR.Entries), new List<string> {
                "Needed_Item_Id_to_Unlock",
                "Mat_1_Id",
                "Mat_2_Id",
                "Mat_3_Id",
                "Mat_4_Id",
            }},
            {typeof(MHW_Editor.Structs.Weapons.GunnerReload.Entries), new List<string> {
                "No_Mods",
                "Mod_1",
                "Mod_2",
                "Mod_3",
                "Mod_4",
            }},
            {typeof(MHW_Editor.Structs.Weapons.GunnerShoot.Entries), new List<string> {
                "No_Mods",
                "Mod_1",
                "Mod_2",
                "Mod_3",
                "Mod_4",
            }},
            {typeof(MHW_Editor.Structs.Weapons.LimitBreakMaterialBase.Entries), new List<string> {
                "Item_1_Id",
                "Item_2_Id",
            }},
            {typeof(MHW_Editor.Structs.Weapons.LimitBreakMaterialSkill.Entries), new List<string> {
                "Item_1_Id",
            }},
            {typeof(MHW_Editor.Structs.Weapons.Melee.Entries), new List<string> {
                "Skill",
            }},
            {typeof(MHW_Editor.Structs.Weapons.NewLimitBreakR.Entries), new List<string> {
                "Needed_Item_Id_to_Unlock",
                "Mat_1_Id",
                "Mat_2_Id",
                "Mat_3_Id",
                "Mat_4_Id",
            }},
            {typeof(MHW_Editor.Structs.Weapons.Ranged.Entries), new List<string> {
                "Skill",
            }},
            {typeof(MHW_Editor.Structs.Weapons.ShellTable.Entries), new List<string> {
                "Normal_1_Rec_Amnt",
                "Normal_1_Rel_Spd",
                "Normal_2_Rec_Amnt",
                "Normal_2_Rel_Spd",
                "Normal_3_Rec_Amnt",
                "Normal_3_Rel_Spd",
                "Pierce_1_Rec_Amnt",
                "Pierce_1_Rel_Spd",
                "Pierce_2_Rec_Amnt",
                "Pierce_2_Rel_Spd",
                "Pierce_3_Rec_Amnt",
                "Pierce_3_Rel_Spd",
                "Spread_1_Rec_Amnt",
                "Spread_1_Rel_Spd",
                "Spread_2_Rec_Amnt",
                "Spread_2_Rel_Spd",
                "Spread_3_Rec_Amnt",
                "Spread_3_Rel_Spd",
                "Cluster_1_Rec_Amnt",
                "Cluster_1_Rel_Spd",
                "Cluster_2_Rec_Amnt",
                "Cluster_2_Rel_Spd",
                "Cluster_3_Rec_Amnt",
                "Cluster_3_Rel_Spd",
                "Wyvern_Rec_Amnt",
                "Wyvern_Rel_Spd",
                "Sticky_1_Rec_Amnt",
                "Sticky_1_Rel_Spd",
                "Sticky_2_Rec_Amnt",
                "Sticky_2_Rel_Spd",
                "Sticky_3_Rec_Amnt",
                "Sticky_3_Rel_Spd",
                "Slicing_Rec_Amnt",
                "Slicing_Rel_Spd",
                "Flaming_Rec_Amnt",
                "Flaming_Rel_Spd",
                "Water_Rec_Amnt",
                "Water_Rel_Spd",
                "Freeze_Rec_Amnt",
                "Freeze_Rel_Spd",
                "Thunder_Rec_Amnt",
                "Thunder_Rel_Spd",
                "Dragon_Rec_Amnt",
                "Dragon_Rel_Spd",
                "Poison_1_Rec_Amnt",
                "Poison_1_Rel_Spd",
                "Poison_2_Rec_Amnt",
                "Poison_2_Rel_Spd",
                "Paralysis_1_Rec_Amnt",
                "Paralysis_1_Rel_Spd",
                "Paralysis_2_Rec_Amnt",
                "Paralysis_2_Rel_Spd",
                "Sleep_1_Rec_Amnt",
                "Sleep_1_Rel_Spd",
                "Sleep_2_Rec_Amnt",
                "Sleep_2_Rel_Spd",
                "Exhaust_1_Rec_Amnt",
                "Exhaust_1_Rel_Spd",
                "Exhaust_2_Rec_Amnt",
                "Exhaust_2_Rel_Spd",
                "Recover_1_Rec_Amnt",
                "Recover_1_Rel_Spd",
                "Recover_2_Rec_Amnt",
                "Recover_2_Rel_Spd",
                "Demon_Rec_Amnt",
                "Demon_Rel_Spd",
                "Armor_Rec_Amnt",
                "Armor_Rel_Spd",
                "Unknown_1_Rec_Amnt",
                "Unknown_1_Rel_Spd",
                "Unknown_2_Rec_Amnt",
                "Unknown_2_Rel_Spd",
                "Tranq_Rec_Amnt",
                "Tranq_Rel_Spd",
            }},
            {typeof(MHW_Editor.Structs.Skills.SkillDat.Entries), new List<string> {
                "Id",
                "Unlock_Skill_1",
                "Unlock_Skill_2",
                "Unlock_Skill_3",
                "Unlock_Skill_4",
                "Unlock_Skill_5",
                "Unlock_Skill_6",
            }},
            {typeof(MHW_Editor.Structs.Monsters.MonsterDamageAttributes.Monster_Damage_Attributes_1_), new List<string> {
                "Monster_Id",
            }},
            {typeof(MHW_Editor.Structs.Monsters.MonsterEnrage.Monster_Rage), new List<string> {
                "Monster_Id",
            }},
            {typeof(MHW_Editor.Structs.Monsters.MonsterParts.Monster_Parts), new List<string> {
                "Monster_Id",
            }},
            {typeof(MHW_Editor.Structs.Monsters.MonsterRandomSize.Monsters), new List<string> {
                "Monster_Id",
            }},
            {typeof(MHW_Editor.Structs.Monsters.MonsterStamina.Monster_Stamina_1_), new List<string> {
                "Monster_Id",
            }},
            {typeof(MHW_Editor.Structs.Monsters.SmallMonsterSizeParams.Size_Settings), new List<string> {
                "Monster_Id",
            }},
            {typeof(MHW_Editor.Structs.Items.Bounty.Entries), new List<string> {
                "Item_Id_1",
                "Item_Id_2",
                "Item_Id_3",
            }},
            {typeof(MHW_Editor.Structs.Items.EqCrt.Entries), new List<string> {
                "Needed_Item_Id_to_Unlock",
                "Monster_Unlock",
                "Mat_1_Id",
                "Mat_2_Id",
                "Mat_3_Id",
                "Mat_4_Id",
                "Equipment_Index_Armor",
                "Equipment_Index_Weapon",
            }},
            {typeof(MHW_Editor.Structs.Items.EqCus.Entries), new List<string> {
                "Needed_Item_Id_to_Unlock",
                "Monster_Unlock",
                "Mat_1_Id",
                "Mat_2_Id",
                "Mat_3_Id",
                "Mat_4_Id",
                "Equipment_Index_Armor",
                "Equipment_Index_Weapon",
            }},
            {typeof(MHW_Editor.Structs.Items.ItemDelivery.Entries), new List<string> {
                "Decoration_Reward",
                "Item_1_Id",
                "Item_2_Id",
            }},
            {typeof(MHW_Editor.Structs.Items.ItemList.Entries), new List<string> {
                "Item_Id",
            }},
            {typeof(MHW_Editor.Structs.Items.ItemLottery.InnerItem), new List<string> {
                "itemId",
            }},
            {typeof(MHW_Editor.Structs.Items.ItemMake.Entries), new List<string> {
                "Mat_1_Id",
                "Mat_2_Id",
                "Result_Id",
            }},
            {typeof(MHW_Editor.Structs.Items.KulveGradeLottery.Entries), new List<string> {
                "Item_Id",
            }},
            {typeof(MHW_Editor.Structs.Items.KulveItemLottery.Entries), new List<string> {
                "Weapon_Id",
            }},
            {typeof(MHW_Editor.Structs.Items.MelderExchange.Item_Box), new List<string> {
                "Source_Item_Id",
            }},
            {typeof(MHW_Editor.Structs.Items.MelderItem.Entries), new List<string> {
                "Result_Item_Id",
            }},
            {typeof(MHW_Editor.Structs.Items.PlantItem.Entries), new List<string> {
                "Item",
            }},
            {typeof(MHW_Editor.Structs.Items.QuestReward.Items), new List<string> {
                "Item_Id",
            }},
            {typeof(MHW_Editor.Structs.Items.QuestReward.QuestRewardCustomView), new List<string> {
                "Item_Id",
            }},
            {typeof(MHW_Editor.Structs.Items.RoomAnimal.Entries), new List<string> {
                "Item_Id",
            }},
            {typeof(MHW_Editor.Structs.Items.RoomFurniture.Entries), new List<string> {
                "Item_Id",
            }},
            {typeof(MHW_Editor.Structs.Items.SafiItemGradeLottery.Entries), new List<string> {
                "Item_Id",
            }},
            {typeof(MHW_Editor.Structs.Items.SafiItemLottery.Entries), new List<string> {
                "Weapon_Id",
            }},
            {typeof(MHW_Editor.Structs.Items.ShopList.Entries), new List<string> {
                "Item_Id",
            }},
            {typeof(MHW_Editor.Structs.Items.ShopSed.Entries), new List<string> {
                "Equip_Id",
            }},
            {typeof(MHW_Editor.Structs.Items.SteamRewardList.Entries), new List<string> {
                "Item_Id",
            }},
            {typeof(MHW_Editor.Structs.Items.SupplyData.Item_Box), new List<string> {
                "Item_Id",
            }},
            {typeof(MHW_Editor.Structs.Items.SupplyData.Ammo_Box), new List<string> {
                "Ammo_Id",
            }},
            {typeof(MHW_Editor.Structs.Items.SwapItem.Entries), new List<string> {
                "Item_Id",
            }},
            {typeof(MHW_Editor.Structs.Items.SwapN.Entries), new List<string> {
                "Item_Id",
            }},
            {typeof(MHW_Editor.Structs.Items.Treasure.Entries), new List<string> {
                "Item_Id",
            }},
            {typeof(MHW_Editor.Structs.Items.ValueTrader.Entries), new List<string> {
                "Item_Id",
            }},
            {typeof(MHW_Editor.Structs.GuildCard.GcData.Entries), new List<string> {
                "Monster_Id",
            }},
            {typeof(MHW_Editor.Structs.Gems.DecoGradeLottery.Entries), new List<string> {
                "Item_Id",
            }},
            {typeof(MHW_Editor.Structs.Gems.DecoLottery.Entries), new List<string> {
                "Item_Id",
            }},
            {typeof(MHW_Editor.Structs.Gems.Gem.Entries), new List<string> {
                "Id",
                "Skill_1",
                "Skill_2",
            }},
            {typeof(MHW_Editor.Structs.Armors.Armor.Entries), new List<string> {
                "Set_Skill_1",
                "Hidden_Skill",
                "Skill_1",
                "Skill_2",
                "Skill_3",
            }},
            {typeof(MHW_Editor.Structs.Armors.ASkill.Entries), new List<string> {
                "Mantle_Item_Id",
            }},
            {typeof(MHW_Editor.Structs.Weapons.ArenaEquipment.Entries.Armors), new List<string> {
                "Armor_Id",
            }},
            {typeof(MHW_Editor.Structs.Weapons.ArenaEquipment.Entries.Mantles), new List<string> {
                "Mantle_Id",
            }},
            {typeof(MHW_Editor.Structs.Weapons.ArenaEquipment.Entries.Decorations), new List<string> {
                "Deco_1",
                "Deco_2",
                "Deco_3",
            }},
            {typeof(MHW_Editor.Structs.Weapons.ArenaEquipment.Entries.Items), new List<string> {
                "Item_Id",
            }},
            {typeof(MHW_Editor.Structs.Weapons.ArenaEquipment.Entries.Ammo), new List<string> {
                "Ammo_Id",
            }},
            {typeof(MHW_Editor.Structs.Items.ItemLottery.Entries.Items), new List<string> {
                "Item_Id",
            }},
            {typeof(MHW_Editor.Structs.Items.MelderExchange.Item_Box.Items), new List<string> {
                "Item_Id",
            }},
        };
    }
}