using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using MHW_Editor.Assets;
using MHW_Editor.Controls.Models;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Structs.Weapons {
    public partial class Wp09Param {
        public override string EncryptionKey => "j1P15gEkgVa7NdFxiqwCPitykHctY2nZPjSaElvqb0eSwcLO1cOlTqqv";

        public partial class W09p_Params_1_Shared_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W09p Params (1, Shared)";

            protected char[] Weapon_raw;
            public const string Weapon_displayName = "Weapon";
            public const int Weapon_sortIndex = 50;
            [SortOrder(Weapon_sortIndex)]
            [DisplayName(Weapon_displayName)]
            [IsReadOnly]
            public virtual string Weapon {
                get => (string) new string(Weapon_raw);
                set {
                    if ((string) new string(Weapon_raw) == value) return;
                    Weapon_raw = (char[]) value.ToCharArray(0, 3);
                    ChangedItems.Add(nameof(Weapon));
                    OnPropertyChanged(nameof(Weapon));
                }
            }

            [DisplayName("Offset")]
            public long Weapon_offset { get; private set; }

            protected uint Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 100;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            public virtual uint Unk_1 {
                get => Unk_1_raw;
                set {
                    if (Unk_1_raw == value) return;
                    Unk_1_raw = value;
                    ChangedItems.Add(nameof(Unk_1));
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

            [DisplayName("Offset")]
            public long Unk_1_offset { get; private set; }

            public const int lastSortIndex = 150;

            public static ObservableMhwStructCollection<W09p_Params_1_Shared_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W09p_Params_1_Shared_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W09p_Params_1_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new W09p_Params_1_Shared_();
                data.Index = i;
                data.Weapon_offset = reader.BaseStream.Position;
                data.Weapon_raw = reader.ReadChars(4);
                data.Unk_1_offset = reader.BaseStream.Position;
                data.Unk_1_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Weapon_raw);
                writer.Write(Unk_1_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Weapon", "Weapon", "Weapon_offset"),
                    new MultiStructItemCustomView(this, "Unk 1", "Unk_1", "Unk_1_offset"),
                };
            }
        }

        public partial class Unk_Arr_1_Shared_ : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 20;
            public const string GridName = "Unk Arr 1 (Shared)";

            protected float Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 50;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            public virtual float Unk_1 {
                get => Unk_1_raw;
                set {
                    if (Unk_1_raw == value) return;
                    Unk_1_raw = value;
                    ChangedItems.Add(nameof(Unk_1));
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

            protected float Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 100;
            [SortOrder(Unk_2_sortIndex)]
            [DisplayName(Unk_2_displayName)]
            public virtual float Unk_2 {
                get => Unk_2_raw;
                set {
                    if (Unk_2_raw == value) return;
                    Unk_2_raw = value;
                    ChangedItems.Add(nameof(Unk_2));
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            protected float Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 150;
            [SortOrder(Unk_3_sortIndex)]
            [DisplayName(Unk_3_displayName)]
            public virtual float Unk_3 {
                get => Unk_3_raw;
                set {
                    if (Unk_3_raw == value) return;
                    Unk_3_raw = value;
                    ChangedItems.Add(nameof(Unk_3));
                    OnPropertyChanged(nameof(Unk_3));
                }
            }

            protected byte Unk_4_raw;
            public const string Unk_4_displayName = "Unk 4";
            public const int Unk_4_sortIndex = 200;
            [SortOrder(Unk_4_sortIndex)]
            [DisplayName(Unk_4_displayName)]
            public virtual bool Unk_4 {
                get => (bool) Convert.ToBoolean(Unk_4_raw);
                set {
                    if (Convert.ToBoolean(Unk_4_raw) == value) return;
                    Unk_4_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Unk_4));
                    OnPropertyChanged(nameof(Unk_4));
                }
            }

            protected float Unk_5_raw;
            public const string Unk_5_displayName = "Unk 5";
            public const int Unk_5_sortIndex = 250;
            [SortOrder(Unk_5_sortIndex)]
            [DisplayName(Unk_5_displayName)]
            public virtual float Unk_5 {
                get => Unk_5_raw;
                set {
                    if (Unk_5_raw == value) return;
                    Unk_5_raw = value;
                    ChangedItems.Add(nameof(Unk_5));
                    OnPropertyChanged(nameof(Unk_5));
                }
            }

            public const int lastSortIndex = 300;

            public static ObservableMhwStructCollection<Unk_Arr_1_Shared_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Unk_Arr_1_Shared_>();
                const ulong count = 20UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Unk_Arr_1_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new Unk_Arr_1_Shared_();
                data.Index = i;
                data.Unk_1_raw = reader.ReadSingle();
                data.Unk_2_raw = reader.ReadSingle();
                data.Unk_3_raw = reader.ReadSingle();
                data.Unk_4_raw = reader.ReadByte();
                data.Unk_5_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
                writer.Write(Unk_3_raw);
                writer.Write(Unk_4_raw);
                writer.Write(Unk_5_raw);
            }
        }

        public partial class W09p_Params_2_Shared_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W09p Params (2, Shared)";

            protected float Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 50;
            [SortOrder(Unk_2_sortIndex)]
            [DisplayName(Unk_2_displayName)]
            public virtual float Unk_2 {
                get => Unk_2_raw;
                set {
                    if (Unk_2_raw == value) return;
                    Unk_2_raw = value;
                    ChangedItems.Add(nameof(Unk_2));
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            [DisplayName("Offset")]
            public long Unk_2_offset { get; private set; }

            protected float Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 100;
            [SortOrder(Unk_3_sortIndex)]
            [DisplayName(Unk_3_displayName)]
            public virtual float Unk_3 {
                get => Unk_3_raw;
                set {
                    if (Unk_3_raw == value) return;
                    Unk_3_raw = value;
                    ChangedItems.Add(nameof(Unk_3));
                    OnPropertyChanged(nameof(Unk_3));
                }
            }

            [DisplayName("Offset")]
            public long Unk_3_offset { get; private set; }

            protected float Unk_4_raw;
            public const string Unk_4_displayName = "Unk 4";
            public const int Unk_4_sortIndex = 150;
            [SortOrder(Unk_4_sortIndex)]
            [DisplayName(Unk_4_displayName)]
            public virtual float Unk_4 {
                get => Unk_4_raw;
                set {
                    if (Unk_4_raw == value) return;
                    Unk_4_raw = value;
                    ChangedItems.Add(nameof(Unk_4));
                    OnPropertyChanged(nameof(Unk_4));
                }
            }

            [DisplayName("Offset")]
            public long Unk_4_offset { get; private set; }

            protected float Unk_5_raw;
            public const string Unk_5_displayName = "Unk 5";
            public const int Unk_5_sortIndex = 200;
            [SortOrder(Unk_5_sortIndex)]
            [DisplayName(Unk_5_displayName)]
            public virtual float Unk_5 {
                get => Unk_5_raw;
                set {
                    if (Unk_5_raw == value) return;
                    Unk_5_raw = value;
                    ChangedItems.Add(nameof(Unk_5));
                    OnPropertyChanged(nameof(Unk_5));
                }
            }

            [DisplayName("Offset")]
            public long Unk_5_offset { get; private set; }

            protected float Unk_6_raw;
            public const string Unk_6_displayName = "Unk 6";
            public const int Unk_6_sortIndex = 250;
            [SortOrder(Unk_6_sortIndex)]
            [DisplayName(Unk_6_displayName)]
            public virtual float Unk_6 {
                get => Unk_6_raw;
                set {
                    if (Unk_6_raw == value) return;
                    Unk_6_raw = value;
                    ChangedItems.Add(nameof(Unk_6));
                    OnPropertyChanged(nameof(Unk_6));
                }
            }

            [DisplayName("Offset")]
            public long Unk_6_offset { get; private set; }

            protected float Unk_7_raw;
            public const string Unk_7_displayName = "Unk 7";
            public const int Unk_7_sortIndex = 300;
            [SortOrder(Unk_7_sortIndex)]
            [DisplayName(Unk_7_displayName)]
            public virtual float Unk_7 {
                get => Unk_7_raw;
                set {
                    if (Unk_7_raw == value) return;
                    Unk_7_raw = value;
                    ChangedItems.Add(nameof(Unk_7));
                    OnPropertyChanged(nameof(Unk_7));
                }
            }

            [DisplayName("Offset")]
            public long Unk_7_offset { get; private set; }

            protected float Unk_8_raw;
            public const string Unk_8_displayName = "Unk 8";
            public const int Unk_8_sortIndex = 350;
            [SortOrder(Unk_8_sortIndex)]
            [DisplayName(Unk_8_displayName)]
            public virtual float Unk_8 {
                get => Unk_8_raw;
                set {
                    if (Unk_8_raw == value) return;
                    Unk_8_raw = value;
                    ChangedItems.Add(nameof(Unk_8));
                    OnPropertyChanged(nameof(Unk_8));
                }
            }

            [DisplayName("Offset")]
            public long Unk_8_offset { get; private set; }

            protected float Unk_9_raw;
            public const string Unk_9_displayName = "Unk 9";
            public const int Unk_9_sortIndex = 400;
            [SortOrder(Unk_9_sortIndex)]
            [DisplayName(Unk_9_displayName)]
            public virtual float Unk_9 {
                get => Unk_9_raw;
                set {
                    if (Unk_9_raw == value) return;
                    Unk_9_raw = value;
                    ChangedItems.Add(nameof(Unk_9));
                    OnPropertyChanged(nameof(Unk_9));
                }
            }

            [DisplayName("Offset")]
            public long Unk_9_offset { get; private set; }

            protected float Unk_10_raw;
            public const string Unk_10_displayName = "Unk 10";
            public const int Unk_10_sortIndex = 450;
            [SortOrder(Unk_10_sortIndex)]
            [DisplayName(Unk_10_displayName)]
            public virtual float Unk_10 {
                get => Unk_10_raw;
                set {
                    if (Unk_10_raw == value) return;
                    Unk_10_raw = value;
                    ChangedItems.Add(nameof(Unk_10));
                    OnPropertyChanged(nameof(Unk_10));
                }
            }

            [DisplayName("Offset")]
            public long Unk_10_offset { get; private set; }

            protected float Unk_11_raw;
            public const string Unk_11_displayName = "Unk 11";
            public const int Unk_11_sortIndex = 500;
            [SortOrder(Unk_11_sortIndex)]
            [DisplayName(Unk_11_displayName)]
            public virtual float Unk_11 {
                get => Unk_11_raw;
                set {
                    if (Unk_11_raw == value) return;
                    Unk_11_raw = value;
                    ChangedItems.Add(nameof(Unk_11));
                    OnPropertyChanged(nameof(Unk_11));
                }
            }

            [DisplayName("Offset")]
            public long Unk_11_offset { get; private set; }

            protected float Unk_12_raw;
            public const string Unk_12_displayName = "Unk 12";
            public const int Unk_12_sortIndex = 550;
            [SortOrder(Unk_12_sortIndex)]
            [DisplayName(Unk_12_displayName)]
            public virtual float Unk_12 {
                get => Unk_12_raw;
                set {
                    if (Unk_12_raw == value) return;
                    Unk_12_raw = value;
                    ChangedItems.Add(nameof(Unk_12));
                    OnPropertyChanged(nameof(Unk_12));
                }
            }

            [DisplayName("Offset")]
            public long Unk_12_offset { get; private set; }

            protected float Unk_13_raw;
            public const string Unk_13_displayName = "Unk 13";
            public const int Unk_13_sortIndex = 600;
            [SortOrder(Unk_13_sortIndex)]
            [DisplayName(Unk_13_displayName)]
            public virtual float Unk_13 {
                get => Unk_13_raw;
                set {
                    if (Unk_13_raw == value) return;
                    Unk_13_raw = value;
                    ChangedItems.Add(nameof(Unk_13));
                    OnPropertyChanged(nameof(Unk_13));
                }
            }

            [DisplayName("Offset")]
            public long Unk_13_offset { get; private set; }

            protected float Unk_14_raw;
            public const string Unk_14_displayName = "Unk 14";
            public const int Unk_14_sortIndex = 650;
            [SortOrder(Unk_14_sortIndex)]
            [DisplayName(Unk_14_displayName)]
            public virtual float Unk_14 {
                get => Unk_14_raw;
                set {
                    if (Unk_14_raw == value) return;
                    Unk_14_raw = value;
                    ChangedItems.Add(nameof(Unk_14));
                    OnPropertyChanged(nameof(Unk_14));
                }
            }

            [DisplayName("Offset")]
            public long Unk_14_offset { get; private set; }

            protected float Unk_15_raw;
            public const string Unk_15_displayName = "Unk 15";
            public const int Unk_15_sortIndex = 700;
            [SortOrder(Unk_15_sortIndex)]
            [DisplayName(Unk_15_displayName)]
            public virtual float Unk_15 {
                get => Unk_15_raw;
                set {
                    if (Unk_15_raw == value) return;
                    Unk_15_raw = value;
                    ChangedItems.Add(nameof(Unk_15));
                    OnPropertyChanged(nameof(Unk_15));
                }
            }

            [DisplayName("Offset")]
            public long Unk_15_offset { get; private set; }

            protected float Unk_16_raw;
            public const string Unk_16_displayName = "Unk 16";
            public const int Unk_16_sortIndex = 750;
            [SortOrder(Unk_16_sortIndex)]
            [DisplayName(Unk_16_displayName)]
            public virtual float Unk_16 {
                get => Unk_16_raw;
                set {
                    if (Unk_16_raw == value) return;
                    Unk_16_raw = value;
                    ChangedItems.Add(nameof(Unk_16));
                    OnPropertyChanged(nameof(Unk_16));
                }
            }

            [DisplayName("Offset")]
            public long Unk_16_offset { get; private set; }

            protected float Unk_17_raw;
            public const string Unk_17_displayName = "Unk 17";
            public const int Unk_17_sortIndex = 800;
            [SortOrder(Unk_17_sortIndex)]
            [DisplayName(Unk_17_displayName)]
            public virtual float Unk_17 {
                get => Unk_17_raw;
                set {
                    if (Unk_17_raw == value) return;
                    Unk_17_raw = value;
                    ChangedItems.Add(nameof(Unk_17));
                    OnPropertyChanged(nameof(Unk_17));
                }
            }

            [DisplayName("Offset")]
            public long Unk_17_offset { get; private set; }

            protected byte Sharpness_Consumed_Melee_Only__raw;
            public const string Sharpness_Consumed_Melee_Only__displayName = "Sharpness Consumed (Melee Only)";
            public const int Sharpness_Consumed_Melee_Only__sortIndex = 850;
            [SortOrder(Sharpness_Consumed_Melee_Only__sortIndex)]
            [DisplayName(Sharpness_Consumed_Melee_Only__displayName)]
            public virtual byte Sharpness_Consumed_Melee_Only_ {
                get => Sharpness_Consumed_Melee_Only__raw;
                set {
                    if (Sharpness_Consumed_Melee_Only__raw == value) return;
                    Sharpness_Consumed_Melee_Only__raw = value;
                    ChangedItems.Add(nameof(Sharpness_Consumed_Melee_Only_));
                    OnPropertyChanged(nameof(Sharpness_Consumed_Melee_Only_));
                }
            }

            [DisplayName("Offset")]
            public long Sharpness_Consumed_Melee_Only__offset { get; private set; }

            protected byte Guard_Knockback_Sharpness_Usage_Small_raw;
            public const string Guard_Knockback_Sharpness_Usage_Small_displayName = "Guard Knockback Sharpness Usage: Small";
            public const int Guard_Knockback_Sharpness_Usage_Small_sortIndex = 900;
            [SortOrder(Guard_Knockback_Sharpness_Usage_Small_sortIndex)]
            [DisplayName(Guard_Knockback_Sharpness_Usage_Small_displayName)]
            public virtual byte Guard_Knockback_Sharpness_Usage_Small {
                get => Guard_Knockback_Sharpness_Usage_Small_raw;
                set {
                    if (Guard_Knockback_Sharpness_Usage_Small_raw == value) return;
                    Guard_Knockback_Sharpness_Usage_Small_raw = value;
                    ChangedItems.Add(nameof(Guard_Knockback_Sharpness_Usage_Small));
                    OnPropertyChanged(nameof(Guard_Knockback_Sharpness_Usage_Small));
                }
            }

            [DisplayName("Offset")]
            public long Guard_Knockback_Sharpness_Usage_Small_offset { get; private set; }

            protected byte Guard_Knockback_Sharpness_Usage_Medium_raw;
            public const string Guard_Knockback_Sharpness_Usage_Medium_displayName = "Guard Knockback Sharpness Usage: Medium";
            public const int Guard_Knockback_Sharpness_Usage_Medium_sortIndex = 950;
            [SortOrder(Guard_Knockback_Sharpness_Usage_Medium_sortIndex)]
            [DisplayName(Guard_Knockback_Sharpness_Usage_Medium_displayName)]
            public virtual byte Guard_Knockback_Sharpness_Usage_Medium {
                get => Guard_Knockback_Sharpness_Usage_Medium_raw;
                set {
                    if (Guard_Knockback_Sharpness_Usage_Medium_raw == value) return;
                    Guard_Knockback_Sharpness_Usage_Medium_raw = value;
                    ChangedItems.Add(nameof(Guard_Knockback_Sharpness_Usage_Medium));
                    OnPropertyChanged(nameof(Guard_Knockback_Sharpness_Usage_Medium));
                }
            }

            [DisplayName("Offset")]
            public long Guard_Knockback_Sharpness_Usage_Medium_offset { get; private set; }

            protected byte Guard_Knockback_Sharpness_Usage_Large_raw;
            public const string Guard_Knockback_Sharpness_Usage_Large_displayName = "Guard Knockback Sharpness Usage: Large";
            public const int Guard_Knockback_Sharpness_Usage_Large_sortIndex = 1000;
            [SortOrder(Guard_Knockback_Sharpness_Usage_Large_sortIndex)]
            [DisplayName(Guard_Knockback_Sharpness_Usage_Large_displayName)]
            public virtual byte Guard_Knockback_Sharpness_Usage_Large {
                get => Guard_Knockback_Sharpness_Usage_Large_raw;
                set {
                    if (Guard_Knockback_Sharpness_Usage_Large_raw == value) return;
                    Guard_Knockback_Sharpness_Usage_Large_raw = value;
                    ChangedItems.Add(nameof(Guard_Knockback_Sharpness_Usage_Large));
                    OnPropertyChanged(nameof(Guard_Knockback_Sharpness_Usage_Large));
                }
            }

            [DisplayName("Offset")]
            public long Guard_Knockback_Sharpness_Usage_Large_offset { get; private set; }

            protected float Weapon_Sweet_spot_raw;
            public const string Weapon_Sweet_spot_displayName = "Weapon Sweet-spot";
            public const int Weapon_Sweet_spot_sortIndex = 1050;
            [SortOrder(Weapon_Sweet_spot_sortIndex)]
            [DisplayName(Weapon_Sweet_spot_displayName)]
            public virtual float Weapon_Sweet_spot {
                get => Weapon_Sweet_spot_raw;
                set {
                    if (Weapon_Sweet_spot_raw == value) return;
                    Weapon_Sweet_spot_raw = value;
                    ChangedItems.Add(nameof(Weapon_Sweet_spot));
                    OnPropertyChanged(nameof(Weapon_Sweet_spot));
                }
            }

            [DisplayName("Offset")]
            public long Weapon_Sweet_spot_offset { get; private set; }

            protected float Unk_23_raw;
            public const string Unk_23_displayName = "Unk 23";
            public const int Unk_23_sortIndex = 1100;
            [SortOrder(Unk_23_sortIndex)]
            [DisplayName(Unk_23_displayName)]
            public virtual float Unk_23 {
                get => Unk_23_raw;
                set {
                    if (Unk_23_raw == value) return;
                    Unk_23_raw = value;
                    ChangedItems.Add(nameof(Unk_23));
                    OnPropertyChanged(nameof(Unk_23));
                }
            }

            [DisplayName("Offset")]
            public long Unk_23_offset { get; private set; }

            protected float Unk_24_raw;
            public const string Unk_24_displayName = "Unk 24";
            public const int Unk_24_sortIndex = 1150;
            [SortOrder(Unk_24_sortIndex)]
            [DisplayName(Unk_24_displayName)]
            public virtual float Unk_24 {
                get => Unk_24_raw;
                set {
                    if (Unk_24_raw == value) return;
                    Unk_24_raw = value;
                    ChangedItems.Add(nameof(Unk_24));
                    OnPropertyChanged(nameof(Unk_24));
                }
            }

            [DisplayName("Offset")]
            public long Unk_24_offset { get; private set; }

            protected float Elderseal_Modifier__raw;
            public const string Elderseal_Modifier__displayName = "Elderseal Modifier?";
            public const int Elderseal_Modifier__sortIndex = 1200;
            [SortOrder(Elderseal_Modifier__sortIndex)]
            [DisplayName(Elderseal_Modifier__displayName)]
            public virtual float Elderseal_Modifier_ {
                get => Elderseal_Modifier__raw;
                set {
                    if (Elderseal_Modifier__raw == value) return;
                    Elderseal_Modifier__raw = value;
                    ChangedItems.Add(nameof(Elderseal_Modifier_));
                    OnPropertyChanged(nameof(Elderseal_Modifier_));
                }
            }

            [DisplayName("Offset")]
            public long Elderseal_Modifier__offset { get; private set; }

            protected byte Limit_Until_The_Tic_Damage_Decreases_1shot_e_g_Pierce_Slice_Ammo__raw;
            public const string Limit_Until_The_Tic_Damage_Decreases_1shot_e_g_Pierce_Slice_Ammo__displayName = "Limit Until The Tic Damage Decreases 1shot (e.g. Pierce / Slice Ammo)";
            public const int Limit_Until_The_Tic_Damage_Decreases_1shot_e_g_Pierce_Slice_Ammo__sortIndex = 1250;
            [SortOrder(Limit_Until_The_Tic_Damage_Decreases_1shot_e_g_Pierce_Slice_Ammo__sortIndex)]
            [DisplayName(Limit_Until_The_Tic_Damage_Decreases_1shot_e_g_Pierce_Slice_Ammo__displayName)]
            public virtual byte Limit_Until_The_Tic_Damage_Decreases_1shot_e_g_Pierce_Slice_Ammo_ {
                get => Limit_Until_The_Tic_Damage_Decreases_1shot_e_g_Pierce_Slice_Ammo__raw;
                set {
                    if (Limit_Until_The_Tic_Damage_Decreases_1shot_e_g_Pierce_Slice_Ammo__raw == value) return;
                    Limit_Until_The_Tic_Damage_Decreases_1shot_e_g_Pierce_Slice_Ammo__raw = value;
                    ChangedItems.Add(nameof(Limit_Until_The_Tic_Damage_Decreases_1shot_e_g_Pierce_Slice_Ammo_));
                    OnPropertyChanged(nameof(Limit_Until_The_Tic_Damage_Decreases_1shot_e_g_Pierce_Slice_Ammo_));
                }
            }

            [DisplayName("Offset")]
            public long Limit_Until_The_Tic_Damage_Decreases_1shot_e_g_Pierce_Slice_Ammo__offset { get; private set; }

            protected float Decreases_Tic_Damage_Over_The_Limit_raw;
            public const string Decreases_Tic_Damage_Over_The_Limit_displayName = "Decreases Tic Damage Over The Limit";
            public const int Decreases_Tic_Damage_Over_The_Limit_sortIndex = 1300;
            [SortOrder(Decreases_Tic_Damage_Over_The_Limit_sortIndex)]
            [DisplayName(Decreases_Tic_Damage_Over_The_Limit_displayName)]
            public virtual float Decreases_Tic_Damage_Over_The_Limit {
                get => Decreases_Tic_Damage_Over_The_Limit_raw;
                set {
                    if (Decreases_Tic_Damage_Over_The_Limit_raw == value) return;
                    Decreases_Tic_Damage_Over_The_Limit_raw = value;
                    ChangedItems.Add(nameof(Decreases_Tic_Damage_Over_The_Limit));
                    OnPropertyChanged(nameof(Decreases_Tic_Damage_Over_The_Limit));
                }
            }

            [DisplayName("Offset")]
            public long Decreases_Tic_Damage_Over_The_Limit_offset { get; private set; }

            public const int lastSortIndex = 1350;

            public static ObservableMhwStructCollection<W09p_Params_2_Shared_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W09p_Params_2_Shared_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W09p_Params_2_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new W09p_Params_2_Shared_();
                data.Index = i;
                data.Unk_2_offset = reader.BaseStream.Position;
                data.Unk_2_raw = reader.ReadSingle();
                data.Unk_3_offset = reader.BaseStream.Position;
                data.Unk_3_raw = reader.ReadSingle();
                data.Unk_4_offset = reader.BaseStream.Position;
                data.Unk_4_raw = reader.ReadSingle();
                data.Unk_5_offset = reader.BaseStream.Position;
                data.Unk_5_raw = reader.ReadSingle();
                data.Unk_6_offset = reader.BaseStream.Position;
                data.Unk_6_raw = reader.ReadSingle();
                data.Unk_7_offset = reader.BaseStream.Position;
                data.Unk_7_raw = reader.ReadSingle();
                data.Unk_8_offset = reader.BaseStream.Position;
                data.Unk_8_raw = reader.ReadSingle();
                data.Unk_9_offset = reader.BaseStream.Position;
                data.Unk_9_raw = reader.ReadSingle();
                data.Unk_10_offset = reader.BaseStream.Position;
                data.Unk_10_raw = reader.ReadSingle();
                data.Unk_11_offset = reader.BaseStream.Position;
                data.Unk_11_raw = reader.ReadSingle();
                data.Unk_12_offset = reader.BaseStream.Position;
                data.Unk_12_raw = reader.ReadSingle();
                data.Unk_13_offset = reader.BaseStream.Position;
                data.Unk_13_raw = reader.ReadSingle();
                data.Unk_14_offset = reader.BaseStream.Position;
                data.Unk_14_raw = reader.ReadSingle();
                data.Unk_15_offset = reader.BaseStream.Position;
                data.Unk_15_raw = reader.ReadSingle();
                data.Unk_16_offset = reader.BaseStream.Position;
                data.Unk_16_raw = reader.ReadSingle();
                data.Unk_17_offset = reader.BaseStream.Position;
                data.Unk_17_raw = reader.ReadSingle();
                data.Sharpness_Consumed_Melee_Only__offset = reader.BaseStream.Position;
                data.Sharpness_Consumed_Melee_Only__raw = reader.ReadByte();
                data.Guard_Knockback_Sharpness_Usage_Small_offset = reader.BaseStream.Position;
                data.Guard_Knockback_Sharpness_Usage_Small_raw = reader.ReadByte();
                data.Guard_Knockback_Sharpness_Usage_Medium_offset = reader.BaseStream.Position;
                data.Guard_Knockback_Sharpness_Usage_Medium_raw = reader.ReadByte();
                data.Guard_Knockback_Sharpness_Usage_Large_offset = reader.BaseStream.Position;
                data.Guard_Knockback_Sharpness_Usage_Large_raw = reader.ReadByte();
                data.Weapon_Sweet_spot_offset = reader.BaseStream.Position;
                data.Weapon_Sweet_spot_raw = reader.ReadSingle();
                data.Unk_23_offset = reader.BaseStream.Position;
                data.Unk_23_raw = reader.ReadSingle();
                data.Unk_24_offset = reader.BaseStream.Position;
                data.Unk_24_raw = reader.ReadSingle();
                data.Elderseal_Modifier__offset = reader.BaseStream.Position;
                data.Elderseal_Modifier__raw = reader.ReadSingle();
                data.Limit_Until_The_Tic_Damage_Decreases_1shot_e_g_Pierce_Slice_Ammo__offset = reader.BaseStream.Position;
                data.Limit_Until_The_Tic_Damage_Decreases_1shot_e_g_Pierce_Slice_Ammo__raw = reader.ReadByte();
                data.Decreases_Tic_Damage_Over_The_Limit_offset = reader.BaseStream.Position;
                data.Decreases_Tic_Damage_Over_The_Limit_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_2_raw);
                writer.Write(Unk_3_raw);
                writer.Write(Unk_4_raw);
                writer.Write(Unk_5_raw);
                writer.Write(Unk_6_raw);
                writer.Write(Unk_7_raw);
                writer.Write(Unk_8_raw);
                writer.Write(Unk_9_raw);
                writer.Write(Unk_10_raw);
                writer.Write(Unk_11_raw);
                writer.Write(Unk_12_raw);
                writer.Write(Unk_13_raw);
                writer.Write(Unk_14_raw);
                writer.Write(Unk_15_raw);
                writer.Write(Unk_16_raw);
                writer.Write(Unk_17_raw);
                writer.Write(Sharpness_Consumed_Melee_Only__raw);
                writer.Write(Guard_Knockback_Sharpness_Usage_Small_raw);
                writer.Write(Guard_Knockback_Sharpness_Usage_Medium_raw);
                writer.Write(Guard_Knockback_Sharpness_Usage_Large_raw);
                writer.Write(Weapon_Sweet_spot_raw);
                writer.Write(Unk_23_raw);
                writer.Write(Unk_24_raw);
                writer.Write(Elderseal_Modifier__raw);
                writer.Write(Limit_Until_The_Tic_Damage_Decreases_1shot_e_g_Pierce_Slice_Ammo__raw);
                writer.Write(Decreases_Tic_Damage_Over_The_Limit_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 2", "Unk_2", "Unk_2_offset"),
                    new MultiStructItemCustomView(this, "Unk 3", "Unk_3", "Unk_3_offset"),
                    new MultiStructItemCustomView(this, "Unk 4", "Unk_4", "Unk_4_offset"),
                    new MultiStructItemCustomView(this, "Unk 5", "Unk_5", "Unk_5_offset"),
                    new MultiStructItemCustomView(this, "Unk 6", "Unk_6", "Unk_6_offset"),
                    new MultiStructItemCustomView(this, "Unk 7", "Unk_7", "Unk_7_offset"),
                    new MultiStructItemCustomView(this, "Unk 8", "Unk_8", "Unk_8_offset"),
                    new MultiStructItemCustomView(this, "Unk 9", "Unk_9", "Unk_9_offset"),
                    new MultiStructItemCustomView(this, "Unk 10", "Unk_10", "Unk_10_offset"),
                    new MultiStructItemCustomView(this, "Unk 11", "Unk_11", "Unk_11_offset"),
                    new MultiStructItemCustomView(this, "Unk 12", "Unk_12", "Unk_12_offset"),
                    new MultiStructItemCustomView(this, "Unk 13", "Unk_13", "Unk_13_offset"),
                    new MultiStructItemCustomView(this, "Unk 14", "Unk_14", "Unk_14_offset"),
                    new MultiStructItemCustomView(this, "Unk 15", "Unk_15", "Unk_15_offset"),
                    new MultiStructItemCustomView(this, "Unk 16", "Unk_16", "Unk_16_offset"),
                    new MultiStructItemCustomView(this, "Unk 17", "Unk_17", "Unk_17_offset"),
                    new MultiStructItemCustomView(this, "Sharpness Consumed (Melee Only)", "Sharpness_Consumed_Melee_Only_", "Sharpness_Consumed_Melee_Only__offset"),
                    new MultiStructItemCustomView(this, "Guard Knockback Sharpness Usage: Small", "Guard_Knockback_Sharpness_Usage_Small", "Guard_Knockback_Sharpness_Usage_Small_offset"),
                    new MultiStructItemCustomView(this, "Guard Knockback Sharpness Usage: Medium", "Guard_Knockback_Sharpness_Usage_Medium", "Guard_Knockback_Sharpness_Usage_Medium_offset"),
                    new MultiStructItemCustomView(this, "Guard Knockback Sharpness Usage: Large", "Guard_Knockback_Sharpness_Usage_Large", "Guard_Knockback_Sharpness_Usage_Large_offset"),
                    new MultiStructItemCustomView(this, "Weapon Sweet-spot", "Weapon_Sweet_spot", "Weapon_Sweet_spot_offset"),
                    new MultiStructItemCustomView(this, "Unk 23", "Unk_23", "Unk_23_offset"),
                    new MultiStructItemCustomView(this, "Unk 24", "Unk_24", "Unk_24_offset"),
                    new MultiStructItemCustomView(this, "Elderseal Modifier?", "Elderseal_Modifier_", "Elderseal_Modifier__offset"),
                    new MultiStructItemCustomView(this, "Limit Until The Tic Damage Decreases 1shot (e.g. Pierce / Slice Ammo)", "Limit_Until_The_Tic_Damage_Decreases_1shot_e_g_Pierce_Slice_Ammo_", "Limit_Until_The_Tic_Damage_Decreases_1shot_e_g_Pierce_Slice_Ammo__offset"),
                    new MultiStructItemCustomView(this, "Decreases Tic Damage Over The Limit", "Decreases_Tic_Damage_Over_The_Limit", "Decreases_Tic_Damage_Over_The_Limit_offset"),
                };
            }
        }

        public partial class Guard_Angles_Shared_ : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 2;
            public const string GridName = "Guard Angles (Shared)";

            protected float Guard_Angle_Both_Sides__raw;
            public const string Guard_Angle_Both_Sides__displayName = "Guard Angle (Both Sides)";
            public const int Guard_Angle_Both_Sides__sortIndex = 50;
            [SortOrder(Guard_Angle_Both_Sides__sortIndex)]
            [DisplayName(Guard_Angle_Both_Sides__displayName)]
            public virtual float Guard_Angle_Both_Sides_ {
                get => Guard_Angle_Both_Sides__raw;
                set {
                    if (Guard_Angle_Both_Sides__raw == value) return;
                    Guard_Angle_Both_Sides__raw = value;
                    ChangedItems.Add(nameof(Guard_Angle_Both_Sides_));
                    OnPropertyChanged(nameof(Guard_Angle_Both_Sides_));
                }
            }

            protected byte Knockback_Threshold_Small_raw;
            public const string Knockback_Threshold_Small_displayName = "Knockback Threshold Small";
            public const int Knockback_Threshold_Small_sortIndex = 100;
            [SortOrder(Knockback_Threshold_Small_sortIndex)]
            [DisplayName(Knockback_Threshold_Small_displayName)]
            public virtual byte Knockback_Threshold_Small {
                get => Knockback_Threshold_Small_raw;
                set {
                    if (Knockback_Threshold_Small_raw == value) return;
                    Knockback_Threshold_Small_raw = value;
                    ChangedItems.Add(nameof(Knockback_Threshold_Small));
                    OnPropertyChanged(nameof(Knockback_Threshold_Small));
                }
            }

            protected byte Knockback_Threshold_Medium_raw;
            public const string Knockback_Threshold_Medium_displayName = "Knockback Threshold Medium";
            public const int Knockback_Threshold_Medium_sortIndex = 150;
            [SortOrder(Knockback_Threshold_Medium_sortIndex)]
            [DisplayName(Knockback_Threshold_Medium_displayName)]
            public virtual byte Knockback_Threshold_Medium {
                get => Knockback_Threshold_Medium_raw;
                set {
                    if (Knockback_Threshold_Medium_raw == value) return;
                    Knockback_Threshold_Medium_raw = value;
                    ChangedItems.Add(nameof(Knockback_Threshold_Medium));
                    OnPropertyChanged(nameof(Knockback_Threshold_Medium));
                }
            }

            protected byte Knockback_Threshold_Large_raw;
            public const string Knockback_Threshold_Large_displayName = "Knockback Threshold Large";
            public const int Knockback_Threshold_Large_sortIndex = 200;
            [SortOrder(Knockback_Threshold_Large_sortIndex)]
            [DisplayName(Knockback_Threshold_Large_displayName)]
            public virtual byte Knockback_Threshold_Large {
                get => Knockback_Threshold_Large_raw;
                set {
                    if (Knockback_Threshold_Large_raw == value) return;
                    Knockback_Threshold_Large_raw = value;
                    ChangedItems.Add(nameof(Knockback_Threshold_Large));
                    OnPropertyChanged(nameof(Knockback_Threshold_Large));
                }
            }

            public const int lastSortIndex = 250;

            public static ObservableMhwStructCollection<Guard_Angles_Shared_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Guard_Angles_Shared_>();
                const ulong count = 2UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Guard_Angles_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new Guard_Angles_Shared_();
                data.Index = i;
                data.Guard_Angle_Both_Sides__raw = reader.ReadSingle();
                data.Knockback_Threshold_Small_raw = reader.ReadByte();
                data.Knockback_Threshold_Medium_raw = reader.ReadByte();
                data.Knockback_Threshold_Large_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Guard_Angle_Both_Sides__raw);
                writer.Write(Knockback_Threshold_Small_raw);
                writer.Write(Knockback_Threshold_Medium_raw);
                writer.Write(Knockback_Threshold_Large_raw);
            }
        }

        public partial class W09p_Params_3_Shared_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W09p Params (3, Shared)";

            protected float Unk_28_raw;
            public const string Unk_28_displayName = "Unk 28";
            public const int Unk_28_sortIndex = 50;
            [SortOrder(Unk_28_sortIndex)]
            [DisplayName(Unk_28_displayName)]
            public virtual float Unk_28 {
                get => Unk_28_raw;
                set {
                    if (Unk_28_raw == value) return;
                    Unk_28_raw = value;
                    ChangedItems.Add(nameof(Unk_28));
                    OnPropertyChanged(nameof(Unk_28));
                }
            }

            [DisplayName("Offset")]
            public long Unk_28_offset { get; private set; }

            protected float Unk_29_raw;
            public const string Unk_29_displayName = "Unk 29";
            public const int Unk_29_sortIndex = 100;
            [SortOrder(Unk_29_sortIndex)]
            [DisplayName(Unk_29_displayName)]
            public virtual float Unk_29 {
                get => Unk_29_raw;
                set {
                    if (Unk_29_raw == value) return;
                    Unk_29_raw = value;
                    ChangedItems.Add(nameof(Unk_29));
                    OnPropertyChanged(nameof(Unk_29));
                }
            }

            [DisplayName("Offset")]
            public long Unk_29_offset { get; private set; }

            protected float Unk_30_raw;
            public const string Unk_30_displayName = "Unk 30";
            public const int Unk_30_sortIndex = 150;
            [SortOrder(Unk_30_sortIndex)]
            [DisplayName(Unk_30_displayName)]
            public virtual float Unk_30 {
                get => Unk_30_raw;
                set {
                    if (Unk_30_raw == value) return;
                    Unk_30_raw = value;
                    ChangedItems.Add(nameof(Unk_30));
                    OnPropertyChanged(nameof(Unk_30));
                }
            }

            [DisplayName("Offset")]
            public long Unk_30_offset { get; private set; }

            protected float Unk_31_raw;
            public const string Unk_31_displayName = "Unk 31";
            public const int Unk_31_sortIndex = 200;
            [SortOrder(Unk_31_sortIndex)]
            [DisplayName(Unk_31_displayName)]
            public virtual float Unk_31 {
                get => Unk_31_raw;
                set {
                    if (Unk_31_raw == value) return;
                    Unk_31_raw = value;
                    ChangedItems.Add(nameof(Unk_31));
                    OnPropertyChanged(nameof(Unk_31));
                }
            }

            [DisplayName("Offset")]
            public long Unk_31_offset { get; private set; }

            protected float Unk_32_raw;
            public const string Unk_32_displayName = "Unk 32";
            public const int Unk_32_sortIndex = 250;
            [SortOrder(Unk_32_sortIndex)]
            [DisplayName(Unk_32_displayName)]
            public virtual float Unk_32 {
                get => Unk_32_raw;
                set {
                    if (Unk_32_raw == value) return;
                    Unk_32_raw = value;
                    ChangedItems.Add(nameof(Unk_32));
                    OnPropertyChanged(nameof(Unk_32));
                }
            }

            [DisplayName("Offset")]
            public long Unk_32_offset { get; private set; }

            protected float Unk_33_raw;
            public const string Unk_33_displayName = "Unk 33";
            public const int Unk_33_sortIndex = 300;
            [SortOrder(Unk_33_sortIndex)]
            [DisplayName(Unk_33_displayName)]
            public virtual float Unk_33 {
                get => Unk_33_raw;
                set {
                    if (Unk_33_raw == value) return;
                    Unk_33_raw = value;
                    ChangedItems.Add(nameof(Unk_33));
                    OnPropertyChanged(nameof(Unk_33));
                }
            }

            [DisplayName("Offset")]
            public long Unk_33_offset { get; private set; }

            protected float Unk_34_raw;
            public const string Unk_34_displayName = "Unk 34";
            public const int Unk_34_sortIndex = 350;
            [SortOrder(Unk_34_sortIndex)]
            [DisplayName(Unk_34_displayName)]
            public virtual float Unk_34 {
                get => Unk_34_raw;
                set {
                    if (Unk_34_raw == value) return;
                    Unk_34_raw = value;
                    ChangedItems.Add(nameof(Unk_34));
                    OnPropertyChanged(nameof(Unk_34));
                }
            }

            [DisplayName("Offset")]
            public long Unk_34_offset { get; private set; }

            protected float Unk_35_raw;
            public const string Unk_35_displayName = "Unk 35";
            public const int Unk_35_sortIndex = 400;
            [SortOrder(Unk_35_sortIndex)]
            [DisplayName(Unk_35_displayName)]
            public virtual float Unk_35 {
                get => Unk_35_raw;
                set {
                    if (Unk_35_raw == value) return;
                    Unk_35_raw = value;
                    ChangedItems.Add(nameof(Unk_35));
                    OnPropertyChanged(nameof(Unk_35));
                }
            }

            [DisplayName("Offset")]
            public long Unk_35_offset { get; private set; }

            protected float Unk_36_raw;
            public const string Unk_36_displayName = "Unk 36";
            public const int Unk_36_sortIndex = 450;
            [SortOrder(Unk_36_sortIndex)]
            [DisplayName(Unk_36_displayName)]
            public virtual float Unk_36 {
                get => Unk_36_raw;
                set {
                    if (Unk_36_raw == value) return;
                    Unk_36_raw = value;
                    ChangedItems.Add(nameof(Unk_36));
                    OnPropertyChanged(nameof(Unk_36));
                }
            }

            [DisplayName("Offset")]
            public long Unk_36_offset { get; private set; }

            protected float Unk_37_raw;
            public const string Unk_37_displayName = "Unk 37";
            public const int Unk_37_sortIndex = 500;
            [SortOrder(Unk_37_sortIndex)]
            [DisplayName(Unk_37_displayName)]
            public virtual float Unk_37 {
                get => Unk_37_raw;
                set {
                    if (Unk_37_raw == value) return;
                    Unk_37_raw = value;
                    ChangedItems.Add(nameof(Unk_37));
                    OnPropertyChanged(nameof(Unk_37));
                }
            }

            [DisplayName("Offset")]
            public long Unk_37_offset { get; private set; }

            protected float Unk_38_raw;
            public const string Unk_38_displayName = "Unk 38";
            public const int Unk_38_sortIndex = 550;
            [SortOrder(Unk_38_sortIndex)]
            [DisplayName(Unk_38_displayName)]
            public virtual float Unk_38 {
                get => Unk_38_raw;
                set {
                    if (Unk_38_raw == value) return;
                    Unk_38_raw = value;
                    ChangedItems.Add(nameof(Unk_38));
                    OnPropertyChanged(nameof(Unk_38));
                }
            }

            [DisplayName("Offset")]
            public long Unk_38_offset { get; private set; }

            protected float Unk_39_raw;
            public const string Unk_39_displayName = "Unk 39";
            public const int Unk_39_sortIndex = 600;
            [SortOrder(Unk_39_sortIndex)]
            [DisplayName(Unk_39_displayName)]
            public virtual float Unk_39 {
                get => Unk_39_raw;
                set {
                    if (Unk_39_raw == value) return;
                    Unk_39_raw = value;
                    ChangedItems.Add(nameof(Unk_39));
                    OnPropertyChanged(nameof(Unk_39));
                }
            }

            [DisplayName("Offset")]
            public long Unk_39_offset { get; private set; }

            protected float Unk_40_raw;
            public const string Unk_40_displayName = "Unk 40";
            public const int Unk_40_sortIndex = 650;
            [SortOrder(Unk_40_sortIndex)]
            [DisplayName(Unk_40_displayName)]
            public virtual float Unk_40 {
                get => Unk_40_raw;
                set {
                    if (Unk_40_raw == value) return;
                    Unk_40_raw = value;
                    ChangedItems.Add(nameof(Unk_40));
                    OnPropertyChanged(nameof(Unk_40));
                }
            }

            [DisplayName("Offset")]
            public long Unk_40_offset { get; private set; }

            protected float Unk_41_raw;
            public const string Unk_41_displayName = "Unk 41";
            public const int Unk_41_sortIndex = 700;
            [SortOrder(Unk_41_sortIndex)]
            [DisplayName(Unk_41_displayName)]
            public virtual float Unk_41 {
                get => Unk_41_raw;
                set {
                    if (Unk_41_raw == value) return;
                    Unk_41_raw = value;
                    ChangedItems.Add(nameof(Unk_41));
                    OnPropertyChanged(nameof(Unk_41));
                }
            }

            [DisplayName("Offset")]
            public long Unk_41_offset { get; private set; }

            protected float Unk_42_raw;
            public const string Unk_42_displayName = "Unk 42";
            public const int Unk_42_sortIndex = 750;
            [SortOrder(Unk_42_sortIndex)]
            [DisplayName(Unk_42_displayName)]
            public virtual float Unk_42 {
                get => Unk_42_raw;
                set {
                    if (Unk_42_raw == value) return;
                    Unk_42_raw = value;
                    ChangedItems.Add(nameof(Unk_42));
                    OnPropertyChanged(nameof(Unk_42));
                }
            }

            [DisplayName("Offset")]
            public long Unk_42_offset { get; private set; }

            protected float Unk_43_raw;
            public const string Unk_43_displayName = "Unk 43";
            public const int Unk_43_sortIndex = 800;
            [SortOrder(Unk_43_sortIndex)]
            [DisplayName(Unk_43_displayName)]
            public virtual float Unk_43 {
                get => Unk_43_raw;
                set {
                    if (Unk_43_raw == value) return;
                    Unk_43_raw = value;
                    ChangedItems.Add(nameof(Unk_43));
                    OnPropertyChanged(nameof(Unk_43));
                }
            }

            [DisplayName("Offset")]
            public long Unk_43_offset { get; private set; }

            protected float Unk_44_raw;
            public const string Unk_44_displayName = "Unk 44";
            public const int Unk_44_sortIndex = 850;
            [SortOrder(Unk_44_sortIndex)]
            [DisplayName(Unk_44_displayName)]
            public virtual float Unk_44 {
                get => Unk_44_raw;
                set {
                    if (Unk_44_raw == value) return;
                    Unk_44_raw = value;
                    ChangedItems.Add(nameof(Unk_44));
                    OnPropertyChanged(nameof(Unk_44));
                }
            }

            [DisplayName("Offset")]
            public long Unk_44_offset { get; private set; }

            protected float Unk_45_raw;
            public const string Unk_45_displayName = "Unk 45";
            public const int Unk_45_sortIndex = 900;
            [SortOrder(Unk_45_sortIndex)]
            [DisplayName(Unk_45_displayName)]
            public virtual float Unk_45 {
                get => Unk_45_raw;
                set {
                    if (Unk_45_raw == value) return;
                    Unk_45_raw = value;
                    ChangedItems.Add(nameof(Unk_45));
                    OnPropertyChanged(nameof(Unk_45));
                }
            }

            [DisplayName("Offset")]
            public long Unk_45_offset { get; private set; }

            protected float Unk_46_raw;
            public const string Unk_46_displayName = "Unk 46";
            public const int Unk_46_sortIndex = 950;
            [SortOrder(Unk_46_sortIndex)]
            [DisplayName(Unk_46_displayName)]
            public virtual float Unk_46 {
                get => Unk_46_raw;
                set {
                    if (Unk_46_raw == value) return;
                    Unk_46_raw = value;
                    ChangedItems.Add(nameof(Unk_46));
                    OnPropertyChanged(nameof(Unk_46));
                }
            }

            [DisplayName("Offset")]
            public long Unk_46_offset { get; private set; }

            protected float Unk_47_raw;
            public const string Unk_47_displayName = "Unk 47";
            public const int Unk_47_sortIndex = 1000;
            [SortOrder(Unk_47_sortIndex)]
            [DisplayName(Unk_47_displayName)]
            public virtual float Unk_47 {
                get => Unk_47_raw;
                set {
                    if (Unk_47_raw == value) return;
                    Unk_47_raw = value;
                    ChangedItems.Add(nameof(Unk_47));
                    OnPropertyChanged(nameof(Unk_47));
                }
            }

            [DisplayName("Offset")]
            public long Unk_47_offset { get; private set; }

            protected float Unk_48_raw;
            public const string Unk_48_displayName = "Unk 48";
            public const int Unk_48_sortIndex = 1050;
            [SortOrder(Unk_48_sortIndex)]
            [DisplayName(Unk_48_displayName)]
            public virtual float Unk_48 {
                get => Unk_48_raw;
                set {
                    if (Unk_48_raw == value) return;
                    Unk_48_raw = value;
                    ChangedItems.Add(nameof(Unk_48));
                    OnPropertyChanged(nameof(Unk_48));
                }
            }

            [DisplayName("Offset")]
            public long Unk_48_offset { get; private set; }

            protected uint Unk_49_raw;
            public const string Unk_49_displayName = "Unk 49";
            public const int Unk_49_sortIndex = 1100;
            [SortOrder(Unk_49_sortIndex)]
            [DisplayName(Unk_49_displayName)]
            public virtual uint Unk_49 {
                get => Unk_49_raw;
                set {
                    if (Unk_49_raw == value) return;
                    Unk_49_raw = value;
                    ChangedItems.Add(nameof(Unk_49));
                    OnPropertyChanged(nameof(Unk_49));
                }
            }

            [DisplayName("Offset")]
            public long Unk_49_offset { get; private set; }

            protected uint Unk_50_raw;
            public const string Unk_50_displayName = "Unk 50";
            public const int Unk_50_sortIndex = 1150;
            [SortOrder(Unk_50_sortIndex)]
            [DisplayName(Unk_50_displayName)]
            public virtual uint Unk_50 {
                get => Unk_50_raw;
                set {
                    if (Unk_50_raw == value) return;
                    Unk_50_raw = value;
                    ChangedItems.Add(nameof(Unk_50));
                    OnPropertyChanged(nameof(Unk_50));
                }
            }

            [DisplayName("Offset")]
            public long Unk_50_offset { get; private set; }

            protected float Unk_51_raw;
            public const string Unk_51_displayName = "Unk 51";
            public const int Unk_51_sortIndex = 1200;
            [SortOrder(Unk_51_sortIndex)]
            [DisplayName(Unk_51_displayName)]
            public virtual float Unk_51 {
                get => Unk_51_raw;
                set {
                    if (Unk_51_raw == value) return;
                    Unk_51_raw = value;
                    ChangedItems.Add(nameof(Unk_51));
                    OnPropertyChanged(nameof(Unk_51));
                }
            }

            [DisplayName("Offset")]
            public long Unk_51_offset { get; private set; }

            protected float Unk_52_raw;
            public const string Unk_52_displayName = "Unk 52";
            public const int Unk_52_sortIndex = 1250;
            [SortOrder(Unk_52_sortIndex)]
            [DisplayName(Unk_52_displayName)]
            public virtual float Unk_52 {
                get => Unk_52_raw;
                set {
                    if (Unk_52_raw == value) return;
                    Unk_52_raw = value;
                    ChangedItems.Add(nameof(Unk_52));
                    OnPropertyChanged(nameof(Unk_52));
                }
            }

            [DisplayName("Offset")]
            public long Unk_52_offset { get; private set; }

            protected float Unk_53_raw;
            public const string Unk_53_displayName = "Unk 53";
            public const int Unk_53_sortIndex = 1300;
            [SortOrder(Unk_53_sortIndex)]
            [DisplayName(Unk_53_displayName)]
            public virtual float Unk_53 {
                get => Unk_53_raw;
                set {
                    if (Unk_53_raw == value) return;
                    Unk_53_raw = value;
                    ChangedItems.Add(nameof(Unk_53));
                    OnPropertyChanged(nameof(Unk_53));
                }
            }

            [DisplayName("Offset")]
            public long Unk_53_offset { get; private set; }

            protected float Unk_54_raw;
            public const string Unk_54_displayName = "Unk 54";
            public const int Unk_54_sortIndex = 1350;
            [SortOrder(Unk_54_sortIndex)]
            [DisplayName(Unk_54_displayName)]
            public virtual float Unk_54 {
                get => Unk_54_raw;
                set {
                    if (Unk_54_raw == value) return;
                    Unk_54_raw = value;
                    ChangedItems.Add(nameof(Unk_54));
                    OnPropertyChanged(nameof(Unk_54));
                }
            }

            [DisplayName("Offset")]
            public long Unk_54_offset { get; private set; }

            protected float Unk_55_raw;
            public const string Unk_55_displayName = "Unk 55";
            public const int Unk_55_sortIndex = 1400;
            [SortOrder(Unk_55_sortIndex)]
            [DisplayName(Unk_55_displayName)]
            public virtual float Unk_55 {
                get => Unk_55_raw;
                set {
                    if (Unk_55_raw == value) return;
                    Unk_55_raw = value;
                    ChangedItems.Add(nameof(Unk_55));
                    OnPropertyChanged(nameof(Unk_55));
                }
            }

            [DisplayName("Offset")]
            public long Unk_55_offset { get; private set; }

            protected float Unk_56_raw;
            public const string Unk_56_displayName = "Unk 56";
            public const int Unk_56_sortIndex = 1450;
            [SortOrder(Unk_56_sortIndex)]
            [DisplayName(Unk_56_displayName)]
            public virtual float Unk_56 {
                get => Unk_56_raw;
                set {
                    if (Unk_56_raw == value) return;
                    Unk_56_raw = value;
                    ChangedItems.Add(nameof(Unk_56));
                    OnPropertyChanged(nameof(Unk_56));
                }
            }

            [DisplayName("Offset")]
            public long Unk_56_offset { get; private set; }

            protected float Unk_57_raw;
            public const string Unk_57_displayName = "Unk 57";
            public const int Unk_57_sortIndex = 1500;
            [SortOrder(Unk_57_sortIndex)]
            [DisplayName(Unk_57_displayName)]
            public virtual float Unk_57 {
                get => Unk_57_raw;
                set {
                    if (Unk_57_raw == value) return;
                    Unk_57_raw = value;
                    ChangedItems.Add(nameof(Unk_57));
                    OnPropertyChanged(nameof(Unk_57));
                }
            }

            [DisplayName("Offset")]
            public long Unk_57_offset { get; private set; }

            protected float Unk_58_raw;
            public const string Unk_58_displayName = "Unk 58";
            public const int Unk_58_sortIndex = 1550;
            [SortOrder(Unk_58_sortIndex)]
            [DisplayName(Unk_58_displayName)]
            public virtual float Unk_58 {
                get => Unk_58_raw;
                set {
                    if (Unk_58_raw == value) return;
                    Unk_58_raw = value;
                    ChangedItems.Add(nameof(Unk_58));
                    OnPropertyChanged(nameof(Unk_58));
                }
            }

            [DisplayName("Offset")]
            public long Unk_58_offset { get; private set; }

            protected float Unk_59_raw;
            public const string Unk_59_displayName = "Unk 59";
            public const int Unk_59_sortIndex = 1600;
            [SortOrder(Unk_59_sortIndex)]
            [DisplayName(Unk_59_displayName)]
            public virtual float Unk_59 {
                get => Unk_59_raw;
                set {
                    if (Unk_59_raw == value) return;
                    Unk_59_raw = value;
                    ChangedItems.Add(nameof(Unk_59));
                    OnPropertyChanged(nameof(Unk_59));
                }
            }

            [DisplayName("Offset")]
            public long Unk_59_offset { get; private set; }

            protected float Unk_60_raw;
            public const string Unk_60_displayName = "Unk 60";
            public const int Unk_60_sortIndex = 1650;
            [SortOrder(Unk_60_sortIndex)]
            [DisplayName(Unk_60_displayName)]
            public virtual float Unk_60 {
                get => Unk_60_raw;
                set {
                    if (Unk_60_raw == value) return;
                    Unk_60_raw = value;
                    ChangedItems.Add(nameof(Unk_60));
                    OnPropertyChanged(nameof(Unk_60));
                }
            }

            [DisplayName("Offset")]
            public long Unk_60_offset { get; private set; }

            protected float Unk_61_raw;
            public const string Unk_61_displayName = "Unk 61";
            public const int Unk_61_sortIndex = 1700;
            [SortOrder(Unk_61_sortIndex)]
            [DisplayName(Unk_61_displayName)]
            public virtual float Unk_61 {
                get => Unk_61_raw;
                set {
                    if (Unk_61_raw == value) return;
                    Unk_61_raw = value;
                    ChangedItems.Add(nameof(Unk_61));
                    OnPropertyChanged(nameof(Unk_61));
                }
            }

            [DisplayName("Offset")]
            public long Unk_61_offset { get; private set; }

            protected float Unk_62_raw;
            public const string Unk_62_displayName = "Unk 62";
            public const int Unk_62_sortIndex = 1750;
            [SortOrder(Unk_62_sortIndex)]
            [DisplayName(Unk_62_displayName)]
            public virtual float Unk_62 {
                get => Unk_62_raw;
                set {
                    if (Unk_62_raw == value) return;
                    Unk_62_raw = value;
                    ChangedItems.Add(nameof(Unk_62));
                    OnPropertyChanged(nameof(Unk_62));
                }
            }

            [DisplayName("Offset")]
            public long Unk_62_offset { get; private set; }

            protected float Unk_63_raw;
            public const string Unk_63_displayName = "Unk 63";
            public const int Unk_63_sortIndex = 1800;
            [SortOrder(Unk_63_sortIndex)]
            [DisplayName(Unk_63_displayName)]
            public virtual float Unk_63 {
                get => Unk_63_raw;
                set {
                    if (Unk_63_raw == value) return;
                    Unk_63_raw = value;
                    ChangedItems.Add(nameof(Unk_63));
                    OnPropertyChanged(nameof(Unk_63));
                }
            }

            [DisplayName("Offset")]
            public long Unk_63_offset { get; private set; }

            protected float Unk_64_raw;
            public const string Unk_64_displayName = "Unk 64";
            public const int Unk_64_sortIndex = 1850;
            [SortOrder(Unk_64_sortIndex)]
            [DisplayName(Unk_64_displayName)]
            public virtual float Unk_64 {
                get => Unk_64_raw;
                set {
                    if (Unk_64_raw == value) return;
                    Unk_64_raw = value;
                    ChangedItems.Add(nameof(Unk_64));
                    OnPropertyChanged(nameof(Unk_64));
                }
            }

            [DisplayName("Offset")]
            public long Unk_64_offset { get; private set; }

            protected float Unk_65_raw;
            public const string Unk_65_displayName = "Unk 65";
            public const int Unk_65_sortIndex = 1900;
            [SortOrder(Unk_65_sortIndex)]
            [DisplayName(Unk_65_displayName)]
            public virtual float Unk_65 {
                get => Unk_65_raw;
                set {
                    if (Unk_65_raw == value) return;
                    Unk_65_raw = value;
                    ChangedItems.Add(nameof(Unk_65));
                    OnPropertyChanged(nameof(Unk_65));
                }
            }

            [DisplayName("Offset")]
            public long Unk_65_offset { get; private set; }

            protected float Unk_66_raw;
            public const string Unk_66_displayName = "Unk 66";
            public const int Unk_66_sortIndex = 1950;
            [SortOrder(Unk_66_sortIndex)]
            [DisplayName(Unk_66_displayName)]
            public virtual float Unk_66 {
                get => Unk_66_raw;
                set {
                    if (Unk_66_raw == value) return;
                    Unk_66_raw = value;
                    ChangedItems.Add(nameof(Unk_66));
                    OnPropertyChanged(nameof(Unk_66));
                }
            }

            [DisplayName("Offset")]
            public long Unk_66_offset { get; private set; }

            protected float Unk_67_raw;
            public const string Unk_67_displayName = "Unk 67";
            public const int Unk_67_sortIndex = 2000;
            [SortOrder(Unk_67_sortIndex)]
            [DisplayName(Unk_67_displayName)]
            public virtual float Unk_67 {
                get => Unk_67_raw;
                set {
                    if (Unk_67_raw == value) return;
                    Unk_67_raw = value;
                    ChangedItems.Add(nameof(Unk_67));
                    OnPropertyChanged(nameof(Unk_67));
                }
            }

            [DisplayName("Offset")]
            public long Unk_67_offset { get; private set; }

            protected float Unk_68_raw;
            public const string Unk_68_displayName = "Unk 68";
            public const int Unk_68_sortIndex = 2050;
            [SortOrder(Unk_68_sortIndex)]
            [DisplayName(Unk_68_displayName)]
            public virtual float Unk_68 {
                get => Unk_68_raw;
                set {
                    if (Unk_68_raw == value) return;
                    Unk_68_raw = value;
                    ChangedItems.Add(nameof(Unk_68));
                    OnPropertyChanged(nameof(Unk_68));
                }
            }

            [DisplayName("Offset")]
            public long Unk_68_offset { get; private set; }

            protected float Unk_69_raw;
            public const string Unk_69_displayName = "Unk 69";
            public const int Unk_69_sortIndex = 2100;
            [SortOrder(Unk_69_sortIndex)]
            [DisplayName(Unk_69_displayName)]
            public virtual float Unk_69 {
                get => Unk_69_raw;
                set {
                    if (Unk_69_raw == value) return;
                    Unk_69_raw = value;
                    ChangedItems.Add(nameof(Unk_69));
                    OnPropertyChanged(nameof(Unk_69));
                }
            }

            [DisplayName("Offset")]
            public long Unk_69_offset { get; private set; }

            protected float Unk_70_raw;
            public const string Unk_70_displayName = "Unk 70";
            public const int Unk_70_sortIndex = 2150;
            [SortOrder(Unk_70_sortIndex)]
            [DisplayName(Unk_70_displayName)]
            public virtual float Unk_70 {
                get => Unk_70_raw;
                set {
                    if (Unk_70_raw == value) return;
                    Unk_70_raw = value;
                    ChangedItems.Add(nameof(Unk_70));
                    OnPropertyChanged(nameof(Unk_70));
                }
            }

            [DisplayName("Offset")]
            public long Unk_70_offset { get; private set; }

            protected float Unk_71_raw;
            public const string Unk_71_displayName = "Unk 71";
            public const int Unk_71_sortIndex = 2200;
            [SortOrder(Unk_71_sortIndex)]
            [DisplayName(Unk_71_displayName)]
            public virtual float Unk_71 {
                get => Unk_71_raw;
                set {
                    if (Unk_71_raw == value) return;
                    Unk_71_raw = value;
                    ChangedItems.Add(nameof(Unk_71));
                    OnPropertyChanged(nameof(Unk_71));
                }
            }

            [DisplayName("Offset")]
            public long Unk_71_offset { get; private set; }

            protected byte Unk_72_raw;
            public const string Unk_72_displayName = "Unk 72";
            public const int Unk_72_sortIndex = 2250;
            [SortOrder(Unk_72_sortIndex)]
            [DisplayName(Unk_72_displayName)]
            public virtual byte Unk_72 {
                get => Unk_72_raw;
                set {
                    if (Unk_72_raw == value) return;
                    Unk_72_raw = value;
                    ChangedItems.Add(nameof(Unk_72));
                    OnPropertyChanged(nameof(Unk_72));
                }
            }

            [DisplayName("Offset")]
            public long Unk_72_offset { get; private set; }

            protected uint Unk_73_raw;
            public const string Unk_73_displayName = "Unk 73";
            public const int Unk_73_sortIndex = 2300;
            [SortOrder(Unk_73_sortIndex)]
            [DisplayName(Unk_73_displayName)]
            public virtual uint Unk_73 {
                get => Unk_73_raw;
                set {
                    if (Unk_73_raw == value) return;
                    Unk_73_raw = value;
                    ChangedItems.Add(nameof(Unk_73));
                    OnPropertyChanged(nameof(Unk_73));
                }
            }

            [DisplayName("Offset")]
            public long Unk_73_offset { get; private set; }

            protected float Unk_74_raw;
            public const string Unk_74_displayName = "Unk 74";
            public const int Unk_74_sortIndex = 2350;
            [SortOrder(Unk_74_sortIndex)]
            [DisplayName(Unk_74_displayName)]
            public virtual float Unk_74 {
                get => Unk_74_raw;
                set {
                    if (Unk_74_raw == value) return;
                    Unk_74_raw = value;
                    ChangedItems.Add(nameof(Unk_74));
                    OnPropertyChanged(nameof(Unk_74));
                }
            }

            [DisplayName("Offset")]
            public long Unk_74_offset { get; private set; }

            protected float Unk_75_raw;
            public const string Unk_75_displayName = "Unk 75";
            public const int Unk_75_sortIndex = 2400;
            [SortOrder(Unk_75_sortIndex)]
            [DisplayName(Unk_75_displayName)]
            public virtual float Unk_75 {
                get => Unk_75_raw;
                set {
                    if (Unk_75_raw == value) return;
                    Unk_75_raw = value;
                    ChangedItems.Add(nameof(Unk_75));
                    OnPropertyChanged(nameof(Unk_75));
                }
            }

            [DisplayName("Offset")]
            public long Unk_75_offset { get; private set; }

            protected float Unk_76_raw;
            public const string Unk_76_displayName = "Unk 76";
            public const int Unk_76_sortIndex = 2450;
            [SortOrder(Unk_76_sortIndex)]
            [DisplayName(Unk_76_displayName)]
            public virtual float Unk_76 {
                get => Unk_76_raw;
                set {
                    if (Unk_76_raw == value) return;
                    Unk_76_raw = value;
                    ChangedItems.Add(nameof(Unk_76));
                    OnPropertyChanged(nameof(Unk_76));
                }
            }

            [DisplayName("Offset")]
            public long Unk_76_offset { get; private set; }

            public const int lastSortIndex = 2500;

            public static ObservableMhwStructCollection<W09p_Params_3_Shared_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W09p_Params_3_Shared_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W09p_Params_3_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new W09p_Params_3_Shared_();
                data.Index = i;
                data.Unk_28_offset = reader.BaseStream.Position;
                data.Unk_28_raw = reader.ReadSingle();
                data.Unk_29_offset = reader.BaseStream.Position;
                data.Unk_29_raw = reader.ReadSingle();
                data.Unk_30_offset = reader.BaseStream.Position;
                data.Unk_30_raw = reader.ReadSingle();
                data.Unk_31_offset = reader.BaseStream.Position;
                data.Unk_31_raw = reader.ReadSingle();
                data.Unk_32_offset = reader.BaseStream.Position;
                data.Unk_32_raw = reader.ReadSingle();
                data.Unk_33_offset = reader.BaseStream.Position;
                data.Unk_33_raw = reader.ReadSingle();
                data.Unk_34_offset = reader.BaseStream.Position;
                data.Unk_34_raw = reader.ReadSingle();
                data.Unk_35_offset = reader.BaseStream.Position;
                data.Unk_35_raw = reader.ReadSingle();
                data.Unk_36_offset = reader.BaseStream.Position;
                data.Unk_36_raw = reader.ReadSingle();
                data.Unk_37_offset = reader.BaseStream.Position;
                data.Unk_37_raw = reader.ReadSingle();
                data.Unk_38_offset = reader.BaseStream.Position;
                data.Unk_38_raw = reader.ReadSingle();
                data.Unk_39_offset = reader.BaseStream.Position;
                data.Unk_39_raw = reader.ReadSingle();
                data.Unk_40_offset = reader.BaseStream.Position;
                data.Unk_40_raw = reader.ReadSingle();
                data.Unk_41_offset = reader.BaseStream.Position;
                data.Unk_41_raw = reader.ReadSingle();
                data.Unk_42_offset = reader.BaseStream.Position;
                data.Unk_42_raw = reader.ReadSingle();
                data.Unk_43_offset = reader.BaseStream.Position;
                data.Unk_43_raw = reader.ReadSingle();
                data.Unk_44_offset = reader.BaseStream.Position;
                data.Unk_44_raw = reader.ReadSingle();
                data.Unk_45_offset = reader.BaseStream.Position;
                data.Unk_45_raw = reader.ReadSingle();
                data.Unk_46_offset = reader.BaseStream.Position;
                data.Unk_46_raw = reader.ReadSingle();
                data.Unk_47_offset = reader.BaseStream.Position;
                data.Unk_47_raw = reader.ReadSingle();
                data.Unk_48_offset = reader.BaseStream.Position;
                data.Unk_48_raw = reader.ReadSingle();
                data.Unk_49_offset = reader.BaseStream.Position;
                data.Unk_49_raw = reader.ReadUInt32();
                data.Unk_50_offset = reader.BaseStream.Position;
                data.Unk_50_raw = reader.ReadUInt32();
                data.Unk_51_offset = reader.BaseStream.Position;
                data.Unk_51_raw = reader.ReadSingle();
                data.Unk_52_offset = reader.BaseStream.Position;
                data.Unk_52_raw = reader.ReadSingle();
                data.Unk_53_offset = reader.BaseStream.Position;
                data.Unk_53_raw = reader.ReadSingle();
                data.Unk_54_offset = reader.BaseStream.Position;
                data.Unk_54_raw = reader.ReadSingle();
                data.Unk_55_offset = reader.BaseStream.Position;
                data.Unk_55_raw = reader.ReadSingle();
                data.Unk_56_offset = reader.BaseStream.Position;
                data.Unk_56_raw = reader.ReadSingle();
                data.Unk_57_offset = reader.BaseStream.Position;
                data.Unk_57_raw = reader.ReadSingle();
                data.Unk_58_offset = reader.BaseStream.Position;
                data.Unk_58_raw = reader.ReadSingle();
                data.Unk_59_offset = reader.BaseStream.Position;
                data.Unk_59_raw = reader.ReadSingle();
                data.Unk_60_offset = reader.BaseStream.Position;
                data.Unk_60_raw = reader.ReadSingle();
                data.Unk_61_offset = reader.BaseStream.Position;
                data.Unk_61_raw = reader.ReadSingle();
                data.Unk_62_offset = reader.BaseStream.Position;
                data.Unk_62_raw = reader.ReadSingle();
                data.Unk_63_offset = reader.BaseStream.Position;
                data.Unk_63_raw = reader.ReadSingle();
                data.Unk_64_offset = reader.BaseStream.Position;
                data.Unk_64_raw = reader.ReadSingle();
                data.Unk_65_offset = reader.BaseStream.Position;
                data.Unk_65_raw = reader.ReadSingle();
                data.Unk_66_offset = reader.BaseStream.Position;
                data.Unk_66_raw = reader.ReadSingle();
                data.Unk_67_offset = reader.BaseStream.Position;
                data.Unk_67_raw = reader.ReadSingle();
                data.Unk_68_offset = reader.BaseStream.Position;
                data.Unk_68_raw = reader.ReadSingle();
                data.Unk_69_offset = reader.BaseStream.Position;
                data.Unk_69_raw = reader.ReadSingle();
                data.Unk_70_offset = reader.BaseStream.Position;
                data.Unk_70_raw = reader.ReadSingle();
                data.Unk_71_offset = reader.BaseStream.Position;
                data.Unk_71_raw = reader.ReadSingle();
                data.Unk_72_offset = reader.BaseStream.Position;
                data.Unk_72_raw = reader.ReadByte();
                data.Unk_73_offset = reader.BaseStream.Position;
                data.Unk_73_raw = reader.ReadUInt32();
                data.Unk_74_offset = reader.BaseStream.Position;
                data.Unk_74_raw = reader.ReadSingle();
                data.Unk_75_offset = reader.BaseStream.Position;
                data.Unk_75_raw = reader.ReadSingle();
                data.Unk_76_offset = reader.BaseStream.Position;
                data.Unk_76_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_28_raw);
                writer.Write(Unk_29_raw);
                writer.Write(Unk_30_raw);
                writer.Write(Unk_31_raw);
                writer.Write(Unk_32_raw);
                writer.Write(Unk_33_raw);
                writer.Write(Unk_34_raw);
                writer.Write(Unk_35_raw);
                writer.Write(Unk_36_raw);
                writer.Write(Unk_37_raw);
                writer.Write(Unk_38_raw);
                writer.Write(Unk_39_raw);
                writer.Write(Unk_40_raw);
                writer.Write(Unk_41_raw);
                writer.Write(Unk_42_raw);
                writer.Write(Unk_43_raw);
                writer.Write(Unk_44_raw);
                writer.Write(Unk_45_raw);
                writer.Write(Unk_46_raw);
                writer.Write(Unk_47_raw);
                writer.Write(Unk_48_raw);
                writer.Write(Unk_49_raw);
                writer.Write(Unk_50_raw);
                writer.Write(Unk_51_raw);
                writer.Write(Unk_52_raw);
                writer.Write(Unk_53_raw);
                writer.Write(Unk_54_raw);
                writer.Write(Unk_55_raw);
                writer.Write(Unk_56_raw);
                writer.Write(Unk_57_raw);
                writer.Write(Unk_58_raw);
                writer.Write(Unk_59_raw);
                writer.Write(Unk_60_raw);
                writer.Write(Unk_61_raw);
                writer.Write(Unk_62_raw);
                writer.Write(Unk_63_raw);
                writer.Write(Unk_64_raw);
                writer.Write(Unk_65_raw);
                writer.Write(Unk_66_raw);
                writer.Write(Unk_67_raw);
                writer.Write(Unk_68_raw);
                writer.Write(Unk_69_raw);
                writer.Write(Unk_70_raw);
                writer.Write(Unk_71_raw);
                writer.Write(Unk_72_raw);
                writer.Write(Unk_73_raw);
                writer.Write(Unk_74_raw);
                writer.Write(Unk_75_raw);
                writer.Write(Unk_76_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 28", "Unk_28", "Unk_28_offset"),
                    new MultiStructItemCustomView(this, "Unk 29", "Unk_29", "Unk_29_offset"),
                    new MultiStructItemCustomView(this, "Unk 30", "Unk_30", "Unk_30_offset"),
                    new MultiStructItemCustomView(this, "Unk 31", "Unk_31", "Unk_31_offset"),
                    new MultiStructItemCustomView(this, "Unk 32", "Unk_32", "Unk_32_offset"),
                    new MultiStructItemCustomView(this, "Unk 33", "Unk_33", "Unk_33_offset"),
                    new MultiStructItemCustomView(this, "Unk 34", "Unk_34", "Unk_34_offset"),
                    new MultiStructItemCustomView(this, "Unk 35", "Unk_35", "Unk_35_offset"),
                    new MultiStructItemCustomView(this, "Unk 36", "Unk_36", "Unk_36_offset"),
                    new MultiStructItemCustomView(this, "Unk 37", "Unk_37", "Unk_37_offset"),
                    new MultiStructItemCustomView(this, "Unk 38", "Unk_38", "Unk_38_offset"),
                    new MultiStructItemCustomView(this, "Unk 39", "Unk_39", "Unk_39_offset"),
                    new MultiStructItemCustomView(this, "Unk 40", "Unk_40", "Unk_40_offset"),
                    new MultiStructItemCustomView(this, "Unk 41", "Unk_41", "Unk_41_offset"),
                    new MultiStructItemCustomView(this, "Unk 42", "Unk_42", "Unk_42_offset"),
                    new MultiStructItemCustomView(this, "Unk 43", "Unk_43", "Unk_43_offset"),
                    new MultiStructItemCustomView(this, "Unk 44", "Unk_44", "Unk_44_offset"),
                    new MultiStructItemCustomView(this, "Unk 45", "Unk_45", "Unk_45_offset"),
                    new MultiStructItemCustomView(this, "Unk 46", "Unk_46", "Unk_46_offset"),
                    new MultiStructItemCustomView(this, "Unk 47", "Unk_47", "Unk_47_offset"),
                    new MultiStructItemCustomView(this, "Unk 48", "Unk_48", "Unk_48_offset"),
                    new MultiStructItemCustomView(this, "Unk 49", "Unk_49", "Unk_49_offset"),
                    new MultiStructItemCustomView(this, "Unk 50", "Unk_50", "Unk_50_offset"),
                    new MultiStructItemCustomView(this, "Unk 51", "Unk_51", "Unk_51_offset"),
                    new MultiStructItemCustomView(this, "Unk 52", "Unk_52", "Unk_52_offset"),
                    new MultiStructItemCustomView(this, "Unk 53", "Unk_53", "Unk_53_offset"),
                    new MultiStructItemCustomView(this, "Unk 54", "Unk_54", "Unk_54_offset"),
                    new MultiStructItemCustomView(this, "Unk 55", "Unk_55", "Unk_55_offset"),
                    new MultiStructItemCustomView(this, "Unk 56", "Unk_56", "Unk_56_offset"),
                    new MultiStructItemCustomView(this, "Unk 57", "Unk_57", "Unk_57_offset"),
                    new MultiStructItemCustomView(this, "Unk 58", "Unk_58", "Unk_58_offset"),
                    new MultiStructItemCustomView(this, "Unk 59", "Unk_59", "Unk_59_offset"),
                    new MultiStructItemCustomView(this, "Unk 60", "Unk_60", "Unk_60_offset"),
                    new MultiStructItemCustomView(this, "Unk 61", "Unk_61", "Unk_61_offset"),
                    new MultiStructItemCustomView(this, "Unk 62", "Unk_62", "Unk_62_offset"),
                    new MultiStructItemCustomView(this, "Unk 63", "Unk_63", "Unk_63_offset"),
                    new MultiStructItemCustomView(this, "Unk 64", "Unk_64", "Unk_64_offset"),
                    new MultiStructItemCustomView(this, "Unk 65", "Unk_65", "Unk_65_offset"),
                    new MultiStructItemCustomView(this, "Unk 66", "Unk_66", "Unk_66_offset"),
                    new MultiStructItemCustomView(this, "Unk 67", "Unk_67", "Unk_67_offset"),
                    new MultiStructItemCustomView(this, "Unk 68", "Unk_68", "Unk_68_offset"),
                    new MultiStructItemCustomView(this, "Unk 69", "Unk_69", "Unk_69_offset"),
                    new MultiStructItemCustomView(this, "Unk 70", "Unk_70", "Unk_70_offset"),
                    new MultiStructItemCustomView(this, "Unk 71", "Unk_71", "Unk_71_offset"),
                    new MultiStructItemCustomView(this, "Unk 72", "Unk_72", "Unk_72_offset"),
                    new MultiStructItemCustomView(this, "Unk 73", "Unk_73", "Unk_73_offset"),
                    new MultiStructItemCustomView(this, "Unk 74", "Unk_74", "Unk_74_offset"),
                    new MultiStructItemCustomView(this, "Unk 75", "Unk_75", "Unk_75_offset"),
                    new MultiStructItemCustomView(this, "Unk 76", "Unk_76", "Unk_76_offset"),
                };
            }
        }

        public partial class Unk_Arr_2_Shared_ : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 8;
            public const string GridName = "Unk Arr 2 (Shared)";

            protected byte Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 50;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            public virtual byte Unk_1 {
                get => Unk_1_raw;
                set {
                    if (Unk_1_raw == value) return;
                    Unk_1_raw = value;
                    ChangedItems.Add(nameof(Unk_1));
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

            protected int Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 100;
            [SortOrder(Unk_2_sortIndex)]
            [DisplayName(Unk_2_displayName)]
            public virtual int Unk_2 {
                get => Unk_2_raw;
                set {
                    if (Unk_2_raw == value) return;
                    Unk_2_raw = value;
                    ChangedItems.Add(nameof(Unk_2));
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            protected float Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 150;
            [SortOrder(Unk_3_sortIndex)]
            [DisplayName(Unk_3_displayName)]
            public virtual float Unk_3 {
                get => Unk_3_raw;
                set {
                    if (Unk_3_raw == value) return;
                    Unk_3_raw = value;
                    ChangedItems.Add(nameof(Unk_3));
                    OnPropertyChanged(nameof(Unk_3));
                }
            }

            protected float Unk_4_raw;
            public const string Unk_4_displayName = "Unk 4";
            public const int Unk_4_sortIndex = 200;
            [SortOrder(Unk_4_sortIndex)]
            [DisplayName(Unk_4_displayName)]
            public virtual float Unk_4 {
                get => Unk_4_raw;
                set {
                    if (Unk_4_raw == value) return;
                    Unk_4_raw = value;
                    ChangedItems.Add(nameof(Unk_4));
                    OnPropertyChanged(nameof(Unk_4));
                }
            }

            protected float Unk_5_raw;
            public const string Unk_5_displayName = "Unk 5";
            public const int Unk_5_sortIndex = 250;
            [SortOrder(Unk_5_sortIndex)]
            [DisplayName(Unk_5_displayName)]
            public virtual float Unk_5 {
                get => Unk_5_raw;
                set {
                    if (Unk_5_raw == value) return;
                    Unk_5_raw = value;
                    ChangedItems.Add(nameof(Unk_5));
                    OnPropertyChanged(nameof(Unk_5));
                }
            }

            protected float Unk_6_raw;
            public const string Unk_6_displayName = "Unk 6";
            public const int Unk_6_sortIndex = 300;
            [SortOrder(Unk_6_sortIndex)]
            [DisplayName(Unk_6_displayName)]
            public virtual float Unk_6 {
                get => Unk_6_raw;
                set {
                    if (Unk_6_raw == value) return;
                    Unk_6_raw = value;
                    ChangedItems.Add(nameof(Unk_6));
                    OnPropertyChanged(nameof(Unk_6));
                }
            }

            protected float Unk_7_raw;
            public const string Unk_7_displayName = "Unk 7";
            public const int Unk_7_sortIndex = 350;
            [SortOrder(Unk_7_sortIndex)]
            [DisplayName(Unk_7_displayName)]
            public virtual float Unk_7 {
                get => Unk_7_raw;
                set {
                    if (Unk_7_raw == value) return;
                    Unk_7_raw = value;
                    ChangedItems.Add(nameof(Unk_7));
                    OnPropertyChanged(nameof(Unk_7));
                }
            }

            protected float Unk_8_raw;
            public const string Unk_8_displayName = "Unk 8";
            public const int Unk_8_sortIndex = 400;
            [SortOrder(Unk_8_sortIndex)]
            [DisplayName(Unk_8_displayName)]
            public virtual float Unk_8 {
                get => Unk_8_raw;
                set {
                    if (Unk_8_raw == value) return;
                    Unk_8_raw = value;
                    ChangedItems.Add(nameof(Unk_8));
                    OnPropertyChanged(nameof(Unk_8));
                }
            }

            protected float Unk_9_raw;
            public const string Unk_9_displayName = "Unk 9";
            public const int Unk_9_sortIndex = 450;
            [SortOrder(Unk_9_sortIndex)]
            [DisplayName(Unk_9_displayName)]
            public virtual float Unk_9 {
                get => Unk_9_raw;
                set {
                    if (Unk_9_raw == value) return;
                    Unk_9_raw = value;
                    ChangedItems.Add(nameof(Unk_9));
                    OnPropertyChanged(nameof(Unk_9));
                }
            }

            protected float Unk_10_raw;
            public const string Unk_10_displayName = "Unk 10";
            public const int Unk_10_sortIndex = 500;
            [SortOrder(Unk_10_sortIndex)]
            [DisplayName(Unk_10_displayName)]
            public virtual float Unk_10 {
                get => Unk_10_raw;
                set {
                    if (Unk_10_raw == value) return;
                    Unk_10_raw = value;
                    ChangedItems.Add(nameof(Unk_10));
                    OnPropertyChanged(nameof(Unk_10));
                }
            }

            protected float Unk_11_raw;
            public const string Unk_11_displayName = "Unk 11";
            public const int Unk_11_sortIndex = 550;
            [SortOrder(Unk_11_sortIndex)]
            [DisplayName(Unk_11_displayName)]
            public virtual float Unk_11 {
                get => Unk_11_raw;
                set {
                    if (Unk_11_raw == value) return;
                    Unk_11_raw = value;
                    ChangedItems.Add(nameof(Unk_11));
                    OnPropertyChanged(nameof(Unk_11));
                }
            }

            protected float Unk_12_raw;
            public const string Unk_12_displayName = "Unk 12";
            public const int Unk_12_sortIndex = 600;
            [SortOrder(Unk_12_sortIndex)]
            [DisplayName(Unk_12_displayName)]
            public virtual float Unk_12 {
                get => Unk_12_raw;
                set {
                    if (Unk_12_raw == value) return;
                    Unk_12_raw = value;
                    ChangedItems.Add(nameof(Unk_12));
                    OnPropertyChanged(nameof(Unk_12));
                }
            }

            protected float Unk_13_raw;
            public const string Unk_13_displayName = "Unk 13";
            public const int Unk_13_sortIndex = 650;
            [SortOrder(Unk_13_sortIndex)]
            [DisplayName(Unk_13_displayName)]
            public virtual float Unk_13 {
                get => Unk_13_raw;
                set {
                    if (Unk_13_raw == value) return;
                    Unk_13_raw = value;
                    ChangedItems.Add(nameof(Unk_13));
                    OnPropertyChanged(nameof(Unk_13));
                }
            }

            protected float Unk_14_raw;
            public const string Unk_14_displayName = "Unk 14";
            public const int Unk_14_sortIndex = 700;
            [SortOrder(Unk_14_sortIndex)]
            [DisplayName(Unk_14_displayName)]
            public virtual float Unk_14 {
                get => Unk_14_raw;
                set {
                    if (Unk_14_raw == value) return;
                    Unk_14_raw = value;
                    ChangedItems.Add(nameof(Unk_14));
                    OnPropertyChanged(nameof(Unk_14));
                }
            }

            protected float Unk_15_raw;
            public const string Unk_15_displayName = "Unk 15";
            public const int Unk_15_sortIndex = 750;
            [SortOrder(Unk_15_sortIndex)]
            [DisplayName(Unk_15_displayName)]
            public virtual float Unk_15 {
                get => Unk_15_raw;
                set {
                    if (Unk_15_raw == value) return;
                    Unk_15_raw = value;
                    ChangedItems.Add(nameof(Unk_15));
                    OnPropertyChanged(nameof(Unk_15));
                }
            }

            public const int lastSortIndex = 800;

            public static ObservableMhwStructCollection<Unk_Arr_2_Shared_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Unk_Arr_2_Shared_>();
                const ulong count = 8UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Unk_Arr_2_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new Unk_Arr_2_Shared_();
                data.Index = i;
                data.Unk_1_raw = reader.ReadByte();
                data.Unk_2_raw = reader.ReadInt32();
                data.Unk_3_raw = reader.ReadSingle();
                data.Unk_4_raw = reader.ReadSingle();
                data.Unk_5_raw = reader.ReadSingle();
                data.Unk_6_raw = reader.ReadSingle();
                data.Unk_7_raw = reader.ReadSingle();
                data.Unk_8_raw = reader.ReadSingle();
                data.Unk_9_raw = reader.ReadSingle();
                data.Unk_10_raw = reader.ReadSingle();
                data.Unk_11_raw = reader.ReadSingle();
                data.Unk_12_raw = reader.ReadSingle();
                data.Unk_13_raw = reader.ReadSingle();
                data.Unk_14_raw = reader.ReadSingle();
                data.Unk_15_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
                writer.Write(Unk_3_raw);
                writer.Write(Unk_4_raw);
                writer.Write(Unk_5_raw);
                writer.Write(Unk_6_raw);
                writer.Write(Unk_7_raw);
                writer.Write(Unk_8_raw);
                writer.Write(Unk_9_raw);
                writer.Write(Unk_10_raw);
                writer.Write(Unk_11_raw);
                writer.Write(Unk_12_raw);
                writer.Write(Unk_13_raw);
                writer.Write(Unk_14_raw);
                writer.Write(Unk_15_raw);
            }
        }

        public partial class W09p_Params_4_Shared_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W09p Params (4, Shared)";

            protected byte Unk_77_raw;
            public const string Unk_77_displayName = "Unk 77";
            public const int Unk_77_sortIndex = 50;
            [SortOrder(Unk_77_sortIndex)]
            [DisplayName(Unk_77_displayName)]
            public virtual byte Unk_77 {
                get => Unk_77_raw;
                set {
                    if (Unk_77_raw == value) return;
                    Unk_77_raw = value;
                    ChangedItems.Add(nameof(Unk_77));
                    OnPropertyChanged(nameof(Unk_77));
                }
            }

            [DisplayName("Offset")]
            public long Unk_77_offset { get; private set; }

            protected int Unk_78_raw;
            public const string Unk_78_displayName = "Unk 78";
            public const int Unk_78_sortIndex = 100;
            [SortOrder(Unk_78_sortIndex)]
            [DisplayName(Unk_78_displayName)]
            public virtual int Unk_78 {
                get => Unk_78_raw;
                set {
                    if (Unk_78_raw == value) return;
                    Unk_78_raw = value;
                    ChangedItems.Add(nameof(Unk_78));
                    OnPropertyChanged(nameof(Unk_78));
                }
            }

            [DisplayName("Offset")]
            public long Unk_78_offset { get; private set; }

            protected float Unk_79_raw;
            public const string Unk_79_displayName = "Unk 79";
            public const int Unk_79_sortIndex = 150;
            [SortOrder(Unk_79_sortIndex)]
            [DisplayName(Unk_79_displayName)]
            public virtual float Unk_79 {
                get => Unk_79_raw;
                set {
                    if (Unk_79_raw == value) return;
                    Unk_79_raw = value;
                    ChangedItems.Add(nameof(Unk_79));
                    OnPropertyChanged(nameof(Unk_79));
                }
            }

            [DisplayName("Offset")]
            public long Unk_79_offset { get; private set; }

            protected float Unk_80_raw;
            public const string Unk_80_displayName = "Unk 80";
            public const int Unk_80_sortIndex = 200;
            [SortOrder(Unk_80_sortIndex)]
            [DisplayName(Unk_80_displayName)]
            public virtual float Unk_80 {
                get => Unk_80_raw;
                set {
                    if (Unk_80_raw == value) return;
                    Unk_80_raw = value;
                    ChangedItems.Add(nameof(Unk_80));
                    OnPropertyChanged(nameof(Unk_80));
                }
            }

            [DisplayName("Offset")]
            public long Unk_80_offset { get; private set; }

            protected float Unk_81_raw;
            public const string Unk_81_displayName = "Unk 81";
            public const int Unk_81_sortIndex = 250;
            [SortOrder(Unk_81_sortIndex)]
            [DisplayName(Unk_81_displayName)]
            public virtual float Unk_81 {
                get => Unk_81_raw;
                set {
                    if (Unk_81_raw == value) return;
                    Unk_81_raw = value;
                    ChangedItems.Add(nameof(Unk_81));
                    OnPropertyChanged(nameof(Unk_81));
                }
            }

            [DisplayName("Offset")]
            public long Unk_81_offset { get; private set; }

            protected float Unk_82_raw;
            public const string Unk_82_displayName = "Unk 82";
            public const int Unk_82_sortIndex = 300;
            [SortOrder(Unk_82_sortIndex)]
            [DisplayName(Unk_82_displayName)]
            public virtual float Unk_82 {
                get => Unk_82_raw;
                set {
                    if (Unk_82_raw == value) return;
                    Unk_82_raw = value;
                    ChangedItems.Add(nameof(Unk_82));
                    OnPropertyChanged(nameof(Unk_82));
                }
            }

            [DisplayName("Offset")]
            public long Unk_82_offset { get; private set; }

            protected float Unk_83_raw;
            public const string Unk_83_displayName = "Unk 83";
            public const int Unk_83_sortIndex = 350;
            [SortOrder(Unk_83_sortIndex)]
            [DisplayName(Unk_83_displayName)]
            public virtual float Unk_83 {
                get => Unk_83_raw;
                set {
                    if (Unk_83_raw == value) return;
                    Unk_83_raw = value;
                    ChangedItems.Add(nameof(Unk_83));
                    OnPropertyChanged(nameof(Unk_83));
                }
            }

            [DisplayName("Offset")]
            public long Unk_83_offset { get; private set; }

            protected float Unk_84_raw;
            public const string Unk_84_displayName = "Unk 84";
            public const int Unk_84_sortIndex = 400;
            [SortOrder(Unk_84_sortIndex)]
            [DisplayName(Unk_84_displayName)]
            public virtual float Unk_84 {
                get => Unk_84_raw;
                set {
                    if (Unk_84_raw == value) return;
                    Unk_84_raw = value;
                    ChangedItems.Add(nameof(Unk_84));
                    OnPropertyChanged(nameof(Unk_84));
                }
            }

            [DisplayName("Offset")]
            public long Unk_84_offset { get; private set; }

            protected float Unk_85_raw;
            public const string Unk_85_displayName = "Unk 85";
            public const int Unk_85_sortIndex = 450;
            [SortOrder(Unk_85_sortIndex)]
            [DisplayName(Unk_85_displayName)]
            public virtual float Unk_85 {
                get => Unk_85_raw;
                set {
                    if (Unk_85_raw == value) return;
                    Unk_85_raw = value;
                    ChangedItems.Add(nameof(Unk_85));
                    OnPropertyChanged(nameof(Unk_85));
                }
            }

            [DisplayName("Offset")]
            public long Unk_85_offset { get; private set; }

            protected float Unk_86_raw;
            public const string Unk_86_displayName = "Unk 86";
            public const int Unk_86_sortIndex = 500;
            [SortOrder(Unk_86_sortIndex)]
            [DisplayName(Unk_86_displayName)]
            public virtual float Unk_86 {
                get => Unk_86_raw;
                set {
                    if (Unk_86_raw == value) return;
                    Unk_86_raw = value;
                    ChangedItems.Add(nameof(Unk_86));
                    OnPropertyChanged(nameof(Unk_86));
                }
            }

            [DisplayName("Offset")]
            public long Unk_86_offset { get; private set; }

            protected float Unk_87_raw;
            public const string Unk_87_displayName = "Unk 87";
            public const int Unk_87_sortIndex = 550;
            [SortOrder(Unk_87_sortIndex)]
            [DisplayName(Unk_87_displayName)]
            public virtual float Unk_87 {
                get => Unk_87_raw;
                set {
                    if (Unk_87_raw == value) return;
                    Unk_87_raw = value;
                    ChangedItems.Add(nameof(Unk_87));
                    OnPropertyChanged(nameof(Unk_87));
                }
            }

            [DisplayName("Offset")]
            public long Unk_87_offset { get; private set; }

            protected float Unk_88_raw;
            public const string Unk_88_displayName = "Unk 88";
            public const int Unk_88_sortIndex = 600;
            [SortOrder(Unk_88_sortIndex)]
            [DisplayName(Unk_88_displayName)]
            public virtual float Unk_88 {
                get => Unk_88_raw;
                set {
                    if (Unk_88_raw == value) return;
                    Unk_88_raw = value;
                    ChangedItems.Add(nameof(Unk_88));
                    OnPropertyChanged(nameof(Unk_88));
                }
            }

            [DisplayName("Offset")]
            public long Unk_88_offset { get; private set; }

            protected float Unk_89_raw;
            public const string Unk_89_displayName = "Unk 89";
            public const int Unk_89_sortIndex = 650;
            [SortOrder(Unk_89_sortIndex)]
            [DisplayName(Unk_89_displayName)]
            public virtual float Unk_89 {
                get => Unk_89_raw;
                set {
                    if (Unk_89_raw == value) return;
                    Unk_89_raw = value;
                    ChangedItems.Add(nameof(Unk_89));
                    OnPropertyChanged(nameof(Unk_89));
                }
            }

            [DisplayName("Offset")]
            public long Unk_89_offset { get; private set; }

            protected float Unk_90_raw;
            public const string Unk_90_displayName = "Unk 90";
            public const int Unk_90_sortIndex = 700;
            [SortOrder(Unk_90_sortIndex)]
            [DisplayName(Unk_90_displayName)]
            public virtual float Unk_90 {
                get => Unk_90_raw;
                set {
                    if (Unk_90_raw == value) return;
                    Unk_90_raw = value;
                    ChangedItems.Add(nameof(Unk_90));
                    OnPropertyChanged(nameof(Unk_90));
                }
            }

            [DisplayName("Offset")]
            public long Unk_90_offset { get; private set; }

            protected float Unk_15_10_1_raw;
            public const string Unk_15_10_1_displayName = "Unk (15.10) 1";
            public const int Unk_15_10_1_sortIndex = 750;
            [SortOrder(Unk_15_10_1_sortIndex)]
            [DisplayName(Unk_15_10_1_displayName)]
            public virtual float Unk_15_10_1 {
                get => Unk_15_10_1_raw;
                set {
                    if (Unk_15_10_1_raw == value) return;
                    Unk_15_10_1_raw = value;
                    ChangedItems.Add(nameof(Unk_15_10_1));
                    OnPropertyChanged(nameof(Unk_15_10_1));
                }
            }

            [DisplayName("Offset")]
            public long Unk_15_10_1_offset { get; private set; }

            protected float Unk_15_10_2_raw;
            public const string Unk_15_10_2_displayName = "Unk (15.10) 2";
            public const int Unk_15_10_2_sortIndex = 800;
            [SortOrder(Unk_15_10_2_sortIndex)]
            [DisplayName(Unk_15_10_2_displayName)]
            public virtual float Unk_15_10_2 {
                get => Unk_15_10_2_raw;
                set {
                    if (Unk_15_10_2_raw == value) return;
                    Unk_15_10_2_raw = value;
                    ChangedItems.Add(nameof(Unk_15_10_2));
                    OnPropertyChanged(nameof(Unk_15_10_2));
                }
            }

            [DisplayName("Offset")]
            public long Unk_15_10_2_offset { get; private set; }

            protected float Unk_15_10_3_raw;
            public const string Unk_15_10_3_displayName = "Unk (15.10) 3";
            public const int Unk_15_10_3_sortIndex = 850;
            [SortOrder(Unk_15_10_3_sortIndex)]
            [DisplayName(Unk_15_10_3_displayName)]
            public virtual float Unk_15_10_3 {
                get => Unk_15_10_3_raw;
                set {
                    if (Unk_15_10_3_raw == value) return;
                    Unk_15_10_3_raw = value;
                    ChangedItems.Add(nameof(Unk_15_10_3));
                    OnPropertyChanged(nameof(Unk_15_10_3));
                }
            }

            [DisplayName("Offset")]
            public long Unk_15_10_3_offset { get; private set; }

            protected float Unk_15_10_4_raw;
            public const string Unk_15_10_4_displayName = "Unk (15.10) 4";
            public const int Unk_15_10_4_sortIndex = 900;
            [SortOrder(Unk_15_10_4_sortIndex)]
            [DisplayName(Unk_15_10_4_displayName)]
            public virtual float Unk_15_10_4 {
                get => Unk_15_10_4_raw;
                set {
                    if (Unk_15_10_4_raw == value) return;
                    Unk_15_10_4_raw = value;
                    ChangedItems.Add(nameof(Unk_15_10_4));
                    OnPropertyChanged(nameof(Unk_15_10_4));
                }
            }

            [DisplayName("Offset")]
            public long Unk_15_10_4_offset { get; private set; }

            protected float Unk_15_10_5_raw;
            public const string Unk_15_10_5_displayName = "Unk (15.10) 5";
            public const int Unk_15_10_5_sortIndex = 950;
            [SortOrder(Unk_15_10_5_sortIndex)]
            [DisplayName(Unk_15_10_5_displayName)]
            public virtual float Unk_15_10_5 {
                get => Unk_15_10_5_raw;
                set {
                    if (Unk_15_10_5_raw == value) return;
                    Unk_15_10_5_raw = value;
                    ChangedItems.Add(nameof(Unk_15_10_5));
                    OnPropertyChanged(nameof(Unk_15_10_5));
                }
            }

            [DisplayName("Offset")]
            public long Unk_15_10_5_offset { get; private set; }

            protected float Unk_15_10_6_raw;
            public const string Unk_15_10_6_displayName = "Unk (15.10) 6";
            public const int Unk_15_10_6_sortIndex = 1000;
            [SortOrder(Unk_15_10_6_sortIndex)]
            [DisplayName(Unk_15_10_6_displayName)]
            public virtual float Unk_15_10_6 {
                get => Unk_15_10_6_raw;
                set {
                    if (Unk_15_10_6_raw == value) return;
                    Unk_15_10_6_raw = value;
                    ChangedItems.Add(nameof(Unk_15_10_6));
                    OnPropertyChanged(nameof(Unk_15_10_6));
                }
            }

            [DisplayName("Offset")]
            public long Unk_15_10_6_offset { get; private set; }

            public const int lastSortIndex = 1050;

            public static ObservableMhwStructCollection<W09p_Params_4_Shared_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W09p_Params_4_Shared_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W09p_Params_4_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new W09p_Params_4_Shared_();
                data.Index = i;
                data.Unk_77_offset = reader.BaseStream.Position;
                data.Unk_77_raw = reader.ReadByte();
                data.Unk_78_offset = reader.BaseStream.Position;
                data.Unk_78_raw = reader.ReadInt32();
                data.Unk_79_offset = reader.BaseStream.Position;
                data.Unk_79_raw = reader.ReadSingle();
                data.Unk_80_offset = reader.BaseStream.Position;
                data.Unk_80_raw = reader.ReadSingle();
                data.Unk_81_offset = reader.BaseStream.Position;
                data.Unk_81_raw = reader.ReadSingle();
                data.Unk_82_offset = reader.BaseStream.Position;
                data.Unk_82_raw = reader.ReadSingle();
                data.Unk_83_offset = reader.BaseStream.Position;
                data.Unk_83_raw = reader.ReadSingle();
                data.Unk_84_offset = reader.BaseStream.Position;
                data.Unk_84_raw = reader.ReadSingle();
                data.Unk_85_offset = reader.BaseStream.Position;
                data.Unk_85_raw = reader.ReadSingle();
                data.Unk_86_offset = reader.BaseStream.Position;
                data.Unk_86_raw = reader.ReadSingle();
                data.Unk_87_offset = reader.BaseStream.Position;
                data.Unk_87_raw = reader.ReadSingle();
                data.Unk_88_offset = reader.BaseStream.Position;
                data.Unk_88_raw = reader.ReadSingle();
                data.Unk_89_offset = reader.BaseStream.Position;
                data.Unk_89_raw = reader.ReadSingle();
                data.Unk_90_offset = reader.BaseStream.Position;
                data.Unk_90_raw = reader.ReadSingle();
                data.Unk_15_10_1_offset = reader.BaseStream.Position;
                data.Unk_15_10_1_raw = reader.ReadSingle();
                data.Unk_15_10_2_offset = reader.BaseStream.Position;
                data.Unk_15_10_2_raw = reader.ReadSingle();
                data.Unk_15_10_3_offset = reader.BaseStream.Position;
                data.Unk_15_10_3_raw = reader.ReadSingle();
                data.Unk_15_10_4_offset = reader.BaseStream.Position;
                data.Unk_15_10_4_raw = reader.ReadSingle();
                data.Unk_15_10_5_offset = reader.BaseStream.Position;
                data.Unk_15_10_5_raw = reader.ReadSingle();
                data.Unk_15_10_6_offset = reader.BaseStream.Position;
                data.Unk_15_10_6_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_77_raw);
                writer.Write(Unk_78_raw);
                writer.Write(Unk_79_raw);
                writer.Write(Unk_80_raw);
                writer.Write(Unk_81_raw);
                writer.Write(Unk_82_raw);
                writer.Write(Unk_83_raw);
                writer.Write(Unk_84_raw);
                writer.Write(Unk_85_raw);
                writer.Write(Unk_86_raw);
                writer.Write(Unk_87_raw);
                writer.Write(Unk_88_raw);
                writer.Write(Unk_89_raw);
                writer.Write(Unk_90_raw);
                writer.Write(Unk_15_10_1_raw);
                writer.Write(Unk_15_10_2_raw);
                writer.Write(Unk_15_10_3_raw);
                writer.Write(Unk_15_10_4_raw);
                writer.Write(Unk_15_10_5_raw);
                writer.Write(Unk_15_10_6_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 77", "Unk_77", "Unk_77_offset"),
                    new MultiStructItemCustomView(this, "Unk 78", "Unk_78", "Unk_78_offset"),
                    new MultiStructItemCustomView(this, "Unk 79", "Unk_79", "Unk_79_offset"),
                    new MultiStructItemCustomView(this, "Unk 80", "Unk_80", "Unk_80_offset"),
                    new MultiStructItemCustomView(this, "Unk 81", "Unk_81", "Unk_81_offset"),
                    new MultiStructItemCustomView(this, "Unk 82", "Unk_82", "Unk_82_offset"),
                    new MultiStructItemCustomView(this, "Unk 83", "Unk_83", "Unk_83_offset"),
                    new MultiStructItemCustomView(this, "Unk 84", "Unk_84", "Unk_84_offset"),
                    new MultiStructItemCustomView(this, "Unk 85", "Unk_85", "Unk_85_offset"),
                    new MultiStructItemCustomView(this, "Unk 86", "Unk_86", "Unk_86_offset"),
                    new MultiStructItemCustomView(this, "Unk 87", "Unk_87", "Unk_87_offset"),
                    new MultiStructItemCustomView(this, "Unk 88", "Unk_88", "Unk_88_offset"),
                    new MultiStructItemCustomView(this, "Unk 89", "Unk_89", "Unk_89_offset"),
                    new MultiStructItemCustomView(this, "Unk 90", "Unk_90", "Unk_90_offset"),
                    new MultiStructItemCustomView(this, "Unk (15.10) 1", "Unk_15_10_1", "Unk_15_10_1_offset"),
                    new MultiStructItemCustomView(this, "Unk (15.10) 2", "Unk_15_10_2", "Unk_15_10_2_offset"),
                    new MultiStructItemCustomView(this, "Unk (15.10) 3", "Unk_15_10_3", "Unk_15_10_3_offset"),
                    new MultiStructItemCustomView(this, "Unk (15.10) 4", "Unk_15_10_4", "Unk_15_10_4_offset"),
                    new MultiStructItemCustomView(this, "Unk (15.10) 5", "Unk_15_10_5", "Unk_15_10_5_offset"),
                    new MultiStructItemCustomView(this, "Unk (15.10) 6", "Unk_15_10_6", "Unk_15_10_6_offset"),
                };
            }
        }

        public partial class W09p_Params_5_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W09p Params (5)";

            protected uint Unk_91_raw;
            public const string Unk_91_displayName = "Unk 91";
            public const int Unk_91_sortIndex = 50;
            [SortOrder(Unk_91_sortIndex)]
            [DisplayName(Unk_91_displayName)]
            public virtual uint Unk_91 {
                get => Unk_91_raw;
                set {
                    if (Unk_91_raw == value) return;
                    Unk_91_raw = value;
                    ChangedItems.Add(nameof(Unk_91));
                    OnPropertyChanged(nameof(Unk_91));
                }
            }

            [DisplayName("Offset")]
            public long Unk_91_offset { get; private set; }

            protected uint Unk_92_raw;
            public const string Unk_92_displayName = "Unk 92";
            public const int Unk_92_sortIndex = 100;
            [SortOrder(Unk_92_sortIndex)]
            [DisplayName(Unk_92_displayName)]
            public virtual uint Unk_92 {
                get => Unk_92_raw;
                set {
                    if (Unk_92_raw == value) return;
                    Unk_92_raw = value;
                    ChangedItems.Add(nameof(Unk_92));
                    OnPropertyChanged(nameof(Unk_92));
                }
            }

            [DisplayName("Offset")]
            public long Unk_92_offset { get; private set; }

            protected float Unk_93_raw;
            public const string Unk_93_displayName = "Unk 93";
            public const int Unk_93_sortIndex = 150;
            [SortOrder(Unk_93_sortIndex)]
            [DisplayName(Unk_93_displayName)]
            public virtual float Unk_93 {
                get => Unk_93_raw;
                set {
                    if (Unk_93_raw == value) return;
                    Unk_93_raw = value;
                    ChangedItems.Add(nameof(Unk_93));
                    OnPropertyChanged(nameof(Unk_93));
                }
            }

            [DisplayName("Offset")]
            public long Unk_93_offset { get; private set; }

            protected float Unk_94_raw;
            public const string Unk_94_displayName = "Unk 94";
            public const int Unk_94_sortIndex = 200;
            [SortOrder(Unk_94_sortIndex)]
            [DisplayName(Unk_94_displayName)]
            public virtual float Unk_94 {
                get => Unk_94_raw;
                set {
                    if (Unk_94_raw == value) return;
                    Unk_94_raw = value;
                    ChangedItems.Add(nameof(Unk_94));
                    OnPropertyChanged(nameof(Unk_94));
                }
            }

            [DisplayName("Offset")]
            public long Unk_94_offset { get; private set; }

            protected float All_Sword_Phial_Damage_Interval_raw;
            public const string All_Sword_Phial_Damage_Interval_displayName = "All Sword Phial Damage Interval";
            public const int All_Sword_Phial_Damage_Interval_sortIndex = 250;
            [SortOrder(All_Sword_Phial_Damage_Interval_sortIndex)]
            [DisplayName(All_Sword_Phial_Damage_Interval_displayName)]
            public virtual float All_Sword_Phial_Damage_Interval {
                get => All_Sword_Phial_Damage_Interval_raw;
                set {
                    if (All_Sword_Phial_Damage_Interval_raw == value) return;
                    All_Sword_Phial_Damage_Interval_raw = value;
                    ChangedItems.Add(nameof(All_Sword_Phial_Damage_Interval));
                    OnPropertyChanged(nameof(All_Sword_Phial_Damage_Interval));
                }
            }

            [DisplayName("Offset")]
            public long All_Sword_Phial_Damage_Interval_offset { get; private set; }

            protected float Shield_Thrust_Phial_Damage_Interval_raw;
            public const string Shield_Thrust_Phial_Damage_Interval_displayName = "Shield Thrust Phial Damage Interval";
            public const int Shield_Thrust_Phial_Damage_Interval_sortIndex = 300;
            [SortOrder(Shield_Thrust_Phial_Damage_Interval_sortIndex)]
            [DisplayName(Shield_Thrust_Phial_Damage_Interval_displayName)]
            public virtual float Shield_Thrust_Phial_Damage_Interval {
                get => Shield_Thrust_Phial_Damage_Interval_raw;
                set {
                    if (Shield_Thrust_Phial_Damage_Interval_raw == value) return;
                    Shield_Thrust_Phial_Damage_Interval_raw = value;
                    ChangedItems.Add(nameof(Shield_Thrust_Phial_Damage_Interval));
                    OnPropertyChanged(nameof(Shield_Thrust_Phial_Damage_Interval));
                }
            }

            [DisplayName("Offset")]
            public long Shield_Thrust_Phial_Damage_Interval_offset { get; private set; }

            protected float Axe_Elemental_Discharge_1_Rushing_Element_Discharge_1_Phial_Damage_Interval_Same_Move_Just_Different_Input__raw;
            public const string Axe_Elemental_Discharge_1_Rushing_Element_Discharge_1_Phial_Damage_Interval_Same_Move_Just_Different_Input__displayName = "Axe Elemental Discharge 1 / Rushing Element Discharge 1 Phial Damage Interval (Same Move Just Different Input)";
            public const int Axe_Elemental_Discharge_1_Rushing_Element_Discharge_1_Phial_Damage_Interval_Same_Move_Just_Different_Input__sortIndex = 350;
            [SortOrder(Axe_Elemental_Discharge_1_Rushing_Element_Discharge_1_Phial_Damage_Interval_Same_Move_Just_Different_Input__sortIndex)]
            [DisplayName(Axe_Elemental_Discharge_1_Rushing_Element_Discharge_1_Phial_Damage_Interval_Same_Move_Just_Different_Input__displayName)]
            public virtual float Axe_Elemental_Discharge_1_Rushing_Element_Discharge_1_Phial_Damage_Interval_Same_Move_Just_Different_Input_ {
                get => Axe_Elemental_Discharge_1_Rushing_Element_Discharge_1_Phial_Damage_Interval_Same_Move_Just_Different_Input__raw;
                set {
                    if (Axe_Elemental_Discharge_1_Rushing_Element_Discharge_1_Phial_Damage_Interval_Same_Move_Just_Different_Input__raw == value) return;
                    Axe_Elemental_Discharge_1_Rushing_Element_Discharge_1_Phial_Damage_Interval_Same_Move_Just_Different_Input__raw = value;
                    ChangedItems.Add(nameof(Axe_Elemental_Discharge_1_Rushing_Element_Discharge_1_Phial_Damage_Interval_Same_Move_Just_Different_Input_));
                    OnPropertyChanged(nameof(Axe_Elemental_Discharge_1_Rushing_Element_Discharge_1_Phial_Damage_Interval_Same_Move_Just_Different_Input_));
                }
            }

            [DisplayName("Offset")]
            public long Axe_Elemental_Discharge_1_Rushing_Element_Discharge_1_Phial_Damage_Interval_Same_Move_Just_Different_Input__offset { get; private set; }

            protected float Axe_Elemental_Discharge_2_First_Hit_Phial_Damage_Interval_raw;
            public const string Axe_Elemental_Discharge_2_First_Hit_Phial_Damage_Interval_displayName = "Axe Elemental Discharge 2 First Hit Phial Damage Interval";
            public const int Axe_Elemental_Discharge_2_First_Hit_Phial_Damage_Interval_sortIndex = 400;
            [SortOrder(Axe_Elemental_Discharge_2_First_Hit_Phial_Damage_Interval_sortIndex)]
            [DisplayName(Axe_Elemental_Discharge_2_First_Hit_Phial_Damage_Interval_displayName)]
            public virtual float Axe_Elemental_Discharge_2_First_Hit_Phial_Damage_Interval {
                get => Axe_Elemental_Discharge_2_First_Hit_Phial_Damage_Interval_raw;
                set {
                    if (Axe_Elemental_Discharge_2_First_Hit_Phial_Damage_Interval_raw == value) return;
                    Axe_Elemental_Discharge_2_First_Hit_Phial_Damage_Interval_raw = value;
                    ChangedItems.Add(nameof(Axe_Elemental_Discharge_2_First_Hit_Phial_Damage_Interval));
                    OnPropertyChanged(nameof(Axe_Elemental_Discharge_2_First_Hit_Phial_Damage_Interval));
                }
            }

            [DisplayName("Offset")]
            public long Axe_Elemental_Discharge_2_First_Hit_Phial_Damage_Interval_offset { get; private set; }

            protected float Axe_Elemental_Discharge_2_Second_Hit_Phial_Damage_Interval_raw;
            public const string Axe_Elemental_Discharge_2_Second_Hit_Phial_Damage_Interval_displayName = "Axe Elemental Discharge 2 Second Hit Phial Damage Interval";
            public const int Axe_Elemental_Discharge_2_Second_Hit_Phial_Damage_Interval_sortIndex = 450;
            [SortOrder(Axe_Elemental_Discharge_2_Second_Hit_Phial_Damage_Interval_sortIndex)]
            [DisplayName(Axe_Elemental_Discharge_2_Second_Hit_Phial_Damage_Interval_displayName)]
            public virtual float Axe_Elemental_Discharge_2_Second_Hit_Phial_Damage_Interval {
                get => Axe_Elemental_Discharge_2_Second_Hit_Phial_Damage_Interval_raw;
                set {
                    if (Axe_Elemental_Discharge_2_Second_Hit_Phial_Damage_Interval_raw == value) return;
                    Axe_Elemental_Discharge_2_Second_Hit_Phial_Damage_Interval_raw = value;
                    ChangedItems.Add(nameof(Axe_Elemental_Discharge_2_Second_Hit_Phial_Damage_Interval));
                    OnPropertyChanged(nameof(Axe_Elemental_Discharge_2_Second_Hit_Phial_Damage_Interval));
                }
            }

            [DisplayName("Offset")]
            public long Axe_Elemental_Discharge_2_Second_Hit_Phial_Damage_Interval_offset { get; private set; }

            protected float AED_Phial_Damage_Interval_raw;
            public const string AED_Phial_Damage_Interval_displayName = "AED Phial Damage Interval";
            public const int AED_Phial_Damage_Interval_sortIndex = 500;
            [SortOrder(AED_Phial_Damage_Interval_sortIndex)]
            [DisplayName(AED_Phial_Damage_Interval_displayName)]
            public virtual float AED_Phial_Damage_Interval {
                get => AED_Phial_Damage_Interval_raw;
                set {
                    if (AED_Phial_Damage_Interval_raw == value) return;
                    AED_Phial_Damage_Interval_raw = value;
                    ChangedItems.Add(nameof(AED_Phial_Damage_Interval));
                    OnPropertyChanged(nameof(AED_Phial_Damage_Interval));
                }
            }

            [DisplayName("Offset")]
            public long AED_Phial_Damage_Interval_offset { get; private set; }

            protected byte Charge_to_Reach_Yellow_Phial_raw;
            public const string Charge_to_Reach_Yellow_Phial_displayName = "Charge to Reach Yellow Phial";
            public const int Charge_to_Reach_Yellow_Phial_sortIndex = 550;
            [SortOrder(Charge_to_Reach_Yellow_Phial_sortIndex)]
            [DisplayName(Charge_to_Reach_Yellow_Phial_displayName)]
            public virtual byte Charge_to_Reach_Yellow_Phial {
                get => Charge_to_Reach_Yellow_Phial_raw;
                set {
                    if (Charge_to_Reach_Yellow_Phial_raw == value) return;
                    Charge_to_Reach_Yellow_Phial_raw = value;
                    ChangedItems.Add(nameof(Charge_to_Reach_Yellow_Phial));
                    OnPropertyChanged(nameof(Charge_to_Reach_Yellow_Phial));
                }
            }

            [DisplayName("Offset")]
            public long Charge_to_Reach_Yellow_Phial_offset { get; private set; }

            protected byte Charge_to_Reach_Red_Phial_raw;
            public const string Charge_to_Reach_Red_Phial_displayName = "Charge to Reach Red Phial";
            public const int Charge_to_Reach_Red_Phial_sortIndex = 600;
            [SortOrder(Charge_to_Reach_Red_Phial_sortIndex)]
            [DisplayName(Charge_to_Reach_Red_Phial_displayName)]
            public virtual byte Charge_to_Reach_Red_Phial {
                get => Charge_to_Reach_Red_Phial_raw;
                set {
                    if (Charge_to_Reach_Red_Phial_raw == value) return;
                    Charge_to_Reach_Red_Phial_raw = value;
                    ChangedItems.Add(nameof(Charge_to_Reach_Red_Phial));
                    OnPropertyChanged(nameof(Charge_to_Reach_Red_Phial));
                }
            }

            [DisplayName("Offset")]
            public long Charge_to_Reach_Red_Phial_offset { get; private set; }

            protected byte Charge_Gained_When_Blocking_a_Small_Knock_back_raw;
            public const string Charge_Gained_When_Blocking_a_Small_Knock_back_displayName = "Charge Gained When Blocking a Small Knock-back";
            public const int Charge_Gained_When_Blocking_a_Small_Knock_back_sortIndex = 650;
            [SortOrder(Charge_Gained_When_Blocking_a_Small_Knock_back_sortIndex)]
            [DisplayName(Charge_Gained_When_Blocking_a_Small_Knock_back_displayName)]
            public virtual byte Charge_Gained_When_Blocking_a_Small_Knock_back {
                get => Charge_Gained_When_Blocking_a_Small_Knock_back_raw;
                set {
                    if (Charge_Gained_When_Blocking_a_Small_Knock_back_raw == value) return;
                    Charge_Gained_When_Blocking_a_Small_Knock_back_raw = value;
                    ChangedItems.Add(nameof(Charge_Gained_When_Blocking_a_Small_Knock_back));
                    OnPropertyChanged(nameof(Charge_Gained_When_Blocking_a_Small_Knock_back));
                }
            }

            [DisplayName("Offset")]
            public long Charge_Gained_When_Blocking_a_Small_Knock_back_offset { get; private set; }

            protected byte Charge_Gained_When_Blocking_a_Medium_Knock_back_raw;
            public const string Charge_Gained_When_Blocking_a_Medium_Knock_back_displayName = "Charge Gained When Blocking a Medium Knock-back";
            public const int Charge_Gained_When_Blocking_a_Medium_Knock_back_sortIndex = 700;
            [SortOrder(Charge_Gained_When_Blocking_a_Medium_Knock_back_sortIndex)]
            [DisplayName(Charge_Gained_When_Blocking_a_Medium_Knock_back_displayName)]
            public virtual byte Charge_Gained_When_Blocking_a_Medium_Knock_back {
                get => Charge_Gained_When_Blocking_a_Medium_Knock_back_raw;
                set {
                    if (Charge_Gained_When_Blocking_a_Medium_Knock_back_raw == value) return;
                    Charge_Gained_When_Blocking_a_Medium_Knock_back_raw = value;
                    ChangedItems.Add(nameof(Charge_Gained_When_Blocking_a_Medium_Knock_back));
                    OnPropertyChanged(nameof(Charge_Gained_When_Blocking_a_Medium_Knock_back));
                }
            }

            [DisplayName("Offset")]
            public long Charge_Gained_When_Blocking_a_Medium_Knock_back_offset { get; private set; }

            protected byte Charge_Gained_When_Blocking_a_Large_Knock_back_raw;
            public const string Charge_Gained_When_Blocking_a_Large_Knock_back_displayName = "Charge Gained When Blocking a Large Knock-back";
            public const int Charge_Gained_When_Blocking_a_Large_Knock_back_sortIndex = 750;
            [SortOrder(Charge_Gained_When_Blocking_a_Large_Knock_back_sortIndex)]
            [DisplayName(Charge_Gained_When_Blocking_a_Large_Knock_back_displayName)]
            public virtual byte Charge_Gained_When_Blocking_a_Large_Knock_back {
                get => Charge_Gained_When_Blocking_a_Large_Knock_back_raw;
                set {
                    if (Charge_Gained_When_Blocking_a_Large_Knock_back_raw == value) return;
                    Charge_Gained_When_Blocking_a_Large_Knock_back_raw = value;
                    ChangedItems.Add(nameof(Charge_Gained_When_Blocking_a_Large_Knock_back));
                    OnPropertyChanged(nameof(Charge_Gained_When_Blocking_a_Large_Knock_back));
                }
            }

            [DisplayName("Offset")]
            public long Charge_Gained_When_Blocking_a_Large_Knock_back_offset { get; private set; }

            protected byte Overcharged_Phial_raw;
            public const string Overcharged_Phial_displayName = "Overcharged Phial";
            public const int Overcharged_Phial_sortIndex = 800;
            [SortOrder(Overcharged_Phial_sortIndex)]
            [DisplayName(Overcharged_Phial_displayName)]
            public virtual byte Overcharged_Phial {
                get => Overcharged_Phial_raw;
                set {
                    if (Overcharged_Phial_raw == value) return;
                    Overcharged_Phial_raw = value;
                    ChangedItems.Add(nameof(Overcharged_Phial));
                    OnPropertyChanged(nameof(Overcharged_Phial));
                }
            }

            [DisplayName("Offset")]
            public long Overcharged_Phial_offset { get; private set; }

            protected byte Phial_Charge_Limit_raw;
            public const string Phial_Charge_Limit_displayName = "Phial Charge Limit";
            public const int Phial_Charge_Limit_sortIndex = 850;
            [SortOrder(Phial_Charge_Limit_sortIndex)]
            [DisplayName(Phial_Charge_Limit_displayName)]
            public virtual byte Phial_Charge_Limit {
                get => Phial_Charge_Limit_raw;
                set {
                    if (Phial_Charge_Limit_raw == value) return;
                    Phial_Charge_Limit_raw = value;
                    ChangedItems.Add(nameof(Phial_Charge_Limit));
                    OnPropertyChanged(nameof(Phial_Charge_Limit));
                }
            }

            [DisplayName("Offset")]
            public long Phial_Charge_Limit_offset { get; private set; }

            protected float Axe_Mode_Damage_Multiplier_raw;
            public const string Axe_Mode_Damage_Multiplier_displayName = "Axe Mode Damage Multiplier";
            public const int Axe_Mode_Damage_Multiplier_sortIndex = 900;
            [SortOrder(Axe_Mode_Damage_Multiplier_sortIndex)]
            [DisplayName(Axe_Mode_Damage_Multiplier_displayName)]
            public virtual float Axe_Mode_Damage_Multiplier {
                get => Axe_Mode_Damage_Multiplier_raw;
                set {
                    if (Axe_Mode_Damage_Multiplier_raw == value) return;
                    Axe_Mode_Damage_Multiplier_raw = value;
                    ChangedItems.Add(nameof(Axe_Mode_Damage_Multiplier));
                    OnPropertyChanged(nameof(Axe_Mode_Damage_Multiplier));
                }
            }

            [DisplayName("Offset")]
            public long Axe_Mode_Damage_Multiplier_offset { get; private set; }

            protected float Guard_Point_Sharpness_Cost_Multiplier_raw;
            public const string Guard_Point_Sharpness_Cost_Multiplier_displayName = "Guard Point Sharpness Cost Multiplier";
            public const int Guard_Point_Sharpness_Cost_Multiplier_sortIndex = 950;
            [SortOrder(Guard_Point_Sharpness_Cost_Multiplier_sortIndex)]
            [DisplayName(Guard_Point_Sharpness_Cost_Multiplier_displayName)]
            public virtual float Guard_Point_Sharpness_Cost_Multiplier {
                get => Guard_Point_Sharpness_Cost_Multiplier_raw;
                set {
                    if (Guard_Point_Sharpness_Cost_Multiplier_raw == value) return;
                    Guard_Point_Sharpness_Cost_Multiplier_raw = value;
                    ChangedItems.Add(nameof(Guard_Point_Sharpness_Cost_Multiplier));
                    OnPropertyChanged(nameof(Guard_Point_Sharpness_Cost_Multiplier));
                }
            }

            [DisplayName("Offset")]
            public long Guard_Point_Sharpness_Cost_Multiplier_offset { get; private set; }

            protected float Impact_Phial_Damage_Multiplier_Not_for_SAED__raw;
            public const string Impact_Phial_Damage_Multiplier_Not_for_SAED__displayName = "Impact Phial Damage Multiplier (Not for SAED)";
            public const int Impact_Phial_Damage_Multiplier_Not_for_SAED__sortIndex = 1000;
            [SortOrder(Impact_Phial_Damage_Multiplier_Not_for_SAED__sortIndex)]
            [DisplayName(Impact_Phial_Damage_Multiplier_Not_for_SAED__displayName)]
            public virtual float Impact_Phial_Damage_Multiplier_Not_for_SAED_ {
                get => Impact_Phial_Damage_Multiplier_Not_for_SAED__raw;
                set {
                    if (Impact_Phial_Damage_Multiplier_Not_for_SAED__raw == value) return;
                    Impact_Phial_Damage_Multiplier_Not_for_SAED__raw = value;
                    ChangedItems.Add(nameof(Impact_Phial_Damage_Multiplier_Not_for_SAED_));
                    OnPropertyChanged(nameof(Impact_Phial_Damage_Multiplier_Not_for_SAED_));
                }
            }

            [DisplayName("Offset")]
            public long Impact_Phial_Damage_Multiplier_Not_for_SAED__offset { get; private set; }

            protected float Impact_Phial_Stun_Buildup_Multiplier_raw;
            public const string Impact_Phial_Stun_Buildup_Multiplier_displayName = "Impact Phial Stun Buildup Multiplier";
            public const int Impact_Phial_Stun_Buildup_Multiplier_sortIndex = 1050;
            [SortOrder(Impact_Phial_Stun_Buildup_Multiplier_sortIndex)]
            [DisplayName(Impact_Phial_Stun_Buildup_Multiplier_displayName)]
            public virtual float Impact_Phial_Stun_Buildup_Multiplier {
                get => Impact_Phial_Stun_Buildup_Multiplier_raw;
                set {
                    if (Impact_Phial_Stun_Buildup_Multiplier_raw == value) return;
                    Impact_Phial_Stun_Buildup_Multiplier_raw = value;
                    ChangedItems.Add(nameof(Impact_Phial_Stun_Buildup_Multiplier));
                    OnPropertyChanged(nameof(Impact_Phial_Stun_Buildup_Multiplier));
                }
            }

            [DisplayName("Offset")]
            public long Impact_Phial_Stun_Buildup_Multiplier_offset { get; private set; }

            protected float Impact_Phial_Exhaust_Buildup_Multiplier_raw;
            public const string Impact_Phial_Exhaust_Buildup_Multiplier_displayName = "Impact Phial Exhaust Buildup Multiplier";
            public const int Impact_Phial_Exhaust_Buildup_Multiplier_sortIndex = 1100;
            [SortOrder(Impact_Phial_Exhaust_Buildup_Multiplier_sortIndex)]
            [DisplayName(Impact_Phial_Exhaust_Buildup_Multiplier_displayName)]
            public virtual float Impact_Phial_Exhaust_Buildup_Multiplier {
                get => Impact_Phial_Exhaust_Buildup_Multiplier_raw;
                set {
                    if (Impact_Phial_Exhaust_Buildup_Multiplier_raw == value) return;
                    Impact_Phial_Exhaust_Buildup_Multiplier_raw = value;
                    ChangedItems.Add(nameof(Impact_Phial_Exhaust_Buildup_Multiplier));
                    OnPropertyChanged(nameof(Impact_Phial_Exhaust_Buildup_Multiplier));
                }
            }

            [DisplayName("Offset")]
            public long Impact_Phial_Exhaust_Buildup_Multiplier_offset { get; private set; }

            protected float Elemental_Phial_Damage_Multiplier_Not_for_SAED__raw;
            public const string Elemental_Phial_Damage_Multiplier_Not_for_SAED__displayName = "Elemental Phial Damage Multiplier (Not for SAED)";
            public const int Elemental_Phial_Damage_Multiplier_Not_for_SAED__sortIndex = 1150;
            [SortOrder(Elemental_Phial_Damage_Multiplier_Not_for_SAED__sortIndex)]
            [DisplayName(Elemental_Phial_Damage_Multiplier_Not_for_SAED__displayName)]
            public virtual float Elemental_Phial_Damage_Multiplier_Not_for_SAED_ {
                get => Elemental_Phial_Damage_Multiplier_Not_for_SAED__raw;
                set {
                    if (Elemental_Phial_Damage_Multiplier_Not_for_SAED__raw == value) return;
                    Elemental_Phial_Damage_Multiplier_Not_for_SAED__raw = value;
                    ChangedItems.Add(nameof(Elemental_Phial_Damage_Multiplier_Not_for_SAED_));
                    OnPropertyChanged(nameof(Elemental_Phial_Damage_Multiplier_Not_for_SAED_));
                }
            }

            [DisplayName("Offset")]
            public long Elemental_Phial_Damage_Multiplier_Not_for_SAED__offset { get; private set; }

            protected float Phial_Duration_raw;
            public const string Phial_Duration_displayName = "Phial Duration";
            public const int Phial_Duration_sortIndex = 1200;
            [SortOrder(Phial_Duration_sortIndex)]
            [DisplayName(Phial_Duration_displayName)]
            public virtual float Phial_Duration {
                get => Phial_Duration_raw;
                set {
                    if (Phial_Duration_raw == value) return;
                    Phial_Duration_raw = value;
                    ChangedItems.Add(nameof(Phial_Duration));
                    OnPropertyChanged(nameof(Phial_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Phial_Duration_offset { get; private set; }

            protected byte Shield_Charge_Guard_Threshold_Bonus_raw;
            public const string Shield_Charge_Guard_Threshold_Bonus_displayName = "Shield Charge Guard Threshold Bonus";
            public const int Shield_Charge_Guard_Threshold_Bonus_sortIndex = 1250;
            [SortOrder(Shield_Charge_Guard_Threshold_Bonus_sortIndex)]
            [DisplayName(Shield_Charge_Guard_Threshold_Bonus_displayName)]
            public virtual byte Shield_Charge_Guard_Threshold_Bonus {
                get => Shield_Charge_Guard_Threshold_Bonus_raw;
                set {
                    if (Shield_Charge_Guard_Threshold_Bonus_raw == value) return;
                    Shield_Charge_Guard_Threshold_Bonus_raw = value;
                    ChangedItems.Add(nameof(Shield_Charge_Guard_Threshold_Bonus));
                    OnPropertyChanged(nameof(Shield_Charge_Guard_Threshold_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Shield_Charge_Guard_Threshold_Bonus_offset { get; private set; }

            protected float Charged_Shield_Warning_Duration_When_About_to_End_raw;
            public const string Charged_Shield_Warning_Duration_When_About_to_End_displayName = "Charged Shield Warning Duration When About to End";
            public const int Charged_Shield_Warning_Duration_When_About_to_End_sortIndex = 1300;
            [SortOrder(Charged_Shield_Warning_Duration_When_About_to_End_sortIndex)]
            [DisplayName(Charged_Shield_Warning_Duration_When_About_to_End_displayName)]
            public virtual float Charged_Shield_Warning_Duration_When_About_to_End {
                get => Charged_Shield_Warning_Duration_When_About_to_End_raw;
                set {
                    if (Charged_Shield_Warning_Duration_When_About_to_End_raw == value) return;
                    Charged_Shield_Warning_Duration_When_About_to_End_raw = value;
                    ChangedItems.Add(nameof(Charged_Shield_Warning_Duration_When_About_to_End));
                    OnPropertyChanged(nameof(Charged_Shield_Warning_Duration_When_About_to_End));
                }
            }

            [DisplayName("Offset")]
            public long Charged_Shield_Warning_Duration_When_About_to_End_offset { get; private set; }

            protected float Charged_Sword_Warning_Duration_When_About_to_End_raw;
            public const string Charged_Sword_Warning_Duration_When_About_to_End_displayName = "Charged Sword Warning Duration When About to End";
            public const int Charged_Sword_Warning_Duration_When_About_to_End_sortIndex = 1350;
            [SortOrder(Charged_Sword_Warning_Duration_When_About_to_End_sortIndex)]
            [DisplayName(Charged_Sword_Warning_Duration_When_About_to_End_displayName)]
            public virtual float Charged_Sword_Warning_Duration_When_About_to_End {
                get => Charged_Sword_Warning_Duration_When_About_to_End_raw;
                set {
                    if (Charged_Sword_Warning_Duration_When_About_to_End_raw == value) return;
                    Charged_Sword_Warning_Duration_When_About_to_End_raw = value;
                    ChangedItems.Add(nameof(Charged_Sword_Warning_Duration_When_About_to_End));
                    OnPropertyChanged(nameof(Charged_Sword_Warning_Duration_When_About_to_End));
                }
            }

            [DisplayName("Offset")]
            public long Charged_Sword_Warning_Duration_When_About_to_End_offset { get; private set; }

            protected float Sword_Charge_Duration_raw;
            public const string Sword_Charge_Duration_displayName = "Sword Charge Duration";
            public const int Sword_Charge_Duration_sortIndex = 1400;
            [SortOrder(Sword_Charge_Duration_sortIndex)]
            [DisplayName(Sword_Charge_Duration_displayName)]
            public virtual float Sword_Charge_Duration {
                get => Sword_Charge_Duration_raw;
                set {
                    if (Sword_Charge_Duration_raw == value) return;
                    Sword_Charge_Duration_raw = value;
                    ChangedItems.Add(nameof(Sword_Charge_Duration));
                    OnPropertyChanged(nameof(Sword_Charge_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Sword_Charge_Duration_offset { get; private set; }

            protected float Unk_119_raw;
            public const string Unk_119_displayName = "Unk 119";
            public const int Unk_119_sortIndex = 1450;
            [SortOrder(Unk_119_sortIndex)]
            [DisplayName(Unk_119_displayName)]
            public virtual float Unk_119 {
                get => Unk_119_raw;
                set {
                    if (Unk_119_raw == value) return;
                    Unk_119_raw = value;
                    ChangedItems.Add(nameof(Unk_119));
                    OnPropertyChanged(nameof(Unk_119));
                }
            }

            [DisplayName("Offset")]
            public long Unk_119_offset { get; private set; }

            protected float Unk_120_raw;
            public const string Unk_120_displayName = "Unk 120";
            public const int Unk_120_sortIndex = 1500;
            [SortOrder(Unk_120_sortIndex)]
            [DisplayName(Unk_120_displayName)]
            public virtual float Unk_120 {
                get => Unk_120_raw;
                set {
                    if (Unk_120_raw == value) return;
                    Unk_120_raw = value;
                    ChangedItems.Add(nameof(Unk_120));
                    OnPropertyChanged(nameof(Unk_120));
                }
            }

            [DisplayName("Offset")]
            public long Unk_120_offset { get; private set; }

            protected float Unk_121_raw;
            public const string Unk_121_displayName = "Unk 121";
            public const int Unk_121_sortIndex = 1550;
            [SortOrder(Unk_121_sortIndex)]
            [DisplayName(Unk_121_displayName)]
            public virtual float Unk_121 {
                get => Unk_121_raw;
                set {
                    if (Unk_121_raw == value) return;
                    Unk_121_raw = value;
                    ChangedItems.Add(nameof(Unk_121));
                    OnPropertyChanged(nameof(Unk_121));
                }
            }

            [DisplayName("Offset")]
            public long Unk_121_offset { get; private set; }

            protected float Unk_122_raw;
            public const string Unk_122_displayName = "Unk 122";
            public const int Unk_122_sortIndex = 1600;
            [SortOrder(Unk_122_sortIndex)]
            [DisplayName(Unk_122_displayName)]
            public virtual float Unk_122 {
                get => Unk_122_raw;
                set {
                    if (Unk_122_raw == value) return;
                    Unk_122_raw = value;
                    ChangedItems.Add(nameof(Unk_122));
                    OnPropertyChanged(nameof(Unk_122));
                }
            }

            [DisplayName("Offset")]
            public long Unk_122_offset { get; private set; }

            public const int lastSortIndex = 1650;

            public static ObservableMhwStructCollection<W09p_Params_5_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W09p_Params_5_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W09p_Params_5_ LoadData(BinaryReader reader, ulong i) {
                var data = new W09p_Params_5_();
                data.Index = i;
                data.Unk_91_offset = reader.BaseStream.Position;
                data.Unk_91_raw = reader.ReadUInt32();
                data.Unk_92_offset = reader.BaseStream.Position;
                data.Unk_92_raw = reader.ReadUInt32();
                data.Unk_93_offset = reader.BaseStream.Position;
                data.Unk_93_raw = reader.ReadSingle();
                data.Unk_94_offset = reader.BaseStream.Position;
                data.Unk_94_raw = reader.ReadSingle();
                data.All_Sword_Phial_Damage_Interval_offset = reader.BaseStream.Position;
                data.All_Sword_Phial_Damage_Interval_raw = reader.ReadSingle();
                data.Shield_Thrust_Phial_Damage_Interval_offset = reader.BaseStream.Position;
                data.Shield_Thrust_Phial_Damage_Interval_raw = reader.ReadSingle();
                data.Axe_Elemental_Discharge_1_Rushing_Element_Discharge_1_Phial_Damage_Interval_Same_Move_Just_Different_Input__offset = reader.BaseStream.Position;
                data.Axe_Elemental_Discharge_1_Rushing_Element_Discharge_1_Phial_Damage_Interval_Same_Move_Just_Different_Input__raw = reader.ReadSingle();
                data.Axe_Elemental_Discharge_2_First_Hit_Phial_Damage_Interval_offset = reader.BaseStream.Position;
                data.Axe_Elemental_Discharge_2_First_Hit_Phial_Damage_Interval_raw = reader.ReadSingle();
                data.Axe_Elemental_Discharge_2_Second_Hit_Phial_Damage_Interval_offset = reader.BaseStream.Position;
                data.Axe_Elemental_Discharge_2_Second_Hit_Phial_Damage_Interval_raw = reader.ReadSingle();
                data.AED_Phial_Damage_Interval_offset = reader.BaseStream.Position;
                data.AED_Phial_Damage_Interval_raw = reader.ReadSingle();
                data.Charge_to_Reach_Yellow_Phial_offset = reader.BaseStream.Position;
                data.Charge_to_Reach_Yellow_Phial_raw = reader.ReadByte();
                data.Charge_to_Reach_Red_Phial_offset = reader.BaseStream.Position;
                data.Charge_to_Reach_Red_Phial_raw = reader.ReadByte();
                data.Charge_Gained_When_Blocking_a_Small_Knock_back_offset = reader.BaseStream.Position;
                data.Charge_Gained_When_Blocking_a_Small_Knock_back_raw = reader.ReadByte();
                data.Charge_Gained_When_Blocking_a_Medium_Knock_back_offset = reader.BaseStream.Position;
                data.Charge_Gained_When_Blocking_a_Medium_Knock_back_raw = reader.ReadByte();
                data.Charge_Gained_When_Blocking_a_Large_Knock_back_offset = reader.BaseStream.Position;
                data.Charge_Gained_When_Blocking_a_Large_Knock_back_raw = reader.ReadByte();
                data.Overcharged_Phial_offset = reader.BaseStream.Position;
                data.Overcharged_Phial_raw = reader.ReadByte();
                data.Phial_Charge_Limit_offset = reader.BaseStream.Position;
                data.Phial_Charge_Limit_raw = reader.ReadByte();
                data.Axe_Mode_Damage_Multiplier_offset = reader.BaseStream.Position;
                data.Axe_Mode_Damage_Multiplier_raw = reader.ReadSingle();
                data.Guard_Point_Sharpness_Cost_Multiplier_offset = reader.BaseStream.Position;
                data.Guard_Point_Sharpness_Cost_Multiplier_raw = reader.ReadSingle();
                data.Impact_Phial_Damage_Multiplier_Not_for_SAED__offset = reader.BaseStream.Position;
                data.Impact_Phial_Damage_Multiplier_Not_for_SAED__raw = reader.ReadSingle();
                data.Impact_Phial_Stun_Buildup_Multiplier_offset = reader.BaseStream.Position;
                data.Impact_Phial_Stun_Buildup_Multiplier_raw = reader.ReadSingle();
                data.Impact_Phial_Exhaust_Buildup_Multiplier_offset = reader.BaseStream.Position;
                data.Impact_Phial_Exhaust_Buildup_Multiplier_raw = reader.ReadSingle();
                data.Elemental_Phial_Damage_Multiplier_Not_for_SAED__offset = reader.BaseStream.Position;
                data.Elemental_Phial_Damage_Multiplier_Not_for_SAED__raw = reader.ReadSingle();
                data.Phial_Duration_offset = reader.BaseStream.Position;
                data.Phial_Duration_raw = reader.ReadSingle();
                data.Shield_Charge_Guard_Threshold_Bonus_offset = reader.BaseStream.Position;
                data.Shield_Charge_Guard_Threshold_Bonus_raw = reader.ReadByte();
                data.Charged_Shield_Warning_Duration_When_About_to_End_offset = reader.BaseStream.Position;
                data.Charged_Shield_Warning_Duration_When_About_to_End_raw = reader.ReadSingle();
                data.Charged_Sword_Warning_Duration_When_About_to_End_offset = reader.BaseStream.Position;
                data.Charged_Sword_Warning_Duration_When_About_to_End_raw = reader.ReadSingle();
                data.Sword_Charge_Duration_offset = reader.BaseStream.Position;
                data.Sword_Charge_Duration_raw = reader.ReadSingle();
                data.Unk_119_offset = reader.BaseStream.Position;
                data.Unk_119_raw = reader.ReadSingle();
                data.Unk_120_offset = reader.BaseStream.Position;
                data.Unk_120_raw = reader.ReadSingle();
                data.Unk_121_offset = reader.BaseStream.Position;
                data.Unk_121_raw = reader.ReadSingle();
                data.Unk_122_offset = reader.BaseStream.Position;
                data.Unk_122_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_91_raw);
                writer.Write(Unk_92_raw);
                writer.Write(Unk_93_raw);
                writer.Write(Unk_94_raw);
                writer.Write(All_Sword_Phial_Damage_Interval_raw);
                writer.Write(Shield_Thrust_Phial_Damage_Interval_raw);
                writer.Write(Axe_Elemental_Discharge_1_Rushing_Element_Discharge_1_Phial_Damage_Interval_Same_Move_Just_Different_Input__raw);
                writer.Write(Axe_Elemental_Discharge_2_First_Hit_Phial_Damage_Interval_raw);
                writer.Write(Axe_Elemental_Discharge_2_Second_Hit_Phial_Damage_Interval_raw);
                writer.Write(AED_Phial_Damage_Interval_raw);
                writer.Write(Charge_to_Reach_Yellow_Phial_raw);
                writer.Write(Charge_to_Reach_Red_Phial_raw);
                writer.Write(Charge_Gained_When_Blocking_a_Small_Knock_back_raw);
                writer.Write(Charge_Gained_When_Blocking_a_Medium_Knock_back_raw);
                writer.Write(Charge_Gained_When_Blocking_a_Large_Knock_back_raw);
                writer.Write(Overcharged_Phial_raw);
                writer.Write(Phial_Charge_Limit_raw);
                writer.Write(Axe_Mode_Damage_Multiplier_raw);
                writer.Write(Guard_Point_Sharpness_Cost_Multiplier_raw);
                writer.Write(Impact_Phial_Damage_Multiplier_Not_for_SAED__raw);
                writer.Write(Impact_Phial_Stun_Buildup_Multiplier_raw);
                writer.Write(Impact_Phial_Exhaust_Buildup_Multiplier_raw);
                writer.Write(Elemental_Phial_Damage_Multiplier_Not_for_SAED__raw);
                writer.Write(Phial_Duration_raw);
                writer.Write(Shield_Charge_Guard_Threshold_Bonus_raw);
                writer.Write(Charged_Shield_Warning_Duration_When_About_to_End_raw);
                writer.Write(Charged_Sword_Warning_Duration_When_About_to_End_raw);
                writer.Write(Sword_Charge_Duration_raw);
                writer.Write(Unk_119_raw);
                writer.Write(Unk_120_raw);
                writer.Write(Unk_121_raw);
                writer.Write(Unk_122_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 91", "Unk_91", "Unk_91_offset"),
                    new MultiStructItemCustomView(this, "Unk 92", "Unk_92", "Unk_92_offset"),
                    new MultiStructItemCustomView(this, "Unk 93", "Unk_93", "Unk_93_offset"),
                    new MultiStructItemCustomView(this, "Unk 94", "Unk_94", "Unk_94_offset"),
                    new MultiStructItemCustomView(this, "All Sword Phial Damage Interval", "All_Sword_Phial_Damage_Interval", "All_Sword_Phial_Damage_Interval_offset"),
                    new MultiStructItemCustomView(this, "Shield Thrust Phial Damage Interval", "Shield_Thrust_Phial_Damage_Interval", "Shield_Thrust_Phial_Damage_Interval_offset"),
                    new MultiStructItemCustomView(this, "Axe Elemental Discharge 1 / Rushing Element Discharge 1 Phial Damage Interval (Same Move Just Different Input)", "Axe_Elemental_Discharge_1_Rushing_Element_Discharge_1_Phial_Damage_Interval_Same_Move_Just_Different_Input_", "Axe_Elemental_Discharge_1_Rushing_Element_Discharge_1_Phial_Damage_Interval_Same_Move_Just_Different_Input__offset"),
                    new MultiStructItemCustomView(this, "Axe Elemental Discharge 2 First Hit Phial Damage Interval", "Axe_Elemental_Discharge_2_First_Hit_Phial_Damage_Interval", "Axe_Elemental_Discharge_2_First_Hit_Phial_Damage_Interval_offset"),
                    new MultiStructItemCustomView(this, "Axe Elemental Discharge 2 Second Hit Phial Damage Interval", "Axe_Elemental_Discharge_2_Second_Hit_Phial_Damage_Interval", "Axe_Elemental_Discharge_2_Second_Hit_Phial_Damage_Interval_offset"),
                    new MultiStructItemCustomView(this, "AED Phial Damage Interval", "AED_Phial_Damage_Interval", "AED_Phial_Damage_Interval_offset"),
                    new MultiStructItemCustomView(this, "Charge to Reach Yellow Phial", "Charge_to_Reach_Yellow_Phial", "Charge_to_Reach_Yellow_Phial_offset"),
                    new MultiStructItemCustomView(this, "Charge to Reach Red Phial", "Charge_to_Reach_Red_Phial", "Charge_to_Reach_Red_Phial_offset"),
                    new MultiStructItemCustomView(this, "Charge Gained When Blocking a Small Knock-back", "Charge_Gained_When_Blocking_a_Small_Knock_back", "Charge_Gained_When_Blocking_a_Small_Knock_back_offset"),
                    new MultiStructItemCustomView(this, "Charge Gained When Blocking a Medium Knock-back", "Charge_Gained_When_Blocking_a_Medium_Knock_back", "Charge_Gained_When_Blocking_a_Medium_Knock_back_offset"),
                    new MultiStructItemCustomView(this, "Charge Gained When Blocking a Large Knock-back", "Charge_Gained_When_Blocking_a_Large_Knock_back", "Charge_Gained_When_Blocking_a_Large_Knock_back_offset"),
                    new MultiStructItemCustomView(this, "Overcharged Phial", "Overcharged_Phial", "Overcharged_Phial_offset"),
                    new MultiStructItemCustomView(this, "Phial Charge Limit", "Phial_Charge_Limit", "Phial_Charge_Limit_offset"),
                    new MultiStructItemCustomView(this, "Axe Mode Damage Multiplier", "Axe_Mode_Damage_Multiplier", "Axe_Mode_Damage_Multiplier_offset"),
                    new MultiStructItemCustomView(this, "Guard Point Sharpness Cost Multiplier", "Guard_Point_Sharpness_Cost_Multiplier", "Guard_Point_Sharpness_Cost_Multiplier_offset"),
                    new MultiStructItemCustomView(this, "Impact Phial Damage Multiplier (Not for SAED)", "Impact_Phial_Damage_Multiplier_Not_for_SAED_", "Impact_Phial_Damage_Multiplier_Not_for_SAED__offset"),
                    new MultiStructItemCustomView(this, "Impact Phial Stun Buildup Multiplier", "Impact_Phial_Stun_Buildup_Multiplier", "Impact_Phial_Stun_Buildup_Multiplier_offset"),
                    new MultiStructItemCustomView(this, "Impact Phial Exhaust Buildup Multiplier", "Impact_Phial_Exhaust_Buildup_Multiplier", "Impact_Phial_Exhaust_Buildup_Multiplier_offset"),
                    new MultiStructItemCustomView(this, "Elemental Phial Damage Multiplier (Not for SAED)", "Elemental_Phial_Damage_Multiplier_Not_for_SAED_", "Elemental_Phial_Damage_Multiplier_Not_for_SAED__offset"),
                    new MultiStructItemCustomView(this, "Phial Duration", "Phial_Duration", "Phial_Duration_offset"),
                    new MultiStructItemCustomView(this, "Shield Charge Guard Threshold Bonus", "Shield_Charge_Guard_Threshold_Bonus", "Shield_Charge_Guard_Threshold_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Charged Shield Warning Duration When About to End", "Charged_Shield_Warning_Duration_When_About_to_End", "Charged_Shield_Warning_Duration_When_About_to_End_offset"),
                    new MultiStructItemCustomView(this, "Charged Sword Warning Duration When About to End", "Charged_Sword_Warning_Duration_When_About_to_End", "Charged_Sword_Warning_Duration_When_About_to_End_offset"),
                    new MultiStructItemCustomView(this, "Sword Charge Duration", "Sword_Charge_Duration", "Sword_Charge_Duration_offset"),
                    new MultiStructItemCustomView(this, "Unk 119", "Unk_119", "Unk_119_offset"),
                    new MultiStructItemCustomView(this, "Unk 120", "Unk_120", "Unk_120_offset"),
                    new MultiStructItemCustomView(this, "Unk 121", "Unk_121", "Unk_121_offset"),
                    new MultiStructItemCustomView(this, "Unk 122", "Unk_122", "Unk_122_offset"),
                };
            }
        }

        public partial class Action_Param_1 : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Action Param 1";

            protected float Gravity_raw;
            public const string Gravity_displayName = "Gravity";
            public const int Gravity_sortIndex = 50;
            [SortOrder(Gravity_sortIndex)]
            [DisplayName(Gravity_displayName)]
            public virtual float Gravity {
                get => Gravity_raw;
                set {
                    if (Gravity_raw == value) return;
                    Gravity_raw = value;
                    ChangedItems.Add(nameof(Gravity));
                    OnPropertyChanged(nameof(Gravity));
                }
            }

            protected float Time_Rate_raw;
            public const string Time_Rate_displayName = "Time Rate";
            public const int Time_Rate_sortIndex = 100;
            [SortOrder(Time_Rate_sortIndex)]
            [DisplayName(Time_Rate_displayName)]
            public virtual float Time_Rate {
                get => Time_Rate_raw;
                set {
                    if (Time_Rate_raw == value) return;
                    Time_Rate_raw = value;
                    ChangedItems.Add(nameof(Time_Rate));
                    OnPropertyChanged(nameof(Time_Rate));
                }
            }

            protected float Initial_X_Velocity_raw;
            public const string Initial_X_Velocity_displayName = "Initial X Velocity";
            public const int Initial_X_Velocity_sortIndex = 150;
            [SortOrder(Initial_X_Velocity_sortIndex)]
            [DisplayName(Initial_X_Velocity_displayName)]
            public virtual float Initial_X_Velocity {
                get => Initial_X_Velocity_raw;
                set {
                    if (Initial_X_Velocity_raw == value) return;
                    Initial_X_Velocity_raw = value;
                    ChangedItems.Add(nameof(Initial_X_Velocity));
                    OnPropertyChanged(nameof(Initial_X_Velocity));
                }
            }

            protected float Initial_Y_Velocity_raw;
            public const string Initial_Y_Velocity_displayName = "Initial Y Velocity";
            public const int Initial_Y_Velocity_sortIndex = 200;
            [SortOrder(Initial_Y_Velocity_sortIndex)]
            [DisplayName(Initial_Y_Velocity_displayName)]
            public virtual float Initial_Y_Velocity {
                get => Initial_Y_Velocity_raw;
                set {
                    if (Initial_Y_Velocity_raw == value) return;
                    Initial_Y_Velocity_raw = value;
                    ChangedItems.Add(nameof(Initial_Y_Velocity));
                    OnPropertyChanged(nameof(Initial_Y_Velocity));
                }
            }

            protected float Initial_Z_Velocity_raw;
            public const string Initial_Z_Velocity_displayName = "Initial Z Velocity";
            public const int Initial_Z_Velocity_sortIndex = 250;
            [SortOrder(Initial_Z_Velocity_sortIndex)]
            [DisplayName(Initial_Z_Velocity_displayName)]
            public virtual float Initial_Z_Velocity {
                get => Initial_Z_Velocity_raw;
                set {
                    if (Initial_Z_Velocity_raw == value) return;
                    Initial_Z_Velocity_raw = value;
                    ChangedItems.Add(nameof(Initial_Z_Velocity));
                    OnPropertyChanged(nameof(Initial_Z_Velocity));
                }
            }

            public const int lastSortIndex = 300;

            public static ObservableMhwStructCollection<Action_Param_1> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Action_Param_1>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Action_Param_1 LoadData(BinaryReader reader, ulong i) {
                var data = new Action_Param_1();
                data.Index = i;
                data.Gravity_raw = reader.ReadSingle();
                data.Time_Rate_raw = reader.ReadSingle();
                data.Initial_X_Velocity_raw = reader.ReadSingle();
                data.Initial_Y_Velocity_raw = reader.ReadSingle();
                data.Initial_Z_Velocity_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Gravity_raw);
                writer.Write(Time_Rate_raw);
                writer.Write(Initial_X_Velocity_raw);
                writer.Write(Initial_Y_Velocity_raw);
                writer.Write(Initial_Z_Velocity_raw);
            }
        }

        public partial class W09p_Params_6_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W09p Params (6)";

            protected float Unk_123_raw;
            public const string Unk_123_displayName = "Unk 123";
            public const int Unk_123_sortIndex = 50;
            [SortOrder(Unk_123_sortIndex)]
            [DisplayName(Unk_123_displayName)]
            public virtual float Unk_123 {
                get => Unk_123_raw;
                set {
                    if (Unk_123_raw == value) return;
                    Unk_123_raw = value;
                    ChangedItems.Add(nameof(Unk_123));
                    OnPropertyChanged(nameof(Unk_123));
                }
            }

            [DisplayName("Offset")]
            public long Unk_123_offset { get; private set; }

            protected float Unk_124_raw;
            public const string Unk_124_displayName = "Unk 124";
            public const int Unk_124_sortIndex = 100;
            [SortOrder(Unk_124_sortIndex)]
            [DisplayName(Unk_124_displayName)]
            public virtual float Unk_124 {
                get => Unk_124_raw;
                set {
                    if (Unk_124_raw == value) return;
                    Unk_124_raw = value;
                    ChangedItems.Add(nameof(Unk_124));
                    OnPropertyChanged(nameof(Unk_124));
                }
            }

            [DisplayName("Offset")]
            public long Unk_124_offset { get; private set; }

            protected float Unk_125_raw;
            public const string Unk_125_displayName = "Unk 125";
            public const int Unk_125_sortIndex = 150;
            [SortOrder(Unk_125_sortIndex)]
            [DisplayName(Unk_125_displayName)]
            public virtual float Unk_125 {
                get => Unk_125_raw;
                set {
                    if (Unk_125_raw == value) return;
                    Unk_125_raw = value;
                    ChangedItems.Add(nameof(Unk_125));
                    OnPropertyChanged(nameof(Unk_125));
                }
            }

            [DisplayName("Offset")]
            public long Unk_125_offset { get; private set; }

            protected float Unk_126_raw;
            public const string Unk_126_displayName = "Unk 126";
            public const int Unk_126_sortIndex = 200;
            [SortOrder(Unk_126_sortIndex)]
            [DisplayName(Unk_126_displayName)]
            public virtual float Unk_126 {
                get => Unk_126_raw;
                set {
                    if (Unk_126_raw == value) return;
                    Unk_126_raw = value;
                    ChangedItems.Add(nameof(Unk_126));
                    OnPropertyChanged(nameof(Unk_126));
                }
            }

            [DisplayName("Offset")]
            public long Unk_126_offset { get; private set; }

            protected float Unk_127_raw;
            public const string Unk_127_displayName = "Unk 127";
            public const int Unk_127_sortIndex = 250;
            [SortOrder(Unk_127_sortIndex)]
            [DisplayName(Unk_127_displayName)]
            public virtual float Unk_127 {
                get => Unk_127_raw;
                set {
                    if (Unk_127_raw == value) return;
                    Unk_127_raw = value;
                    ChangedItems.Add(nameof(Unk_127));
                    OnPropertyChanged(nameof(Unk_127));
                }
            }

            [DisplayName("Offset")]
            public long Unk_127_offset { get; private set; }

            protected float Unk_128_raw;
            public const string Unk_128_displayName = "Unk 128";
            public const int Unk_128_sortIndex = 300;
            [SortOrder(Unk_128_sortIndex)]
            [DisplayName(Unk_128_displayName)]
            public virtual float Unk_128 {
                get => Unk_128_raw;
                set {
                    if (Unk_128_raw == value) return;
                    Unk_128_raw = value;
                    ChangedItems.Add(nameof(Unk_128));
                    OnPropertyChanged(nameof(Unk_128));
                }
            }

            [DisplayName("Offset")]
            public long Unk_128_offset { get; private set; }

            protected float Unk_129_raw;
            public const string Unk_129_displayName = "Unk 129";
            public const int Unk_129_sortIndex = 350;
            [SortOrder(Unk_129_sortIndex)]
            [DisplayName(Unk_129_displayName)]
            public virtual float Unk_129 {
                get => Unk_129_raw;
                set {
                    if (Unk_129_raw == value) return;
                    Unk_129_raw = value;
                    ChangedItems.Add(nameof(Unk_129));
                    OnPropertyChanged(nameof(Unk_129));
                }
            }

            [DisplayName("Offset")]
            public long Unk_129_offset { get; private set; }

            protected float Unk_130_raw;
            public const string Unk_130_displayName = "Unk 130";
            public const int Unk_130_sortIndex = 400;
            [SortOrder(Unk_130_sortIndex)]
            [DisplayName(Unk_130_displayName)]
            public virtual float Unk_130 {
                get => Unk_130_raw;
                set {
                    if (Unk_130_raw == value) return;
                    Unk_130_raw = value;
                    ChangedItems.Add(nameof(Unk_130));
                    OnPropertyChanged(nameof(Unk_130));
                }
            }

            [DisplayName("Offset")]
            public long Unk_130_offset { get; private set; }

            protected float Unk_131_raw;
            public const string Unk_131_displayName = "Unk 131";
            public const int Unk_131_sortIndex = 450;
            [SortOrder(Unk_131_sortIndex)]
            [DisplayName(Unk_131_displayName)]
            public virtual float Unk_131 {
                get => Unk_131_raw;
                set {
                    if (Unk_131_raw == value) return;
                    Unk_131_raw = value;
                    ChangedItems.Add(nameof(Unk_131));
                    OnPropertyChanged(nameof(Unk_131));
                }
            }

            [DisplayName("Offset")]
            public long Unk_131_offset { get; private set; }

            public const int lastSortIndex = 500;

            public static ObservableMhwStructCollection<W09p_Params_6_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W09p_Params_6_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W09p_Params_6_ LoadData(BinaryReader reader, ulong i) {
                var data = new W09p_Params_6_();
                data.Index = i;
                data.Unk_123_offset = reader.BaseStream.Position;
                data.Unk_123_raw = reader.ReadSingle();
                data.Unk_124_offset = reader.BaseStream.Position;
                data.Unk_124_raw = reader.ReadSingle();
                data.Unk_125_offset = reader.BaseStream.Position;
                data.Unk_125_raw = reader.ReadSingle();
                data.Unk_126_offset = reader.BaseStream.Position;
                data.Unk_126_raw = reader.ReadSingle();
                data.Unk_127_offset = reader.BaseStream.Position;
                data.Unk_127_raw = reader.ReadSingle();
                data.Unk_128_offset = reader.BaseStream.Position;
                data.Unk_128_raw = reader.ReadSingle();
                data.Unk_129_offset = reader.BaseStream.Position;
                data.Unk_129_raw = reader.ReadSingle();
                data.Unk_130_offset = reader.BaseStream.Position;
                data.Unk_130_raw = reader.ReadSingle();
                data.Unk_131_offset = reader.BaseStream.Position;
                data.Unk_131_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_123_raw);
                writer.Write(Unk_124_raw);
                writer.Write(Unk_125_raw);
                writer.Write(Unk_126_raw);
                writer.Write(Unk_127_raw);
                writer.Write(Unk_128_raw);
                writer.Write(Unk_129_raw);
                writer.Write(Unk_130_raw);
                writer.Write(Unk_131_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 123", "Unk_123", "Unk_123_offset"),
                    new MultiStructItemCustomView(this, "Unk 124", "Unk_124", "Unk_124_offset"),
                    new MultiStructItemCustomView(this, "Unk 125", "Unk_125", "Unk_125_offset"),
                    new MultiStructItemCustomView(this, "Unk 126", "Unk_126", "Unk_126_offset"),
                    new MultiStructItemCustomView(this, "Unk 127", "Unk_127", "Unk_127_offset"),
                    new MultiStructItemCustomView(this, "Unk 128", "Unk_128", "Unk_128_offset"),
                    new MultiStructItemCustomView(this, "Unk 129", "Unk_129", "Unk_129_offset"),
                    new MultiStructItemCustomView(this, "Unk 130", "Unk_130", "Unk_130_offset"),
                    new MultiStructItemCustomView(this, "Unk 131", "Unk_131", "Unk_131_offset"),
                };
            }
        }

        public partial class Unk_Arr_3 : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 4;
            public const string GridName = "Unk Arr 3";

            protected float Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 50;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            public virtual float Unk_1 {
                get => Unk_1_raw;
                set {
                    if (Unk_1_raw == value) return;
                    Unk_1_raw = value;
                    ChangedItems.Add(nameof(Unk_1));
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

            protected float Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 100;
            [SortOrder(Unk_2_sortIndex)]
            [DisplayName(Unk_2_displayName)]
            public virtual float Unk_2 {
                get => Unk_2_raw;
                set {
                    if (Unk_2_raw == value) return;
                    Unk_2_raw = value;
                    ChangedItems.Add(nameof(Unk_2));
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            protected float Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 150;
            [SortOrder(Unk_3_sortIndex)]
            [DisplayName(Unk_3_displayName)]
            public virtual float Unk_3 {
                get => Unk_3_raw;
                set {
                    if (Unk_3_raw == value) return;
                    Unk_3_raw = value;
                    ChangedItems.Add(nameof(Unk_3));
                    OnPropertyChanged(nameof(Unk_3));
                }
            }

            protected byte Unk_4_raw;
            public const string Unk_4_displayName = "Unk 4";
            public const int Unk_4_sortIndex = 200;
            [SortOrder(Unk_4_sortIndex)]
            [DisplayName(Unk_4_displayName)]
            public virtual bool Unk_4 {
                get => (bool) Convert.ToBoolean(Unk_4_raw);
                set {
                    if (Convert.ToBoolean(Unk_4_raw) == value) return;
                    Unk_4_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Unk_4));
                    OnPropertyChanged(nameof(Unk_4));
                }
            }

            protected float Unk_5_raw;
            public const string Unk_5_displayName = "Unk 5";
            public const int Unk_5_sortIndex = 250;
            [SortOrder(Unk_5_sortIndex)]
            [DisplayName(Unk_5_displayName)]
            public virtual float Unk_5 {
                get => Unk_5_raw;
                set {
                    if (Unk_5_raw == value) return;
                    Unk_5_raw = value;
                    ChangedItems.Add(nameof(Unk_5));
                    OnPropertyChanged(nameof(Unk_5));
                }
            }

            public const int lastSortIndex = 300;

            public static ObservableMhwStructCollection<Unk_Arr_3> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Unk_Arr_3>();
                const ulong count = 4UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Unk_Arr_3 LoadData(BinaryReader reader, ulong i) {
                var data = new Unk_Arr_3();
                data.Index = i;
                data.Unk_1_raw = reader.ReadSingle();
                data.Unk_2_raw = reader.ReadSingle();
                data.Unk_3_raw = reader.ReadSingle();
                data.Unk_4_raw = reader.ReadByte();
                data.Unk_5_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
                writer.Write(Unk_3_raw);
                writer.Write(Unk_4_raw);
                writer.Write(Unk_5_raw);
            }
        }

        public partial class W09p_Params_7_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W09p Params (7)";

            protected float Unk_132_raw;
            public const string Unk_132_displayName = "Unk 132";
            public const int Unk_132_sortIndex = 50;
            [SortOrder(Unk_132_sortIndex)]
            [DisplayName(Unk_132_displayName)]
            public virtual float Unk_132 {
                get => Unk_132_raw;
                set {
                    if (Unk_132_raw == value) return;
                    Unk_132_raw = value;
                    ChangedItems.Add(nameof(Unk_132));
                    OnPropertyChanged(nameof(Unk_132));
                }
            }

            [DisplayName("Offset")]
            public long Unk_132_offset { get; private set; }

            public const int lastSortIndex = 100;

            public static ObservableMhwStructCollection<W09p_Params_7_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W09p_Params_7_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W09p_Params_7_ LoadData(BinaryReader reader, ulong i) {
                var data = new W09p_Params_7_();
                data.Index = i;
                data.Unk_132_offset = reader.BaseStream.Position;
                data.Unk_132_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_132_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 132", "Unk_132", "Unk_132_offset"),
                };
            }
        }

        public partial class Action_Param_2 : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Action Param 2";

            protected float Gravity_raw;
            public const string Gravity_displayName = "Gravity";
            public const int Gravity_sortIndex = 50;
            [SortOrder(Gravity_sortIndex)]
            [DisplayName(Gravity_displayName)]
            public virtual float Gravity {
                get => Gravity_raw;
                set {
                    if (Gravity_raw == value) return;
                    Gravity_raw = value;
                    ChangedItems.Add(nameof(Gravity));
                    OnPropertyChanged(nameof(Gravity));
                }
            }

            protected float Time_Rate_raw;
            public const string Time_Rate_displayName = "Time Rate";
            public const int Time_Rate_sortIndex = 100;
            [SortOrder(Time_Rate_sortIndex)]
            [DisplayName(Time_Rate_displayName)]
            public virtual float Time_Rate {
                get => Time_Rate_raw;
                set {
                    if (Time_Rate_raw == value) return;
                    Time_Rate_raw = value;
                    ChangedItems.Add(nameof(Time_Rate));
                    OnPropertyChanged(nameof(Time_Rate));
                }
            }

            protected float Initial_X_Velocity_raw;
            public const string Initial_X_Velocity_displayName = "Initial X Velocity";
            public const int Initial_X_Velocity_sortIndex = 150;
            [SortOrder(Initial_X_Velocity_sortIndex)]
            [DisplayName(Initial_X_Velocity_displayName)]
            public virtual float Initial_X_Velocity {
                get => Initial_X_Velocity_raw;
                set {
                    if (Initial_X_Velocity_raw == value) return;
                    Initial_X_Velocity_raw = value;
                    ChangedItems.Add(nameof(Initial_X_Velocity));
                    OnPropertyChanged(nameof(Initial_X_Velocity));
                }
            }

            protected float Initial_Y_Velocity_raw;
            public const string Initial_Y_Velocity_displayName = "Initial Y Velocity";
            public const int Initial_Y_Velocity_sortIndex = 200;
            [SortOrder(Initial_Y_Velocity_sortIndex)]
            [DisplayName(Initial_Y_Velocity_displayName)]
            public virtual float Initial_Y_Velocity {
                get => Initial_Y_Velocity_raw;
                set {
                    if (Initial_Y_Velocity_raw == value) return;
                    Initial_Y_Velocity_raw = value;
                    ChangedItems.Add(nameof(Initial_Y_Velocity));
                    OnPropertyChanged(nameof(Initial_Y_Velocity));
                }
            }

            protected float Initial_Z_Velocity_raw;
            public const string Initial_Z_Velocity_displayName = "Initial Z Velocity";
            public const int Initial_Z_Velocity_sortIndex = 250;
            [SortOrder(Initial_Z_Velocity_sortIndex)]
            [DisplayName(Initial_Z_Velocity_displayName)]
            public virtual float Initial_Z_Velocity {
                get => Initial_Z_Velocity_raw;
                set {
                    if (Initial_Z_Velocity_raw == value) return;
                    Initial_Z_Velocity_raw = value;
                    ChangedItems.Add(nameof(Initial_Z_Velocity));
                    OnPropertyChanged(nameof(Initial_Z_Velocity));
                }
            }

            public const int lastSortIndex = 300;

            public static ObservableMhwStructCollection<Action_Param_2> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Action_Param_2>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Action_Param_2 LoadData(BinaryReader reader, ulong i) {
                var data = new Action_Param_2();
                data.Index = i;
                data.Gravity_raw = reader.ReadSingle();
                data.Time_Rate_raw = reader.ReadSingle();
                data.Initial_X_Velocity_raw = reader.ReadSingle();
                data.Initial_Y_Velocity_raw = reader.ReadSingle();
                data.Initial_Z_Velocity_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Gravity_raw);
                writer.Write(Time_Rate_raw);
                writer.Write(Initial_X_Velocity_raw);
                writer.Write(Initial_Y_Velocity_raw);
                writer.Write(Initial_Z_Velocity_raw);
            }
        }

        public partial class W09p_Params_8_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W09p Params (8)";

            protected float Charge_of_Sword_Charged_Double_Slash_raw;
            public const string Charge_of_Sword_Charged_Double_Slash_displayName = "Charge of [Sword]: Charged Double Slash";
            public const int Charge_of_Sword_Charged_Double_Slash_sortIndex = 50;
            [SortOrder(Charge_of_Sword_Charged_Double_Slash_sortIndex)]
            [DisplayName(Charge_of_Sword_Charged_Double_Slash_displayName)]
            public virtual float Charge_of_Sword_Charged_Double_Slash {
                get => Charge_of_Sword_Charged_Double_Slash_raw;
                set {
                    if (Charge_of_Sword_Charged_Double_Slash_raw == value) return;
                    Charge_of_Sword_Charged_Double_Slash_raw = value;
                    ChangedItems.Add(nameof(Charge_of_Sword_Charged_Double_Slash));
                    OnPropertyChanged(nameof(Charge_of_Sword_Charged_Double_Slash));
                }
            }

            [DisplayName("Offset")]
            public long Charge_of_Sword_Charged_Double_Slash_offset { get; private set; }

            protected float Unk_134_raw;
            public const string Unk_134_displayName = "Unk 134";
            public const int Unk_134_sortIndex = 100;
            [SortOrder(Unk_134_sortIndex)]
            [DisplayName(Unk_134_displayName)]
            public virtual float Unk_134 {
                get => Unk_134_raw;
                set {
                    if (Unk_134_raw == value) return;
                    Unk_134_raw = value;
                    ChangedItems.Add(nameof(Unk_134));
                    OnPropertyChanged(nameof(Unk_134));
                }
            }

            [DisplayName("Offset")]
            public long Unk_134_offset { get; private set; }

            protected float Speed_From_a_Different_Move_to_Sword_Charged_Double_Slash_raw;
            public const string Speed_From_a_Different_Move_to_Sword_Charged_Double_Slash_displayName = "Speed From a Different Move to [Sword]: Charged Double Slash";
            public const int Speed_From_a_Different_Move_to_Sword_Charged_Double_Slash_sortIndex = 150;
            [SortOrder(Speed_From_a_Different_Move_to_Sword_Charged_Double_Slash_sortIndex)]
            [DisplayName(Speed_From_a_Different_Move_to_Sword_Charged_Double_Slash_displayName)]
            public virtual float Speed_From_a_Different_Move_to_Sword_Charged_Double_Slash {
                get => Speed_From_a_Different_Move_to_Sword_Charged_Double_Slash_raw;
                set {
                    if (Speed_From_a_Different_Move_to_Sword_Charged_Double_Slash_raw == value) return;
                    Speed_From_a_Different_Move_to_Sword_Charged_Double_Slash_raw = value;
                    ChangedItems.Add(nameof(Speed_From_a_Different_Move_to_Sword_Charged_Double_Slash));
                    OnPropertyChanged(nameof(Speed_From_a_Different_Move_to_Sword_Charged_Double_Slash));
                }
            }

            [DisplayName("Offset")]
            public long Speed_From_a_Different_Move_to_Sword_Charged_Double_Slash_offset { get; private set; }

            protected float Unk_136_raw;
            public const string Unk_136_displayName = "Unk 136";
            public const int Unk_136_sortIndex = 200;
            [SortOrder(Unk_136_sortIndex)]
            [DisplayName(Unk_136_displayName)]
            public virtual float Unk_136 {
                get => Unk_136_raw;
                set {
                    if (Unk_136_raw == value) return;
                    Unk_136_raw = value;
                    ChangedItems.Add(nameof(Unk_136));
                    OnPropertyChanged(nameof(Unk_136));
                }
            }

            [DisplayName("Offset")]
            public long Unk_136_offset { get; private set; }

            protected float Charge_of_Sword_Condensed_Element_Slash_raw;
            public const string Charge_of_Sword_Condensed_Element_Slash_displayName = "Charge of [Sword]: Condensed Element Slash";
            public const int Charge_of_Sword_Condensed_Element_Slash_sortIndex = 250;
            [SortOrder(Charge_of_Sword_Condensed_Element_Slash_sortIndex)]
            [DisplayName(Charge_of_Sword_Condensed_Element_Slash_displayName)]
            public virtual float Charge_of_Sword_Condensed_Element_Slash {
                get => Charge_of_Sword_Condensed_Element_Slash_raw;
                set {
                    if (Charge_of_Sword_Condensed_Element_Slash_raw == value) return;
                    Charge_of_Sword_Condensed_Element_Slash_raw = value;
                    ChangedItems.Add(nameof(Charge_of_Sword_Condensed_Element_Slash));
                    OnPropertyChanged(nameof(Charge_of_Sword_Condensed_Element_Slash));
                }
            }

            [DisplayName("Offset")]
            public long Charge_of_Sword_Condensed_Element_Slash_offset { get; private set; }

            protected float Unk_138_raw;
            public const string Unk_138_displayName = "Unk 138";
            public const int Unk_138_sortIndex = 300;
            [SortOrder(Unk_138_sortIndex)]
            [DisplayName(Unk_138_displayName)]
            public virtual float Unk_138 {
                get => Unk_138_raw;
                set {
                    if (Unk_138_raw == value) return;
                    Unk_138_raw = value;
                    ChangedItems.Add(nameof(Unk_138));
                    OnPropertyChanged(nameof(Unk_138));
                }
            }

            [DisplayName("Offset")]
            public long Unk_138_offset { get; private set; }

            protected float Unk_139_raw;
            public const string Unk_139_displayName = "Unk 139";
            public const int Unk_139_sortIndex = 350;
            [SortOrder(Unk_139_sortIndex)]
            [DisplayName(Unk_139_displayName)]
            public virtual float Unk_139 {
                get => Unk_139_raw;
                set {
                    if (Unk_139_raw == value) return;
                    Unk_139_raw = value;
                    ChangedItems.Add(nameof(Unk_139));
                    OnPropertyChanged(nameof(Unk_139));
                }
            }

            [DisplayName("Offset")]
            public long Unk_139_offset { get; private set; }

            public const int lastSortIndex = 400;

            public static ObservableMhwStructCollection<W09p_Params_8_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W09p_Params_8_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W09p_Params_8_ LoadData(BinaryReader reader, ulong i) {
                var data = new W09p_Params_8_();
                data.Index = i;
                data.Charge_of_Sword_Charged_Double_Slash_offset = reader.BaseStream.Position;
                data.Charge_of_Sword_Charged_Double_Slash_raw = reader.ReadSingle();
                data.Unk_134_offset = reader.BaseStream.Position;
                data.Unk_134_raw = reader.ReadSingle();
                data.Speed_From_a_Different_Move_to_Sword_Charged_Double_Slash_offset = reader.BaseStream.Position;
                data.Speed_From_a_Different_Move_to_Sword_Charged_Double_Slash_raw = reader.ReadSingle();
                data.Unk_136_offset = reader.BaseStream.Position;
                data.Unk_136_raw = reader.ReadSingle();
                data.Charge_of_Sword_Condensed_Element_Slash_offset = reader.BaseStream.Position;
                data.Charge_of_Sword_Condensed_Element_Slash_raw = reader.ReadSingle();
                data.Unk_138_offset = reader.BaseStream.Position;
                data.Unk_138_raw = reader.ReadSingle();
                data.Unk_139_offset = reader.BaseStream.Position;
                data.Unk_139_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Charge_of_Sword_Charged_Double_Slash_raw);
                writer.Write(Unk_134_raw);
                writer.Write(Speed_From_a_Different_Move_to_Sword_Charged_Double_Slash_raw);
                writer.Write(Unk_136_raw);
                writer.Write(Charge_of_Sword_Condensed_Element_Slash_raw);
                writer.Write(Unk_138_raw);
                writer.Write(Unk_139_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Charge of [Sword]: Charged Double Slash", "Charge_of_Sword_Charged_Double_Slash", "Charge_of_Sword_Charged_Double_Slash_offset"),
                    new MultiStructItemCustomView(this, "Unk 134", "Unk_134", "Unk_134_offset"),
                    new MultiStructItemCustomView(this, "Speed From a Different Move to [Sword]: Charged Double Slash", "Speed_From_a_Different_Move_to_Sword_Charged_Double_Slash", "Speed_From_a_Different_Move_to_Sword_Charged_Double_Slash_offset"),
                    new MultiStructItemCustomView(this, "Unk 136", "Unk_136", "Unk_136_offset"),
                    new MultiStructItemCustomView(this, "Charge of [Sword]: Condensed Element Slash", "Charge_of_Sword_Condensed_Element_Slash", "Charge_of_Sword_Condensed_Element_Slash_offset"),
                    new MultiStructItemCustomView(this, "Unk 138", "Unk_138", "Unk_138_offset"),
                    new MultiStructItemCustomView(this, "Unk 139", "Unk_139", "Unk_139_offset"),
                };
            }
        }

        public partial class Action_Param_3 : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Action Param 3";

            protected float Gravity_raw;
            public const string Gravity_displayName = "Gravity";
            public const int Gravity_sortIndex = 50;
            [SortOrder(Gravity_sortIndex)]
            [DisplayName(Gravity_displayName)]
            public virtual float Gravity {
                get => Gravity_raw;
                set {
                    if (Gravity_raw == value) return;
                    Gravity_raw = value;
                    ChangedItems.Add(nameof(Gravity));
                    OnPropertyChanged(nameof(Gravity));
                }
            }

            protected float Time_Rate_raw;
            public const string Time_Rate_displayName = "Time Rate";
            public const int Time_Rate_sortIndex = 100;
            [SortOrder(Time_Rate_sortIndex)]
            [DisplayName(Time_Rate_displayName)]
            public virtual float Time_Rate {
                get => Time_Rate_raw;
                set {
                    if (Time_Rate_raw == value) return;
                    Time_Rate_raw = value;
                    ChangedItems.Add(nameof(Time_Rate));
                    OnPropertyChanged(nameof(Time_Rate));
                }
            }

            protected float Initial_X_Velocity_raw;
            public const string Initial_X_Velocity_displayName = "Initial X Velocity";
            public const int Initial_X_Velocity_sortIndex = 150;
            [SortOrder(Initial_X_Velocity_sortIndex)]
            [DisplayName(Initial_X_Velocity_displayName)]
            public virtual float Initial_X_Velocity {
                get => Initial_X_Velocity_raw;
                set {
                    if (Initial_X_Velocity_raw == value) return;
                    Initial_X_Velocity_raw = value;
                    ChangedItems.Add(nameof(Initial_X_Velocity));
                    OnPropertyChanged(nameof(Initial_X_Velocity));
                }
            }

            protected float Initial_Y_Velocity_raw;
            public const string Initial_Y_Velocity_displayName = "Initial Y Velocity";
            public const int Initial_Y_Velocity_sortIndex = 200;
            [SortOrder(Initial_Y_Velocity_sortIndex)]
            [DisplayName(Initial_Y_Velocity_displayName)]
            public virtual float Initial_Y_Velocity {
                get => Initial_Y_Velocity_raw;
                set {
                    if (Initial_Y_Velocity_raw == value) return;
                    Initial_Y_Velocity_raw = value;
                    ChangedItems.Add(nameof(Initial_Y_Velocity));
                    OnPropertyChanged(nameof(Initial_Y_Velocity));
                }
            }

            protected float Initial_Z_Velocity_raw;
            public const string Initial_Z_Velocity_displayName = "Initial Z Velocity";
            public const int Initial_Z_Velocity_sortIndex = 250;
            [SortOrder(Initial_Z_Velocity_sortIndex)]
            [DisplayName(Initial_Z_Velocity_displayName)]
            public virtual float Initial_Z_Velocity {
                get => Initial_Z_Velocity_raw;
                set {
                    if (Initial_Z_Velocity_raw == value) return;
                    Initial_Z_Velocity_raw = value;
                    ChangedItems.Add(nameof(Initial_Z_Velocity));
                    OnPropertyChanged(nameof(Initial_Z_Velocity));
                }
            }

            public const int lastSortIndex = 300;

            public static ObservableMhwStructCollection<Action_Param_3> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Action_Param_3>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Action_Param_3 LoadData(BinaryReader reader, ulong i) {
                var data = new Action_Param_3();
                data.Index = i;
                data.Gravity_raw = reader.ReadSingle();
                data.Time_Rate_raw = reader.ReadSingle();
                data.Initial_X_Velocity_raw = reader.ReadSingle();
                data.Initial_Y_Velocity_raw = reader.ReadSingle();
                data.Initial_Z_Velocity_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Gravity_raw);
                writer.Write(Time_Rate_raw);
                writer.Write(Initial_X_Velocity_raw);
                writer.Write(Initial_Y_Velocity_raw);
                writer.Write(Initial_Z_Velocity_raw);
            }
        }

        public partial class W09p_Params_9_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W09p Params (9)";

            protected float Unk_140_raw;
            public const string Unk_140_displayName = "Unk 140";
            public const int Unk_140_sortIndex = 50;
            [SortOrder(Unk_140_sortIndex)]
            [DisplayName(Unk_140_displayName)]
            public virtual float Unk_140 {
                get => Unk_140_raw;
                set {
                    if (Unk_140_raw == value) return;
                    Unk_140_raw = value;
                    ChangedItems.Add(nameof(Unk_140));
                    OnPropertyChanged(nameof(Unk_140));
                }
            }

            [DisplayName("Offset")]
            public long Unk_140_offset { get; private set; }

            public const int lastSortIndex = 100;

            public static ObservableMhwStructCollection<W09p_Params_9_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W09p_Params_9_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W09p_Params_9_ LoadData(BinaryReader reader, ulong i) {
                var data = new W09p_Params_9_();
                data.Index = i;
                data.Unk_140_offset = reader.BaseStream.Position;
                data.Unk_140_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_140_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 140", "Unk_140", "Unk_140_offset"),
                };
            }
        }

        public partial class Action_Param_4 : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Action Param 4";

            protected float Gravity_raw;
            public const string Gravity_displayName = "Gravity";
            public const int Gravity_sortIndex = 50;
            [SortOrder(Gravity_sortIndex)]
            [DisplayName(Gravity_displayName)]
            public virtual float Gravity {
                get => Gravity_raw;
                set {
                    if (Gravity_raw == value) return;
                    Gravity_raw = value;
                    ChangedItems.Add(nameof(Gravity));
                    OnPropertyChanged(nameof(Gravity));
                }
            }

            protected float Time_Rate_raw;
            public const string Time_Rate_displayName = "Time Rate";
            public const int Time_Rate_sortIndex = 100;
            [SortOrder(Time_Rate_sortIndex)]
            [DisplayName(Time_Rate_displayName)]
            public virtual float Time_Rate {
                get => Time_Rate_raw;
                set {
                    if (Time_Rate_raw == value) return;
                    Time_Rate_raw = value;
                    ChangedItems.Add(nameof(Time_Rate));
                    OnPropertyChanged(nameof(Time_Rate));
                }
            }

            protected float Initial_X_Velocity_raw;
            public const string Initial_X_Velocity_displayName = "Initial X Velocity";
            public const int Initial_X_Velocity_sortIndex = 150;
            [SortOrder(Initial_X_Velocity_sortIndex)]
            [DisplayName(Initial_X_Velocity_displayName)]
            public virtual float Initial_X_Velocity {
                get => Initial_X_Velocity_raw;
                set {
                    if (Initial_X_Velocity_raw == value) return;
                    Initial_X_Velocity_raw = value;
                    ChangedItems.Add(nameof(Initial_X_Velocity));
                    OnPropertyChanged(nameof(Initial_X_Velocity));
                }
            }

            protected float Initial_Y_Velocity_raw;
            public const string Initial_Y_Velocity_displayName = "Initial Y Velocity";
            public const int Initial_Y_Velocity_sortIndex = 200;
            [SortOrder(Initial_Y_Velocity_sortIndex)]
            [DisplayName(Initial_Y_Velocity_displayName)]
            public virtual float Initial_Y_Velocity {
                get => Initial_Y_Velocity_raw;
                set {
                    if (Initial_Y_Velocity_raw == value) return;
                    Initial_Y_Velocity_raw = value;
                    ChangedItems.Add(nameof(Initial_Y_Velocity));
                    OnPropertyChanged(nameof(Initial_Y_Velocity));
                }
            }

            protected float Initial_Z_Velocity_raw;
            public const string Initial_Z_Velocity_displayName = "Initial Z Velocity";
            public const int Initial_Z_Velocity_sortIndex = 250;
            [SortOrder(Initial_Z_Velocity_sortIndex)]
            [DisplayName(Initial_Z_Velocity_displayName)]
            public virtual float Initial_Z_Velocity {
                get => Initial_Z_Velocity_raw;
                set {
                    if (Initial_Z_Velocity_raw == value) return;
                    Initial_Z_Velocity_raw = value;
                    ChangedItems.Add(nameof(Initial_Z_Velocity));
                    OnPropertyChanged(nameof(Initial_Z_Velocity));
                }
            }

            public const int lastSortIndex = 300;

            public static ObservableMhwStructCollection<Action_Param_4> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Action_Param_4>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Action_Param_4 LoadData(BinaryReader reader, ulong i) {
                var data = new Action_Param_4();
                data.Index = i;
                data.Gravity_raw = reader.ReadSingle();
                data.Time_Rate_raw = reader.ReadSingle();
                data.Initial_X_Velocity_raw = reader.ReadSingle();
                data.Initial_Y_Velocity_raw = reader.ReadSingle();
                data.Initial_Z_Velocity_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Gravity_raw);
                writer.Write(Time_Rate_raw);
                writer.Write(Initial_X_Velocity_raw);
                writer.Write(Initial_Y_Velocity_raw);
                writer.Write(Initial_Z_Velocity_raw);
            }
        }

        public partial class Impact_SAED_Phial_Spawn_Interval : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Impact SAED Phial Spawn Interval";

            protected float Phial_1_raw;
            public const string Phial_1_displayName = "Phial 1";
            public const int Phial_1_sortIndex = 50;
            [SortOrder(Phial_1_sortIndex)]
            [DisplayName(Phial_1_displayName)]
            public virtual float Phial_1 {
                get => Phial_1_raw;
                set {
                    if (Phial_1_raw == value) return;
                    Phial_1_raw = value;
                    ChangedItems.Add(nameof(Phial_1));
                    OnPropertyChanged(nameof(Phial_1));
                }
            }

            [DisplayName("Offset")]
            public long Phial_1_offset { get; private set; }

            protected float Phial_2_raw;
            public const string Phial_2_displayName = "Phial 2";
            public const int Phial_2_sortIndex = 100;
            [SortOrder(Phial_2_sortIndex)]
            [DisplayName(Phial_2_displayName)]
            public virtual float Phial_2 {
                get => Phial_2_raw;
                set {
                    if (Phial_2_raw == value) return;
                    Phial_2_raw = value;
                    ChangedItems.Add(nameof(Phial_2));
                    OnPropertyChanged(nameof(Phial_2));
                }
            }

            [DisplayName("Offset")]
            public long Phial_2_offset { get; private set; }

            protected float Phial_3_raw;
            public const string Phial_3_displayName = "Phial 3";
            public const int Phial_3_sortIndex = 150;
            [SortOrder(Phial_3_sortIndex)]
            [DisplayName(Phial_3_displayName)]
            public virtual float Phial_3 {
                get => Phial_3_raw;
                set {
                    if (Phial_3_raw == value) return;
                    Phial_3_raw = value;
                    ChangedItems.Add(nameof(Phial_3));
                    OnPropertyChanged(nameof(Phial_3));
                }
            }

            [DisplayName("Offset")]
            public long Phial_3_offset { get; private set; }

            protected float Phial_4_raw;
            public const string Phial_4_displayName = "Phial 4";
            public const int Phial_4_sortIndex = 200;
            [SortOrder(Phial_4_sortIndex)]
            [DisplayName(Phial_4_displayName)]
            public virtual float Phial_4 {
                get => Phial_4_raw;
                set {
                    if (Phial_4_raw == value) return;
                    Phial_4_raw = value;
                    ChangedItems.Add(nameof(Phial_4));
                    OnPropertyChanged(nameof(Phial_4));
                }
            }

            [DisplayName("Offset")]
            public long Phial_4_offset { get; private set; }

            protected float Phial_5_raw;
            public const string Phial_5_displayName = "Phial 5";
            public const int Phial_5_sortIndex = 250;
            [SortOrder(Phial_5_sortIndex)]
            [DisplayName(Phial_5_displayName)]
            public virtual float Phial_5 {
                get => Phial_5_raw;
                set {
                    if (Phial_5_raw == value) return;
                    Phial_5_raw = value;
                    ChangedItems.Add(nameof(Phial_5));
                    OnPropertyChanged(nameof(Phial_5));
                }
            }

            [DisplayName("Offset")]
            public long Phial_5_offset { get; private set; }

            protected float Phial_6_raw;
            public const string Phial_6_displayName = "Phial 6";
            public const int Phial_6_sortIndex = 300;
            [SortOrder(Phial_6_sortIndex)]
            [DisplayName(Phial_6_displayName)]
            public virtual float Phial_6 {
                get => Phial_6_raw;
                set {
                    if (Phial_6_raw == value) return;
                    Phial_6_raw = value;
                    ChangedItems.Add(nameof(Phial_6));
                    OnPropertyChanged(nameof(Phial_6));
                }
            }

            [DisplayName("Offset")]
            public long Phial_6_offset { get; private set; }

            public const int lastSortIndex = 350;

            public static ObservableMhwStructCollection<Impact_SAED_Phial_Spawn_Interval> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Impact_SAED_Phial_Spawn_Interval>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Impact_SAED_Phial_Spawn_Interval LoadData(BinaryReader reader, ulong i) {
                var data = new Impact_SAED_Phial_Spawn_Interval();
                data.Index = i;
                data.Phial_1_offset = reader.BaseStream.Position;
                data.Phial_1_raw = reader.ReadSingle();
                data.Phial_2_offset = reader.BaseStream.Position;
                data.Phial_2_raw = reader.ReadSingle();
                data.Phial_3_offset = reader.BaseStream.Position;
                data.Phial_3_raw = reader.ReadSingle();
                data.Phial_4_offset = reader.BaseStream.Position;
                data.Phial_4_raw = reader.ReadSingle();
                data.Phial_5_offset = reader.BaseStream.Position;
                data.Phial_5_raw = reader.ReadSingle();
                data.Phial_6_offset = reader.BaseStream.Position;
                data.Phial_6_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Phial_1_raw);
                writer.Write(Phial_2_raw);
                writer.Write(Phial_3_raw);
                writer.Write(Phial_4_raw);
                writer.Write(Phial_5_raw);
                writer.Write(Phial_6_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Phial 1", "Phial_1", "Phial_1_offset"),
                    new MultiStructItemCustomView(this, "Phial 2", "Phial_2", "Phial_2_offset"),
                    new MultiStructItemCustomView(this, "Phial 3", "Phial_3", "Phial_3_offset"),
                    new MultiStructItemCustomView(this, "Phial 4", "Phial_4", "Phial_4_offset"),
                    new MultiStructItemCustomView(this, "Phial 5", "Phial_5", "Phial_5_offset"),
                    new MultiStructItemCustomView(this, "Phial 6", "Phial_6", "Phial_6_offset"),
                };
            }
        }

        public partial class Impact_SAED_Coordinates : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 21;
            public const string GridName = "Impact SAED Coordinates";

            protected float Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 50;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            public virtual float Unk_1 {
                get => Unk_1_raw;
                set {
                    if (Unk_1_raw == value) return;
                    Unk_1_raw = value;
                    ChangedItems.Add(nameof(Unk_1));
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

            protected float Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 100;
            [SortOrder(Unk_2_sortIndex)]
            [DisplayName(Unk_2_displayName)]
            public virtual float Unk_2 {
                get => Unk_2_raw;
                set {
                    if (Unk_2_raw == value) return;
                    Unk_2_raw = value;
                    ChangedItems.Add(nameof(Unk_2));
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            protected float Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 150;
            [SortOrder(Unk_3_sortIndex)]
            [DisplayName(Unk_3_displayName)]
            public virtual float Unk_3 {
                get => Unk_3_raw;
                set {
                    if (Unk_3_raw == value) return;
                    Unk_3_raw = value;
                    ChangedItems.Add(nameof(Unk_3));
                    OnPropertyChanged(nameof(Unk_3));
                }
            }

            protected float Unk_4_raw;
            public const string Unk_4_displayName = "Unk 4";
            public const int Unk_4_sortIndex = 200;
            [SortOrder(Unk_4_sortIndex)]
            [DisplayName(Unk_4_displayName)]
            public virtual float Unk_4 {
                get => Unk_4_raw;
                set {
                    if (Unk_4_raw == value) return;
                    Unk_4_raw = value;
                    ChangedItems.Add(nameof(Unk_4));
                    OnPropertyChanged(nameof(Unk_4));
                }
            }

            public const int lastSortIndex = 250;

            public static ObservableMhwStructCollection<Impact_SAED_Coordinates> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Impact_SAED_Coordinates>();
                const ulong count = 21UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Impact_SAED_Coordinates LoadData(BinaryReader reader, ulong i) {
                var data = new Impact_SAED_Coordinates();
                data.Index = i;
                data.Unk_1_raw = reader.ReadSingle();
                data.Unk_2_raw = reader.ReadSingle();
                data.Unk_3_raw = reader.ReadSingle();
                data.Unk_4_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
                writer.Write(Unk_3_raw);
                writer.Write(Unk_4_raw);
            }
        }

        public partial class Elemental_SAED_Spawn_Interval_Coords : MhwStructItem, IWriteData, IHasChildren {
            public const ulong FixedSizeCount = 6;
            public const string GridName = "Elemental SAED Spawn Interval/Coords";

            public partial class Spawn_Intervals : MhwStructItem, IWriteDataInner<Elemental_SAED_Spawn_Interval_Coords> {
                public const ulong FixedSizeCount = 0;
                public const string GridName = "Spawn Intervals";

                protected float Spawn_Interval_raw;
                public const string Spawn_Interval_displayName = "Spawn Interval";
                public const int Spawn_Interval_sortIndex = 50;
                [SortOrder(Spawn_Interval_sortIndex)]
                [DisplayName(Spawn_Interval_displayName)]
                public virtual float Spawn_Interval {
                    get => Spawn_Interval_raw;
                    set {
                        if (Spawn_Interval_raw == value) return;
                        Spawn_Interval_raw = value;
                        ChangedItems.Add(nameof(Spawn_Interval));
                        OnPropertyChanged(nameof(Spawn_Interval));
                    }
                }

                public const int lastSortIndex = 100;

                public static ObservableMhwStructCollection<Spawn_Intervals> LoadData(BinaryReader reader, Elemental_SAED_Spawn_Interval_Coords parent) {
                    var list = new ObservableMhwStructCollection<Spawn_Intervals>();
                    ulong count = GetLoadCount(reader, parent);
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Spawn_Intervals LoadData(BinaryReader reader, ulong i, Elemental_SAED_Spawn_Interval_Coords parent) {
                    var data = new Spawn_Intervals();
                    data.Index = i;
                    data.Spawn_Interval_raw = reader.ReadSingle();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Elemental_SAED_Spawn_Interval_Coords parent) {
                    writer.Write(Spawn_Interval_raw);
                }
            }

            public const string Spawn_Intervals_displayName = "Spawn Intervals";
            public const int Spawn_Intervals_sortIndex = 50;
            [SortOrder(Spawn_Intervals_sortIndex)]
            [DisplayName(Spawn_Intervals_displayName)]
            public virtual ObservableCollection<Spawn_Intervals> Spawn_Intervals_raw { get; protected set; }

            public partial class Coordinates : MhwStructItem, IWriteDataInner<Elemental_SAED_Spawn_Interval_Coords> {
                public const ulong FixedSizeCount = 0;
                public const string GridName = "Coordinates";

                protected float Unk_1_raw;
                public const string Unk_1_displayName = "Unk 1";
                public const int Unk_1_sortIndex = 50;
                [SortOrder(Unk_1_sortIndex)]
                [DisplayName(Unk_1_displayName)]
                public virtual float Unk_1 {
                    get => Unk_1_raw;
                    set {
                        if (Unk_1_raw == value) return;
                        Unk_1_raw = value;
                        ChangedItems.Add(nameof(Unk_1));
                        OnPropertyChanged(nameof(Unk_1));
                    }
                }

                protected float Unk_2_raw;
                public const string Unk_2_displayName = "Unk 2";
                public const int Unk_2_sortIndex = 100;
                [SortOrder(Unk_2_sortIndex)]
                [DisplayName(Unk_2_displayName)]
                public virtual float Unk_2 {
                    get => Unk_2_raw;
                    set {
                        if (Unk_2_raw == value) return;
                        Unk_2_raw = value;
                        ChangedItems.Add(nameof(Unk_2));
                        OnPropertyChanged(nameof(Unk_2));
                    }
                }

                protected float Unk_3_raw;
                public const string Unk_3_displayName = "Unk 3";
                public const int Unk_3_sortIndex = 150;
                [SortOrder(Unk_3_sortIndex)]
                [DisplayName(Unk_3_displayName)]
                public virtual float Unk_3 {
                    get => Unk_3_raw;
                    set {
                        if (Unk_3_raw == value) return;
                        Unk_3_raw = value;
                        ChangedItems.Add(nameof(Unk_3));
                        OnPropertyChanged(nameof(Unk_3));
                    }
                }

                protected float Unk_4_raw;
                public const string Unk_4_displayName = "Unk 4";
                public const int Unk_4_sortIndex = 200;
                [SortOrder(Unk_4_sortIndex)]
                [DisplayName(Unk_4_displayName)]
                public virtual float Unk_4 {
                    get => Unk_4_raw;
                    set {
                        if (Unk_4_raw == value) return;
                        Unk_4_raw = value;
                        ChangedItems.Add(nameof(Unk_4));
                        OnPropertyChanged(nameof(Unk_4));
                    }
                }

                public const int lastSortIndex = 250;

                public static ObservableMhwStructCollection<Coordinates> LoadData(BinaryReader reader, Elemental_SAED_Spawn_Interval_Coords parent) {
                    var list = new ObservableMhwStructCollection<Coordinates>();
                    ulong count = GetLoadCount(reader, parent);
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Coordinates LoadData(BinaryReader reader, ulong i, Elemental_SAED_Spawn_Interval_Coords parent) {
                    var data = new Coordinates();
                    data.Index = i;
                    data.Unk_1_raw = reader.ReadSingle();
                    data.Unk_2_raw = reader.ReadSingle();
                    data.Unk_3_raw = reader.ReadSingle();
                    data.Unk_4_raw = reader.ReadSingle();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Elemental_SAED_Spawn_Interval_Coords parent) {
                    writer.Write(Unk_1_raw);
                    writer.Write(Unk_2_raw);
                    writer.Write(Unk_3_raw);
                    writer.Write(Unk_4_raw);
                }
            }

            public const string Coordinates_displayName = "Coordinates";
            public const int Coordinates_sortIndex = 100;
            [SortOrder(Coordinates_sortIndex)]
            [DisplayName(Coordinates_displayName)]
            public virtual ObservableCollection<Coordinates> Coordinates_raw { get; protected set; }

            public const int lastSortIndex = 150;

            public IEnumerable<F> GetAllEnumerableChildrenOfType<F>() {
                if (typeof(Spawn_Intervals).Is(typeof(F)) || typeof(Spawn_Intervals).IsGeneric(typeof(F))) {
                    foreach (var item in Spawn_Intervals_raw.Cast<F>()) {
                        yield return item;
                    }
                }
                if (typeof(Coordinates).Is(typeof(F)) || typeof(Coordinates).IsGeneric(typeof(F))) {
                    foreach (var item in Coordinates_raw.Cast<F>()) {
                        yield return item;
                    }
                }
            }

            public static ObservableMhwStructCollection<Elemental_SAED_Spawn_Interval_Coords> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Elemental_SAED_Spawn_Interval_Coords>();
                const ulong count = 6UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Elemental_SAED_Spawn_Interval_Coords LoadData(BinaryReader reader, ulong i) {
                var data = new Elemental_SAED_Spawn_Interval_Coords();
                data.Index = i;
                data.Spawn_Intervals_raw = Spawn_Intervals.LoadData(reader, data);
                data.Coordinates_raw = Coordinates.LoadData(reader, data);
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                foreach (var obj in Spawn_Intervals_raw) {
                    obj.WriteData(writer, this);
                }
                foreach (var obj in Coordinates_raw) {
                    obj.WriteData(writer, this);
                }
            }
        }

        public partial class W09p_Params_17_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W09p Params (17)";

            protected float Unk_168_raw;
            public const string Unk_168_displayName = "Unk 168";
            public const int Unk_168_sortIndex = 50;
            [SortOrder(Unk_168_sortIndex)]
            [DisplayName(Unk_168_displayName)]
            public virtual float Unk_168 {
                get => Unk_168_raw;
                set {
                    if (Unk_168_raw == value) return;
                    Unk_168_raw = value;
                    ChangedItems.Add(nameof(Unk_168));
                    OnPropertyChanged(nameof(Unk_168));
                }
            }

            [DisplayName("Offset")]
            public long Unk_168_offset { get; private set; }

            protected float Unk_169_raw;
            public const string Unk_169_displayName = "Unk 169";
            public const int Unk_169_sortIndex = 100;
            [SortOrder(Unk_169_sortIndex)]
            [DisplayName(Unk_169_displayName)]
            public virtual float Unk_169 {
                get => Unk_169_raw;
                set {
                    if (Unk_169_raw == value) return;
                    Unk_169_raw = value;
                    ChangedItems.Add(nameof(Unk_169));
                    OnPropertyChanged(nameof(Unk_169));
                }
            }

            [DisplayName("Offset")]
            public long Unk_169_offset { get; private set; }

            protected float Unk_170_raw;
            public const string Unk_170_displayName = "Unk 170";
            public const int Unk_170_sortIndex = 150;
            [SortOrder(Unk_170_sortIndex)]
            [DisplayName(Unk_170_displayName)]
            public virtual float Unk_170 {
                get => Unk_170_raw;
                set {
                    if (Unk_170_raw == value) return;
                    Unk_170_raw = value;
                    ChangedItems.Add(nameof(Unk_170));
                    OnPropertyChanged(nameof(Unk_170));
                }
            }

            [DisplayName("Offset")]
            public long Unk_170_offset { get; private set; }

            protected float Unk_171_raw;
            public const string Unk_171_displayName = "Unk 171";
            public const int Unk_171_sortIndex = 200;
            [SortOrder(Unk_171_sortIndex)]
            [DisplayName(Unk_171_displayName)]
            public virtual float Unk_171 {
                get => Unk_171_raw;
                set {
                    if (Unk_171_raw == value) return;
                    Unk_171_raw = value;
                    ChangedItems.Add(nameof(Unk_171));
                    OnPropertyChanged(nameof(Unk_171));
                }
            }

            [DisplayName("Offset")]
            public long Unk_171_offset { get; private set; }

            protected float Unk_172_raw;
            public const string Unk_172_displayName = "Unk 172";
            public const int Unk_172_sortIndex = 250;
            [SortOrder(Unk_172_sortIndex)]
            [DisplayName(Unk_172_displayName)]
            public virtual float Unk_172 {
                get => Unk_172_raw;
                set {
                    if (Unk_172_raw == value) return;
                    Unk_172_raw = value;
                    ChangedItems.Add(nameof(Unk_172));
                    OnPropertyChanged(nameof(Unk_172));
                }
            }

            [DisplayName("Offset")]
            public long Unk_172_offset { get; private set; }

            protected float Unk_173_raw;
            public const string Unk_173_displayName = "Unk 173";
            public const int Unk_173_sortIndex = 300;
            [SortOrder(Unk_173_sortIndex)]
            [DisplayName(Unk_173_displayName)]
            public virtual float Unk_173 {
                get => Unk_173_raw;
                set {
                    if (Unk_173_raw == value) return;
                    Unk_173_raw = value;
                    ChangedItems.Add(nameof(Unk_173));
                    OnPropertyChanged(nameof(Unk_173));
                }
            }

            [DisplayName("Offset")]
            public long Unk_173_offset { get; private set; }

            protected float Unk_174_raw;
            public const string Unk_174_displayName = "Unk 174";
            public const int Unk_174_sortIndex = 350;
            [SortOrder(Unk_174_sortIndex)]
            [DisplayName(Unk_174_displayName)]
            public virtual float Unk_174 {
                get => Unk_174_raw;
                set {
                    if (Unk_174_raw == value) return;
                    Unk_174_raw = value;
                    ChangedItems.Add(nameof(Unk_174));
                    OnPropertyChanged(nameof(Unk_174));
                }
            }

            [DisplayName("Offset")]
            public long Unk_174_offset { get; private set; }

            protected float Unk_175_raw;
            public const string Unk_175_displayName = "Unk 175";
            public const int Unk_175_sortIndex = 400;
            [SortOrder(Unk_175_sortIndex)]
            [DisplayName(Unk_175_displayName)]
            public virtual float Unk_175 {
                get => Unk_175_raw;
                set {
                    if (Unk_175_raw == value) return;
                    Unk_175_raw = value;
                    ChangedItems.Add(nameof(Unk_175));
                    OnPropertyChanged(nameof(Unk_175));
                }
            }

            [DisplayName("Offset")]
            public long Unk_175_offset { get; private set; }

            protected float Unk_176_raw;
            public const string Unk_176_displayName = "Unk 176";
            public const int Unk_176_sortIndex = 450;
            [SortOrder(Unk_176_sortIndex)]
            [DisplayName(Unk_176_displayName)]
            public virtual float Unk_176 {
                get => Unk_176_raw;
                set {
                    if (Unk_176_raw == value) return;
                    Unk_176_raw = value;
                    ChangedItems.Add(nameof(Unk_176));
                    OnPropertyChanged(nameof(Unk_176));
                }
            }

            [DisplayName("Offset")]
            public long Unk_176_offset { get; private set; }

            protected float Unk_177_raw;
            public const string Unk_177_displayName = "Unk 177";
            public const int Unk_177_sortIndex = 500;
            [SortOrder(Unk_177_sortIndex)]
            [DisplayName(Unk_177_displayName)]
            public virtual float Unk_177 {
                get => Unk_177_raw;
                set {
                    if (Unk_177_raw == value) return;
                    Unk_177_raw = value;
                    ChangedItems.Add(nameof(Unk_177));
                    OnPropertyChanged(nameof(Unk_177));
                }
            }

            [DisplayName("Offset")]
            public long Unk_177_offset { get; private set; }

            protected float Unk_178_raw;
            public const string Unk_178_displayName = "Unk 178";
            public const int Unk_178_sortIndex = 550;
            [SortOrder(Unk_178_sortIndex)]
            [DisplayName(Unk_178_displayName)]
            public virtual float Unk_178 {
                get => Unk_178_raw;
                set {
                    if (Unk_178_raw == value) return;
                    Unk_178_raw = value;
                    ChangedItems.Add(nameof(Unk_178));
                    OnPropertyChanged(nameof(Unk_178));
                }
            }

            [DisplayName("Offset")]
            public long Unk_178_offset { get; private set; }

            protected float Unk_179_raw;
            public const string Unk_179_displayName = "Unk 179";
            public const int Unk_179_sortIndex = 600;
            [SortOrder(Unk_179_sortIndex)]
            [DisplayName(Unk_179_displayName)]
            public virtual float Unk_179 {
                get => Unk_179_raw;
                set {
                    if (Unk_179_raw == value) return;
                    Unk_179_raw = value;
                    ChangedItems.Add(nameof(Unk_179));
                    OnPropertyChanged(nameof(Unk_179));
                }
            }

            [DisplayName("Offset")]
            public long Unk_179_offset { get; private set; }

            protected float Unk_180_raw;
            public const string Unk_180_displayName = "Unk 180";
            public const int Unk_180_sortIndex = 650;
            [SortOrder(Unk_180_sortIndex)]
            [DisplayName(Unk_180_displayName)]
            public virtual float Unk_180 {
                get => Unk_180_raw;
                set {
                    if (Unk_180_raw == value) return;
                    Unk_180_raw = value;
                    ChangedItems.Add(nameof(Unk_180));
                    OnPropertyChanged(nameof(Unk_180));
                }
            }

            [DisplayName("Offset")]
            public long Unk_180_offset { get; private set; }

            protected float Unk_181_raw;
            public const string Unk_181_displayName = "Unk 181";
            public const int Unk_181_sortIndex = 700;
            [SortOrder(Unk_181_sortIndex)]
            [DisplayName(Unk_181_displayName)]
            public virtual float Unk_181 {
                get => Unk_181_raw;
                set {
                    if (Unk_181_raw == value) return;
                    Unk_181_raw = value;
                    ChangedItems.Add(nameof(Unk_181));
                    OnPropertyChanged(nameof(Unk_181));
                }
            }

            [DisplayName("Offset")]
            public long Unk_181_offset { get; private set; }

            protected float Unk_182_raw;
            public const string Unk_182_displayName = "Unk 182";
            public const int Unk_182_sortIndex = 750;
            [SortOrder(Unk_182_sortIndex)]
            [DisplayName(Unk_182_displayName)]
            public virtual float Unk_182 {
                get => Unk_182_raw;
                set {
                    if (Unk_182_raw == value) return;
                    Unk_182_raw = value;
                    ChangedItems.Add(nameof(Unk_182));
                    OnPropertyChanged(nameof(Unk_182));
                }
            }

            [DisplayName("Offset")]
            public long Unk_182_offset { get; private set; }

            protected float Unk_183_raw;
            public const string Unk_183_displayName = "Unk 183";
            public const int Unk_183_sortIndex = 800;
            [SortOrder(Unk_183_sortIndex)]
            [DisplayName(Unk_183_displayName)]
            public virtual float Unk_183 {
                get => Unk_183_raw;
                set {
                    if (Unk_183_raw == value) return;
                    Unk_183_raw = value;
                    ChangedItems.Add(nameof(Unk_183));
                    OnPropertyChanged(nameof(Unk_183));
                }
            }

            [DisplayName("Offset")]
            public long Unk_183_offset { get; private set; }

            protected float Unk_184_raw;
            public const string Unk_184_displayName = "Unk 184";
            public const int Unk_184_sortIndex = 850;
            [SortOrder(Unk_184_sortIndex)]
            [DisplayName(Unk_184_displayName)]
            public virtual float Unk_184 {
                get => Unk_184_raw;
                set {
                    if (Unk_184_raw == value) return;
                    Unk_184_raw = value;
                    ChangedItems.Add(nameof(Unk_184));
                    OnPropertyChanged(nameof(Unk_184));
                }
            }

            [DisplayName("Offset")]
            public long Unk_184_offset { get; private set; }

            protected float Unk_185_raw;
            public const string Unk_185_displayName = "Unk 185";
            public const int Unk_185_sortIndex = 900;
            [SortOrder(Unk_185_sortIndex)]
            [DisplayName(Unk_185_displayName)]
            public virtual float Unk_185 {
                get => Unk_185_raw;
                set {
                    if (Unk_185_raw == value) return;
                    Unk_185_raw = value;
                    ChangedItems.Add(nameof(Unk_185));
                    OnPropertyChanged(nameof(Unk_185));
                }
            }

            [DisplayName("Offset")]
            public long Unk_185_offset { get; private set; }

            protected float Unk_186_raw;
            public const string Unk_186_displayName = "Unk 186";
            public const int Unk_186_sortIndex = 950;
            [SortOrder(Unk_186_sortIndex)]
            [DisplayName(Unk_186_displayName)]
            public virtual float Unk_186 {
                get => Unk_186_raw;
                set {
                    if (Unk_186_raw == value) return;
                    Unk_186_raw = value;
                    ChangedItems.Add(nameof(Unk_186));
                    OnPropertyChanged(nameof(Unk_186));
                }
            }

            [DisplayName("Offset")]
            public long Unk_186_offset { get; private set; }

            protected float Unk_187_raw;
            public const string Unk_187_displayName = "Unk 187";
            public const int Unk_187_sortIndex = 1000;
            [SortOrder(Unk_187_sortIndex)]
            [DisplayName(Unk_187_displayName)]
            public virtual float Unk_187 {
                get => Unk_187_raw;
                set {
                    if (Unk_187_raw == value) return;
                    Unk_187_raw = value;
                    ChangedItems.Add(nameof(Unk_187));
                    OnPropertyChanged(nameof(Unk_187));
                }
            }

            [DisplayName("Offset")]
            public long Unk_187_offset { get; private set; }

            protected float Unk_188_raw;
            public const string Unk_188_displayName = "Unk 188";
            public const int Unk_188_sortIndex = 1050;
            [SortOrder(Unk_188_sortIndex)]
            [DisplayName(Unk_188_displayName)]
            public virtual float Unk_188 {
                get => Unk_188_raw;
                set {
                    if (Unk_188_raw == value) return;
                    Unk_188_raw = value;
                    ChangedItems.Add(nameof(Unk_188));
                    OnPropertyChanged(nameof(Unk_188));
                }
            }

            [DisplayName("Offset")]
            public long Unk_188_offset { get; private set; }

            public const int lastSortIndex = 1100;

            public static ObservableMhwStructCollection<W09p_Params_17_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W09p_Params_17_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W09p_Params_17_ LoadData(BinaryReader reader, ulong i) {
                var data = new W09p_Params_17_();
                data.Index = i;
                data.Unk_168_offset = reader.BaseStream.Position;
                data.Unk_168_raw = reader.ReadSingle();
                data.Unk_169_offset = reader.BaseStream.Position;
                data.Unk_169_raw = reader.ReadSingle();
                data.Unk_170_offset = reader.BaseStream.Position;
                data.Unk_170_raw = reader.ReadSingle();
                data.Unk_171_offset = reader.BaseStream.Position;
                data.Unk_171_raw = reader.ReadSingle();
                data.Unk_172_offset = reader.BaseStream.Position;
                data.Unk_172_raw = reader.ReadSingle();
                data.Unk_173_offset = reader.BaseStream.Position;
                data.Unk_173_raw = reader.ReadSingle();
                data.Unk_174_offset = reader.BaseStream.Position;
                data.Unk_174_raw = reader.ReadSingle();
                data.Unk_175_offset = reader.BaseStream.Position;
                data.Unk_175_raw = reader.ReadSingle();
                data.Unk_176_offset = reader.BaseStream.Position;
                data.Unk_176_raw = reader.ReadSingle();
                data.Unk_177_offset = reader.BaseStream.Position;
                data.Unk_177_raw = reader.ReadSingle();
                data.Unk_178_offset = reader.BaseStream.Position;
                data.Unk_178_raw = reader.ReadSingle();
                data.Unk_179_offset = reader.BaseStream.Position;
                data.Unk_179_raw = reader.ReadSingle();
                data.Unk_180_offset = reader.BaseStream.Position;
                data.Unk_180_raw = reader.ReadSingle();
                data.Unk_181_offset = reader.BaseStream.Position;
                data.Unk_181_raw = reader.ReadSingle();
                data.Unk_182_offset = reader.BaseStream.Position;
                data.Unk_182_raw = reader.ReadSingle();
                data.Unk_183_offset = reader.BaseStream.Position;
                data.Unk_183_raw = reader.ReadSingle();
                data.Unk_184_offset = reader.BaseStream.Position;
                data.Unk_184_raw = reader.ReadSingle();
                data.Unk_185_offset = reader.BaseStream.Position;
                data.Unk_185_raw = reader.ReadSingle();
                data.Unk_186_offset = reader.BaseStream.Position;
                data.Unk_186_raw = reader.ReadSingle();
                data.Unk_187_offset = reader.BaseStream.Position;
                data.Unk_187_raw = reader.ReadSingle();
                data.Unk_188_offset = reader.BaseStream.Position;
                data.Unk_188_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_168_raw);
                writer.Write(Unk_169_raw);
                writer.Write(Unk_170_raw);
                writer.Write(Unk_171_raw);
                writer.Write(Unk_172_raw);
                writer.Write(Unk_173_raw);
                writer.Write(Unk_174_raw);
                writer.Write(Unk_175_raw);
                writer.Write(Unk_176_raw);
                writer.Write(Unk_177_raw);
                writer.Write(Unk_178_raw);
                writer.Write(Unk_179_raw);
                writer.Write(Unk_180_raw);
                writer.Write(Unk_181_raw);
                writer.Write(Unk_182_raw);
                writer.Write(Unk_183_raw);
                writer.Write(Unk_184_raw);
                writer.Write(Unk_185_raw);
                writer.Write(Unk_186_raw);
                writer.Write(Unk_187_raw);
                writer.Write(Unk_188_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 168", "Unk_168", "Unk_168_offset"),
                    new MultiStructItemCustomView(this, "Unk 169", "Unk_169", "Unk_169_offset"),
                    new MultiStructItemCustomView(this, "Unk 170", "Unk_170", "Unk_170_offset"),
                    new MultiStructItemCustomView(this, "Unk 171", "Unk_171", "Unk_171_offset"),
                    new MultiStructItemCustomView(this, "Unk 172", "Unk_172", "Unk_172_offset"),
                    new MultiStructItemCustomView(this, "Unk 173", "Unk_173", "Unk_173_offset"),
                    new MultiStructItemCustomView(this, "Unk 174", "Unk_174", "Unk_174_offset"),
                    new MultiStructItemCustomView(this, "Unk 175", "Unk_175", "Unk_175_offset"),
                    new MultiStructItemCustomView(this, "Unk 176", "Unk_176", "Unk_176_offset"),
                    new MultiStructItemCustomView(this, "Unk 177", "Unk_177", "Unk_177_offset"),
                    new MultiStructItemCustomView(this, "Unk 178", "Unk_178", "Unk_178_offset"),
                    new MultiStructItemCustomView(this, "Unk 179", "Unk_179", "Unk_179_offset"),
                    new MultiStructItemCustomView(this, "Unk 180", "Unk_180", "Unk_180_offset"),
                    new MultiStructItemCustomView(this, "Unk 181", "Unk_181", "Unk_181_offset"),
                    new MultiStructItemCustomView(this, "Unk 182", "Unk_182", "Unk_182_offset"),
                    new MultiStructItemCustomView(this, "Unk 183", "Unk_183", "Unk_183_offset"),
                    new MultiStructItemCustomView(this, "Unk 184", "Unk_184", "Unk_184_offset"),
                    new MultiStructItemCustomView(this, "Unk 185", "Unk_185", "Unk_185_offset"),
                    new MultiStructItemCustomView(this, "Unk 186", "Unk_186", "Unk_186_offset"),
                    new MultiStructItemCustomView(this, "Unk 187", "Unk_187", "Unk_187_offset"),
                    new MultiStructItemCustomView(this, "Unk 188", "Unk_188", "Unk_188_offset"),
                };
            }
        }

        public partial class Action_Param_5 : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Action Param 5";

            protected float Gravity_raw;
            public const string Gravity_displayName = "Gravity";
            public const int Gravity_sortIndex = 50;
            [SortOrder(Gravity_sortIndex)]
            [DisplayName(Gravity_displayName)]
            public virtual float Gravity {
                get => Gravity_raw;
                set {
                    if (Gravity_raw == value) return;
                    Gravity_raw = value;
                    ChangedItems.Add(nameof(Gravity));
                    OnPropertyChanged(nameof(Gravity));
                }
            }

            protected float Time_Rate_raw;
            public const string Time_Rate_displayName = "Time Rate";
            public const int Time_Rate_sortIndex = 100;
            [SortOrder(Time_Rate_sortIndex)]
            [DisplayName(Time_Rate_displayName)]
            public virtual float Time_Rate {
                get => Time_Rate_raw;
                set {
                    if (Time_Rate_raw == value) return;
                    Time_Rate_raw = value;
                    ChangedItems.Add(nameof(Time_Rate));
                    OnPropertyChanged(nameof(Time_Rate));
                }
            }

            protected float Initial_X_Velocity_raw;
            public const string Initial_X_Velocity_displayName = "Initial X Velocity";
            public const int Initial_X_Velocity_sortIndex = 150;
            [SortOrder(Initial_X_Velocity_sortIndex)]
            [DisplayName(Initial_X_Velocity_displayName)]
            public virtual float Initial_X_Velocity {
                get => Initial_X_Velocity_raw;
                set {
                    if (Initial_X_Velocity_raw == value) return;
                    Initial_X_Velocity_raw = value;
                    ChangedItems.Add(nameof(Initial_X_Velocity));
                    OnPropertyChanged(nameof(Initial_X_Velocity));
                }
            }

            protected float Initial_Y_Velocity_raw;
            public const string Initial_Y_Velocity_displayName = "Initial Y Velocity";
            public const int Initial_Y_Velocity_sortIndex = 200;
            [SortOrder(Initial_Y_Velocity_sortIndex)]
            [DisplayName(Initial_Y_Velocity_displayName)]
            public virtual float Initial_Y_Velocity {
                get => Initial_Y_Velocity_raw;
                set {
                    if (Initial_Y_Velocity_raw == value) return;
                    Initial_Y_Velocity_raw = value;
                    ChangedItems.Add(nameof(Initial_Y_Velocity));
                    OnPropertyChanged(nameof(Initial_Y_Velocity));
                }
            }

            protected float Initial_Z_Velocity_raw;
            public const string Initial_Z_Velocity_displayName = "Initial Z Velocity";
            public const int Initial_Z_Velocity_sortIndex = 250;
            [SortOrder(Initial_Z_Velocity_sortIndex)]
            [DisplayName(Initial_Z_Velocity_displayName)]
            public virtual float Initial_Z_Velocity {
                get => Initial_Z_Velocity_raw;
                set {
                    if (Initial_Z_Velocity_raw == value) return;
                    Initial_Z_Velocity_raw = value;
                    ChangedItems.Add(nameof(Initial_Z_Velocity));
                    OnPropertyChanged(nameof(Initial_Z_Velocity));
                }
            }

            public const int lastSortIndex = 300;

            public static ObservableMhwStructCollection<Action_Param_5> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Action_Param_5>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Action_Param_5 LoadData(BinaryReader reader, ulong i) {
                var data = new Action_Param_5();
                data.Index = i;
                data.Gravity_raw = reader.ReadSingle();
                data.Time_Rate_raw = reader.ReadSingle();
                data.Initial_X_Velocity_raw = reader.ReadSingle();
                data.Initial_Y_Velocity_raw = reader.ReadSingle();
                data.Initial_Z_Velocity_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Gravity_raw);
                writer.Write(Time_Rate_raw);
                writer.Write(Initial_X_Velocity_raw);
                writer.Write(Initial_Y_Velocity_raw);
                writer.Write(Initial_Z_Velocity_raw);
            }
        }

        public partial class W09p_Params_18_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W09p Params (18)";

            protected float Savage_Axe_Duration_Elemental_Phial__raw;
            public const string Savage_Axe_Duration_Elemental_Phial__displayName = "Savage Axe Duration (Elemental Phial)";
            public const int Savage_Axe_Duration_Elemental_Phial__sortIndex = 50;
            [SortOrder(Savage_Axe_Duration_Elemental_Phial__sortIndex)]
            [DisplayName(Savage_Axe_Duration_Elemental_Phial__displayName)]
            public virtual float Savage_Axe_Duration_Elemental_Phial_ {
                get => Savage_Axe_Duration_Elemental_Phial__raw;
                set {
                    if (Savage_Axe_Duration_Elemental_Phial__raw == value) return;
                    Savage_Axe_Duration_Elemental_Phial__raw = value;
                    ChangedItems.Add(nameof(Savage_Axe_Duration_Elemental_Phial_));
                    OnPropertyChanged(nameof(Savage_Axe_Duration_Elemental_Phial_));
                }
            }

            [DisplayName("Offset")]
            public long Savage_Axe_Duration_Elemental_Phial__offset { get; private set; }

            protected float Unk_190_raw;
            public const string Unk_190_displayName = "Unk 190";
            public const int Unk_190_sortIndex = 100;
            [SortOrder(Unk_190_sortIndex)]
            [DisplayName(Unk_190_displayName)]
            public virtual float Unk_190 {
                get => Unk_190_raw;
                set {
                    if (Unk_190_raw == value) return;
                    Unk_190_raw = value;
                    ChangedItems.Add(nameof(Unk_190));
                    OnPropertyChanged(nameof(Unk_190));
                }
            }

            [DisplayName("Offset")]
            public long Unk_190_offset { get; private set; }

            protected float Savage_Axe_Duration_Impact_Phial_Inverse_Multiplier_of_Elemental_Phial_Duration__raw;
            public const string Savage_Axe_Duration_Impact_Phial_Inverse_Multiplier_of_Elemental_Phial_Duration__displayName = "Savage Axe Duration (Impact Phial) (Inverse Multiplier of Elemental Phial Duration)";
            public const int Savage_Axe_Duration_Impact_Phial_Inverse_Multiplier_of_Elemental_Phial_Duration__sortIndex = 150;
            [SortOrder(Savage_Axe_Duration_Impact_Phial_Inverse_Multiplier_of_Elemental_Phial_Duration__sortIndex)]
            [DisplayName(Savage_Axe_Duration_Impact_Phial_Inverse_Multiplier_of_Elemental_Phial_Duration__displayName)]
            public virtual float Savage_Axe_Duration_Impact_Phial_Inverse_Multiplier_of_Elemental_Phial_Duration_ {
                get => Savage_Axe_Duration_Impact_Phial_Inverse_Multiplier_of_Elemental_Phial_Duration__raw;
                set {
                    if (Savage_Axe_Duration_Impact_Phial_Inverse_Multiplier_of_Elemental_Phial_Duration__raw == value) return;
                    Savage_Axe_Duration_Impact_Phial_Inverse_Multiplier_of_Elemental_Phial_Duration__raw = value;
                    ChangedItems.Add(nameof(Savage_Axe_Duration_Impact_Phial_Inverse_Multiplier_of_Elemental_Phial_Duration_));
                    OnPropertyChanged(nameof(Savage_Axe_Duration_Impact_Phial_Inverse_Multiplier_of_Elemental_Phial_Duration_));
                }
            }

            [DisplayName("Offset")]
            public long Savage_Axe_Duration_Impact_Phial_Inverse_Multiplier_of_Elemental_Phial_Duration__offset { get; private set; }

            protected float Unk_192_raw;
            public const string Unk_192_displayName = "Unk 192";
            public const int Unk_192_sortIndex = 200;
            [SortOrder(Unk_192_sortIndex)]
            [DisplayName(Unk_192_displayName)]
            public virtual float Unk_192 {
                get => Unk_192_raw;
                set {
                    if (Unk_192_raw == value) return;
                    Unk_192_raw = value;
                    ChangedItems.Add(nameof(Unk_192));
                    OnPropertyChanged(nameof(Unk_192));
                }
            }

            [DisplayName("Offset")]
            public long Unk_192_offset { get; private set; }

            protected float Unk_193_raw;
            public const string Unk_193_displayName = "Unk 193";
            public const int Unk_193_sortIndex = 250;
            [SortOrder(Unk_193_sortIndex)]
            [DisplayName(Unk_193_displayName)]
            public virtual float Unk_193 {
                get => Unk_193_raw;
                set {
                    if (Unk_193_raw == value) return;
                    Unk_193_raw = value;
                    ChangedItems.Add(nameof(Unk_193));
                    OnPropertyChanged(nameof(Unk_193));
                }
            }

            [DisplayName("Offset")]
            public long Unk_193_offset { get; private set; }

            protected uint Savage_Axe_Tick_Sharpness_Use_on_N_Hit_raw;
            public const string Savage_Axe_Tick_Sharpness_Use_on_N_Hit_displayName = "Savage Axe Tick Sharpness Use on N Hit";
            public const int Savage_Axe_Tick_Sharpness_Use_on_N_Hit_sortIndex = 300;
            [SortOrder(Savage_Axe_Tick_Sharpness_Use_on_N_Hit_sortIndex)]
            [DisplayName(Savage_Axe_Tick_Sharpness_Use_on_N_Hit_displayName)]
            public virtual uint Savage_Axe_Tick_Sharpness_Use_on_N_Hit {
                get => Savage_Axe_Tick_Sharpness_Use_on_N_Hit_raw;
                set {
                    if (Savage_Axe_Tick_Sharpness_Use_on_N_Hit_raw == value) return;
                    Savage_Axe_Tick_Sharpness_Use_on_N_Hit_raw = value;
                    ChangedItems.Add(nameof(Savage_Axe_Tick_Sharpness_Use_on_N_Hit));
                    OnPropertyChanged(nameof(Savage_Axe_Tick_Sharpness_Use_on_N_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Savage_Axe_Tick_Sharpness_Use_on_N_Hit_offset { get; private set; }

            public const int lastSortIndex = 350;

            public static ObservableMhwStructCollection<W09p_Params_18_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W09p_Params_18_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W09p_Params_18_ LoadData(BinaryReader reader, ulong i) {
                var data = new W09p_Params_18_();
                data.Index = i;
                data.Savage_Axe_Duration_Elemental_Phial__offset = reader.BaseStream.Position;
                data.Savage_Axe_Duration_Elemental_Phial__raw = reader.ReadSingle();
                data.Unk_190_offset = reader.BaseStream.Position;
                data.Unk_190_raw = reader.ReadSingle();
                data.Savage_Axe_Duration_Impact_Phial_Inverse_Multiplier_of_Elemental_Phial_Duration__offset = reader.BaseStream.Position;
                data.Savage_Axe_Duration_Impact_Phial_Inverse_Multiplier_of_Elemental_Phial_Duration__raw = reader.ReadSingle();
                data.Unk_192_offset = reader.BaseStream.Position;
                data.Unk_192_raw = reader.ReadSingle();
                data.Unk_193_offset = reader.BaseStream.Position;
                data.Unk_193_raw = reader.ReadSingle();
                data.Savage_Axe_Tick_Sharpness_Use_on_N_Hit_offset = reader.BaseStream.Position;
                data.Savage_Axe_Tick_Sharpness_Use_on_N_Hit_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Savage_Axe_Duration_Elemental_Phial__raw);
                writer.Write(Unk_190_raw);
                writer.Write(Savage_Axe_Duration_Impact_Phial_Inverse_Multiplier_of_Elemental_Phial_Duration__raw);
                writer.Write(Unk_192_raw);
                writer.Write(Unk_193_raw);
                writer.Write(Savage_Axe_Tick_Sharpness_Use_on_N_Hit_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Savage Axe Duration (Elemental Phial)", "Savage_Axe_Duration_Elemental_Phial_", "Savage_Axe_Duration_Elemental_Phial__offset"),
                    new MultiStructItemCustomView(this, "Unk 190", "Unk_190", "Unk_190_offset"),
                    new MultiStructItemCustomView(this, "Savage Axe Duration (Impact Phial) (Inverse Multiplier of Elemental Phial Duration)", "Savage_Axe_Duration_Impact_Phial_Inverse_Multiplier_of_Elemental_Phial_Duration_", "Savage_Axe_Duration_Impact_Phial_Inverse_Multiplier_of_Elemental_Phial_Duration__offset"),
                    new MultiStructItemCustomView(this, "Unk 192", "Unk_192", "Unk_192_offset"),
                    new MultiStructItemCustomView(this, "Unk 193", "Unk_193", "Unk_193_offset"),
                    new MultiStructItemCustomView(this, "Savage Axe Tick Sharpness Use on N Hit", "Savage_Axe_Tick_Sharpness_Use_on_N_Hit", "Savage_Axe_Tick_Sharpness_Use_on_N_Hit_offset"),
                };
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var W09p_Params_1_Shared__ = new MhwStructDataContainer<W09p_Params_1_Shared_>(W09p_Params_1_Shared_.LoadData(reader), typeof(W09p_Params_1_Shared_));
            data.AddLast(W09p_Params_1_Shared__);
            var Unk_Arr_1_Shared__ = new MhwStructDataContainer<Unk_Arr_1_Shared_>(Unk_Arr_1_Shared_.LoadData(reader), typeof(Unk_Arr_1_Shared_));
            data.AddLast(Unk_Arr_1_Shared__);
            var W09p_Params_2_Shared__ = new MhwStructDataContainer<W09p_Params_2_Shared_>(W09p_Params_2_Shared_.LoadData(reader), typeof(W09p_Params_2_Shared_));
            data.AddLast(W09p_Params_2_Shared__);
            var Guard_Angles_Shared__ = new MhwStructDataContainer<Guard_Angles_Shared_>(Guard_Angles_Shared_.LoadData(reader), typeof(Guard_Angles_Shared_));
            data.AddLast(Guard_Angles_Shared__);
            var W09p_Params_3_Shared__ = new MhwStructDataContainer<W09p_Params_3_Shared_>(W09p_Params_3_Shared_.LoadData(reader), typeof(W09p_Params_3_Shared_));
            data.AddLast(W09p_Params_3_Shared__);
            var Unk_Arr_2_Shared__ = new MhwStructDataContainer<Unk_Arr_2_Shared_>(Unk_Arr_2_Shared_.LoadData(reader), typeof(Unk_Arr_2_Shared_));
            data.AddLast(Unk_Arr_2_Shared__);
            var W09p_Params_4_Shared__ = new MhwStructDataContainer<W09p_Params_4_Shared_>(W09p_Params_4_Shared_.LoadData(reader), typeof(W09p_Params_4_Shared_));
            data.AddLast(W09p_Params_4_Shared__);
            var W09p_Params_5__ = new MhwStructDataContainer<W09p_Params_5_>(W09p_Params_5_.LoadData(reader), typeof(W09p_Params_5_));
            data.AddLast(W09p_Params_5__);
            var Action_Param_1_ = new MhwStructDataContainer<Action_Param_1>(Action_Param_1.LoadData(reader), typeof(Action_Param_1));
            data.AddLast(Action_Param_1_);
            var W09p_Params_6__ = new MhwStructDataContainer<W09p_Params_6_>(W09p_Params_6_.LoadData(reader), typeof(W09p_Params_6_));
            data.AddLast(W09p_Params_6__);
            var Unk_Arr_3_ = new MhwStructDataContainer<Unk_Arr_3>(Unk_Arr_3.LoadData(reader), typeof(Unk_Arr_3));
            data.AddLast(Unk_Arr_3_);
            var W09p_Params_7__ = new MhwStructDataContainer<W09p_Params_7_>(W09p_Params_7_.LoadData(reader), typeof(W09p_Params_7_));
            data.AddLast(W09p_Params_7__);
            var Action_Param_2_ = new MhwStructDataContainer<Action_Param_2>(Action_Param_2.LoadData(reader), typeof(Action_Param_2));
            data.AddLast(Action_Param_2_);
            var W09p_Params_8__ = new MhwStructDataContainer<W09p_Params_8_>(W09p_Params_8_.LoadData(reader), typeof(W09p_Params_8_));
            data.AddLast(W09p_Params_8__);
            var Action_Param_3_ = new MhwStructDataContainer<Action_Param_3>(Action_Param_3.LoadData(reader), typeof(Action_Param_3));
            data.AddLast(Action_Param_3_);
            var W09p_Params_9__ = new MhwStructDataContainer<W09p_Params_9_>(W09p_Params_9_.LoadData(reader), typeof(W09p_Params_9_));
            data.AddLast(W09p_Params_9__);
            var Action_Param_4_ = new MhwStructDataContainer<Action_Param_4>(Action_Param_4.LoadData(reader), typeof(Action_Param_4));
            data.AddLast(Action_Param_4_);
            var Impact_SAED_Phial_Spawn_Interval_ = new MhwStructDataContainer<Impact_SAED_Phial_Spawn_Interval>(Impact_SAED_Phial_Spawn_Interval.LoadData(reader), typeof(Impact_SAED_Phial_Spawn_Interval));
            data.AddLast(Impact_SAED_Phial_Spawn_Interval_);
            var Impact_SAED_Coordinates_ = new MhwStructDataContainer<Impact_SAED_Coordinates>(Impact_SAED_Coordinates.LoadData(reader), typeof(Impact_SAED_Coordinates));
            data.AddLast(Impact_SAED_Coordinates_);
            var Elemental_SAED_Spawn_Interval_Coords_ = new MhwStructDataContainer<Elemental_SAED_Spawn_Interval_Coords>(Elemental_SAED_Spawn_Interval_Coords.LoadData(reader), typeof(Elemental_SAED_Spawn_Interval_Coords));
            data.AddLast(Elemental_SAED_Spawn_Interval_Coords_);
            var W09p_Params_17__ = new MhwStructDataContainer<W09p_Params_17_>(W09p_Params_17_.LoadData(reader), typeof(W09p_Params_17_));
            data.AddLast(W09p_Params_17__);
            var Action_Param_5_ = new MhwStructDataContainer<Action_Param_5>(Action_Param_5.LoadData(reader), typeof(Action_Param_5));
            data.AddLast(Action_Param_5_);
            var W09p_Params_18__ = new MhwStructDataContainer<W09p_Params_18_>(W09p_Params_18_.LoadData(reader), typeof(W09p_Params_18_));
            data.AddLast(W09p_Params_18__);
        }
    }
}