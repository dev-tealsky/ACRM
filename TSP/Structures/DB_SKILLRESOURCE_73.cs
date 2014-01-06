using System;
using System.IO;
using System.Reflection;

namespace ACRM
{
    public class DB_SKILLRESOURCE_73
    {
        public Int32 id { get; set; }
        public Int32 text_id { get; set; }
        public Byte desc_id { get; set; }
        public Int32 tooltip_id { get; set; }
        public Byte is_valid { get; set; }
        public Byte elemental { get; set; }
        public Byte is_passive { get; set; }
        public Byte is_physical_act { get; set; }
        public Byte is_harmful { get; set; }
        public Byte is_need_target { get; set; }
        public Byte is_corpse { get; set; }
        public Byte is_toggle { get; set; }
        public Int32 toggle_group { get; set; }
        public Byte casting_type { get; set; }
        public Byte casting_level { get; set; }
        public Int32 cast_range { get; set; }
        public Int32 valid_range { get; set; }
        public Int32 cost_hp { get; set; }
        public Int32 cost_hp_per_skl { get; set; }
        public Int32 cost_mp { get; set; }
        public Int32 cost_mp_per_skl { get; set; }
        public Int32 cost_mp_per_enhance { get; set; }
        public Single cost_hp_per { get; set; }
        public Single cost_hp_per_skl_per { get; set; }
        public Single cost_mp_per { get; set; }
        public Single cost_mp_per_skl_per { get; set; }
        public Int32 cost_havoc { get; set; }
        public Int32 cost_havoc_per_skl { get; set; }
        public Int32 cost_energy { get; set; }
        public Int32 cost_energy_per_skl { get; set; }
        public Int32 cost_exp { get; set; }
        public Int32 cost_exp_per_enhance { get; set; }
        public Int32 cost_jp { get; set; }
        public Int32 cost_jp_per_enhance { get; set; }
        public Int32 cost_item { get; set; }
        public Int32 cost_item_count { get; set; }
        public Int32 cost_item_count_per_skl { get; set; }
        public Int32 need_level { get; set; }
        public Int32 need_hp { get; set; }
        public Int32 need_mp { get; set; }
        public Int32 need_havoc { get; set; }
        public Int32 need_havoc_burst { get; set; }
        public Int32 need_state_id { get; set; }
        public Byte need_state_level { get; set; }
        public Byte need_state_exhaust { get; set; }
        public Byte vf_one_hand_sword { get; set; }
        public Byte vf_two_hand_sword { get; set; }
        public Byte vf_double_sword { get; set; }
        public Byte vf_dagger { get; set; }
        public Byte vf_double_dagger { get; set; }
        public Byte vf_spear { get; set; }
        public Byte vf_axe { get; set; }
        public Byte vf_one_hand_axe { get; set; }
        public Byte vf_double_axe { get; set; }
        public Byte vf_one_hand_mace { get; set; }
        public Byte vf_two_hand_mace { get; set; }
        public Byte vf_lightbow { get; set; }
        public Byte vf_heavybow { get; set; }
        public Byte vf_crossbow { get; set; }
        public Byte vf_one_hand_staff { get; set; }
        public Byte vf_two_hand_staff { get; set; }
        public Byte vf_shield_only { get; set; }
        public Byte vf_is_not_need_weapon { get; set; }
        public Decimal delay_cast { get; set; }
        public Decimal delay_cast_per_skl { get; set; }
        public Decimal delay_cast_mode_per_enhance { get; set; }
        public Decimal delay_common { get; set; }
        public Decimal delay_cooltime { get; set; }
        public Decimal delay_cooltime_per_skl { get; set; }
        public Single delay_cooltime_mode_per_enhance { get; set; }
        public Int32 cool_time_group_id { get; set; }
        public Byte uf_self { get; set; }
        public Byte uf_party { get; set; }
        public Byte uf_guild { get; set; }
        public Byte uf_neutral { get; set; }
        public Byte uf_purple { get; set; }
        public Byte uf_enemy { get; set; }
        public Byte tf_avatar { get; set; }
        public Byte tf_summon { get; set; }
        public Byte tf_monster { get; set; }
        public Int32 skill_lvup_limit { get; set; }
        public Int16 target { get; set; }
        public Int16 effect_type { get; set; }
        public Int32 skill_enchant_link_id { get; set; }
        public Int32 state_id { get; set; }
        public Int32 state_level_base { get; set; }
        public Single state_level_per_skl { get; set; }
        public Single state_level_per_enhance { get; set; }
        public Decimal state_second { get; set; }
        public Decimal state_second_per_level { get; set; }
        public Decimal state_second_per_enhance { get; set; }
        public Int32 probability_on_hit { get; set; }
        public Int32 probability_inc_by_slv { get; set; }
        public Int16 hit_bonus { get; set; }
        public Int16 hit_bonus_per_enhance { get; set; }
        public Int16 percentage { get; set; }
        public Decimal hate_mod { get; set; }
        public Int16 hate_basic { get; set; }
        public Decimal hate_per_skl { get; set; }
        public Decimal hate_per_enhance { get; set; }
        public Byte critical_bonus { get; set; }
        public Byte critical_bonus_per_skl { get; set; }
        public Decimal var1 { get; set; }
        public Decimal var2 { get; set; }
        public Decimal var3 { get; set; }
        public Decimal var4 { get; set; }
        public Decimal var5 { get; set; }
        public Decimal var6 { get; set; }
        public Decimal var7 { get; set; }
        public Decimal var8 { get; set; }
        public Decimal var9 { get; set; }
        public Decimal var10 { get; set; }
        public Decimal var11 { get; set; }
        public Decimal var12 { get; set; }
        public Decimal var13 { get; set; }
        public Decimal var14 { get; set; }
        public Decimal var15 { get; set; }
        public Decimal var16 { get; set; }
        public Decimal var17 { get; set; }
        public Decimal var18 { get; set; }
        public Decimal var19 { get; set; }
        public Decimal var20 { get; set; }
        public Int32 icon_id { get; set; }
        public String icon_file_name { get; set; }
        public Byte is_projectile { get; set; }
        public Decimal projectile_speed { get; set; }
        public Decimal projectile_acceleration { get; set; }
        public Int32 jp_01 { get; set; }
        public Int32 jp_02 { get; set; }
        public Int32 jp_03 { get; set; }
        public Int32 jp_04 { get; set; }
        public Int32 jp_05 { get; set; }
        public Int32 jp_06 { get; set; }
        public Int32 jp_07 { get; set; }
        public Int32 jp_08 { get; set; }
        public Int32 jp_09 { get; set; }
        public Int32 jp_10 { get; set; }
        public Int32 jp_11 { get; set; }
        public Int32 jp_12 { get; set; }
        public Int32 jp_13 { get; set; }
        public Int32 jp_14 { get; set; }
        public Int32 jp_15 { get; set; }
        public Int32 jp_16 { get; set; }
        public Int32 jp_17 { get; set; }
        public Int32 jp_18 { get; set; }
        public Int32 jp_19 { get; set; }
        public Int32 jp_20 { get; set; }
        public Int32 jp_21 { get; set; }
        public Int32 jp_22 { get; set; }
        public Int32 jp_23 { get; set; }
        public Int32 jp_24 { get; set; }
        public Int32 jp_25 { get; set; }
        public Int32 jp_26 { get; set; }
        public Int32 jp_27 { get; set; }
        public Int32 jp_28 { get; set; }
        public Int32 jp_29 { get; set; }
        public Int32 jp_30 { get; set; }
        public Int32 jp_31 { get; set; }
        public Int32 jp_32 { get; set; }
        public Int32 jp_33 { get; set; }
        public Int32 jp_34 { get; set; }
        public Int32 jp_35 { get; set; }
        public Int32 jp_36 { get; set; }
        public Int32 jp_37 { get; set; }
        public Int32 jp_38 { get; set; }
        public Int32 jp_39 { get; set; }
        public Int32 jp_40 { get; set; }
        public Int32 jp_41 { get; set; }
        public Int32 jp_42 { get; set; }
        public Int32 jp_43 { get; set; }
        public Int32 jp_44 { get; set; }
        public Int32 jp_45 { get; set; }
        public Int32 jp_46 { get; set; }
        public Int32 jp_47 { get; set; }
        public Int32 jp_48 { get; set; }
        public Int32 jp_49 { get; set; }
        public Int32 jp_50 { get; set; }

