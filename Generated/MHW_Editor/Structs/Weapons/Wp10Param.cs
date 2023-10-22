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
    public partial class Wp10Param {
        public override string EncryptionKey => "j1P15gEkgVa7NdFxiqwCPitykHctY2nZPjSaElvqb0eSwcLO1cOlTqqv";

        public partial class W10p_Params_1_Shared_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W10p Params (1, Shared)";

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

            public static ObservableMhwStructCollection<W10p_Params_1_Shared_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W10p_Params_1_Shared_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W10p_Params_1_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new W10p_Params_1_Shared_();
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

        public partial class W10p_Params_2_Shared_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W10p Params (2, Shared)";

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

            public static ObservableMhwStructCollection<W10p_Params_2_Shared_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W10p_Params_2_Shared_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W10p_Params_2_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new W10p_Params_2_Shared_();
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

        public partial class W10p_Params_3_Shared_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W10p Params (3, Shared)";

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

            public static ObservableMhwStructCollection<W10p_Params_3_Shared_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W10p_Params_3_Shared_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W10p_Params_3_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new W10p_Params_3_Shared_();
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

        public partial class W10p_Params_4_Shared_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W10p Params (4, Shared)";

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

            public static ObservableMhwStructCollection<W10p_Params_4_Shared_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W10p_Params_4_Shared_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W10p_Params_4_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new W10p_Params_4_Shared_();
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

        public partial class W10p_Params_5_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W10p Params (5)";

            protected float Red_Extract_Duration_raw;
            public const string Red_Extract_Duration_displayName = "Red Extract Duration";
            public const int Red_Extract_Duration_sortIndex = 50;
            [SortOrder(Red_Extract_Duration_sortIndex)]
            [DisplayName(Red_Extract_Duration_displayName)]
            public virtual float Red_Extract_Duration {
                get => Red_Extract_Duration_raw;
                set {
                    if (Red_Extract_Duration_raw == value) return;
                    Red_Extract_Duration_raw = value;
                    ChangedItems.Add(nameof(Red_Extract_Duration));
                    OnPropertyChanged(nameof(Red_Extract_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Red_Extract_Duration_offset { get; private set; }

            protected float White_Extract_Duration_raw;
            public const string White_Extract_Duration_displayName = "White Extract Duration";
            public const int White_Extract_Duration_sortIndex = 100;
            [SortOrder(White_Extract_Duration_sortIndex)]
            [DisplayName(White_Extract_Duration_displayName)]
            public virtual float White_Extract_Duration {
                get => White_Extract_Duration_raw;
                set {
                    if (White_Extract_Duration_raw == value) return;
                    White_Extract_Duration_raw = value;
                    ChangedItems.Add(nameof(White_Extract_Duration));
                    OnPropertyChanged(nameof(White_Extract_Duration));
                }
            }

            [DisplayName("Offset")]
            public long White_Extract_Duration_offset { get; private set; }

            protected float Orange_Extract_Duration_raw;
            public const string Orange_Extract_Duration_displayName = "Orange Extract Duration";
            public const int Orange_Extract_Duration_sortIndex = 150;
            [SortOrder(Orange_Extract_Duration_sortIndex)]
            [DisplayName(Orange_Extract_Duration_displayName)]
            public virtual float Orange_Extract_Duration {
                get => Orange_Extract_Duration_raw;
                set {
                    if (Orange_Extract_Duration_raw == value) return;
                    Orange_Extract_Duration_raw = value;
                    ChangedItems.Add(nameof(Orange_Extract_Duration));
                    OnPropertyChanged(nameof(Orange_Extract_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Orange_Extract_Duration_offset { get; private set; }

            protected float Triple_Extract_Duration_raw;
            public const string Triple_Extract_Duration_displayName = "Triple Extract Duration";
            public const int Triple_Extract_Duration_sortIndex = 200;
            [SortOrder(Triple_Extract_Duration_sortIndex)]
            [DisplayName(Triple_Extract_Duration_displayName)]
            public virtual float Triple_Extract_Duration {
                get => Triple_Extract_Duration_raw;
                set {
                    if (Triple_Extract_Duration_raw == value) return;
                    Triple_Extract_Duration_raw = value;
                    ChangedItems.Add(nameof(Triple_Extract_Duration));
                    OnPropertyChanged(nameof(Triple_Extract_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Triple_Extract_Duration_offset { get; private set; }

            protected float Twinkling_When_Extraction_Time_Remaining_is_10s_raw;
            public const string Twinkling_When_Extraction_Time_Remaining_is_10s_displayName = "Twinkling When Extraction Time Remaining is 10s";
            public const int Twinkling_When_Extraction_Time_Remaining_is_10s_sortIndex = 250;
            [SortOrder(Twinkling_When_Extraction_Time_Remaining_is_10s_sortIndex)]
            [DisplayName(Twinkling_When_Extraction_Time_Remaining_is_10s_displayName)]
            public virtual float Twinkling_When_Extraction_Time_Remaining_is_10s {
                get => Twinkling_When_Extraction_Time_Remaining_is_10s_raw;
                set {
                    if (Twinkling_When_Extraction_Time_Remaining_is_10s_raw == value) return;
                    Twinkling_When_Extraction_Time_Remaining_is_10s_raw = value;
                    ChangedItems.Add(nameof(Twinkling_When_Extraction_Time_Remaining_is_10s));
                    OnPropertyChanged(nameof(Twinkling_When_Extraction_Time_Remaining_is_10s));
                }
            }

            [DisplayName("Offset")]
            public long Twinkling_When_Extraction_Time_Remaining_is_10s_offset { get; private set; }

            protected float Damage_Buff_Red_Plus_White_raw;
            public const string Damage_Buff_Red_Plus_White_displayName = "Damage Buff: Red + White";
            public const int Damage_Buff_Red_Plus_White_sortIndex = 300;
            [SortOrder(Damage_Buff_Red_Plus_White_sortIndex)]
            [DisplayName(Damage_Buff_Red_Plus_White_displayName)]
            public virtual float Damage_Buff_Red_Plus_White {
                get => Damage_Buff_Red_Plus_White_raw;
                set {
                    if (Damage_Buff_Red_Plus_White_raw == value) return;
                    Damage_Buff_Red_Plus_White_raw = value;
                    ChangedItems.Add(nameof(Damage_Buff_Red_Plus_White));
                    OnPropertyChanged(nameof(Damage_Buff_Red_Plus_White));
                }
            }

            [DisplayName("Offset")]
            public long Damage_Buff_Red_Plus_White_offset { get; private set; }

            protected float Damage_Buff_All_Three_Extracts_raw;
            public const string Damage_Buff_All_Three_Extracts_displayName = "Damage Buff: All Three Extracts";
            public const int Damage_Buff_All_Three_Extracts_sortIndex = 350;
            [SortOrder(Damage_Buff_All_Three_Extracts_sortIndex)]
            [DisplayName(Damage_Buff_All_Three_Extracts_displayName)]
            public virtual float Damage_Buff_All_Three_Extracts {
                get => Damage_Buff_All_Three_Extracts_raw;
                set {
                    if (Damage_Buff_All_Three_Extracts_raw == value) return;
                    Damage_Buff_All_Three_Extracts_raw = value;
                    ChangedItems.Add(nameof(Damage_Buff_All_Three_Extracts));
                    OnPropertyChanged(nameof(Damage_Buff_All_Three_Extracts));
                }
            }

            [DisplayName("Offset")]
            public long Damage_Buff_All_Three_Extracts_offset { get; private set; }

            protected float Speed_Buff_White_raw;
            public const string Speed_Buff_White_displayName = "Speed Buff: White";
            public const int Speed_Buff_White_sortIndex = 400;
            [SortOrder(Speed_Buff_White_sortIndex)]
            [DisplayName(Speed_Buff_White_displayName)]
            public virtual float Speed_Buff_White {
                get => Speed_Buff_White_raw;
                set {
                    if (Speed_Buff_White_raw == value) return;
                    Speed_Buff_White_raw = value;
                    ChangedItems.Add(nameof(Speed_Buff_White));
                    OnPropertyChanged(nameof(Speed_Buff_White));
                }
            }

            [DisplayName("Offset")]
            public long Speed_Buff_White_offset { get; private set; }

            protected float Moving_Displacement_Multi_Buff_White_raw;
            public const string Moving_Displacement_Multi_Buff_White_displayName = "Moving Displacement Multi Buff: White";
            public const int Moving_Displacement_Multi_Buff_White_sortIndex = 450;
            [SortOrder(Moving_Displacement_Multi_Buff_White_sortIndex)]
            [DisplayName(Moving_Displacement_Multi_Buff_White_displayName)]
            public virtual float Moving_Displacement_Multi_Buff_White {
                get => Moving_Displacement_Multi_Buff_White_raw;
                set {
                    if (Moving_Displacement_Multi_Buff_White_raw == value) return;
                    Moving_Displacement_Multi_Buff_White_raw = value;
                    ChangedItems.Add(nameof(Moving_Displacement_Multi_Buff_White));
                    OnPropertyChanged(nameof(Moving_Displacement_Multi_Buff_White));
                }
            }

            [DisplayName("Offset")]
            public long Moving_Displacement_Multi_Buff_White_offset { get; private set; }

            protected float Defense_Buff_Orange_raw;
            public const string Defense_Buff_Orange_displayName = "Defense Buff: Orange";
            public const int Defense_Buff_Orange_sortIndex = 500;
            [SortOrder(Defense_Buff_Orange_sortIndex)]
            [DisplayName(Defense_Buff_Orange_displayName)]
            public virtual float Defense_Buff_Orange {
                get => Defense_Buff_Orange_raw;
                set {
                    if (Defense_Buff_Orange_raw == value) return;
                    Defense_Buff_Orange_raw = value;
                    ChangedItems.Add(nameof(Defense_Buff_Orange));
                    OnPropertyChanged(nameof(Defense_Buff_Orange));
                }
            }

            [DisplayName("Offset")]
            public long Defense_Buff_Orange_offset { get; private set; }

            protected float Defense_Buff_Orange_Plus_White_raw;
            public const string Defense_Buff_Orange_Plus_White_displayName = "Defense Buff: Orange + White";
            public const int Defense_Buff_Orange_Plus_White_sortIndex = 550;
            [SortOrder(Defense_Buff_Orange_Plus_White_sortIndex)]
            [DisplayName(Defense_Buff_Orange_Plus_White_displayName)]
            public virtual float Defense_Buff_Orange_Plus_White {
                get => Defense_Buff_Orange_Plus_White_raw;
                set {
                    if (Defense_Buff_Orange_Plus_White_raw == value) return;
                    Defense_Buff_Orange_Plus_White_raw = value;
                    ChangedItems.Add(nameof(Defense_Buff_Orange_Plus_White));
                    OnPropertyChanged(nameof(Defense_Buff_Orange_Plus_White));
                }
            }

            [DisplayName("Offset")]
            public long Defense_Buff_Orange_Plus_White_offset { get; private set; }

            public const int lastSortIndex = 600;

            public static ObservableMhwStructCollection<W10p_Params_5_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W10p_Params_5_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W10p_Params_5_ LoadData(BinaryReader reader, ulong i) {
                var data = new W10p_Params_5_();
                data.Index = i;
                data.Red_Extract_Duration_offset = reader.BaseStream.Position;
                data.Red_Extract_Duration_raw = reader.ReadSingle();
                data.White_Extract_Duration_offset = reader.BaseStream.Position;
                data.White_Extract_Duration_raw = reader.ReadSingle();
                data.Orange_Extract_Duration_offset = reader.BaseStream.Position;
                data.Orange_Extract_Duration_raw = reader.ReadSingle();
                data.Triple_Extract_Duration_offset = reader.BaseStream.Position;
                data.Triple_Extract_Duration_raw = reader.ReadSingle();
                data.Twinkling_When_Extraction_Time_Remaining_is_10s_offset = reader.BaseStream.Position;
                data.Twinkling_When_Extraction_Time_Remaining_is_10s_raw = reader.ReadSingle();
                data.Damage_Buff_Red_Plus_White_offset = reader.BaseStream.Position;
                data.Damage_Buff_Red_Plus_White_raw = reader.ReadSingle();
                data.Damage_Buff_All_Three_Extracts_offset = reader.BaseStream.Position;
                data.Damage_Buff_All_Three_Extracts_raw = reader.ReadSingle();
                data.Speed_Buff_White_offset = reader.BaseStream.Position;
                data.Speed_Buff_White_raw = reader.ReadSingle();
                data.Moving_Displacement_Multi_Buff_White_offset = reader.BaseStream.Position;
                data.Moving_Displacement_Multi_Buff_White_raw = reader.ReadSingle();
                data.Defense_Buff_Orange_offset = reader.BaseStream.Position;
                data.Defense_Buff_Orange_raw = reader.ReadSingle();
                data.Defense_Buff_Orange_Plus_White_offset = reader.BaseStream.Position;
                data.Defense_Buff_Orange_Plus_White_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Red_Extract_Duration_raw);
                writer.Write(White_Extract_Duration_raw);
                writer.Write(Orange_Extract_Duration_raw);
                writer.Write(Triple_Extract_Duration_raw);
                writer.Write(Twinkling_When_Extraction_Time_Remaining_is_10s_raw);
                writer.Write(Damage_Buff_Red_Plus_White_raw);
                writer.Write(Damage_Buff_All_Three_Extracts_raw);
                writer.Write(Speed_Buff_White_raw);
                writer.Write(Moving_Displacement_Multi_Buff_White_raw);
                writer.Write(Defense_Buff_Orange_raw);
                writer.Write(Defense_Buff_Orange_Plus_White_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Red Extract Duration", "Red_Extract_Duration", "Red_Extract_Duration_offset"),
                    new MultiStructItemCustomView(this, "White Extract Duration", "White_Extract_Duration", "White_Extract_Duration_offset"),
                    new MultiStructItemCustomView(this, "Orange Extract Duration", "Orange_Extract_Duration", "Orange_Extract_Duration_offset"),
                    new MultiStructItemCustomView(this, "Triple Extract Duration", "Triple_Extract_Duration", "Triple_Extract_Duration_offset"),
                    new MultiStructItemCustomView(this, "Twinkling When Extraction Time Remaining is 10s", "Twinkling_When_Extraction_Time_Remaining_is_10s", "Twinkling_When_Extraction_Time_Remaining_is_10s_offset"),
                    new MultiStructItemCustomView(this, "Damage Buff: Red + White", "Damage_Buff_Red_Plus_White", "Damage_Buff_Red_Plus_White_offset"),
                    new MultiStructItemCustomView(this, "Damage Buff: All Three Extracts", "Damage_Buff_All_Three_Extracts", "Damage_Buff_All_Three_Extracts_offset"),
                    new MultiStructItemCustomView(this, "Speed Buff: White", "Speed_Buff_White", "Speed_Buff_White_offset"),
                    new MultiStructItemCustomView(this, "Moving Displacement Multi Buff: White", "Moving_Displacement_Multi_Buff_White", "Moving_Displacement_Multi_Buff_White_offset"),
                    new MultiStructItemCustomView(this, "Defense Buff: Orange", "Defense_Buff_Orange", "Defense_Buff_Orange_offset"),
                    new MultiStructItemCustomView(this, "Defense Buff: Orange + White", "Defense_Buff_Orange_Plus_White", "Defense_Buff_Orange_Plus_White_offset"),
                };
            }
        }

        public partial class Action_Param_Relate_Vault_ : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 16;
            public const string GridName = "Action Param (Relate Vault)";

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

            public static ObservableMhwStructCollection<Action_Param_Relate_Vault_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Action_Param_Relate_Vault_>();
                const ulong count = 16UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Action_Param_Relate_Vault_ LoadData(BinaryReader reader, ulong i) {
                var data = new Action_Param_Relate_Vault_();
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

        public partial class W10p_Params_6_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W10p Params (6)";

            protected float Unk_98_raw;
            public const string Unk_98_displayName = "Unk 98";
            public const int Unk_98_sortIndex = 50;
            [SortOrder(Unk_98_sortIndex)]
            [DisplayName(Unk_98_displayName)]
            public virtual float Unk_98 {
                get => Unk_98_raw;
                set {
                    if (Unk_98_raw == value) return;
                    Unk_98_raw = value;
                    ChangedItems.Add(nameof(Unk_98));
                    OnPropertyChanged(nameof(Unk_98));
                }
            }

            [DisplayName("Offset")]
            public long Unk_98_offset { get; private set; }

            protected float Unk_99_raw;
            public const string Unk_99_displayName = "Unk 99";
            public const int Unk_99_sortIndex = 100;
            [SortOrder(Unk_99_sortIndex)]
            [DisplayName(Unk_99_displayName)]
            public virtual float Unk_99 {
                get => Unk_99_raw;
                set {
                    if (Unk_99_raw == value) return;
                    Unk_99_raw = value;
                    ChangedItems.Add(nameof(Unk_99));
                    OnPropertyChanged(nameof(Unk_99));
                }
            }

            [DisplayName("Offset")]
            public long Unk_99_offset { get; private set; }

            protected float Unk_100_raw;
            public const string Unk_100_displayName = "Unk 100";
            public const int Unk_100_sortIndex = 150;
            [SortOrder(Unk_100_sortIndex)]
            [DisplayName(Unk_100_displayName)]
            public virtual float Unk_100 {
                get => Unk_100_raw;
                set {
                    if (Unk_100_raw == value) return;
                    Unk_100_raw = value;
                    ChangedItems.Add(nameof(Unk_100));
                    OnPropertyChanged(nameof(Unk_100));
                }
            }

            [DisplayName("Offset")]
            public long Unk_100_offset { get; private set; }

            public const int lastSortIndex = 200;

            public static ObservableMhwStructCollection<W10p_Params_6_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W10p_Params_6_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W10p_Params_6_ LoadData(BinaryReader reader, ulong i) {
                var data = new W10p_Params_6_();
                data.Index = i;
                data.Unk_98_offset = reader.BaseStream.Position;
                data.Unk_98_raw = reader.ReadSingle();
                data.Unk_99_offset = reader.BaseStream.Position;
                data.Unk_99_raw = reader.ReadSingle();
                data.Unk_100_offset = reader.BaseStream.Position;
                data.Unk_100_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_98_raw);
                writer.Write(Unk_99_raw);
                writer.Write(Unk_100_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 98", "Unk_98", "Unk_98_offset"),
                    new MultiStructItemCustomView(this, "Unk 99", "Unk_99", "Unk_99_offset"),
                    new MultiStructItemCustomView(this, "Unk 100", "Unk_100", "Unk_100_offset"),
                };
            }
        }

        public partial class Action_Param_Relate_Vault_Dance_ : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Action Param (Relate Vault Dance)";

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

            public static ObservableMhwStructCollection<Action_Param_Relate_Vault_Dance_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Action_Param_Relate_Vault_Dance_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Action_Param_Relate_Vault_Dance_ LoadData(BinaryReader reader, ulong i) {
                var data = new Action_Param_Relate_Vault_Dance_();
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

        public partial class W10p_Params_7_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W10p Params (7)";

            protected uint Jumping_Advancing_Slashes_Repeat_Limit_Count_Can_vault_dance_N_times_per_jump__raw;
            public const string Jumping_Advancing_Slashes_Repeat_Limit_Count_Can_vault_dance_N_times_per_jump__displayName = "Jumping Advancing Slashes Repeat Limit Count (Can vault dance N times per jump.)";
            public const int Jumping_Advancing_Slashes_Repeat_Limit_Count_Can_vault_dance_N_times_per_jump__sortIndex = 50;
            [SortOrder(Jumping_Advancing_Slashes_Repeat_Limit_Count_Can_vault_dance_N_times_per_jump__sortIndex)]
            [DisplayName(Jumping_Advancing_Slashes_Repeat_Limit_Count_Can_vault_dance_N_times_per_jump__displayName)]
            public virtual uint Jumping_Advancing_Slashes_Repeat_Limit_Count_Can_vault_dance_N_times_per_jump_ {
                get => Jumping_Advancing_Slashes_Repeat_Limit_Count_Can_vault_dance_N_times_per_jump__raw;
                set {
                    if (Jumping_Advancing_Slashes_Repeat_Limit_Count_Can_vault_dance_N_times_per_jump__raw == value) return;
                    Jumping_Advancing_Slashes_Repeat_Limit_Count_Can_vault_dance_N_times_per_jump__raw = value;
                    ChangedItems.Add(nameof(Jumping_Advancing_Slashes_Repeat_Limit_Count_Can_vault_dance_N_times_per_jump_));
                    OnPropertyChanged(nameof(Jumping_Advancing_Slashes_Repeat_Limit_Count_Can_vault_dance_N_times_per_jump_));
                }
            }

            [DisplayName("Offset")]
            public long Jumping_Advancing_Slashes_Repeat_Limit_Count_Can_vault_dance_N_times_per_jump__offset { get; private set; }

            protected float Unk_102_raw;
            public const string Unk_102_displayName = "Unk 102";
            public const int Unk_102_sortIndex = 100;
            [SortOrder(Unk_102_sortIndex)]
            [DisplayName(Unk_102_displayName)]
            public virtual float Unk_102 {
                get => Unk_102_raw;
                set {
                    if (Unk_102_raw == value) return;
                    Unk_102_raw = value;
                    ChangedItems.Add(nameof(Unk_102));
                    OnPropertyChanged(nameof(Unk_102));
                }
            }

            [DisplayName("Offset")]
            public long Unk_102_offset { get; private set; }

            public const int lastSortIndex = 150;

            public static ObservableMhwStructCollection<W10p_Params_7_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W10p_Params_7_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W10p_Params_7_ LoadData(BinaryReader reader, ulong i) {
                var data = new W10p_Params_7_();
                data.Index = i;
                data.Jumping_Advancing_Slashes_Repeat_Limit_Count_Can_vault_dance_N_times_per_jump__offset = reader.BaseStream.Position;
                data.Jumping_Advancing_Slashes_Repeat_Limit_Count_Can_vault_dance_N_times_per_jump__raw = reader.ReadUInt32();
                data.Unk_102_offset = reader.BaseStream.Position;
                data.Unk_102_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Jumping_Advancing_Slashes_Repeat_Limit_Count_Can_vault_dance_N_times_per_jump__raw);
                writer.Write(Unk_102_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Jumping Advancing Slashes Repeat Limit Count (Can vault dance N times per jump.)", "Jumping_Advancing_Slashes_Repeat_Limit_Count_Can_vault_dance_N_times_per_jump_", "Jumping_Advancing_Slashes_Repeat_Limit_Count_Can_vault_dance_N_times_per_jump__offset"),
                    new MultiStructItemCustomView(this, "Unk 102", "Unk_102", "Unk_102_offset"),
                };
            }
        }

        public partial class Action_Param_Relate_Mid_air_Evade_ : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 9;
            public const string GridName = "Action Param (Relate Mid-air Evade)";

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

            public static ObservableMhwStructCollection<Action_Param_Relate_Mid_air_Evade_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Action_Param_Relate_Mid_air_Evade_>();
                const ulong count = 9UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Action_Param_Relate_Mid_air_Evade_ LoadData(BinaryReader reader, ulong i) {
                var data = new Action_Param_Relate_Mid_air_Evade_();
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

        public partial class W10p_Params_8_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W10p Params (8)";

            protected float Unk_103_raw;
            public const string Unk_103_displayName = "Unk 103";
            public const int Unk_103_sortIndex = 50;
            [SortOrder(Unk_103_sortIndex)]
            [DisplayName(Unk_103_displayName)]
            public virtual float Unk_103 {
                get => Unk_103_raw;
                set {
                    if (Unk_103_raw == value) return;
                    Unk_103_raw = value;
                    ChangedItems.Add(nameof(Unk_103));
                    OnPropertyChanged(nameof(Unk_103));
                }
            }

            [DisplayName("Offset")]
            public long Unk_103_offset { get; private set; }

            protected float Unk_104_raw;
            public const string Unk_104_displayName = "Unk 104";
            public const int Unk_104_sortIndex = 100;
            [SortOrder(Unk_104_sortIndex)]
            [DisplayName(Unk_104_displayName)]
            public virtual float Unk_104 {
                get => Unk_104_raw;
                set {
                    if (Unk_104_raw == value) return;
                    Unk_104_raw = value;
                    ChangedItems.Add(nameof(Unk_104));
                    OnPropertyChanged(nameof(Unk_104));
                }
            }

            [DisplayName("Offset")]
            public long Unk_104_offset { get; private set; }

            public const int lastSortIndex = 150;

            public static ObservableMhwStructCollection<W10p_Params_8_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W10p_Params_8_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W10p_Params_8_ LoadData(BinaryReader reader, ulong i) {
                var data = new W10p_Params_8_();
                data.Index = i;
                data.Unk_103_offset = reader.BaseStream.Position;
                data.Unk_103_raw = reader.ReadSingle();
                data.Unk_104_offset = reader.BaseStream.Position;
                data.Unk_104_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_103_raw);
                writer.Write(Unk_104_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 103", "Unk_103", "Unk_103_offset"),
                    new MultiStructItemCustomView(this, "Unk 104", "Unk_104", "Unk_104_offset"),
                };
            }
        }

        public partial class Action_Param_Relate_Jumping_Attacks_ : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 22;
            public const string GridName = "Action Param (Relate Jumping Attacks)";

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

            public static ObservableMhwStructCollection<Action_Param_Relate_Jumping_Attacks_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Action_Param_Relate_Jumping_Attacks_>();
                const ulong count = 22UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Action_Param_Relate_Jumping_Attacks_ LoadData(BinaryReader reader, ulong i) {
                var data = new Action_Param_Relate_Jumping_Attacks_();
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

        public partial class W10p_Params_9_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W10p Params (9)";

            protected float Unk_105_raw;
            public const string Unk_105_displayName = "Unk 105";
            public const int Unk_105_sortIndex = 50;
            [SortOrder(Unk_105_sortIndex)]
            [DisplayName(Unk_105_displayName)]
            public virtual float Unk_105 {
                get => Unk_105_raw;
                set {
                    if (Unk_105_raw == value) return;
                    Unk_105_raw = value;
                    ChangedItems.Add(nameof(Unk_105));
                    OnPropertyChanged(nameof(Unk_105));
                }
            }

            [DisplayName("Offset")]
            public long Unk_105_offset { get; private set; }

            protected float Unk_106_raw;
            public const string Unk_106_displayName = "Unk 106";
            public const int Unk_106_sortIndex = 100;
            [SortOrder(Unk_106_sortIndex)]
            [DisplayName(Unk_106_displayName)]
            public virtual float Unk_106 {
                get => Unk_106_raw;
                set {
                    if (Unk_106_raw == value) return;
                    Unk_106_raw = value;
                    ChangedItems.Add(nameof(Unk_106));
                    OnPropertyChanged(nameof(Unk_106));
                }
            }

            [DisplayName("Offset")]
            public long Unk_106_offset { get; private set; }

            protected float Unk_107_raw;
            public const string Unk_107_displayName = "Unk 107";
            public const int Unk_107_sortIndex = 150;
            [SortOrder(Unk_107_sortIndex)]
            [DisplayName(Unk_107_displayName)]
            public virtual float Unk_107 {
                get => Unk_107_raw;
                set {
                    if (Unk_107_raw == value) return;
                    Unk_107_raw = value;
                    ChangedItems.Add(nameof(Unk_107));
                    OnPropertyChanged(nameof(Unk_107));
                }
            }

            [DisplayName("Offset")]
            public long Unk_107_offset { get; private set; }

            protected float Unk_108_raw;
            public const string Unk_108_displayName = "Unk 108";
            public const int Unk_108_sortIndex = 200;
            [SortOrder(Unk_108_sortIndex)]
            [DisplayName(Unk_108_displayName)]
            public virtual float Unk_108 {
                get => Unk_108_raw;
                set {
                    if (Unk_108_raw == value) return;
                    Unk_108_raw = value;
                    ChangedItems.Add(nameof(Unk_108));
                    OnPropertyChanged(nameof(Unk_108));
                }
            }

            [DisplayName("Offset")]
            public long Unk_108_offset { get; private set; }

            public const int lastSortIndex = 250;

            public static ObservableMhwStructCollection<W10p_Params_9_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W10p_Params_9_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W10p_Params_9_ LoadData(BinaryReader reader, ulong i) {
                var data = new W10p_Params_9_();
                data.Index = i;
                data.Unk_105_offset = reader.BaseStream.Position;
                data.Unk_105_raw = reader.ReadSingle();
                data.Unk_106_offset = reader.BaseStream.Position;
                data.Unk_106_raw = reader.ReadSingle();
                data.Unk_107_offset = reader.BaseStream.Position;
                data.Unk_107_raw = reader.ReadSingle();
                data.Unk_108_offset = reader.BaseStream.Position;
                data.Unk_108_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_105_raw);
                writer.Write(Unk_106_raw);
                writer.Write(Unk_107_raw);
                writer.Write(Unk_108_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 105", "Unk_105", "Unk_105_offset"),
                    new MultiStructItemCustomView(this, "Unk 106", "Unk_106", "Unk_106_offset"),
                    new MultiStructItemCustomView(this, "Unk 107", "Unk_107", "Unk_107_offset"),
                    new MultiStructItemCustomView(this, "Unk 108", "Unk_108", "Unk_108_offset"),
                };
            }
        }

        public partial class Action_Param_Relate_Wall_Vault_Wall_Opposite_Vault_White_Extract_or_Not_ : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 4;
            public const string GridName = "Action Param (Relate Wall Vault, Wall Opposite Vault, White Extract or Not)";

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

            public static ObservableMhwStructCollection<Action_Param_Relate_Wall_Vault_Wall_Opposite_Vault_White_Extract_or_Not_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Action_Param_Relate_Wall_Vault_Wall_Opposite_Vault_White_Extract_or_Not_>();
                const ulong count = 4UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Action_Param_Relate_Wall_Vault_Wall_Opposite_Vault_White_Extract_or_Not_ LoadData(BinaryReader reader, ulong i) {
                var data = new Action_Param_Relate_Wall_Vault_Wall_Opposite_Vault_White_Extract_or_Not_();
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

        public partial class W10p_Params_10_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W10p Params (10)";

            protected float Unk_109_raw;
            public const string Unk_109_displayName = "Unk 109";
            public const int Unk_109_sortIndex = 50;
            [SortOrder(Unk_109_sortIndex)]
            [DisplayName(Unk_109_displayName)]
            public virtual float Unk_109 {
                get => Unk_109_raw;
                set {
                    if (Unk_109_raw == value) return;
                    Unk_109_raw = value;
                    ChangedItems.Add(nameof(Unk_109));
                    OnPropertyChanged(nameof(Unk_109));
                }
            }

            [DisplayName("Offset")]
            public long Unk_109_offset { get; private set; }

            protected float Unk_110_raw;
            public const string Unk_110_displayName = "Unk 110";
            public const int Unk_110_sortIndex = 100;
            [SortOrder(Unk_110_sortIndex)]
            [DisplayName(Unk_110_displayName)]
            public virtual float Unk_110 {
                get => Unk_110_raw;
                set {
                    if (Unk_110_raw == value) return;
                    Unk_110_raw = value;
                    ChangedItems.Add(nameof(Unk_110));
                    OnPropertyChanged(nameof(Unk_110));
                }
            }

            [DisplayName("Offset")]
            public long Unk_110_offset { get; private set; }

            protected float Sever_Boost_raw;
            public const string Sever_Boost_displayName = "Sever Boost";
            public const int Sever_Boost_sortIndex = 150;
            [SortOrder(Sever_Boost_sortIndex)]
            [DisplayName(Sever_Boost_displayName)]
            public virtual float Sever_Boost {
                get => Sever_Boost_raw;
                set {
                    if (Sever_Boost_raw == value) return;
                    Sever_Boost_raw = value;
                    ChangedItems.Add(nameof(Sever_Boost));
                    OnPropertyChanged(nameof(Sever_Boost));
                }
            }

            [DisplayName("Offset")]
            public long Sever_Boost_offset { get; private set; }

            protected float Blunt_Boost_raw;
            public const string Blunt_Boost_displayName = "Blunt Boost";
            public const int Blunt_Boost_sortIndex = 200;
            [SortOrder(Blunt_Boost_sortIndex)]
            [DisplayName(Blunt_Boost_displayName)]
            public virtual float Blunt_Boost {
                get => Blunt_Boost_raw;
                set {
                    if (Blunt_Boost_raw == value) return;
                    Blunt_Boost_raw = value;
                    ChangedItems.Add(nameof(Blunt_Boost));
                    OnPropertyChanged(nameof(Blunt_Boost));
                }
            }

            [DisplayName("Offset")]
            public long Blunt_Boost_offset { get; private set; }

            protected float Elemental_Boost_raw;
            public const string Elemental_Boost_displayName = "Elemental Boost";
            public const int Elemental_Boost_sortIndex = 250;
            [SortOrder(Elemental_Boost_sortIndex)]
            [DisplayName(Elemental_Boost_displayName)]
            public virtual float Elemental_Boost {
                get => Elemental_Boost_raw;
                set {
                    if (Elemental_Boost_raw == value) return;
                    Elemental_Boost_raw = value;
                    ChangedItems.Add(nameof(Elemental_Boost));
                    OnPropertyChanged(nameof(Elemental_Boost));
                }
            }

            [DisplayName("Offset")]
            public long Elemental_Boost_offset { get; private set; }

            protected float Speed_Boost_raw;
            public const string Speed_Boost_displayName = "Speed Boost";
            public const int Speed_Boost_sortIndex = 300;
            [SortOrder(Speed_Boost_sortIndex)]
            [DisplayName(Speed_Boost_displayName)]
            public virtual float Speed_Boost {
                get => Speed_Boost_raw;
                set {
                    if (Speed_Boost_raw == value) return;
                    Speed_Boost_raw = value;
                    ChangedItems.Add(nameof(Speed_Boost));
                    OnPropertyChanged(nameof(Speed_Boost));
                }
            }

            [DisplayName("Offset")]
            public long Speed_Boost_offset { get; private set; }

            protected float Kinsect_Stamina_Extract_Boost_raw;
            public const string Kinsect_Stamina_Extract_Boost_displayName = "Kinsect Stamina Extract Boost";
            public const int Kinsect_Stamina_Extract_Boost_sortIndex = 350;
            [SortOrder(Kinsect_Stamina_Extract_Boost_sortIndex)]
            [DisplayName(Kinsect_Stamina_Extract_Boost_displayName)]
            public virtual float Kinsect_Stamina_Extract_Boost {
                get => Kinsect_Stamina_Extract_Boost_raw;
                set {
                    if (Kinsect_Stamina_Extract_Boost_raw == value) return;
                    Kinsect_Stamina_Extract_Boost_raw = value;
                    ChangedItems.Add(nameof(Kinsect_Stamina_Extract_Boost));
                    OnPropertyChanged(nameof(Kinsect_Stamina_Extract_Boost));
                }
            }

            [DisplayName("Offset")]
            public long Kinsect_Stamina_Extract_Boost_offset { get; private set; }

            protected float Kinsect_Stamina_On_Recall_Boost_raw;
            public const string Kinsect_Stamina_On_Recall_Boost_displayName = "Kinsect Stamina On Recall Boost";
            public const int Kinsect_Stamina_On_Recall_Boost_sortIndex = 400;
            [SortOrder(Kinsect_Stamina_On_Recall_Boost_sortIndex)]
            [DisplayName(Kinsect_Stamina_On_Recall_Boost_displayName)]
            public virtual float Kinsect_Stamina_On_Recall_Boost {
                get => Kinsect_Stamina_On_Recall_Boost_raw;
                set {
                    if (Kinsect_Stamina_On_Recall_Boost_raw == value) return;
                    Kinsect_Stamina_On_Recall_Boost_raw = value;
                    ChangedItems.Add(nameof(Kinsect_Stamina_On_Recall_Boost));
                    OnPropertyChanged(nameof(Kinsect_Stamina_On_Recall_Boost));
                }
            }

            [DisplayName("Offset")]
            public long Kinsect_Stamina_On_Recall_Boost_offset { get; private set; }

            protected float Kinsect_Stamina_Drain_Boost_raw;
            public const string Kinsect_Stamina_Drain_Boost_displayName = "Kinsect Stamina Drain Boost";
            public const int Kinsect_Stamina_Drain_Boost_sortIndex = 450;
            [SortOrder(Kinsect_Stamina_Drain_Boost_sortIndex)]
            [DisplayName(Kinsect_Stamina_Drain_Boost_displayName)]
            public virtual float Kinsect_Stamina_Drain_Boost {
                get => Kinsect_Stamina_Drain_Boost_raw;
                set {
                    if (Kinsect_Stamina_Drain_Boost_raw == value) return;
                    Kinsect_Stamina_Drain_Boost_raw = value;
                    ChangedItems.Add(nameof(Kinsect_Stamina_Drain_Boost));
                    OnPropertyChanged(nameof(Kinsect_Stamina_Drain_Boost));
                }
            }

            [DisplayName("Offset")]
            public long Kinsect_Stamina_Drain_Boost_offset { get; private set; }

            protected float Kinsect_Healing_Extract_Boost_raw;
            public const string Kinsect_Healing_Extract_Boost_displayName = "Kinsect Healing Extract Boost";
            public const int Kinsect_Healing_Extract_Boost_sortIndex = 500;
            [SortOrder(Kinsect_Healing_Extract_Boost_sortIndex)]
            [DisplayName(Kinsect_Healing_Extract_Boost_displayName)]
            public virtual float Kinsect_Healing_Extract_Boost {
                get => Kinsect_Healing_Extract_Boost_raw;
                set {
                    if (Kinsect_Healing_Extract_Boost_raw == value) return;
                    Kinsect_Healing_Extract_Boost_raw = value;
                    ChangedItems.Add(nameof(Kinsect_Healing_Extract_Boost));
                    OnPropertyChanged(nameof(Kinsect_Healing_Extract_Boost));
                }
            }

            [DisplayName("Offset")]
            public long Kinsect_Healing_Extract_Boost_offset { get; private set; }

            protected float Unk_119_raw;
            public const string Unk_119_displayName = "Unk 119";
            public const int Unk_119_sortIndex = 550;
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
            public const int Unk_120_sortIndex = 600;
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
            public const int Unk_121_sortIndex = 650;
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
            public const int Unk_122_sortIndex = 700;
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

            protected float Unk_123_raw;
            public const string Unk_123_displayName = "Unk 123";
            public const int Unk_123_sortIndex = 750;
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
            public const int Unk_124_sortIndex = 800;
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
            public const int Unk_125_sortIndex = 850;
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

            protected float Kinsect_Max_Flight_Range_raw;
            public const string Kinsect_Max_Flight_Range_displayName = "Kinsect Max Flight Range";
            public const int Kinsect_Max_Flight_Range_sortIndex = 900;
            [SortOrder(Kinsect_Max_Flight_Range_sortIndex)]
            [DisplayName(Kinsect_Max_Flight_Range_displayName)]
            public virtual float Kinsect_Max_Flight_Range {
                get => Kinsect_Max_Flight_Range_raw;
                set {
                    if (Kinsect_Max_Flight_Range_raw == value) return;
                    Kinsect_Max_Flight_Range_raw = value;
                    ChangedItems.Add(nameof(Kinsect_Max_Flight_Range));
                    OnPropertyChanged(nameof(Kinsect_Max_Flight_Range));
                }
            }

            [DisplayName("Offset")]
            public long Kinsect_Max_Flight_Range_offset { get; private set; }

            protected float Unk_127_raw;
            public const string Unk_127_displayName = "Unk 127";
            public const int Unk_127_sortIndex = 950;
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
            public const int Unk_128_sortIndex = 1000;
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
            public const int Unk_129_sortIndex = 1050;
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
            public const int Unk_130_sortIndex = 1100;
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
            public const int Unk_131_sortIndex = 1150;
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

            protected float Unk_132_raw;
            public const string Unk_132_displayName = "Unk 132";
            public const int Unk_132_sortIndex = 1200;
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

            protected float Unk_133_raw;
            public const string Unk_133_displayName = "Unk 133";
            public const int Unk_133_sortIndex = 1250;
            [SortOrder(Unk_133_sortIndex)]
            [DisplayName(Unk_133_displayName)]
            public virtual float Unk_133 {
                get => Unk_133_raw;
                set {
                    if (Unk_133_raw == value) return;
                    Unk_133_raw = value;
                    ChangedItems.Add(nameof(Unk_133));
                    OnPropertyChanged(nameof(Unk_133));
                }
            }

            [DisplayName("Offset")]
            public long Unk_133_offset { get; private set; }

            protected float Unk_134_raw;
            public const string Unk_134_displayName = "Unk 134";
            public const int Unk_134_sortIndex = 1300;
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

            protected float Unk_135_raw;
            public const string Unk_135_displayName = "Unk 135";
            public const int Unk_135_sortIndex = 1350;
            [SortOrder(Unk_135_sortIndex)]
            [DisplayName(Unk_135_displayName)]
            public virtual float Unk_135 {
                get => Unk_135_raw;
                set {
                    if (Unk_135_raw == value) return;
                    Unk_135_raw = value;
                    ChangedItems.Add(nameof(Unk_135));
                    OnPropertyChanged(nameof(Unk_135));
                }
            }

            [DisplayName("Offset")]
            public long Unk_135_offset { get; private set; }

            protected float Unk_136_raw;
            public const string Unk_136_displayName = "Unk 136";
            public const int Unk_136_sortIndex = 1400;
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

            protected float Unk_137_raw;
            public const string Unk_137_displayName = "Unk 137";
            public const int Unk_137_sortIndex = 1450;
            [SortOrder(Unk_137_sortIndex)]
            [DisplayName(Unk_137_displayName)]
            public virtual float Unk_137 {
                get => Unk_137_raw;
                set {
                    if (Unk_137_raw == value) return;
                    Unk_137_raw = value;
                    ChangedItems.Add(nameof(Unk_137));
                    OnPropertyChanged(nameof(Unk_137));
                }
            }

            [DisplayName("Offset")]
            public long Unk_137_offset { get; private set; }

            protected float Unk_138_raw;
            public const string Unk_138_displayName = "Unk 138";
            public const int Unk_138_sortIndex = 1500;
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

            protected float Kinsect_Stamina_Drain_per_Second_raw;
            public const string Kinsect_Stamina_Drain_per_Second_displayName = "Kinsect Stamina Drain per Second";
            public const int Kinsect_Stamina_Drain_per_Second_sortIndex = 1550;
            [SortOrder(Kinsect_Stamina_Drain_per_Second_sortIndex)]
            [DisplayName(Kinsect_Stamina_Drain_per_Second_displayName)]
            public virtual float Kinsect_Stamina_Drain_per_Second {
                get => Kinsect_Stamina_Drain_per_Second_raw;
                set {
                    if (Kinsect_Stamina_Drain_per_Second_raw == value) return;
                    Kinsect_Stamina_Drain_per_Second_raw = value;
                    ChangedItems.Add(nameof(Kinsect_Stamina_Drain_per_Second));
                    OnPropertyChanged(nameof(Kinsect_Stamina_Drain_per_Second));
                }
            }

            [DisplayName("Offset")]
            public long Kinsect_Stamina_Drain_per_Second_offset { get; private set; }

            protected float Kinsect_Max_Stamina_raw;
            public const string Kinsect_Max_Stamina_displayName = "Kinsect Max Stamina";
            public const int Kinsect_Max_Stamina_sortIndex = 1600;
            [SortOrder(Kinsect_Max_Stamina_sortIndex)]
            [DisplayName(Kinsect_Max_Stamina_displayName)]
            public virtual float Kinsect_Max_Stamina {
                get => Kinsect_Max_Stamina_raw;
                set {
                    if (Kinsect_Max_Stamina_raw == value) return;
                    Kinsect_Max_Stamina_raw = value;
                    ChangedItems.Add(nameof(Kinsect_Max_Stamina));
                    OnPropertyChanged(nameof(Kinsect_Max_Stamina));
                }
            }

            [DisplayName("Offset")]
            public long Kinsect_Max_Stamina_offset { get; private set; }

            protected float Reaction_Time_on_Kinsect_Recall_raw;
            public const string Reaction_Time_on_Kinsect_Recall_displayName = "Reaction Time on Kinsect Recall";
            public const int Reaction_Time_on_Kinsect_Recall_sortIndex = 1650;
            [SortOrder(Reaction_Time_on_Kinsect_Recall_sortIndex)]
            [DisplayName(Reaction_Time_on_Kinsect_Recall_displayName)]
            public virtual float Reaction_Time_on_Kinsect_Recall {
                get => Reaction_Time_on_Kinsect_Recall_raw;
                set {
                    if (Reaction_Time_on_Kinsect_Recall_raw == value) return;
                    Reaction_Time_on_Kinsect_Recall_raw = value;
                    ChangedItems.Add(nameof(Reaction_Time_on_Kinsect_Recall));
                    OnPropertyChanged(nameof(Reaction_Time_on_Kinsect_Recall));
                }
            }

            [DisplayName("Offset")]
            public long Reaction_Time_on_Kinsect_Recall_offset { get; private set; }

            protected float Kinsect_Stamina_on_Recall_raw;
            public const string Kinsect_Stamina_on_Recall_displayName = "Kinsect Stamina on Recall";
            public const int Kinsect_Stamina_on_Recall_sortIndex = 1700;
            [SortOrder(Kinsect_Stamina_on_Recall_sortIndex)]
            [DisplayName(Kinsect_Stamina_on_Recall_displayName)]
            public virtual float Kinsect_Stamina_on_Recall {
                get => Kinsect_Stamina_on_Recall_raw;
                set {
                    if (Kinsect_Stamina_on_Recall_raw == value) return;
                    Kinsect_Stamina_on_Recall_raw = value;
                    ChangedItems.Add(nameof(Kinsect_Stamina_on_Recall));
                    OnPropertyChanged(nameof(Kinsect_Stamina_on_Recall));
                }
            }

            [DisplayName("Offset")]
            public long Kinsect_Stamina_on_Recall_offset { get; private set; }

            protected float Kinsect_Penetration_Speed_During_Descending_Thrust_raw;
            public const string Kinsect_Penetration_Speed_During_Descending_Thrust_displayName = "Kinsect Penetration Speed During Descending Thrust";
            public const int Kinsect_Penetration_Speed_During_Descending_Thrust_sortIndex = 1750;
            [SortOrder(Kinsect_Penetration_Speed_During_Descending_Thrust_sortIndex)]
            [DisplayName(Kinsect_Penetration_Speed_During_Descending_Thrust_displayName)]
            public virtual float Kinsect_Penetration_Speed_During_Descending_Thrust {
                get => Kinsect_Penetration_Speed_During_Descending_Thrust_raw;
                set {
                    if (Kinsect_Penetration_Speed_During_Descending_Thrust_raw == value) return;
                    Kinsect_Penetration_Speed_During_Descending_Thrust_raw = value;
                    ChangedItems.Add(nameof(Kinsect_Penetration_Speed_During_Descending_Thrust));
                    OnPropertyChanged(nameof(Kinsect_Penetration_Speed_During_Descending_Thrust));
                }
            }

            [DisplayName("Offset")]
            public long Kinsect_Penetration_Speed_During_Descending_Thrust_offset { get; private set; }

            protected float Unk_144_raw;
            public const string Unk_144_displayName = "Unk 144";
            public const int Unk_144_sortIndex = 1800;
            [SortOrder(Unk_144_sortIndex)]
            [DisplayName(Unk_144_displayName)]
            public virtual float Unk_144 {
                get => Unk_144_raw;
                set {
                    if (Unk_144_raw == value) return;
                    Unk_144_raw = value;
                    ChangedItems.Add(nameof(Unk_144));
                    OnPropertyChanged(nameof(Unk_144));
                }
            }

            [DisplayName("Offset")]
            public long Unk_144_offset { get; private set; }

            protected float Kinsect_Dust_Interval_Blast_raw;
            public const string Kinsect_Dust_Interval_Blast_displayName = "Kinsect Dust Interval: Blast";
            public const int Kinsect_Dust_Interval_Blast_sortIndex = 1850;
            [SortOrder(Kinsect_Dust_Interval_Blast_sortIndex)]
            [DisplayName(Kinsect_Dust_Interval_Blast_displayName)]
            public virtual float Kinsect_Dust_Interval_Blast {
                get => Kinsect_Dust_Interval_Blast_raw;
                set {
                    if (Kinsect_Dust_Interval_Blast_raw == value) return;
                    Kinsect_Dust_Interval_Blast_raw = value;
                    ChangedItems.Add(nameof(Kinsect_Dust_Interval_Blast));
                    OnPropertyChanged(nameof(Kinsect_Dust_Interval_Blast));
                }
            }

            [DisplayName("Offset")]
            public long Kinsect_Dust_Interval_Blast_offset { get; private set; }

            protected float Kinsect_Dust_Interval_Heal_raw;
            public const string Kinsect_Dust_Interval_Heal_displayName = "Kinsect Dust Interval: Heal";
            public const int Kinsect_Dust_Interval_Heal_sortIndex = 1900;
            [SortOrder(Kinsect_Dust_Interval_Heal_sortIndex)]
            [DisplayName(Kinsect_Dust_Interval_Heal_displayName)]
            public virtual float Kinsect_Dust_Interval_Heal {
                get => Kinsect_Dust_Interval_Heal_raw;
                set {
                    if (Kinsect_Dust_Interval_Heal_raw == value) return;
                    Kinsect_Dust_Interval_Heal_raw = value;
                    ChangedItems.Add(nameof(Kinsect_Dust_Interval_Heal));
                    OnPropertyChanged(nameof(Kinsect_Dust_Interval_Heal));
                }
            }

            [DisplayName("Offset")]
            public long Kinsect_Dust_Interval_Heal_offset { get; private set; }

            protected float Kinsect_Dust_Interval_Paralysis_raw;
            public const string Kinsect_Dust_Interval_Paralysis_displayName = "Kinsect Dust Interval: Paralysis";
            public const int Kinsect_Dust_Interval_Paralysis_sortIndex = 1950;
            [SortOrder(Kinsect_Dust_Interval_Paralysis_sortIndex)]
            [DisplayName(Kinsect_Dust_Interval_Paralysis_displayName)]
            public virtual float Kinsect_Dust_Interval_Paralysis {
                get => Kinsect_Dust_Interval_Paralysis_raw;
                set {
                    if (Kinsect_Dust_Interval_Paralysis_raw == value) return;
                    Kinsect_Dust_Interval_Paralysis_raw = value;
                    ChangedItems.Add(nameof(Kinsect_Dust_Interval_Paralysis));
                    OnPropertyChanged(nameof(Kinsect_Dust_Interval_Paralysis));
                }
            }

            [DisplayName("Offset")]
            public long Kinsect_Dust_Interval_Paralysis_offset { get; private set; }

            protected float Kinsect_Dust_Interval_Poison_raw;
            public const string Kinsect_Dust_Interval_Poison_displayName = "Kinsect Dust Interval: Poison";
            public const int Kinsect_Dust_Interval_Poison_sortIndex = 2000;
            [SortOrder(Kinsect_Dust_Interval_Poison_sortIndex)]
            [DisplayName(Kinsect_Dust_Interval_Poison_displayName)]
            public virtual float Kinsect_Dust_Interval_Poison {
                get => Kinsect_Dust_Interval_Poison_raw;
                set {
                    if (Kinsect_Dust_Interval_Poison_raw == value) return;
                    Kinsect_Dust_Interval_Poison_raw = value;
                    ChangedItems.Add(nameof(Kinsect_Dust_Interval_Poison));
                    OnPropertyChanged(nameof(Kinsect_Dust_Interval_Poison));
                }
            }

            [DisplayName("Offset")]
            public long Kinsect_Dust_Interval_Poison_offset { get; private set; }

            protected float Unk_149_raw;
            public const string Unk_149_displayName = "Unk 149";
            public const int Unk_149_sortIndex = 2050;
            [SortOrder(Unk_149_sortIndex)]
            [DisplayName(Unk_149_displayName)]
            public virtual float Unk_149 {
                get => Unk_149_raw;
                set {
                    if (Unk_149_raw == value) return;
                    Unk_149_raw = value;
                    ChangedItems.Add(nameof(Unk_149));
                    OnPropertyChanged(nameof(Unk_149));
                }
            }

            [DisplayName("Offset")]
            public long Unk_149_offset { get; private set; }

            protected float Unk_150_raw;
            public const string Unk_150_displayName = "Unk 150";
            public const int Unk_150_sortIndex = 2100;
            [SortOrder(Unk_150_sortIndex)]
            [DisplayName(Unk_150_displayName)]
            public virtual float Unk_150 {
                get => Unk_150_raw;
                set {
                    if (Unk_150_raw == value) return;
                    Unk_150_raw = value;
                    ChangedItems.Add(nameof(Unk_150));
                    OnPropertyChanged(nameof(Unk_150));
                }
            }

            [DisplayName("Offset")]
            public long Unk_150_offset { get; private set; }

            public const int lastSortIndex = 2150;

            public static ObservableMhwStructCollection<W10p_Params_10_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W10p_Params_10_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W10p_Params_10_ LoadData(BinaryReader reader, ulong i) {
                var data = new W10p_Params_10_();
                data.Index = i;
                data.Unk_109_offset = reader.BaseStream.Position;
                data.Unk_109_raw = reader.ReadSingle();
                data.Unk_110_offset = reader.BaseStream.Position;
                data.Unk_110_raw = reader.ReadSingle();
                data.Sever_Boost_offset = reader.BaseStream.Position;
                data.Sever_Boost_raw = reader.ReadSingle();
                data.Blunt_Boost_offset = reader.BaseStream.Position;
                data.Blunt_Boost_raw = reader.ReadSingle();
                data.Elemental_Boost_offset = reader.BaseStream.Position;
                data.Elemental_Boost_raw = reader.ReadSingle();
                data.Speed_Boost_offset = reader.BaseStream.Position;
                data.Speed_Boost_raw = reader.ReadSingle();
                data.Kinsect_Stamina_Extract_Boost_offset = reader.BaseStream.Position;
                data.Kinsect_Stamina_Extract_Boost_raw = reader.ReadSingle();
                data.Kinsect_Stamina_On_Recall_Boost_offset = reader.BaseStream.Position;
                data.Kinsect_Stamina_On_Recall_Boost_raw = reader.ReadSingle();
                data.Kinsect_Stamina_Drain_Boost_offset = reader.BaseStream.Position;
                data.Kinsect_Stamina_Drain_Boost_raw = reader.ReadSingle();
                data.Kinsect_Healing_Extract_Boost_offset = reader.BaseStream.Position;
                data.Kinsect_Healing_Extract_Boost_raw = reader.ReadSingle();
                data.Unk_119_offset = reader.BaseStream.Position;
                data.Unk_119_raw = reader.ReadSingle();
                data.Unk_120_offset = reader.BaseStream.Position;
                data.Unk_120_raw = reader.ReadSingle();
                data.Unk_121_offset = reader.BaseStream.Position;
                data.Unk_121_raw = reader.ReadSingle();
                data.Unk_122_offset = reader.BaseStream.Position;
                data.Unk_122_raw = reader.ReadSingle();
                data.Unk_123_offset = reader.BaseStream.Position;
                data.Unk_123_raw = reader.ReadSingle();
                data.Unk_124_offset = reader.BaseStream.Position;
                data.Unk_124_raw = reader.ReadSingle();
                data.Unk_125_offset = reader.BaseStream.Position;
                data.Unk_125_raw = reader.ReadSingle();
                data.Kinsect_Max_Flight_Range_offset = reader.BaseStream.Position;
                data.Kinsect_Max_Flight_Range_raw = reader.ReadSingle();
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
                data.Unk_132_offset = reader.BaseStream.Position;
                data.Unk_132_raw = reader.ReadSingle();
                data.Unk_133_offset = reader.BaseStream.Position;
                data.Unk_133_raw = reader.ReadSingle();
                data.Unk_134_offset = reader.BaseStream.Position;
                data.Unk_134_raw = reader.ReadSingle();
                data.Unk_135_offset = reader.BaseStream.Position;
                data.Unk_135_raw = reader.ReadSingle();
                data.Unk_136_offset = reader.BaseStream.Position;
                data.Unk_136_raw = reader.ReadSingle();
                data.Unk_137_offset = reader.BaseStream.Position;
                data.Unk_137_raw = reader.ReadSingle();
                data.Unk_138_offset = reader.BaseStream.Position;
                data.Unk_138_raw = reader.ReadSingle();
                data.Kinsect_Stamina_Drain_per_Second_offset = reader.BaseStream.Position;
                data.Kinsect_Stamina_Drain_per_Second_raw = reader.ReadSingle();
                data.Kinsect_Max_Stamina_offset = reader.BaseStream.Position;
                data.Kinsect_Max_Stamina_raw = reader.ReadSingle();
                data.Reaction_Time_on_Kinsect_Recall_offset = reader.BaseStream.Position;
                data.Reaction_Time_on_Kinsect_Recall_raw = reader.ReadSingle();
                data.Kinsect_Stamina_on_Recall_offset = reader.BaseStream.Position;
                data.Kinsect_Stamina_on_Recall_raw = reader.ReadSingle();
                data.Kinsect_Penetration_Speed_During_Descending_Thrust_offset = reader.BaseStream.Position;
                data.Kinsect_Penetration_Speed_During_Descending_Thrust_raw = reader.ReadSingle();
                data.Unk_144_offset = reader.BaseStream.Position;
                data.Unk_144_raw = reader.ReadSingle();
                data.Kinsect_Dust_Interval_Blast_offset = reader.BaseStream.Position;
                data.Kinsect_Dust_Interval_Blast_raw = reader.ReadSingle();
                data.Kinsect_Dust_Interval_Heal_offset = reader.BaseStream.Position;
                data.Kinsect_Dust_Interval_Heal_raw = reader.ReadSingle();
                data.Kinsect_Dust_Interval_Paralysis_offset = reader.BaseStream.Position;
                data.Kinsect_Dust_Interval_Paralysis_raw = reader.ReadSingle();
                data.Kinsect_Dust_Interval_Poison_offset = reader.BaseStream.Position;
                data.Kinsect_Dust_Interval_Poison_raw = reader.ReadSingle();
                data.Unk_149_offset = reader.BaseStream.Position;
                data.Unk_149_raw = reader.ReadSingle();
                data.Unk_150_offset = reader.BaseStream.Position;
                data.Unk_150_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_109_raw);
                writer.Write(Unk_110_raw);
                writer.Write(Sever_Boost_raw);
                writer.Write(Blunt_Boost_raw);
                writer.Write(Elemental_Boost_raw);
                writer.Write(Speed_Boost_raw);
                writer.Write(Kinsect_Stamina_Extract_Boost_raw);
                writer.Write(Kinsect_Stamina_On_Recall_Boost_raw);
                writer.Write(Kinsect_Stamina_Drain_Boost_raw);
                writer.Write(Kinsect_Healing_Extract_Boost_raw);
                writer.Write(Unk_119_raw);
                writer.Write(Unk_120_raw);
                writer.Write(Unk_121_raw);
                writer.Write(Unk_122_raw);
                writer.Write(Unk_123_raw);
                writer.Write(Unk_124_raw);
                writer.Write(Unk_125_raw);
                writer.Write(Kinsect_Max_Flight_Range_raw);
                writer.Write(Unk_127_raw);
                writer.Write(Unk_128_raw);
                writer.Write(Unk_129_raw);
                writer.Write(Unk_130_raw);
                writer.Write(Unk_131_raw);
                writer.Write(Unk_132_raw);
                writer.Write(Unk_133_raw);
                writer.Write(Unk_134_raw);
                writer.Write(Unk_135_raw);
                writer.Write(Unk_136_raw);
                writer.Write(Unk_137_raw);
                writer.Write(Unk_138_raw);
                writer.Write(Kinsect_Stamina_Drain_per_Second_raw);
                writer.Write(Kinsect_Max_Stamina_raw);
                writer.Write(Reaction_Time_on_Kinsect_Recall_raw);
                writer.Write(Kinsect_Stamina_on_Recall_raw);
                writer.Write(Kinsect_Penetration_Speed_During_Descending_Thrust_raw);
                writer.Write(Unk_144_raw);
                writer.Write(Kinsect_Dust_Interval_Blast_raw);
                writer.Write(Kinsect_Dust_Interval_Heal_raw);
                writer.Write(Kinsect_Dust_Interval_Paralysis_raw);
                writer.Write(Kinsect_Dust_Interval_Poison_raw);
                writer.Write(Unk_149_raw);
                writer.Write(Unk_150_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 109", "Unk_109", "Unk_109_offset"),
                    new MultiStructItemCustomView(this, "Unk 110", "Unk_110", "Unk_110_offset"),
                    new MultiStructItemCustomView(this, "Sever Boost", "Sever_Boost", "Sever_Boost_offset"),
                    new MultiStructItemCustomView(this, "Blunt Boost", "Blunt_Boost", "Blunt_Boost_offset"),
                    new MultiStructItemCustomView(this, "Elemental Boost", "Elemental_Boost", "Elemental_Boost_offset"),
                    new MultiStructItemCustomView(this, "Speed Boost", "Speed_Boost", "Speed_Boost_offset"),
                    new MultiStructItemCustomView(this, "Kinsect Stamina Extract Boost", "Kinsect_Stamina_Extract_Boost", "Kinsect_Stamina_Extract_Boost_offset"),
                    new MultiStructItemCustomView(this, "Kinsect Stamina On Recall Boost", "Kinsect_Stamina_On_Recall_Boost", "Kinsect_Stamina_On_Recall_Boost_offset"),
                    new MultiStructItemCustomView(this, "Kinsect Stamina Drain Boost", "Kinsect_Stamina_Drain_Boost", "Kinsect_Stamina_Drain_Boost_offset"),
                    new MultiStructItemCustomView(this, "Kinsect Healing Extract Boost", "Kinsect_Healing_Extract_Boost", "Kinsect_Healing_Extract_Boost_offset"),
                    new MultiStructItemCustomView(this, "Unk 119", "Unk_119", "Unk_119_offset"),
                    new MultiStructItemCustomView(this, "Unk 120", "Unk_120", "Unk_120_offset"),
                    new MultiStructItemCustomView(this, "Unk 121", "Unk_121", "Unk_121_offset"),
                    new MultiStructItemCustomView(this, "Unk 122", "Unk_122", "Unk_122_offset"),
                    new MultiStructItemCustomView(this, "Unk 123", "Unk_123", "Unk_123_offset"),
                    new MultiStructItemCustomView(this, "Unk 124", "Unk_124", "Unk_124_offset"),
                    new MultiStructItemCustomView(this, "Unk 125", "Unk_125", "Unk_125_offset"),
                    new MultiStructItemCustomView(this, "Kinsect Max Flight Range", "Kinsect_Max_Flight_Range", "Kinsect_Max_Flight_Range_offset"),
                    new MultiStructItemCustomView(this, "Unk 127", "Unk_127", "Unk_127_offset"),
                    new MultiStructItemCustomView(this, "Unk 128", "Unk_128", "Unk_128_offset"),
                    new MultiStructItemCustomView(this, "Unk 129", "Unk_129", "Unk_129_offset"),
                    new MultiStructItemCustomView(this, "Unk 130", "Unk_130", "Unk_130_offset"),
                    new MultiStructItemCustomView(this, "Unk 131", "Unk_131", "Unk_131_offset"),
                    new MultiStructItemCustomView(this, "Unk 132", "Unk_132", "Unk_132_offset"),
                    new MultiStructItemCustomView(this, "Unk 133", "Unk_133", "Unk_133_offset"),
                    new MultiStructItemCustomView(this, "Unk 134", "Unk_134", "Unk_134_offset"),
                    new MultiStructItemCustomView(this, "Unk 135", "Unk_135", "Unk_135_offset"),
                    new MultiStructItemCustomView(this, "Unk 136", "Unk_136", "Unk_136_offset"),
                    new MultiStructItemCustomView(this, "Unk 137", "Unk_137", "Unk_137_offset"),
                    new MultiStructItemCustomView(this, "Unk 138", "Unk_138", "Unk_138_offset"),
                    new MultiStructItemCustomView(this, "Kinsect Stamina Drain per Second", "Kinsect_Stamina_Drain_per_Second", "Kinsect_Stamina_Drain_per_Second_offset"),
                    new MultiStructItemCustomView(this, "Kinsect Max Stamina", "Kinsect_Max_Stamina", "Kinsect_Max_Stamina_offset"),
                    new MultiStructItemCustomView(this, "Reaction Time on Kinsect Recall", "Reaction_Time_on_Kinsect_Recall", "Reaction_Time_on_Kinsect_Recall_offset"),
                    new MultiStructItemCustomView(this, "Kinsect Stamina on Recall", "Kinsect_Stamina_on_Recall", "Kinsect_Stamina_on_Recall_offset"),
                    new MultiStructItemCustomView(this, "Kinsect Penetration Speed During Descending Thrust", "Kinsect_Penetration_Speed_During_Descending_Thrust", "Kinsect_Penetration_Speed_During_Descending_Thrust_offset"),
                    new MultiStructItemCustomView(this, "Unk 144", "Unk_144", "Unk_144_offset"),
                    new MultiStructItemCustomView(this, "Kinsect Dust Interval: Blast", "Kinsect_Dust_Interval_Blast", "Kinsect_Dust_Interval_Blast_offset"),
                    new MultiStructItemCustomView(this, "Kinsect Dust Interval: Heal", "Kinsect_Dust_Interval_Heal", "Kinsect_Dust_Interval_Heal_offset"),
                    new MultiStructItemCustomView(this, "Kinsect Dust Interval: Paralysis", "Kinsect_Dust_Interval_Paralysis", "Kinsect_Dust_Interval_Paralysis_offset"),
                    new MultiStructItemCustomView(this, "Kinsect Dust Interval: Poison", "Kinsect_Dust_Interval_Poison", "Kinsect_Dust_Interval_Poison_offset"),
                    new MultiStructItemCustomView(this, "Unk 149", "Unk_149", "Unk_149_offset"),
                    new MultiStructItemCustomView(this, "Unk 150", "Unk_150", "Unk_150_offset"),
                };
            }
        }

        public partial class Kinsect_Stats : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 9;
            public const string GridName = "Kinsect Stats";

            protected float Level_1_raw;
            public const string Level_1_displayName = "Level 1";
            public const int Level_1_sortIndex = 50;
            [SortOrder(Level_1_sortIndex)]
            [DisplayName(Level_1_displayName)]
            public virtual float Level_1 {
                get => Level_1_raw;
                set {
                    if (Level_1_raw == value) return;
                    Level_1_raw = value;
                    ChangedItems.Add(nameof(Level_1));
                    OnPropertyChanged(nameof(Level_1));
                }
            }

            protected float Level_2_raw;
            public const string Level_2_displayName = "Level 2";
            public const int Level_2_sortIndex = 100;
            [SortOrder(Level_2_sortIndex)]
            [DisplayName(Level_2_displayName)]
            public virtual float Level_2 {
                get => Level_2_raw;
                set {
                    if (Level_2_raw == value) return;
                    Level_2_raw = value;
                    ChangedItems.Add(nameof(Level_2));
                    OnPropertyChanged(nameof(Level_2));
                }
            }

            protected float Level_3_raw;
            public const string Level_3_displayName = "Level 3";
            public const int Level_3_sortIndex = 150;
            [SortOrder(Level_3_sortIndex)]
            [DisplayName(Level_3_displayName)]
            public virtual float Level_3 {
                get => Level_3_raw;
                set {
                    if (Level_3_raw == value) return;
                    Level_3_raw = value;
                    ChangedItems.Add(nameof(Level_3));
                    OnPropertyChanged(nameof(Level_3));
                }
            }

            protected float Level_4_raw;
            public const string Level_4_displayName = "Level 4";
            public const int Level_4_sortIndex = 200;
            [SortOrder(Level_4_sortIndex)]
            [DisplayName(Level_4_displayName)]
            public virtual float Level_4 {
                get => Level_4_raw;
                set {
                    if (Level_4_raw == value) return;
                    Level_4_raw = value;
                    ChangedItems.Add(nameof(Level_4));
                    OnPropertyChanged(nameof(Level_4));
                }
            }

            protected float Level_5_raw;
            public const string Level_5_displayName = "Level 5";
            public const int Level_5_sortIndex = 250;
            [SortOrder(Level_5_sortIndex)]
            [DisplayName(Level_5_displayName)]
            public virtual float Level_5 {
                get => Level_5_raw;
                set {
                    if (Level_5_raw == value) return;
                    Level_5_raw = value;
                    ChangedItems.Add(nameof(Level_5));
                    OnPropertyChanged(nameof(Level_5));
                }
            }

            protected float Level_6_raw;
            public const string Level_6_displayName = "Level 6";
            public const int Level_6_sortIndex = 300;
            [SortOrder(Level_6_sortIndex)]
            [DisplayName(Level_6_displayName)]
            public virtual float Level_6 {
                get => Level_6_raw;
                set {
                    if (Level_6_raw == value) return;
                    Level_6_raw = value;
                    ChangedItems.Add(nameof(Level_6));
                    OnPropertyChanged(nameof(Level_6));
                }
            }

            protected float Level_7_raw;
            public const string Level_7_displayName = "Level 7";
            public const int Level_7_sortIndex = 350;
            [SortOrder(Level_7_sortIndex)]
            [DisplayName(Level_7_displayName)]
            public virtual float Level_7 {
                get => Level_7_raw;
                set {
                    if (Level_7_raw == value) return;
                    Level_7_raw = value;
                    ChangedItems.Add(nameof(Level_7));
                    OnPropertyChanged(nameof(Level_7));
                }
            }

            protected float Level_8_raw;
            public const string Level_8_displayName = "Level 8";
            public const int Level_8_sortIndex = 400;
            [SortOrder(Level_8_sortIndex)]
            [DisplayName(Level_8_displayName)]
            public virtual float Level_8 {
                get => Level_8_raw;
                set {
                    if (Level_8_raw == value) return;
                    Level_8_raw = value;
                    ChangedItems.Add(nameof(Level_8));
                    OnPropertyChanged(nameof(Level_8));
                }
            }

            protected float Level_9_raw;
            public const string Level_9_displayName = "Level 9";
            public const int Level_9_sortIndex = 450;
            [SortOrder(Level_9_sortIndex)]
            [DisplayName(Level_9_displayName)]
            public virtual float Level_9 {
                get => Level_9_raw;
                set {
                    if (Level_9_raw == value) return;
                    Level_9_raw = value;
                    ChangedItems.Add(nameof(Level_9));
                    OnPropertyChanged(nameof(Level_9));
                }
            }

            protected float Level_10_raw;
            public const string Level_10_displayName = "Level 10";
            public const int Level_10_sortIndex = 500;
            [SortOrder(Level_10_sortIndex)]
            [DisplayName(Level_10_displayName)]
            public virtual float Level_10 {
                get => Level_10_raw;
                set {
                    if (Level_10_raw == value) return;
                    Level_10_raw = value;
                    ChangedItems.Add(nameof(Level_10));
                    OnPropertyChanged(nameof(Level_10));
                }
            }

            protected float Level_11_raw;
            public const string Level_11_displayName = "Level 11";
            public const int Level_11_sortIndex = 550;
            [SortOrder(Level_11_sortIndex)]
            [DisplayName(Level_11_displayName)]
            public virtual float Level_11 {
                get => Level_11_raw;
                set {
                    if (Level_11_raw == value) return;
                    Level_11_raw = value;
                    ChangedItems.Add(nameof(Level_11));
                    OnPropertyChanged(nameof(Level_11));
                }
            }

            protected float Level_12_raw;
            public const string Level_12_displayName = "Level 12";
            public const int Level_12_sortIndex = 600;
            [SortOrder(Level_12_sortIndex)]
            [DisplayName(Level_12_displayName)]
            public virtual float Level_12 {
                get => Level_12_raw;
                set {
                    if (Level_12_raw == value) return;
                    Level_12_raw = value;
                    ChangedItems.Add(nameof(Level_12));
                    OnPropertyChanged(nameof(Level_12));
                }
            }

            protected float Level_13_raw;
            public const string Level_13_displayName = "Level 13";
            public const int Level_13_sortIndex = 650;
            [SortOrder(Level_13_sortIndex)]
            [DisplayName(Level_13_displayName)]
            public virtual float Level_13 {
                get => Level_13_raw;
                set {
                    if (Level_13_raw == value) return;
                    Level_13_raw = value;
                    ChangedItems.Add(nameof(Level_13));
                    OnPropertyChanged(nameof(Level_13));
                }
            }

            protected float Level_14_raw;
            public const string Level_14_displayName = "Level 14";
            public const int Level_14_sortIndex = 700;
            [SortOrder(Level_14_sortIndex)]
            [DisplayName(Level_14_displayName)]
            public virtual float Level_14 {
                get => Level_14_raw;
                set {
                    if (Level_14_raw == value) return;
                    Level_14_raw = value;
                    ChangedItems.Add(nameof(Level_14));
                    OnPropertyChanged(nameof(Level_14));
                }
            }

            protected float Level_15_raw;
            public const string Level_15_displayName = "Level 15";
            public const int Level_15_sortIndex = 750;
            [SortOrder(Level_15_sortIndex)]
            [DisplayName(Level_15_displayName)]
            public virtual float Level_15 {
                get => Level_15_raw;
                set {
                    if (Level_15_raw == value) return;
                    Level_15_raw = value;
                    ChangedItems.Add(nameof(Level_15));
                    OnPropertyChanged(nameof(Level_15));
                }
            }

            protected float Level_16_raw;
            public const string Level_16_displayName = "Level 16";
            public const int Level_16_sortIndex = 800;
            [SortOrder(Level_16_sortIndex)]
            [DisplayName(Level_16_displayName)]
            public virtual float Level_16 {
                get => Level_16_raw;
                set {
                    if (Level_16_raw == value) return;
                    Level_16_raw = value;
                    ChangedItems.Add(nameof(Level_16));
                    OnPropertyChanged(nameof(Level_16));
                }
            }

            protected float Level_17_raw;
            public const string Level_17_displayName = "Level 17";
            public const int Level_17_sortIndex = 850;
            [SortOrder(Level_17_sortIndex)]
            [DisplayName(Level_17_displayName)]
            public virtual float Level_17 {
                get => Level_17_raw;
                set {
                    if (Level_17_raw == value) return;
                    Level_17_raw = value;
                    ChangedItems.Add(nameof(Level_17));
                    OnPropertyChanged(nameof(Level_17));
                }
            }

            protected float Level_18_raw;
            public const string Level_18_displayName = "Level 18";
            public const int Level_18_sortIndex = 900;
            [SortOrder(Level_18_sortIndex)]
            [DisplayName(Level_18_displayName)]
            public virtual float Level_18 {
                get => Level_18_raw;
                set {
                    if (Level_18_raw == value) return;
                    Level_18_raw = value;
                    ChangedItems.Add(nameof(Level_18));
                    OnPropertyChanged(nameof(Level_18));
                }
            }

            protected float Level_19_raw;
            public const string Level_19_displayName = "Level 19";
            public const int Level_19_sortIndex = 950;
            [SortOrder(Level_19_sortIndex)]
            [DisplayName(Level_19_displayName)]
            public virtual float Level_19 {
                get => Level_19_raw;
                set {
                    if (Level_19_raw == value) return;
                    Level_19_raw = value;
                    ChangedItems.Add(nameof(Level_19));
                    OnPropertyChanged(nameof(Level_19));
                }
            }

            protected float Level_20_raw;
            public const string Level_20_displayName = "Level 20";
            public const int Level_20_sortIndex = 1000;
            [SortOrder(Level_20_sortIndex)]
            [DisplayName(Level_20_displayName)]
            public virtual float Level_20 {
                get => Level_20_raw;
                set {
                    if (Level_20_raw == value) return;
                    Level_20_raw = value;
                    ChangedItems.Add(nameof(Level_20));
                    OnPropertyChanged(nameof(Level_20));
                }
            }

            public const int lastSortIndex = 1050;

            public static ObservableMhwStructCollection<Kinsect_Stats> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Kinsect_Stats>();
                const ulong count = 9UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Kinsect_Stats LoadData(BinaryReader reader, ulong i) {
                var data = new Kinsect_Stats();
                data.Index = i;
                data.Level_1_raw = reader.ReadSingle();
                data.Level_2_raw = reader.ReadSingle();
                data.Level_3_raw = reader.ReadSingle();
                data.Level_4_raw = reader.ReadSingle();
                data.Level_5_raw = reader.ReadSingle();
                data.Level_6_raw = reader.ReadSingle();
                data.Level_7_raw = reader.ReadSingle();
                data.Level_8_raw = reader.ReadSingle();
                data.Level_9_raw = reader.ReadSingle();
                data.Level_10_raw = reader.ReadSingle();
                data.Level_11_raw = reader.ReadSingle();
                data.Level_12_raw = reader.ReadSingle();
                data.Level_13_raw = reader.ReadSingle();
                data.Level_14_raw = reader.ReadSingle();
                data.Level_15_raw = reader.ReadSingle();
                data.Level_16_raw = reader.ReadSingle();
                data.Level_17_raw = reader.ReadSingle();
                data.Level_18_raw = reader.ReadSingle();
                data.Level_19_raw = reader.ReadSingle();
                data.Level_20_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Level_1_raw);
                writer.Write(Level_2_raw);
                writer.Write(Level_3_raw);
                writer.Write(Level_4_raw);
                writer.Write(Level_5_raw);
                writer.Write(Level_6_raw);
                writer.Write(Level_7_raw);
                writer.Write(Level_8_raw);
                writer.Write(Level_9_raw);
                writer.Write(Level_10_raw);
                writer.Write(Level_11_raw);
                writer.Write(Level_12_raw);
                writer.Write(Level_13_raw);
                writer.Write(Level_14_raw);
                writer.Write(Level_15_raw);
                writer.Write(Level_16_raw);
                writer.Write(Level_17_raw);
                writer.Write(Level_18_raw);
                writer.Write(Level_19_raw);
                writer.Write(Level_20_raw);
            }
        }

        public partial class W10p_Params_11_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W10p Params (11)";

            protected float Unk_151_raw;
            public const string Unk_151_displayName = "Unk 151";
            public const int Unk_151_sortIndex = 50;
            [SortOrder(Unk_151_sortIndex)]
            [DisplayName(Unk_151_displayName)]
            public virtual float Unk_151 {
                get => Unk_151_raw;
                set {
                    if (Unk_151_raw == value) return;
                    Unk_151_raw = value;
                    ChangedItems.Add(nameof(Unk_151));
                    OnPropertyChanged(nameof(Unk_151));
                }
            }

            [DisplayName("Offset")]
            public long Unk_151_offset { get; private set; }

            protected float Unk_152_raw;
            public const string Unk_152_displayName = "Unk 152";
            public const int Unk_152_sortIndex = 100;
            [SortOrder(Unk_152_sortIndex)]
            [DisplayName(Unk_152_displayName)]
            public virtual float Unk_152 {
                get => Unk_152_raw;
                set {
                    if (Unk_152_raw == value) return;
                    Unk_152_raw = value;
                    ChangedItems.Add(nameof(Unk_152));
                    OnPropertyChanged(nameof(Unk_152));
                }
            }

            [DisplayName("Offset")]
            public long Unk_152_offset { get; private set; }

            protected float Unk_153_raw;
            public const string Unk_153_displayName = "Unk 153";
            public const int Unk_153_sortIndex = 150;
            [SortOrder(Unk_153_sortIndex)]
            [DisplayName(Unk_153_displayName)]
            public virtual float Unk_153 {
                get => Unk_153_raw;
                set {
                    if (Unk_153_raw == value) return;
                    Unk_153_raw = value;
                    ChangedItems.Add(nameof(Unk_153));
                    OnPropertyChanged(nameof(Unk_153));
                }
            }

            [DisplayName("Offset")]
            public long Unk_153_offset { get; private set; }

            protected float Unk_154_raw;
            public const string Unk_154_displayName = "Unk 154";
            public const int Unk_154_sortIndex = 200;
            [SortOrder(Unk_154_sortIndex)]
            [DisplayName(Unk_154_displayName)]
            public virtual float Unk_154 {
                get => Unk_154_raw;
                set {
                    if (Unk_154_raw == value) return;
                    Unk_154_raw = value;
                    ChangedItems.Add(nameof(Unk_154));
                    OnPropertyChanged(nameof(Unk_154));
                }
            }

            [DisplayName("Offset")]
            public long Unk_154_offset { get; private set; }

            protected float Unk_155_raw;
            public const string Unk_155_displayName = "Unk 155";
            public const int Unk_155_sortIndex = 250;
            [SortOrder(Unk_155_sortIndex)]
            [DisplayName(Unk_155_displayName)]
            public virtual float Unk_155 {
                get => Unk_155_raw;
                set {
                    if (Unk_155_raw == value) return;
                    Unk_155_raw = value;
                    ChangedItems.Add(nameof(Unk_155));
                    OnPropertyChanged(nameof(Unk_155));
                }
            }

            [DisplayName("Offset")]
            public long Unk_155_offset { get; private set; }

            protected float Unk_156_raw;
            public const string Unk_156_displayName = "Unk 156";
            public const int Unk_156_sortIndex = 300;
            [SortOrder(Unk_156_sortIndex)]
            [DisplayName(Unk_156_displayName)]
            public virtual float Unk_156 {
                get => Unk_156_raw;
                set {
                    if (Unk_156_raw == value) return;
                    Unk_156_raw = value;
                    ChangedItems.Add(nameof(Unk_156));
                    OnPropertyChanged(nameof(Unk_156));
                }
            }

            [DisplayName("Offset")]
            public long Unk_156_offset { get; private set; }

            protected float Kinsect_Buff_Red_raw;
            public const string Kinsect_Buff_Red_displayName = "Kinsect Buff: Red";
            public const int Kinsect_Buff_Red_sortIndex = 350;
            [SortOrder(Kinsect_Buff_Red_sortIndex)]
            [DisplayName(Kinsect_Buff_Red_displayName)]
            public virtual float Kinsect_Buff_Red {
                get => Kinsect_Buff_Red_raw;
                set {
                    if (Kinsect_Buff_Red_raw == value) return;
                    Kinsect_Buff_Red_raw = value;
                    ChangedItems.Add(nameof(Kinsect_Buff_Red));
                    OnPropertyChanged(nameof(Kinsect_Buff_Red));
                }
            }

            [DisplayName("Offset")]
            public long Kinsect_Buff_Red_offset { get; private set; }

            protected float Kinsect_Buff_White_raw;
            public const string Kinsect_Buff_White_displayName = "Kinsect Buff: White";
            public const int Kinsect_Buff_White_sortIndex = 400;
            [SortOrder(Kinsect_Buff_White_sortIndex)]
            [DisplayName(Kinsect_Buff_White_displayName)]
            public virtual float Kinsect_Buff_White {
                get => Kinsect_Buff_White_raw;
                set {
                    if (Kinsect_Buff_White_raw == value) return;
                    Kinsect_Buff_White_raw = value;
                    ChangedItems.Add(nameof(Kinsect_Buff_White));
                    OnPropertyChanged(nameof(Kinsect_Buff_White));
                }
            }

            [DisplayName("Offset")]
            public long Kinsect_Buff_White_offset { get; private set; }

            protected float Kinsect_Buff_Orange_raw;
            public const string Kinsect_Buff_Orange_displayName = "Kinsect Buff: Orange";
            public const int Kinsect_Buff_Orange_sortIndex = 450;
            [SortOrder(Kinsect_Buff_Orange_sortIndex)]
            [DisplayName(Kinsect_Buff_Orange_displayName)]
            public virtual float Kinsect_Buff_Orange {
                get => Kinsect_Buff_Orange_raw;
                set {
                    if (Kinsect_Buff_Orange_raw == value) return;
                    Kinsect_Buff_Orange_raw = value;
                    ChangedItems.Add(nameof(Kinsect_Buff_Orange));
                    OnPropertyChanged(nameof(Kinsect_Buff_Orange));
                }
            }

            [DisplayName("Offset")]
            public long Kinsect_Buff_Orange_offset { get; private set; }

            protected float Kinsect_Buff_All_Three_Extracts_raw;
            public const string Kinsect_Buff_All_Three_Extracts_displayName = "Kinsect Buff: All Three Extracts";
            public const int Kinsect_Buff_All_Three_Extracts_sortIndex = 500;
            [SortOrder(Kinsect_Buff_All_Three_Extracts_sortIndex)]
            [DisplayName(Kinsect_Buff_All_Three_Extracts_displayName)]
            public virtual float Kinsect_Buff_All_Three_Extracts {
                get => Kinsect_Buff_All_Three_Extracts_raw;
                set {
                    if (Kinsect_Buff_All_Three_Extracts_raw == value) return;
                    Kinsect_Buff_All_Three_Extracts_raw = value;
                    ChangedItems.Add(nameof(Kinsect_Buff_All_Three_Extracts));
                    OnPropertyChanged(nameof(Kinsect_Buff_All_Three_Extracts));
                }
            }

            [DisplayName("Offset")]
            public long Kinsect_Buff_All_Three_Extracts_offset { get; private set; }

            protected float Kinsect_Charge_Power_Attack_Power_raw;
            public const string Kinsect_Charge_Power_Attack_Power_displayName = "Kinsect Charge(Power) Attack Power";
            public const int Kinsect_Charge_Power_Attack_Power_sortIndex = 550;
            [SortOrder(Kinsect_Charge_Power_Attack_Power_sortIndex)]
            [DisplayName(Kinsect_Charge_Power_Attack_Power_displayName)]
            public virtual float Kinsect_Charge_Power_Attack_Power {
                get => Kinsect_Charge_Power_Attack_Power_raw;
                set {
                    if (Kinsect_Charge_Power_Attack_Power_raw == value) return;
                    Kinsect_Charge_Power_Attack_Power_raw = value;
                    ChangedItems.Add(nameof(Kinsect_Charge_Power_Attack_Power));
                    OnPropertyChanged(nameof(Kinsect_Charge_Power_Attack_Power));
                }
            }

            [DisplayName("Offset")]
            public long Kinsect_Charge_Power_Attack_Power_offset { get; private set; }

            protected float Kinsect_Charge_Power_Elemental_Attack_Power_raw;
            public const string Kinsect_Charge_Power_Elemental_Attack_Power_displayName = "Kinsect Charge(Power) Elemental Attack Power";
            public const int Kinsect_Charge_Power_Elemental_Attack_Power_sortIndex = 600;
            [SortOrder(Kinsect_Charge_Power_Elemental_Attack_Power_sortIndex)]
            [DisplayName(Kinsect_Charge_Power_Elemental_Attack_Power_displayName)]
            public virtual float Kinsect_Charge_Power_Elemental_Attack_Power {
                get => Kinsect_Charge_Power_Elemental_Attack_Power_raw;
                set {
                    if (Kinsect_Charge_Power_Elemental_Attack_Power_raw == value) return;
                    Kinsect_Charge_Power_Elemental_Attack_Power_raw = value;
                    ChangedItems.Add(nameof(Kinsect_Charge_Power_Elemental_Attack_Power));
                    OnPropertyChanged(nameof(Kinsect_Charge_Power_Elemental_Attack_Power));
                }
            }

            [DisplayName("Offset")]
            public long Kinsect_Charge_Power_Elemental_Attack_Power_offset { get; private set; }

            protected float Kinsect_Charge_Power_Dust_Effect_Multiplier_raw;
            public const string Kinsect_Charge_Power_Dust_Effect_Multiplier_displayName = "Kinsect Charge(Power) Dust Effect Multiplier";
            public const int Kinsect_Charge_Power_Dust_Effect_Multiplier_sortIndex = 650;
            [SortOrder(Kinsect_Charge_Power_Dust_Effect_Multiplier_sortIndex)]
            [DisplayName(Kinsect_Charge_Power_Dust_Effect_Multiplier_displayName)]
            public virtual float Kinsect_Charge_Power_Dust_Effect_Multiplier {
                get => Kinsect_Charge_Power_Dust_Effect_Multiplier_raw;
                set {
                    if (Kinsect_Charge_Power_Dust_Effect_Multiplier_raw == value) return;
                    Kinsect_Charge_Power_Dust_Effect_Multiplier_raw = value;
                    ChangedItems.Add(nameof(Kinsect_Charge_Power_Dust_Effect_Multiplier));
                    OnPropertyChanged(nameof(Kinsect_Charge_Power_Dust_Effect_Multiplier));
                }
            }

            [DisplayName("Offset")]
            public long Kinsect_Charge_Power_Dust_Effect_Multiplier_offset { get; private set; }

            protected float Kinsect_Charge_Spirit_Max_Plus_Regen_Stamina_raw;
            public const string Kinsect_Charge_Spirit_Max_Plus_Regen_Stamina_displayName = "Kinsect Charge(Spirit) Max + Regen Stamina";
            public const int Kinsect_Charge_Spirit_Max_Plus_Regen_Stamina_sortIndex = 700;
            [SortOrder(Kinsect_Charge_Spirit_Max_Plus_Regen_Stamina_sortIndex)]
            [DisplayName(Kinsect_Charge_Spirit_Max_Plus_Regen_Stamina_displayName)]
            public virtual float Kinsect_Charge_Spirit_Max_Plus_Regen_Stamina {
                get => Kinsect_Charge_Spirit_Max_Plus_Regen_Stamina_raw;
                set {
                    if (Kinsect_Charge_Spirit_Max_Plus_Regen_Stamina_raw == value) return;
                    Kinsect_Charge_Spirit_Max_Plus_Regen_Stamina_raw = value;
                    ChangedItems.Add(nameof(Kinsect_Charge_Spirit_Max_Plus_Regen_Stamina));
                    OnPropertyChanged(nameof(Kinsect_Charge_Spirit_Max_Plus_Regen_Stamina));
                }
            }

            [DisplayName("Offset")]
            public long Kinsect_Charge_Spirit_Max_Plus_Regen_Stamina_offset { get; private set; }

            protected float Kinsect_Charge_Power_Dust_Interval_raw;
            public const string Kinsect_Charge_Power_Dust_Interval_displayName = "Kinsect Charge(Power) Dust Interval";
            public const int Kinsect_Charge_Power_Dust_Interval_sortIndex = 750;
            [SortOrder(Kinsect_Charge_Power_Dust_Interval_sortIndex)]
            [DisplayName(Kinsect_Charge_Power_Dust_Interval_displayName)]
            public virtual float Kinsect_Charge_Power_Dust_Interval {
                get => Kinsect_Charge_Power_Dust_Interval_raw;
                set {
                    if (Kinsect_Charge_Power_Dust_Interval_raw == value) return;
                    Kinsect_Charge_Power_Dust_Interval_raw = value;
                    ChangedItems.Add(nameof(Kinsect_Charge_Power_Dust_Interval));
                    OnPropertyChanged(nameof(Kinsect_Charge_Power_Dust_Interval));
                }
            }

            [DisplayName("Offset")]
            public long Kinsect_Charge_Power_Dust_Interval_offset { get; private set; }

            protected float Kinsect_Charge_Piercing_Pod_raw;
            public const string Kinsect_Charge_Piercing_Pod_displayName = "Kinsect Charge: Piercing Pod";
            public const int Kinsect_Charge_Piercing_Pod_sortIndex = 800;
            [SortOrder(Kinsect_Charge_Piercing_Pod_sortIndex)]
            [DisplayName(Kinsect_Charge_Piercing_Pod_displayName)]
            public virtual float Kinsect_Charge_Piercing_Pod {
                get => Kinsect_Charge_Piercing_Pod_raw;
                set {
                    if (Kinsect_Charge_Piercing_Pod_raw == value) return;
                    Kinsect_Charge_Piercing_Pod_raw = value;
                    ChangedItems.Add(nameof(Kinsect_Charge_Piercing_Pod));
                    OnPropertyChanged(nameof(Kinsect_Charge_Piercing_Pod));
                }
            }

            [DisplayName("Offset")]
            public long Kinsect_Charge_Piercing_Pod_offset { get; private set; }

            protected float Kinsect_Charge_Stone_raw;
            public const string Kinsect_Charge_Stone_displayName = "Kinsect Charge: Stone";
            public const int Kinsect_Charge_Stone_sortIndex = 850;
            [SortOrder(Kinsect_Charge_Stone_sortIndex)]
            [DisplayName(Kinsect_Charge_Stone_displayName)]
            public virtual float Kinsect_Charge_Stone {
                get => Kinsect_Charge_Stone_raw;
                set {
                    if (Kinsect_Charge_Stone_raw == value) return;
                    Kinsect_Charge_Stone_raw = value;
                    ChangedItems.Add(nameof(Kinsect_Charge_Stone));
                    OnPropertyChanged(nameof(Kinsect_Charge_Stone));
                }
            }

            [DisplayName("Offset")]
            public long Kinsect_Charge_Stone_offset { get; private set; }

            protected float Kinsect_Charge_Redpit_raw;
            public const string Kinsect_Charge_Redpit_displayName = "Kinsect Charge: Redpit";
            public const int Kinsect_Charge_Redpit_sortIndex = 900;
            [SortOrder(Kinsect_Charge_Redpit_sortIndex)]
            [DisplayName(Kinsect_Charge_Redpit_displayName)]
            public virtual float Kinsect_Charge_Redpit {
                get => Kinsect_Charge_Redpit_raw;
                set {
                    if (Kinsect_Charge_Redpit_raw == value) return;
                    Kinsect_Charge_Redpit_raw = value;
                    ChangedItems.Add(nameof(Kinsect_Charge_Redpit));
                    OnPropertyChanged(nameof(Kinsect_Charge_Redpit));
                }
            }

            [DisplayName("Offset")]
            public long Kinsect_Charge_Redpit_offset { get; private set; }

            protected float Kinsect_Charge_Scatternut_raw;
            public const string Kinsect_Charge_Scatternut_displayName = "Kinsect Charge: Scatternut";
            public const int Kinsect_Charge_Scatternut_sortIndex = 950;
            [SortOrder(Kinsect_Charge_Scatternut_sortIndex)]
            [DisplayName(Kinsect_Charge_Scatternut_displayName)]
            public virtual float Kinsect_Charge_Scatternut {
                get => Kinsect_Charge_Scatternut_raw;
                set {
                    if (Kinsect_Charge_Scatternut_raw == value) return;
                    Kinsect_Charge_Scatternut_raw = value;
                    ChangedItems.Add(nameof(Kinsect_Charge_Scatternut));
                    OnPropertyChanged(nameof(Kinsect_Charge_Scatternut));
                }
            }

            [DisplayName("Offset")]
            public long Kinsect_Charge_Scatternut_offset { get; private set; }

            protected float Kinsect_Charge_Crystalburst_raw;
            public const string Kinsect_Charge_Crystalburst_displayName = "Kinsect Charge: Crystalburst";
            public const int Kinsect_Charge_Crystalburst_sortIndex = 1000;
            [SortOrder(Kinsect_Charge_Crystalburst_sortIndex)]
            [DisplayName(Kinsect_Charge_Crystalburst_displayName)]
            public virtual float Kinsect_Charge_Crystalburst {
                get => Kinsect_Charge_Crystalburst_raw;
                set {
                    if (Kinsect_Charge_Crystalburst_raw == value) return;
                    Kinsect_Charge_Crystalburst_raw = value;
                    ChangedItems.Add(nameof(Kinsect_Charge_Crystalburst));
                    OnPropertyChanged(nameof(Kinsect_Charge_Crystalburst));
                }
            }

            [DisplayName("Offset")]
            public long Kinsect_Charge_Crystalburst_offset { get; private set; }

            protected float Kinsect_Charge_Thorn_Pod_raw;
            public const string Kinsect_Charge_Thorn_Pod_displayName = "Kinsect Charge: Thorn Pod";
            public const int Kinsect_Charge_Thorn_Pod_sortIndex = 1050;
            [SortOrder(Kinsect_Charge_Thorn_Pod_sortIndex)]
            [DisplayName(Kinsect_Charge_Thorn_Pod_displayName)]
            public virtual float Kinsect_Charge_Thorn_Pod {
                get => Kinsect_Charge_Thorn_Pod_raw;
                set {
                    if (Kinsect_Charge_Thorn_Pod_raw == value) return;
                    Kinsect_Charge_Thorn_Pod_raw = value;
                    ChangedItems.Add(nameof(Kinsect_Charge_Thorn_Pod));
                    OnPropertyChanged(nameof(Kinsect_Charge_Thorn_Pod));
                }
            }

            [DisplayName("Offset")]
            public long Kinsect_Charge_Thorn_Pod_offset { get; private set; }

            protected float Kinsect_Charge_Torch_Pod_raw;
            public const string Kinsect_Charge_Torch_Pod_displayName = "Kinsect Charge: Torch Pod";
            public const int Kinsect_Charge_Torch_Pod_sortIndex = 1100;
            [SortOrder(Kinsect_Charge_Torch_Pod_sortIndex)]
            [DisplayName(Kinsect_Charge_Torch_Pod_displayName)]
            public virtual float Kinsect_Charge_Torch_Pod {
                get => Kinsect_Charge_Torch_Pod_raw;
                set {
                    if (Kinsect_Charge_Torch_Pod_raw == value) return;
                    Kinsect_Charge_Torch_Pod_raw = value;
                    ChangedItems.Add(nameof(Kinsect_Charge_Torch_Pod));
                    OnPropertyChanged(nameof(Kinsect_Charge_Torch_Pod));
                }
            }

            [DisplayName("Offset")]
            public long Kinsect_Charge_Torch_Pod_offset { get; private set; }

            protected float Kinsect_Charge_Puddle_Pod_raw;
            public const string Kinsect_Charge_Puddle_Pod_displayName = "Kinsect Charge: Puddle Pod";
            public const int Kinsect_Charge_Puddle_Pod_sortIndex = 1150;
            [SortOrder(Kinsect_Charge_Puddle_Pod_sortIndex)]
            [DisplayName(Kinsect_Charge_Puddle_Pod_displayName)]
            public virtual float Kinsect_Charge_Puddle_Pod {
                get => Kinsect_Charge_Puddle_Pod_raw;
                set {
                    if (Kinsect_Charge_Puddle_Pod_raw == value) return;
                    Kinsect_Charge_Puddle_Pod_raw = value;
                    ChangedItems.Add(nameof(Kinsect_Charge_Puddle_Pod));
                    OnPropertyChanged(nameof(Kinsect_Charge_Puddle_Pod));
                }
            }

            [DisplayName("Offset")]
            public long Kinsect_Charge_Puddle_Pod_offset { get; private set; }

            protected float Kinsect_Charge_Dragon_Pod_raw;
            public const string Kinsect_Charge_Dragon_Pod_displayName = "Kinsect Charge: Dragon Pod";
            public const int Kinsect_Charge_Dragon_Pod_sortIndex = 1200;
            [SortOrder(Kinsect_Charge_Dragon_Pod_sortIndex)]
            [DisplayName(Kinsect_Charge_Dragon_Pod_displayName)]
            public virtual float Kinsect_Charge_Dragon_Pod {
                get => Kinsect_Charge_Dragon_Pod_raw;
                set {
                    if (Kinsect_Charge_Dragon_Pod_raw == value) return;
                    Kinsect_Charge_Dragon_Pod_raw = value;
                    ChangedItems.Add(nameof(Kinsect_Charge_Dragon_Pod));
                    OnPropertyChanged(nameof(Kinsect_Charge_Dragon_Pod));
                }
            }

            [DisplayName("Offset")]
            public long Kinsect_Charge_Dragon_Pod_offset { get; private set; }

            protected float Kinsect_Charge_Bomb_Pod_raw;
            public const string Kinsect_Charge_Bomb_Pod_displayName = "Kinsect Charge: Bomb Pod";
            public const int Kinsect_Charge_Bomb_Pod_sortIndex = 1250;
            [SortOrder(Kinsect_Charge_Bomb_Pod_sortIndex)]
            [DisplayName(Kinsect_Charge_Bomb_Pod_displayName)]
            public virtual float Kinsect_Charge_Bomb_Pod {
                get => Kinsect_Charge_Bomb_Pod_raw;
                set {
                    if (Kinsect_Charge_Bomb_Pod_raw == value) return;
                    Kinsect_Charge_Bomb_Pod_raw = value;
                    ChangedItems.Add(nameof(Kinsect_Charge_Bomb_Pod));
                    OnPropertyChanged(nameof(Kinsect_Charge_Bomb_Pod));
                }
            }

            [DisplayName("Offset")]
            public long Kinsect_Charge_Bomb_Pod_offset { get; private set; }

            protected float Kinsect_Charge_Brightmoss_raw;
            public const string Kinsect_Charge_Brightmoss_displayName = "Kinsect Charge: Brightmoss";
            public const int Kinsect_Charge_Brightmoss_sortIndex = 1300;
            [SortOrder(Kinsect_Charge_Brightmoss_sortIndex)]
            [DisplayName(Kinsect_Charge_Brightmoss_displayName)]
            public virtual float Kinsect_Charge_Brightmoss {
                get => Kinsect_Charge_Brightmoss_raw;
                set {
                    if (Kinsect_Charge_Brightmoss_raw == value) return;
                    Kinsect_Charge_Brightmoss_raw = value;
                    ChangedItems.Add(nameof(Kinsect_Charge_Brightmoss));
                    OnPropertyChanged(nameof(Kinsect_Charge_Brightmoss));
                }
            }

            [DisplayName("Offset")]
            public long Kinsect_Charge_Brightmoss_offset { get; private set; }

            public const int lastSortIndex = 1350;

            public static ObservableMhwStructCollection<W10p_Params_11_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W10p_Params_11_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W10p_Params_11_ LoadData(BinaryReader reader, ulong i) {
                var data = new W10p_Params_11_();
                data.Index = i;
                data.Unk_151_offset = reader.BaseStream.Position;
                data.Unk_151_raw = reader.ReadSingle();
                data.Unk_152_offset = reader.BaseStream.Position;
                data.Unk_152_raw = reader.ReadSingle();
                data.Unk_153_offset = reader.BaseStream.Position;
                data.Unk_153_raw = reader.ReadSingle();
                data.Unk_154_offset = reader.BaseStream.Position;
                data.Unk_154_raw = reader.ReadSingle();
                data.Unk_155_offset = reader.BaseStream.Position;
                data.Unk_155_raw = reader.ReadSingle();
                data.Unk_156_offset = reader.BaseStream.Position;
                data.Unk_156_raw = reader.ReadSingle();
                data.Kinsect_Buff_Red_offset = reader.BaseStream.Position;
                data.Kinsect_Buff_Red_raw = reader.ReadSingle();
                data.Kinsect_Buff_White_offset = reader.BaseStream.Position;
                data.Kinsect_Buff_White_raw = reader.ReadSingle();
                data.Kinsect_Buff_Orange_offset = reader.BaseStream.Position;
                data.Kinsect_Buff_Orange_raw = reader.ReadSingle();
                data.Kinsect_Buff_All_Three_Extracts_offset = reader.BaseStream.Position;
                data.Kinsect_Buff_All_Three_Extracts_raw = reader.ReadSingle();
                data.Kinsect_Charge_Power_Attack_Power_offset = reader.BaseStream.Position;
                data.Kinsect_Charge_Power_Attack_Power_raw = reader.ReadSingle();
                data.Kinsect_Charge_Power_Elemental_Attack_Power_offset = reader.BaseStream.Position;
                data.Kinsect_Charge_Power_Elemental_Attack_Power_raw = reader.ReadSingle();
                data.Kinsect_Charge_Power_Dust_Effect_Multiplier_offset = reader.BaseStream.Position;
                data.Kinsect_Charge_Power_Dust_Effect_Multiplier_raw = reader.ReadSingle();
                data.Kinsect_Charge_Spirit_Max_Plus_Regen_Stamina_offset = reader.BaseStream.Position;
                data.Kinsect_Charge_Spirit_Max_Plus_Regen_Stamina_raw = reader.ReadSingle();
                data.Kinsect_Charge_Power_Dust_Interval_offset = reader.BaseStream.Position;
                data.Kinsect_Charge_Power_Dust_Interval_raw = reader.ReadSingle();
                data.Kinsect_Charge_Piercing_Pod_offset = reader.BaseStream.Position;
                data.Kinsect_Charge_Piercing_Pod_raw = reader.ReadSingle();
                data.Kinsect_Charge_Stone_offset = reader.BaseStream.Position;
                data.Kinsect_Charge_Stone_raw = reader.ReadSingle();
                data.Kinsect_Charge_Redpit_offset = reader.BaseStream.Position;
                data.Kinsect_Charge_Redpit_raw = reader.ReadSingle();
                data.Kinsect_Charge_Scatternut_offset = reader.BaseStream.Position;
                data.Kinsect_Charge_Scatternut_raw = reader.ReadSingle();
                data.Kinsect_Charge_Crystalburst_offset = reader.BaseStream.Position;
                data.Kinsect_Charge_Crystalburst_raw = reader.ReadSingle();
                data.Kinsect_Charge_Thorn_Pod_offset = reader.BaseStream.Position;
                data.Kinsect_Charge_Thorn_Pod_raw = reader.ReadSingle();
                data.Kinsect_Charge_Torch_Pod_offset = reader.BaseStream.Position;
                data.Kinsect_Charge_Torch_Pod_raw = reader.ReadSingle();
                data.Kinsect_Charge_Puddle_Pod_offset = reader.BaseStream.Position;
                data.Kinsect_Charge_Puddle_Pod_raw = reader.ReadSingle();
                data.Kinsect_Charge_Dragon_Pod_offset = reader.BaseStream.Position;
                data.Kinsect_Charge_Dragon_Pod_raw = reader.ReadSingle();
                data.Kinsect_Charge_Bomb_Pod_offset = reader.BaseStream.Position;
                data.Kinsect_Charge_Bomb_Pod_raw = reader.ReadSingle();
                data.Kinsect_Charge_Brightmoss_offset = reader.BaseStream.Position;
                data.Kinsect_Charge_Brightmoss_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_151_raw);
                writer.Write(Unk_152_raw);
                writer.Write(Unk_153_raw);
                writer.Write(Unk_154_raw);
                writer.Write(Unk_155_raw);
                writer.Write(Unk_156_raw);
                writer.Write(Kinsect_Buff_Red_raw);
                writer.Write(Kinsect_Buff_White_raw);
                writer.Write(Kinsect_Buff_Orange_raw);
                writer.Write(Kinsect_Buff_All_Three_Extracts_raw);
                writer.Write(Kinsect_Charge_Power_Attack_Power_raw);
                writer.Write(Kinsect_Charge_Power_Elemental_Attack_Power_raw);
                writer.Write(Kinsect_Charge_Power_Dust_Effect_Multiplier_raw);
                writer.Write(Kinsect_Charge_Spirit_Max_Plus_Regen_Stamina_raw);
                writer.Write(Kinsect_Charge_Power_Dust_Interval_raw);
                writer.Write(Kinsect_Charge_Piercing_Pod_raw);
                writer.Write(Kinsect_Charge_Stone_raw);
                writer.Write(Kinsect_Charge_Redpit_raw);
                writer.Write(Kinsect_Charge_Scatternut_raw);
                writer.Write(Kinsect_Charge_Crystalburst_raw);
                writer.Write(Kinsect_Charge_Thorn_Pod_raw);
                writer.Write(Kinsect_Charge_Torch_Pod_raw);
                writer.Write(Kinsect_Charge_Puddle_Pod_raw);
                writer.Write(Kinsect_Charge_Dragon_Pod_raw);
                writer.Write(Kinsect_Charge_Bomb_Pod_raw);
                writer.Write(Kinsect_Charge_Brightmoss_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 151", "Unk_151", "Unk_151_offset"),
                    new MultiStructItemCustomView(this, "Unk 152", "Unk_152", "Unk_152_offset"),
                    new MultiStructItemCustomView(this, "Unk 153", "Unk_153", "Unk_153_offset"),
                    new MultiStructItemCustomView(this, "Unk 154", "Unk_154", "Unk_154_offset"),
                    new MultiStructItemCustomView(this, "Unk 155", "Unk_155", "Unk_155_offset"),
                    new MultiStructItemCustomView(this, "Unk 156", "Unk_156", "Unk_156_offset"),
                    new MultiStructItemCustomView(this, "Kinsect Buff: Red", "Kinsect_Buff_Red", "Kinsect_Buff_Red_offset"),
                    new MultiStructItemCustomView(this, "Kinsect Buff: White", "Kinsect_Buff_White", "Kinsect_Buff_White_offset"),
                    new MultiStructItemCustomView(this, "Kinsect Buff: Orange", "Kinsect_Buff_Orange", "Kinsect_Buff_Orange_offset"),
                    new MultiStructItemCustomView(this, "Kinsect Buff: All Three Extracts", "Kinsect_Buff_All_Three_Extracts", "Kinsect_Buff_All_Three_Extracts_offset"),
                    new MultiStructItemCustomView(this, "Kinsect Charge(Power) Attack Power", "Kinsect_Charge_Power_Attack_Power", "Kinsect_Charge_Power_Attack_Power_offset"),
                    new MultiStructItemCustomView(this, "Kinsect Charge(Power) Elemental Attack Power", "Kinsect_Charge_Power_Elemental_Attack_Power", "Kinsect_Charge_Power_Elemental_Attack_Power_offset"),
                    new MultiStructItemCustomView(this, "Kinsect Charge(Power) Dust Effect Multiplier", "Kinsect_Charge_Power_Dust_Effect_Multiplier", "Kinsect_Charge_Power_Dust_Effect_Multiplier_offset"),
                    new MultiStructItemCustomView(this, "Kinsect Charge(Spirit) Max + Regen Stamina", "Kinsect_Charge_Spirit_Max_Plus_Regen_Stamina", "Kinsect_Charge_Spirit_Max_Plus_Regen_Stamina_offset"),
                    new MultiStructItemCustomView(this, "Kinsect Charge(Power) Dust Interval", "Kinsect_Charge_Power_Dust_Interval", "Kinsect_Charge_Power_Dust_Interval_offset"),
                    new MultiStructItemCustomView(this, "Kinsect Charge: Piercing Pod", "Kinsect_Charge_Piercing_Pod", "Kinsect_Charge_Piercing_Pod_offset"),
                    new MultiStructItemCustomView(this, "Kinsect Charge: Stone", "Kinsect_Charge_Stone", "Kinsect_Charge_Stone_offset"),
                    new MultiStructItemCustomView(this, "Kinsect Charge: Redpit", "Kinsect_Charge_Redpit", "Kinsect_Charge_Redpit_offset"),
                    new MultiStructItemCustomView(this, "Kinsect Charge: Scatternut", "Kinsect_Charge_Scatternut", "Kinsect_Charge_Scatternut_offset"),
                    new MultiStructItemCustomView(this, "Kinsect Charge: Crystalburst", "Kinsect_Charge_Crystalburst", "Kinsect_Charge_Crystalburst_offset"),
                    new MultiStructItemCustomView(this, "Kinsect Charge: Thorn Pod", "Kinsect_Charge_Thorn_Pod", "Kinsect_Charge_Thorn_Pod_offset"),
                    new MultiStructItemCustomView(this, "Kinsect Charge: Torch Pod", "Kinsect_Charge_Torch_Pod", "Kinsect_Charge_Torch_Pod_offset"),
                    new MultiStructItemCustomView(this, "Kinsect Charge: Puddle Pod", "Kinsect_Charge_Puddle_Pod", "Kinsect_Charge_Puddle_Pod_offset"),
                    new MultiStructItemCustomView(this, "Kinsect Charge: Dragon Pod", "Kinsect_Charge_Dragon_Pod", "Kinsect_Charge_Dragon_Pod_offset"),
                    new MultiStructItemCustomView(this, "Kinsect Charge: Bomb Pod", "Kinsect_Charge_Bomb_Pod", "Kinsect_Charge_Bomb_Pod_offset"),
                    new MultiStructItemCustomView(this, "Kinsect Charge: Brightmoss", "Kinsect_Charge_Brightmoss", "Kinsect_Charge_Brightmoss_offset"),
                };
            }
        }

        public partial class Unk_Arr_4_All_sint8_ : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 14;
            public const string GridName = "Unk Arr 4 (All sint8)";

            protected sbyte Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 50;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            public virtual sbyte Unk_1 {
                get => Unk_1_raw;
                set {
                    if (Unk_1_raw == value) return;
                    Unk_1_raw = value;
                    ChangedItems.Add(nameof(Unk_1));
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

            protected sbyte Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 100;
            [SortOrder(Unk_2_sortIndex)]
            [DisplayName(Unk_2_displayName)]
            public virtual sbyte Unk_2 {
                get => Unk_2_raw;
                set {
                    if (Unk_2_raw == value) return;
                    Unk_2_raw = value;
                    ChangedItems.Add(nameof(Unk_2));
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            protected sbyte Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 150;
            [SortOrder(Unk_3_sortIndex)]
            [DisplayName(Unk_3_displayName)]
            public virtual sbyte Unk_3 {
                get => Unk_3_raw;
                set {
                    if (Unk_3_raw == value) return;
                    Unk_3_raw = value;
                    ChangedItems.Add(nameof(Unk_3));
                    OnPropertyChanged(nameof(Unk_3));
                }
            }

            protected sbyte Unk_4_raw;
            public const string Unk_4_displayName = "Unk 4";
            public const int Unk_4_sortIndex = 200;
            [SortOrder(Unk_4_sortIndex)]
            [DisplayName(Unk_4_displayName)]
            public virtual sbyte Unk_4 {
                get => Unk_4_raw;
                set {
                    if (Unk_4_raw == value) return;
                    Unk_4_raw = value;
                    ChangedItems.Add(nameof(Unk_4));
                    OnPropertyChanged(nameof(Unk_4));
                }
            }

            public const int lastSortIndex = 250;

            public static ObservableMhwStructCollection<Unk_Arr_4_All_sint8_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Unk_Arr_4_All_sint8_>();
                const ulong count = 14UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Unk_Arr_4_All_sint8_ LoadData(BinaryReader reader, ulong i) {
                var data = new Unk_Arr_4_All_sint8_();
                data.Index = i;
                data.Unk_1_raw = reader.ReadSByte();
                data.Unk_2_raw = reader.ReadSByte();
                data.Unk_3_raw = reader.ReadSByte();
                data.Unk_4_raw = reader.ReadSByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
                writer.Write(Unk_3_raw);
                writer.Write(Unk_4_raw);
            }
        }

        public partial class W10p_Params_12_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W10p Params (12)";

            protected float Unk_177_raw;
            public const string Unk_177_displayName = "Unk 177";
            public const int Unk_177_sortIndex = 50;
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
            public const int Unk_178_sortIndex = 100;
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
            public const int Unk_179_sortIndex = 150;
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
            public const int Unk_180_sortIndex = 200;
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
            public const int Unk_181_sortIndex = 250;
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

            public const int lastSortIndex = 300;

            public static ObservableMhwStructCollection<W10p_Params_12_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W10p_Params_12_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W10p_Params_12_ LoadData(BinaryReader reader, ulong i) {
                var data = new W10p_Params_12_();
                data.Index = i;
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
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_177_raw);
                writer.Write(Unk_178_raw);
                writer.Write(Unk_179_raw);
                writer.Write(Unk_180_raw);
                writer.Write(Unk_181_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 177", "Unk_177", "Unk_177_offset"),
                    new MultiStructItemCustomView(this, "Unk 178", "Unk_178", "Unk_178_offset"),
                    new MultiStructItemCustomView(this, "Unk 179", "Unk_179", "Unk_179_offset"),
                    new MultiStructItemCustomView(this, "Unk 180", "Unk_180", "Unk_180_offset"),
                    new MultiStructItemCustomView(this, "Unk 181", "Unk_181", "Unk_181_offset"),
                };
            }
        }

        public partial class Unk_Arr_5_All_sint8_ : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Unk Arr 5 (All sint8)";

            protected sbyte Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 50;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            public virtual sbyte Unk_1 {
                get => Unk_1_raw;
                set {
                    if (Unk_1_raw == value) return;
                    Unk_1_raw = value;
                    ChangedItems.Add(nameof(Unk_1));
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

            protected sbyte Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 100;
            [SortOrder(Unk_2_sortIndex)]
            [DisplayName(Unk_2_displayName)]
            public virtual sbyte Unk_2 {
                get => Unk_2_raw;
                set {
                    if (Unk_2_raw == value) return;
                    Unk_2_raw = value;
                    ChangedItems.Add(nameof(Unk_2));
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            protected sbyte Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 150;
            [SortOrder(Unk_3_sortIndex)]
            [DisplayName(Unk_3_displayName)]
            public virtual sbyte Unk_3 {
                get => Unk_3_raw;
                set {
                    if (Unk_3_raw == value) return;
                    Unk_3_raw = value;
                    ChangedItems.Add(nameof(Unk_3));
                    OnPropertyChanged(nameof(Unk_3));
                }
            }

            protected sbyte Unk_4_raw;
            public const string Unk_4_displayName = "Unk 4";
            public const int Unk_4_sortIndex = 200;
            [SortOrder(Unk_4_sortIndex)]
            [DisplayName(Unk_4_displayName)]
            public virtual sbyte Unk_4 {
                get => Unk_4_raw;
                set {
                    if (Unk_4_raw == value) return;
                    Unk_4_raw = value;
                    ChangedItems.Add(nameof(Unk_4));
                    OnPropertyChanged(nameof(Unk_4));
                }
            }

            protected sbyte Unk_5_raw;
            public const string Unk_5_displayName = "Unk 5";
            public const int Unk_5_sortIndex = 250;
            [SortOrder(Unk_5_sortIndex)]
            [DisplayName(Unk_5_displayName)]
            public virtual sbyte Unk_5 {
                get => Unk_5_raw;
                set {
                    if (Unk_5_raw == value) return;
                    Unk_5_raw = value;
                    ChangedItems.Add(nameof(Unk_5));
                    OnPropertyChanged(nameof(Unk_5));
                }
            }

            protected sbyte Unk_6_raw;
            public const string Unk_6_displayName = "Unk 6";
            public const int Unk_6_sortIndex = 300;
            [SortOrder(Unk_6_sortIndex)]
            [DisplayName(Unk_6_displayName)]
            public virtual sbyte Unk_6 {
                get => Unk_6_raw;
                set {
                    if (Unk_6_raw == value) return;
                    Unk_6_raw = value;
                    ChangedItems.Add(nameof(Unk_6));
                    OnPropertyChanged(nameof(Unk_6));
                }
            }

            protected sbyte Unk_7_raw;
            public const string Unk_7_displayName = "Unk 7";
            public const int Unk_7_sortIndex = 350;
            [SortOrder(Unk_7_sortIndex)]
            [DisplayName(Unk_7_displayName)]
            public virtual sbyte Unk_7 {
                get => Unk_7_raw;
                set {
                    if (Unk_7_raw == value) return;
                    Unk_7_raw = value;
                    ChangedItems.Add(nameof(Unk_7));
                    OnPropertyChanged(nameof(Unk_7));
                }
            }

            protected sbyte Unk_8_raw;
            public const string Unk_8_displayName = "Unk 8";
            public const int Unk_8_sortIndex = 400;
            [SortOrder(Unk_8_sortIndex)]
            [DisplayName(Unk_8_displayName)]
            public virtual sbyte Unk_8 {
                get => Unk_8_raw;
                set {
                    if (Unk_8_raw == value) return;
                    Unk_8_raw = value;
                    ChangedItems.Add(nameof(Unk_8));
                    OnPropertyChanged(nameof(Unk_8));
                }
            }

            protected sbyte Unk_9_raw;
            public const string Unk_9_displayName = "Unk 9";
            public const int Unk_9_sortIndex = 450;
            [SortOrder(Unk_9_sortIndex)]
            [DisplayName(Unk_9_displayName)]
            public virtual sbyte Unk_9 {
                get => Unk_9_raw;
                set {
                    if (Unk_9_raw == value) return;
                    Unk_9_raw = value;
                    ChangedItems.Add(nameof(Unk_9));
                    OnPropertyChanged(nameof(Unk_9));
                }
            }

            protected sbyte Unk_10_raw;
            public const string Unk_10_displayName = "Unk 10";
            public const int Unk_10_sortIndex = 500;
            [SortOrder(Unk_10_sortIndex)]
            [DisplayName(Unk_10_displayName)]
            public virtual sbyte Unk_10 {
                get => Unk_10_raw;
                set {
                    if (Unk_10_raw == value) return;
                    Unk_10_raw = value;
                    ChangedItems.Add(nameof(Unk_10));
                    OnPropertyChanged(nameof(Unk_10));
                }
            }

            protected sbyte Unk_11_raw;
            public const string Unk_11_displayName = "Unk 11";
            public const int Unk_11_sortIndex = 550;
            [SortOrder(Unk_11_sortIndex)]
            [DisplayName(Unk_11_displayName)]
            public virtual sbyte Unk_11 {
                get => Unk_11_raw;
                set {
                    if (Unk_11_raw == value) return;
                    Unk_11_raw = value;
                    ChangedItems.Add(nameof(Unk_11));
                    OnPropertyChanged(nameof(Unk_11));
                }
            }

            protected sbyte Unk_12_raw;
            public const string Unk_12_displayName = "Unk 12";
            public const int Unk_12_sortIndex = 600;
            [SortOrder(Unk_12_sortIndex)]
            [DisplayName(Unk_12_displayName)]
            public virtual sbyte Unk_12 {
                get => Unk_12_raw;
                set {
                    if (Unk_12_raw == value) return;
                    Unk_12_raw = value;
                    ChangedItems.Add(nameof(Unk_12));
                    OnPropertyChanged(nameof(Unk_12));
                }
            }

            public const int lastSortIndex = 650;

            public static ObservableMhwStructCollection<Unk_Arr_5_All_sint8_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Unk_Arr_5_All_sint8_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Unk_Arr_5_All_sint8_ LoadData(BinaryReader reader, ulong i) {
                var data = new Unk_Arr_5_All_sint8_();
                data.Index = i;
                data.Unk_1_raw = reader.ReadSByte();
                data.Unk_2_raw = reader.ReadSByte();
                data.Unk_3_raw = reader.ReadSByte();
                data.Unk_4_raw = reader.ReadSByte();
                data.Unk_5_raw = reader.ReadSByte();
                data.Unk_6_raw = reader.ReadSByte();
                data.Unk_7_raw = reader.ReadSByte();
                data.Unk_8_raw = reader.ReadSByte();
                data.Unk_9_raw = reader.ReadSByte();
                data.Unk_10_raw = reader.ReadSByte();
                data.Unk_11_raw = reader.ReadSByte();
                data.Unk_12_raw = reader.ReadSByte();
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
            }
        }

        public partial class W10p_Params_13_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W10p Params (13)";

            protected float Unk_182_raw;
            public const string Unk_182_displayName = "Unk 182";
            public const int Unk_182_sortIndex = 50;
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

            protected float Descending_Thrust_Kinsect_Following_Speed_Multiplier_raw;
            public const string Descending_Thrust_Kinsect_Following_Speed_Multiplier_displayName = "Descending Thrust Kinsect Following Speed Multiplier";
            public const int Descending_Thrust_Kinsect_Following_Speed_Multiplier_sortIndex = 100;
            [SortOrder(Descending_Thrust_Kinsect_Following_Speed_Multiplier_sortIndex)]
            [DisplayName(Descending_Thrust_Kinsect_Following_Speed_Multiplier_displayName)]
            public virtual float Descending_Thrust_Kinsect_Following_Speed_Multiplier {
                get => Descending_Thrust_Kinsect_Following_Speed_Multiplier_raw;
                set {
                    if (Descending_Thrust_Kinsect_Following_Speed_Multiplier_raw == value) return;
                    Descending_Thrust_Kinsect_Following_Speed_Multiplier_raw = value;
                    ChangedItems.Add(nameof(Descending_Thrust_Kinsect_Following_Speed_Multiplier));
                    OnPropertyChanged(nameof(Descending_Thrust_Kinsect_Following_Speed_Multiplier));
                }
            }

            [DisplayName("Offset")]
            public long Descending_Thrust_Kinsect_Following_Speed_Multiplier_offset { get; private set; }

            protected float Unk_184_raw;
            public const string Unk_184_displayName = "Unk 184";
            public const int Unk_184_sortIndex = 150;
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

            protected float Descending_Thrust_Kinsect_Following_Coordinate_Y_Offset_raw;
            public const string Descending_Thrust_Kinsect_Following_Coordinate_Y_Offset_displayName = "Descending Thrust Kinsect Following Coordinate Y Offset";
            public const int Descending_Thrust_Kinsect_Following_Coordinate_Y_Offset_sortIndex = 200;
            [SortOrder(Descending_Thrust_Kinsect_Following_Coordinate_Y_Offset_sortIndex)]
            [DisplayName(Descending_Thrust_Kinsect_Following_Coordinate_Y_Offset_displayName)]
            public virtual float Descending_Thrust_Kinsect_Following_Coordinate_Y_Offset {
                get => Descending_Thrust_Kinsect_Following_Coordinate_Y_Offset_raw;
                set {
                    if (Descending_Thrust_Kinsect_Following_Coordinate_Y_Offset_raw == value) return;
                    Descending_Thrust_Kinsect_Following_Coordinate_Y_Offset_raw = value;
                    ChangedItems.Add(nameof(Descending_Thrust_Kinsect_Following_Coordinate_Y_Offset));
                    OnPropertyChanged(nameof(Descending_Thrust_Kinsect_Following_Coordinate_Y_Offset));
                }
            }

            [DisplayName("Offset")]
            public long Descending_Thrust_Kinsect_Following_Coordinate_Y_Offset_offset { get; private set; }

            protected float Descending_Thrust_Kinsect_Following_Coordinate_Z_Offset_raw;
            public const string Descending_Thrust_Kinsect_Following_Coordinate_Z_Offset_displayName = "Descending Thrust Kinsect Following Coordinate Z Offset";
            public const int Descending_Thrust_Kinsect_Following_Coordinate_Z_Offset_sortIndex = 250;
            [SortOrder(Descending_Thrust_Kinsect_Following_Coordinate_Z_Offset_sortIndex)]
            [DisplayName(Descending_Thrust_Kinsect_Following_Coordinate_Z_Offset_displayName)]
            public virtual float Descending_Thrust_Kinsect_Following_Coordinate_Z_Offset {
                get => Descending_Thrust_Kinsect_Following_Coordinate_Z_Offset_raw;
                set {
                    if (Descending_Thrust_Kinsect_Following_Coordinate_Z_Offset_raw == value) return;
                    Descending_Thrust_Kinsect_Following_Coordinate_Z_Offset_raw = value;
                    ChangedItems.Add(nameof(Descending_Thrust_Kinsect_Following_Coordinate_Z_Offset));
                    OnPropertyChanged(nameof(Descending_Thrust_Kinsect_Following_Coordinate_Z_Offset));
                }
            }

            [DisplayName("Offset")]
            public long Descending_Thrust_Kinsect_Following_Coordinate_Z_Offset_offset { get; private set; }

            public const int lastSortIndex = 300;

            public static ObservableMhwStructCollection<W10p_Params_13_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W10p_Params_13_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W10p_Params_13_ LoadData(BinaryReader reader, ulong i) {
                var data = new W10p_Params_13_();
                data.Index = i;
                data.Unk_182_offset = reader.BaseStream.Position;
                data.Unk_182_raw = reader.ReadSingle();
                data.Descending_Thrust_Kinsect_Following_Speed_Multiplier_offset = reader.BaseStream.Position;
                data.Descending_Thrust_Kinsect_Following_Speed_Multiplier_raw = reader.ReadSingle();
                data.Unk_184_offset = reader.BaseStream.Position;
                data.Unk_184_raw = reader.ReadSingle();
                data.Descending_Thrust_Kinsect_Following_Coordinate_Y_Offset_offset = reader.BaseStream.Position;
                data.Descending_Thrust_Kinsect_Following_Coordinate_Y_Offset_raw = reader.ReadSingle();
                data.Descending_Thrust_Kinsect_Following_Coordinate_Z_Offset_offset = reader.BaseStream.Position;
                data.Descending_Thrust_Kinsect_Following_Coordinate_Z_Offset_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_182_raw);
                writer.Write(Descending_Thrust_Kinsect_Following_Speed_Multiplier_raw);
                writer.Write(Unk_184_raw);
                writer.Write(Descending_Thrust_Kinsect_Following_Coordinate_Y_Offset_raw);
                writer.Write(Descending_Thrust_Kinsect_Following_Coordinate_Z_Offset_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 182", "Unk_182", "Unk_182_offset"),
                    new MultiStructItemCustomView(this, "Descending Thrust Kinsect Following Speed Multiplier", "Descending_Thrust_Kinsect_Following_Speed_Multiplier", "Descending_Thrust_Kinsect_Following_Speed_Multiplier_offset"),
                    new MultiStructItemCustomView(this, "Unk 184", "Unk_184", "Unk_184_offset"),
                    new MultiStructItemCustomView(this, "Descending Thrust Kinsect Following Coordinate Y Offset", "Descending_Thrust_Kinsect_Following_Coordinate_Y_Offset", "Descending_Thrust_Kinsect_Following_Coordinate_Y_Offset_offset"),
                    new MultiStructItemCustomView(this, "Descending Thrust Kinsect Following Coordinate Z Offset", "Descending_Thrust_Kinsect_Following_Coordinate_Z_Offset", "Descending_Thrust_Kinsect_Following_Coordinate_Z_Offset_offset"),
                };
            }
        }

        public partial class Action_Param_Relate_Clutch_Attack_Finish_ : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Action Param (Relate Clutch Attack Finish)";

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

            public static ObservableMhwStructCollection<Action_Param_Relate_Clutch_Attack_Finish_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Action_Param_Relate_Clutch_Attack_Finish_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Action_Param_Relate_Clutch_Attack_Finish_ LoadData(BinaryReader reader, ulong i) {
                var data = new Action_Param_Relate_Clutch_Attack_Finish_();
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

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var W10p_Params_1_Shared__ = new MhwStructDataContainer<W10p_Params_1_Shared_>(W10p_Params_1_Shared_.LoadData(reader), typeof(W10p_Params_1_Shared_));
            data.AddLast(W10p_Params_1_Shared__);
            var Unk_Arr_1_Shared__ = new MhwStructDataContainer<Unk_Arr_1_Shared_>(Unk_Arr_1_Shared_.LoadData(reader), typeof(Unk_Arr_1_Shared_));
            data.AddLast(Unk_Arr_1_Shared__);
            var W10p_Params_2_Shared__ = new MhwStructDataContainer<W10p_Params_2_Shared_>(W10p_Params_2_Shared_.LoadData(reader), typeof(W10p_Params_2_Shared_));
            data.AddLast(W10p_Params_2_Shared__);
            var Guard_Angles_Shared__ = new MhwStructDataContainer<Guard_Angles_Shared_>(Guard_Angles_Shared_.LoadData(reader), typeof(Guard_Angles_Shared_));
            data.AddLast(Guard_Angles_Shared__);
            var W10p_Params_3_Shared__ = new MhwStructDataContainer<W10p_Params_3_Shared_>(W10p_Params_3_Shared_.LoadData(reader), typeof(W10p_Params_3_Shared_));
            data.AddLast(W10p_Params_3_Shared__);
            var Unk_Arr_2_Shared__ = new MhwStructDataContainer<Unk_Arr_2_Shared_>(Unk_Arr_2_Shared_.LoadData(reader), typeof(Unk_Arr_2_Shared_));
            data.AddLast(Unk_Arr_2_Shared__);
            var W10p_Params_4_Shared__ = new MhwStructDataContainer<W10p_Params_4_Shared_>(W10p_Params_4_Shared_.LoadData(reader), typeof(W10p_Params_4_Shared_));
            data.AddLast(W10p_Params_4_Shared__);
            var W10p_Params_5__ = new MhwStructDataContainer<W10p_Params_5_>(W10p_Params_5_.LoadData(reader), typeof(W10p_Params_5_));
            data.AddLast(W10p_Params_5__);
            var Action_Param_Relate_Vault__ = new MhwStructDataContainer<Action_Param_Relate_Vault_>(Action_Param_Relate_Vault_.LoadData(reader), typeof(Action_Param_Relate_Vault_));
            data.AddLast(Action_Param_Relate_Vault__);
            var W10p_Params_6__ = new MhwStructDataContainer<W10p_Params_6_>(W10p_Params_6_.LoadData(reader), typeof(W10p_Params_6_));
            data.AddLast(W10p_Params_6__);
            var Action_Param_Relate_Vault_Dance__ = new MhwStructDataContainer<Action_Param_Relate_Vault_Dance_>(Action_Param_Relate_Vault_Dance_.LoadData(reader), typeof(Action_Param_Relate_Vault_Dance_));
            data.AddLast(Action_Param_Relate_Vault_Dance__);
            var W10p_Params_7__ = new MhwStructDataContainer<W10p_Params_7_>(W10p_Params_7_.LoadData(reader), typeof(W10p_Params_7_));
            data.AddLast(W10p_Params_7__);
            var Action_Param_Relate_Mid_air_Evade__ = new MhwStructDataContainer<Action_Param_Relate_Mid_air_Evade_>(Action_Param_Relate_Mid_air_Evade_.LoadData(reader), typeof(Action_Param_Relate_Mid_air_Evade_));
            data.AddLast(Action_Param_Relate_Mid_air_Evade__);
            var W10p_Params_8__ = new MhwStructDataContainer<W10p_Params_8_>(W10p_Params_8_.LoadData(reader), typeof(W10p_Params_8_));
            data.AddLast(W10p_Params_8__);
            var Action_Param_Relate_Jumping_Attacks__ = new MhwStructDataContainer<Action_Param_Relate_Jumping_Attacks_>(Action_Param_Relate_Jumping_Attacks_.LoadData(reader), typeof(Action_Param_Relate_Jumping_Attacks_));
            data.AddLast(Action_Param_Relate_Jumping_Attacks__);
            var W10p_Params_9__ = new MhwStructDataContainer<W10p_Params_9_>(W10p_Params_9_.LoadData(reader), typeof(W10p_Params_9_));
            data.AddLast(W10p_Params_9__);
            var Action_Param_Relate_Wall_Vault_Wall_Opposite_Vault_White_Extract_or_Not__ = new MhwStructDataContainer<Action_Param_Relate_Wall_Vault_Wall_Opposite_Vault_White_Extract_or_Not_>(Action_Param_Relate_Wall_Vault_Wall_Opposite_Vault_White_Extract_or_Not_.LoadData(reader), typeof(Action_Param_Relate_Wall_Vault_Wall_Opposite_Vault_White_Extract_or_Not_));
            data.AddLast(Action_Param_Relate_Wall_Vault_Wall_Opposite_Vault_White_Extract_or_Not__);
            var W10p_Params_10__ = new MhwStructDataContainer<W10p_Params_10_>(W10p_Params_10_.LoadData(reader), typeof(W10p_Params_10_));
            data.AddLast(W10p_Params_10__);
            var Kinsect_Stats_ = new MhwStructDataContainer<Kinsect_Stats>(Kinsect_Stats.LoadData(reader), typeof(Kinsect_Stats));
            data.AddLast(Kinsect_Stats_);
            var W10p_Params_11__ = new MhwStructDataContainer<W10p_Params_11_>(W10p_Params_11_.LoadData(reader), typeof(W10p_Params_11_));
            data.AddLast(W10p_Params_11__);
            var Unk_Arr_4_All_sint8__ = new MhwStructDataContainer<Unk_Arr_4_All_sint8_>(Unk_Arr_4_All_sint8_.LoadData(reader), typeof(Unk_Arr_4_All_sint8_));
            data.AddLast(Unk_Arr_4_All_sint8__);
            var W10p_Params_12__ = new MhwStructDataContainer<W10p_Params_12_>(W10p_Params_12_.LoadData(reader), typeof(W10p_Params_12_));
            data.AddLast(W10p_Params_12__);
            var Unk_Arr_5_All_sint8__ = new MhwStructDataContainer<Unk_Arr_5_All_sint8_>(Unk_Arr_5_All_sint8_.LoadData(reader), typeof(Unk_Arr_5_All_sint8_));
            data.AddLast(Unk_Arr_5_All_sint8__);
            var W10p_Params_13__ = new MhwStructDataContainer<W10p_Params_13_>(W10p_Params_13_.LoadData(reader), typeof(W10p_Params_13_));
            data.AddLast(W10p_Params_13__);
            var Action_Param_Relate_Clutch_Attack_Finish__ = new MhwStructDataContainer<Action_Param_Relate_Clutch_Attack_Finish_>(Action_Param_Relate_Clutch_Attack_Finish_.LoadData(reader), typeof(Action_Param_Relate_Clutch_Attack_Finish_));
            data.AddLast(Action_Param_Relate_Clutch_Attack_Finish__);
        }
    }
}