        public void ReadFile(BinaryReader br)
        {
            this.id = br.ReadInt32();
            this.text_id = br.ReadInt32();
            this.is_valid = br.ReadByte();
            this.elemental = br.ReadByte();
            this.is_passive = br.ReadByte();
            this.is_physical_act = br.ReadByte();
            this.is_harmful = br.ReadByte();
            this.is_need_target = br.ReadByte();
            this.is_corpse = br.ReadByte();
            this.is_toggle = br.ReadByte();
            this.casting_type = br.ReadByte();
            this.casting_level = br.ReadByte();
            this.toggle_group = br.ReadInt32();
            this.cast_range = br.ReadInt32();
            this.valid_range = br.ReadInt32();
            this.cost_hp = br.ReadInt32();
            this.cost_hp_per_skl = br.ReadInt32();
            this.cost_mp = br.ReadInt32();
            this.cost_mp_per_skl = br.ReadInt32();
            this.cost_mp_per_enhance = br.ReadInt32();
            this.cost_hp_per = br.ReadSingle();
            this.cost_hp_per_skl_per = br.ReadSingle();
            this.cost_mp_per = br.ReadSingle();
            this.cost_mp_per_skl_per = br.ReadSingle();
            this.cost_havoc = br.ReadInt32();
            this.cost_havoc_per_skl = br.ReadInt32();
            this.cost_energy = br.ReadInt32();
            this.cost_energy_per_skl = br.ReadInt32();
            this.cost_exp = br.ReadInt32();
            this.cost_exp_per_enhance = br.ReadInt32();
            this.cost_jp = br.ReadInt32();
            this.cost_jp_per_enhance = br.ReadInt32();
            this.cost_item = br.ReadInt32();
            this.cost_item_count = br.ReadInt32();
            this.cost_item_count_per_skl = br.ReadInt32();
            this.need_level = br.ReadInt32();
            this.need_hp = br.ReadInt32();
            this.need_mp = br.ReadInt32();
            this.need_havoc = br.ReadInt32();
            this.need_havoc_burst = br.ReadInt32();
            this.need_state_id = br.ReadInt32();
            this.need_state_level = br.ReadByte();
            this.need_state_exhaust = br.ReadByte();
            this.vf_one_hand_sword = br.ReadByte();
            this.vf_two_hand_sword = br.ReadByte();
            this.vf_double_sword = br.ReadByte();
            this.vf_dagger = br.ReadByte();
            this.vf_double_dagger = br.ReadByte();
            this.vf_spear = br.ReadByte();
            this.vf_axe = br.ReadByte();
            this.vf_one_hand_axe = br.ReadByte();
            this.vf_double_axe = br.ReadByte();
            this.vf_one_hand_mace = br.ReadByte();
            this.vf_two_hand_mace = br.ReadByte();
            this.vf_lightbow = br.ReadByte();
            this.vf_heavybow = br.ReadByte();
            this.vf_crossbow = br.ReadByte();
            this.vf_one_hand_staff = br.ReadByte();
            this.vf_two_hand_staff = br.ReadByte();
            this.vf_shield_only = br.ReadByte();
            this.vf_is_not_need_weapon = br.ReadByte();
            this.delay_cast = Convert.ToDecimal(br.ReadInt32()) / 100;
            this.delay_cast_per_skl = Convert.ToDecimal(br.ReadInt32()) / 100;
            this.delay_cast_mode_per_enhance = Convert.ToDecimal(br.ReadSingle());
            this.delay_common = Convert.ToDecimal(br.ReadInt32()) / 100;
            this.delay_cooltime = Convert.ToDecimal(br.ReadInt32()) / 100;
            this.delay_cooltime_per_skl = Convert.ToDecimal(br.ReadInt32() / 100);
            this.delay_cooltime_mode_per_enhance = br.ReadSingle();
            this.cool_time_group_id = br.ReadInt32();
            this.uf_self = br.ReadByte();
            this.uf_party = br.ReadByte();
            this.uf_guild = br.ReadByte();
            this.uf_neutral = br.ReadByte();
            this.uf_purple = br.ReadByte();
            this.uf_enemy = br.ReadByte();
            this.tf_avatar = br.ReadByte();
            this.tf_summon = br.ReadByte();
            this.tf_monster = br.ReadByte();
            this.skill_lvup_limit = br.ReadInt32();
            this.target = br.ReadInt16();
            this.effect_type = br.ReadInt16();
            this.skill_enchant_link_id = br.ReadInt32();
            this.state_id = br.ReadInt32();
            this.state_level_base = br.ReadInt32();
            this.state_level_per_skl = br.ReadSingle();
            this.state_level_per_enhance = br.ReadSingle();
            this.state_second = Convert.ToDecimal(br.ReadInt32()) / 100;
            this.state_second_per_level = Convert.ToDecimal(br.ReadInt32()) / 100;
            this.state_second_per_enhance = Convert.ToDecimal(br.ReadInt32()) / 100;
            this.probability_on_hit = br.ReadInt32();
            this.probability_inc_by_slv = br.ReadInt32();
            this.hit_bonus = br.ReadInt16();
            this.hit_bonus_per_enhance = br.ReadInt16();
            this.percentage = br.ReadInt16();
            this.hate_mod = Convert.ToDecimal(br.ReadSingle());
            this.hate_basic = br.ReadInt16();
            this.hate_per_skl = Convert.ToDecimal(br.ReadSingle());
            this.hate_per_enhance = Convert.ToDecimal(br.ReadSingle());
            br.ReadBytes(10);
            this.var1 = Convert.ToDecimal(br.ReadSingle());
            this.var2 = Convert.ToDecimal(br.ReadSingle());
            this.var3 = Convert.ToDecimal(br.ReadSingle());
            this.var4 = Convert.ToDecimal(br.ReadSingle());
            this.var5 = Convert.ToDecimal(br.ReadSingle());
            this.var6 = Convert.ToDecimal(br.ReadSingle());
            this.var7 = Convert.ToDecimal(br.ReadSingle());
            this.var8 = Convert.ToDecimal(br.ReadSingle());
            this.var9 = Convert.ToDecimal(br.ReadSingle());
            this.var10 = Convert.ToDecimal(br.ReadSingle());
            this.var11 = Convert.ToDecimal(br.ReadSingle());
            this.var12 = Convert.ToDecimal(br.ReadSingle());
            this.var13 = Convert.ToDecimal(br.ReadSingle());
            this.var14 = Convert.ToDecimal(br.ReadSingle());
            this.var15 = Convert.ToDecimal(br.ReadSingle());
            this.var16 = Convert.ToDecimal(br.ReadSingle());
            this.var17 = Convert.ToDecimal(br.ReadSingle());
            this.var18 = Convert.ToDecimal(br.ReadSingle());
            this.var19 = Convert.ToDecimal(br.ReadSingle());
            this.var20 = Convert.ToDecimal(br.ReadSingle());
            this.jp_01 = br.ReadInt32();
            this.jp_02 = br.ReadInt32();
            this.jp_03 = br.ReadInt32();
            this.jp_04 = br.ReadInt32();
            this.jp_05 = br.ReadInt32();
            this.jp_06 = br.ReadInt32();
            this.jp_07 = br.ReadInt32();
            this.jp_08 = br.ReadInt32();
            this.jp_09 = br.ReadInt32();
            this.jp_10 = br.ReadInt32();
            this.jp_11 = br.ReadInt32();
            this.jp_12 = br.ReadInt32();
            this.jp_13 = br.ReadInt32();
            this.jp_14 = br.ReadInt32();
            this.jp_15 = br.ReadInt32();
            this.jp_16 = br.ReadInt32();
            this.jp_17 = br.ReadInt32();
            this.jp_18 = br.ReadInt32();
            this.jp_19 = br.ReadInt32();
            this.jp_20 = br.ReadInt32();
            this.jp_21 = br.ReadInt32();
            this.jp_22 = br.ReadInt32();
            this.jp_23 = br.ReadInt32();
            this.jp_24 = br.ReadInt32();
            this.jp_25 = br.ReadInt32();
            this.jp_26 = br.ReadInt32();
            this.jp_27 = br.ReadInt32();
            this.jp_28 = br.ReadInt32();
            this.jp_29 = br.ReadInt32();
            this.jp_30 = br.ReadInt32();
            this.jp_31 = br.ReadInt32();
            this.jp_32 = br.ReadInt32();
            this.jp_33 = br.ReadInt32();
            this.jp_34 = br.ReadInt32();
            this.jp_35 = br.ReadInt32();
            this.jp_36 = br.ReadInt32();
            this.jp_37 = br.ReadInt32();
            this.jp_38 = br.ReadInt32();
            this.jp_39 = br.ReadInt32();
            this.jp_40 = br.ReadInt32();
            this.jp_41 = br.ReadInt32();
            this.jp_42 = br.ReadInt32();
            this.jp_43 = br.ReadInt32();
            this.jp_44 = br.ReadInt32();
            this.jp_45 = br.ReadInt32();
            this.jp_46 = br.ReadInt32();
            this.jp_47 = br.ReadInt32();
            this.jp_48 = br.ReadInt32();
            this.jp_49 = br.ReadInt32();
            this.jp_50 = br.ReadInt32();
            this.desc_id = br.ReadByte();
            this.tooltip_id = br.ReadInt32();
            this.icon_id = br.ReadInt32();
            this.icon_file_name = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.is_projectile = br.ReadByte();
            this.projectile_speed = Convert.ToDecimal(br.ReadSingle());
            this.projectile_acceleration = Convert.ToDecimal(br.ReadSingle());
        }

        public void SaveFile(BinaryWriter bw)
        {
            bw.Write(this.id);
            bw.Write(this.text_id);
            bw.Write(this.is_valid);
            bw.Write(this.elemental);
            bw.Write(this.is_passive);
            bw.Write(this.is_physical_act);
            bw.Write(this.is_harmful);
            bw.Write(this.is_need_target);
            bw.Write(this.is_corpse);
            bw.Write(this.is_toggle);
            bw.Write(this.casting_type);
            bw.Write(this.casting_level);
            bw.Write(this.toggle_group);
            bw.Write(this.cast_range);
            bw.Write(this.valid_range);
            bw.Write(this.cost_hp);
            bw.Write(this.cost_hp_per_skl);
            bw.Write(this.cost_mp);
            bw.Write(this.cost_mp_per_skl);
            bw.Write(this.cost_mp_per_enhance);
            bw.Write(this.cost_hp_per);
            bw.Write(this.cost_hp_per_skl_per);
            bw.Write(this.cost_mp_per);
            bw.Write(this.cost_mp_per_skl_per);
            bw.Write(this.cost_havoc);
            bw.Write(this.cost_havoc_per_skl);
            bw.Write(this.cost_energy);
            bw.Write(this.cost_energy_per_skl);
            bw.Write(this.cost_exp);
            bw.Write(this.cost_exp_per_enhance);
            bw.Write(this.cost_jp);
            bw.Write(this.cost_jp_per_enhance);
            bw.Write(this.cost_item);
            bw.Write(this.cost_item_count);
            bw.Write(this.cost_item_count_per_skl);
            bw.Write(this.need_level);
            bw.Write(this.need_hp);
            bw.Write(this.need_mp);
            bw.Write(this.need_havoc);
            bw.Write(this.need_havoc_burst);
            bw.Write(this.need_state_id);
            bw.Write(this.need_state_level);
            bw.Write(this.need_state_exhaust);
            bw.Write(this.vf_one_hand_sword);
            bw.Write(this.vf_two_hand_sword);
            bw.Write(this.vf_double_sword);
            bw.Write(this.vf_dagger);
            bw.Write(this.vf_double_dagger);
            bw.Write(this.vf_spear);
            bw.Write(this.vf_axe);
            bw.Write(this.vf_one_hand_axe);
            bw.Write(this.vf_double_axe);
            bw.Write(this.vf_one_hand_mace);
            bw.Write(this.vf_two_hand_mace);
            bw.Write(this.vf_lightbow);
            bw.Write(this.vf_heavybow);
            bw.Write(this.vf_crossbow);
            bw.Write(this.vf_one_hand_staff);
            bw.Write(this.vf_two_hand_staff);
            bw.Write(this.vf_shield_only);
            bw.Write(this.vf_is_not_need_weapon);
            bw.Write(Convert.ToInt32(this.delay_cast * new decimal(100)));
            bw.Write(Convert.ToInt32(this.delay_cast_per_skl * new decimal(100)));
            bw.Write(Convert.ToSingle(this.delay_cast_mode_per_enhance));
            bw.Write(Convert.ToInt32(this.delay_common * new decimal(100)));
            bw.Write(Convert.ToInt32(this.delay_cooltime * new decimal(100)));
            bw.Write(new byte[4]);
            bw.Write(this.delay_cooltime_mode_per_enhance);
            bw.Write(this.cool_time_group_id);
            bw.Write(this.uf_self);
            bw.Write(this.uf_party);
            bw.Write(this.uf_guild);
            bw.Write(this.uf_neutral);
            bw.Write(this.uf_purple);
            bw.Write(this.uf_enemy);
            bw.Write(this.tf_avatar);
            bw.Write(this.tf_summon);
            bw.Write(this.tf_monster);
            bw.Write(this.skill_lvup_limit);
            bw.Write(this.target);
            bw.Write(this.effect_type);
            bw.Write(this.skill_enchant_link_id);
            bw.Write(this.state_id);
            bw.Write(this.state_level_base);
            bw.Write(this.state_level_per_skl);
            bw.Write(this.state_level_per_enhance);
            bw.Write(Convert.ToInt32(this.state_second * 100));
            bw.Write(Convert.ToInt32(this.state_second_per_level * 100));
            bw.Write(Convert.ToInt32(this.state_second_per_enhance * 100));
            bw.Write(this.probability_on_hit);
            bw.Write(this.probability_inc_by_slv);
            bw.Write(this.hit_bonus);
            bw.Write(this.hit_bonus_per_enhance);
            bw.Write(this.percentage);
            bw.Write(Convert.ToSingle(this.hate_mod));
            bw.Write(this.hate_basic);
            bw.Write(Convert.ToSingle(this.hate_per_skl));
            bw.Write(Convert.ToSingle(this.hate_per_enhance));
            bw.Write(Convert.ToInt32(1634271232));
            bw.Write(new Byte[6]);
            bw.Write(Convert.ToSingle(this.var1));
            bw.Write(Convert.ToSingle(this.var2));
            bw.Write(Convert.ToSingle(this.var3));
            bw.Write(Convert.ToSingle(this.var4));
            bw.Write(Convert.ToSingle(this.var5));
            bw.Write(Convert.ToSingle(this.var6));
            bw.Write(Convert.ToSingle(this.var7));
            bw.Write(Convert.ToSingle(this.var8));
            bw.Write(Convert.ToSingle(this.var9));
            bw.Write(Convert.ToSingle(this.var10));
            bw.Write(Convert.ToSingle(this.var11));
            bw.Write(Convert.ToSingle(this.var12));
            bw.Write(Convert.ToSingle(this.var13));
            bw.Write(Convert.ToSingle(this.var14));
            bw.Write(Convert.ToSingle(this.var15));
            bw.Write(Convert.ToSingle(this.var16));
            bw.Write(Convert.ToSingle(this.var17));
            bw.Write(Convert.ToSingle(this.var18));
            bw.Write(Convert.ToSingle(this.var19));
            bw.Write(Convert.ToSingle(this.var20));
            bw.Write(this.jp_01);
            bw.Write(this.jp_02);
            bw.Write(this.jp_03);
            bw.Write(this.jp_04);
            bw.Write(this.jp_05);
            bw.Write(this.jp_06);
            bw.Write(this.jp_07);
            bw.Write(this.jp_08);
            bw.Write(this.jp_09);
            bw.Write(this.jp_10);
            bw.Write(this.jp_11);
            bw.Write(this.jp_12);
            bw.Write(this.jp_13);
            bw.Write(this.jp_14);
            bw.Write(this.jp_15);
            bw.Write(this.jp_16);
            bw.Write(this.jp_17);
            bw.Write(this.jp_18);
            bw.Write(this.jp_19);
            bw.Write(this.jp_20);
            bw.Write(this.jp_21);
            bw.Write(this.jp_22);
            bw.Write(this.jp_23);
            bw.Write(this.jp_24);
            bw.Write(this.jp_25);
            bw.Write(this.jp_26);
            bw.Write(this.jp_27);
            bw.Write(this.jp_28);
            bw.Write(this.jp_29);
            bw.Write(this.jp_30);
            bw.Write(this.jp_31);
            bw.Write(this.jp_32);
            bw.Write(this.jp_33);
            bw.Write(this.jp_34);
            bw.Write(this.jp_35);
            bw.Write(this.jp_36);
            bw.Write(this.jp_37);
            bw.Write(this.jp_38);
            bw.Write(this.jp_39);
            bw.Write(this.jp_40);
            bw.Write(this.jp_41);
            bw.Write(this.jp_42);
            bw.Write(this.jp_43);
            bw.Write(this.jp_44);
            bw.Write(this.jp_45);
            bw.Write(this.jp_46);
            bw.Write(this.jp_47);
            bw.Write(this.jp_48);
            bw.Write(this.jp_49);
            bw.Write(this.jp_50);
            bw.Write(this.desc_id);
            bw.Write(this.tooltip_id);
            bw.Write(this.icon_id);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.icon_file_name));
            bw.Write(new byte[256 - this.icon_file_name.Length]);
            bw.Write(this.is_projectile);
            bw.Write(Convert.ToSingle(this.projectile_speed));
            bw.Write(Convert.ToSingle(this.projectile_acceleration));
        }

        public string ToDatabase()
        {
            string skill_db = "INSERT [dbo].[SkillResource] ([id], [text_id], [desc_id], [tooltip_id], [is_valid], [elemental], [is_passive], [is_physical_act], [is_harmful], [is_need_target], [is_corpse], [is_toggle], [toggle_group], [casting_type], [casting_level], [cast_range], [valid_range], [cost_hp], [cost_hp_per_skl], [cost_mp], [cost_mp_per_skl], [cost_mp_per_enhance], [cost_hp_per], [cost_hp_per_skl_per], [cost_mp_per], [cost_mp_per_skl_per], [cost_havoc], [cost_havoc_per_skl], [cost_energy], [cost_energy_per_skl], [cost_exp], [cost_exp_per_enhance], [cost_jp], [cost_jp_per_enhance], [cost_item], [cost_item_count], [cost_item_count_per_skl], [need_level], [need_hp], [need_mp], [need_havoc], [need_havoc_burst], [need_state_id], [need_state_level], [need_state_exhaust], [vf_one_hand_sword], [vf_two_hand_sword], [vf_double_sword], [vf_dagger], [vf_double_dagger], [vf_spear], [vf_axe], [vf_one_hand_axe], [vf_double_axe], [vf_one_hand_mace], [vf_two_hand_mace], [vf_lightbow], [vf_heavybow], [vf_crossbow], [vf_one_hand_staff], [vf_two_hand_staff], [vf_shield_only], [vf_is_not_need_weapon], [delay_cast], [delay_cast_per_skl], [delay_cast_mode_per_enhance], [delay_common], [delay_cooltime], [delay_cooltime_per_skl], [delay_cooltime_mode_per_enhance], [cool_time_group_id], [uf_self], [uf_party], [uf_guild], [uf_neutral], [uf_purple], [uf_enemy], [tf_avatar], [tf_summon], [tf_monster], [skill_lvup_limit], [target], [effect_type], [skill_enchant_link_id], [state_id], [state_level_base], [state_level_per_skl], [state_level_per_enhance], [state_second], [state_second_per_level], [state_second_per_enhance], [probability_on_hit], [probability_inc_by_slv], [hit_bonus], [hit_bonus_per_enhance], [percentage], [hate_mod], [hate_basic], [hate_per_skl], [hate_per_enhance], [critical_bonus], [critical_bonus_per_skl], [var1], [var2], [var3], [var4], [var5], [var6], [var7], [var8], [var9], [var10], [var11], [var12], [var13], [var14], [var15], [var16], [var17], [var18], [var19], [var20], [icon_id], [icon_file_name], [is_projectile], [projectile_speed], [projectile_acceleration]) VALUES ( @Pid, @Ptext_id, @Pdesc_id, @Ptooltip_id, @Pis_valid, @Pelemental, @Pis_passive, @Pis_physical_act, @Pis_harmful, @Pis_need_target, @Pis_corpse, @Pis_toggle, @Ptoggle_group, @Pcasting_type, @Pcasting_level, @Pcast_range, @Pvalid_range, @Pcost_hp, @Pcost_hp_per_skl, @Pcost_mp, @Pcost_mp_per_skl, @Pcost_mp_per_enhance, @Pcost_hp_per, @Pcost_hp_per_skl_per, @Pcost_mp_per, @Pcost_mp_per_skl_per, @Pcost_havoc, @Pcost_havoc_per_skl, @Pcost_energy, @Pcost_energy_per_skl, @Pcost_exp, @Pcost_exp_per_enhance, @Pcost_jp, @Pcost_jp_per_enhance, @Pcost_item, @Pcost_item_count, @Pcost_item_count_per_skl, @Pneed_level, @Pneed_hp, @Pneed_mp, @Pneed_havoc, @Pneed_havoc_burst, @Pneed_state_id, @Pneed_state_level, @Pneed_state_exhaust, @Pvf_one_hand_sword, @Pvf_two_hand_sword, @Pvf_double_sword, @Pvf_dagger, @Pvf_double_dagger, @Pvf_spear, @Pvf_axe, @Pvf_one_hand_axe, @Pvf_double_axe, @Pvf_one_hand_mace, @Pvf_two_hand_mace, @Pvf_lightbow, @Pvf_heavybow, @Pvf_crossbow, @Pvf_one_hand_staff, @Pvf_two_hand_staff, @Pvf_shield_only, @Pvf_is_not_need_weapon, @Pdelay_cast, @Pdelay_cast_per_skl, @Pdelay_cast_mode_per_enhance, @Pdelay_common, @Pdelay_cooltime, @Pdelay_cooltime_per_skl, @Pdelay_cooltime_mode_per_enhance, @Pcool_time_group_id, @Puf_self, @Puf_party, @Puf_guild, @Puf_neutral, @Puf_purple, @Puf_enemy, @Ptf_avatar, @Ptf_summon, @Ptf_monster, @Pskill_lvup_limit, @Ptarget, @Peffect_type, @Pskill_enchant_link_id, @Pstate_id, @Pstate_level_base, @Pstate_level_per_skl, @Pstate_level_per_enhance, @Pstate_second, @Pstate_second_per_level, @Pstate_second_per_enhance, @Pprobability_on_hit, @Pprobability_inc_by_slv, @Phit_bonus, @Phit_bonus_per_enhance, @Ppercentage, @Phate_mod, @Phate_basic, @Phate_per_skl, @Phate_per_enhance, @Pcritical_bonus, @Pcritical_bonus_per_skl, @Pvar1, @Pvar2, @Pvar3, @Pvar4, @Pvar5, @Pvar6, @Pvar7, @Pvar8, @Pvar9, @Pvar10, @Pvar11, @Pvar12, @Pvar13, @Pvar14, @Pvar15, @Pvar16, @Pvar17, @Pvar18, @Pvar19, @Pvar20, @Picon_id, @Picon_file_name, @Pis_projectile, @Pprojectile_speed, @Pprojectile_acceleration )";
            string skill_jp_db = "INSERT [dbo].[SkillJPResource] ([skill_id], [jp_01], [jp_02], [jp_03], [jp_04], [jp_05], [jp_06], [jp_07], [jp_08], [jp_09], [jp_10], [jp_11], [jp_12], [jp_13], [jp_14], [jp_15], [jp_16], [jp_17], [jp_18], [jp_19], [jp_20], [jp_21], [jp_22], [jp_23], [jp_24], [jp_25], [jp_26], [jp_27], [jp_28], [jp_29], [jp_30], [jp_31], [jp_32], [jp_33], [jp_34], [jp_35], [jp_36], [jp_37], [jp_38], [jp_39], [jp_40], [jp_41], [jp_42], [jp_43], [jp_44], [jp_45], [jp_46], [jp_47], [jp_48], [jp_49], [jp_50]) VALUES ( @Pid, @Pjp_01, @Pjp_02, @Pjp_03, @Pjp_04, @Pjp_05, @Pjp_06, @Pjp_07, @Pjp_08, @Pjp_09, @Pjp_10, @Pjp_11, @Pjp_12, @Pjp_13, @Pjp_14, @Pjp_15, @Pjp_16, @Pjp_17, @Pjp_18, @Pjp_19, @Pjp_20, @Pjp_21, @Pjp_22, @Pjp_23, @Pjp_24, @Pjp_25, @Pjp_26, @Pjp_27, @Pjp_28, @Pjp_29, @Pjp_30, @Pjp_31, @Pjp_32, @Pjp_33, @Pjp_34, @Pjp_35, @Pjp_36, @Pjp_37, @Pjp_38, @Pjp_39, @Pjp_40, @Pjp_41, @Pjp_42, @Pjp_43, @Pjp_44, @Pjp_45, @Pjp_46, @Pjp_47, @Pjp_48, @Pjp_49, @Pjp_50 )";
            return skill_db + skill_jp_db;
        }

        public static String FromDatabase()
        {
            String rString = "SELECT ";
            foreach (FieldInfo fieldInfo in typeof(DB_SKILLRESOURCE_73).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
            {
                rString += string.Format("[{0}], ", fieldInfo.Name.Substring(1, fieldInfo.Name.IndexOf('>') - 1));
            }
            return rString.Substring(0, rString.Length - 2) + " FROM SkillResource SRES LEFT JOIN SKillJPResource JPRES ON JPRES.skill_id = SRES.id  ORDER BY SRES.id";
        }

        public void FromDatabaseExecute(System.Data.SqlClient.SqlDataReader drExecute)
        {
            foreach (FieldInfo fieldInfo in typeof(DB_SKILLRESOURCE_73).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
            {
                String sTempName = null;
                sTempName = fieldInfo.Name.Substring(1, fieldInfo.Name.IndexOf('>') - 1);

                if (!Convert.IsDBNull(drExecute[sTempName]))
                {
                    if (fieldInfo.FieldType == typeof(String))
                    {
                        fieldInfo.SetValue(this, drExecute[sTempName].ToString());
                    }
                    else if (fieldInfo.FieldType == typeof(Int16))
                    {
                        fieldInfo.SetValue(this, Convert.ToInt16(drExecute[sTempName]));
                    }
                    else if (fieldInfo.FieldType == typeof(Int32))
                    {
                        fieldInfo.SetValue(this, Convert.ToInt32(drExecute[sTempName]));
                    }
                    else if (fieldInfo.FieldType == typeof(Single))
                    {
                        fieldInfo.SetValue(this, Convert.ToSingle(drExecute[sTempName]));
                    }
                    else if (fieldInfo.FieldType == typeof(Decimal))
                    {
                        fieldInfo.SetValue(this, Convert.ToDecimal(drExecute[sTempName]));
                    }
                    else if (fieldInfo.FieldType == typeof(Double))
                    {
                        fieldInfo.SetValue(this, Convert.ToDouble(drExecute[sTempName]));
                    }
                    else if (fieldInfo.FieldType == typeof(Byte))
                    {
                        fieldInfo.SetValue(this, Convert.ToByte(drExecute[sTempName]));
                    }
                }
            }
        }
    }

}
