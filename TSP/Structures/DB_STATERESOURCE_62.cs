using System;
using System.IO;
using System.Reflection;

namespace ACRM
{
    public class DB_STATERESOURCE_62
    {
        public Int32 state_id { get; set; }
        public Int32 text_id { get; set; }
        public Int32 tooltip_id { get; set; }
        public Int32 is_harmful { get; set; }
        public Int32 state_time_type { get; set; }
        public Int32 state_group { get; set; }
        public Int32 duplicate_group_1 { get; set; }
        public Int32 duplicate_group_2 { get; set; }
        public Int32 duplicate_group_3 { get; set; }
        public Byte uf_avatar { get; set; }
        public Byte uf_summon { get; set; }
        public Byte uf_monster { get; set; }
        public Byte reiteration_count { get; set; }
        public Int32 base_effect_id { get; set; }
        public Int32 fire_interval { get; set; }
        public Int32 elemental_type { get; set; }
        public Single amplify_base { get; set; }
        public Single amplify_per_skl { get; set; }
        public Int32 add_damage_base { get; set; }
        public Int32 add_damage_per_skl { get; set; }
        public Int32 effect_type { get; set; }
        public Double value_0 { get; set; }
        public Double value_1 { get; set; }
        public Double value_2 { get; set; }
        public Double value_3 { get; set; }
        public Double value_4 { get; set; }
        public Double value_5 { get; set; }
        public Double value_6 { get; set; }
        public Double value_7 { get; set; }
        public Double value_8 { get; set; }
        public Double value_9 { get; set; }
        public Double value_10 { get; set; }
        public Double value_11 { get; set; }
        public Double value_12 { get; set; }
        public Double value_13 { get; set; }
        public Double value_14 { get; set; }
        public Double value_15 { get; set; }
        public Double value_16 { get; set; }
        public Double value_17 { get; set; }
        public Double value_18 { get; set; }
        public Double value_19 { get; set; }
        public Int32 icon_id { get; set; }
        public String icon_file_name { get; set; }
        public Int32 fx_id { get; set; }
        public Int32 pos_id { get; set; }
        public Int32 cast_skill_id { get; set; }
        public Int32 cast_fx_id { get; set; }
        public Int32 cast_fx_pos_id { get; set; }
        public Int32 hit_fx_id { get; set; }
        public Int32 hit_fx_pos_id { get; set; }
        public Int32 special_output_timing_id { get; set; }
        public Int32 special_output_fx_id { get; set; }
        public Int32 special_output_fx_pos_id { get; set; }
        public Int32 special_output_fx_delay { get; set; }
        public Int32 state_fx_id { get; set; }
        public Int32 state_fx_pos_id { get; set; }

        public void ReadFile(BinaryReader br)
        {
            this.state_id = br.ReadInt32();
            this.text_id = br.ReadInt32();
            this.tooltip_id = br.ReadInt32();
            this.is_harmful = br.ReadInt32();
            this.state_time_type = br.ReadInt32();
            this.state_group = br.ReadInt32();
            this.duplicate_group_1 = br.ReadInt32();
            this.duplicate_group_2 = br.ReadInt32();
            this.duplicate_group_3 = br.ReadInt32();
            this.uf_avatar = br.ReadByte();
            this.uf_summon = br.ReadByte();
            this.uf_monster = br.ReadByte();
            //br.ReadByte();
            this.reiteration_count = br.ReadByte();
            //br.ReadInt16();
            this.base_effect_id = br.ReadInt32();
            this.fire_interval = br.ReadInt32();
            this.elemental_type = br.ReadInt32();
            this.amplify_base = br.ReadSingle();
            this.amplify_per_skl = br.ReadSingle();
            this.add_damage_base = br.ReadInt32();
            this.add_damage_per_skl = br.ReadInt32();
            this.effect_type = br.ReadInt32();
            //br.ReadInt32();
            this.value_0 = br.ReadDouble();
            this.value_1 = br.ReadDouble();
            this.value_2 = br.ReadDouble();
            this.value_3 = br.ReadDouble();
            this.value_4 = br.ReadDouble();
            this.value_5 = br.ReadDouble();
            this.value_6 = br.ReadDouble();
            this.value_7 = br.ReadDouble();
            this.value_8 = br.ReadDouble();
            this.value_9 = br.ReadDouble();
            this.value_10 = br.ReadDouble();
            this.value_11 = br.ReadDouble();
            this.value_12 = br.ReadDouble();
            this.value_13 = br.ReadDouble();
            this.value_14 = br.ReadDouble();
            this.value_15 = br.ReadDouble();
            this.value_16 = br.ReadDouble();
            this.value_17 = br.ReadDouble();
            this.value_18 = br.ReadDouble();
            this.value_19 = br.ReadDouble();
            this.icon_id = br.ReadInt32();
            this.icon_file_name = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.fx_id = br.ReadInt32();
            this.pos_id = br.ReadInt32();
            this.cast_skill_id = br.ReadInt32();
            this.cast_fx_id = br.ReadInt32();
            this.cast_fx_pos_id = br.ReadInt32();
            this.hit_fx_id = br.ReadInt32();
            this.hit_fx_pos_id = br.ReadInt32();
            this.special_output_timing_id = br.ReadInt32();
            this.special_output_fx_id = br.ReadInt32();
            this.special_output_fx_pos_id = br.ReadInt32();
            this.special_output_fx_delay = br.ReadInt32();
            this.state_fx_id = br.ReadInt32();
            this.state_fx_pos_id = br.ReadInt32();
        }

        public void SaveFile(BinaryWriter bw)
        {
            bw.Write(this.state_id);
            bw.Write(this.text_id);
            bw.Write(this.tooltip_id);
            bw.Write(this.is_harmful);
            bw.Write(this.state_time_type);
            bw.Write(this.state_group);
            bw.Write(this.duplicate_group_1);
            bw.Write(this.duplicate_group_2);
            bw.Write(this.duplicate_group_3);
            bw.Write(this.uf_avatar);
            bw.Write(this.uf_summon);
            bw.Write(this.uf_monster);
            bw.Write(new Byte());
            bw.Write(this.reiteration_count);
            bw.Write(Convert.ToInt16(163));
            bw.Write(this.base_effect_id);
            bw.Write(this.fire_interval);
            bw.Write(this.elemental_type);
            bw.Write(this.amplify_base);
            bw.Write(this.amplify_per_skl);
            bw.Write(this.add_damage_base);
            bw.Write(this.add_damage_per_skl);
            bw.Write(this.effect_type);
            bw.Write(Convert.ToInt32(15662196));
            bw.Write(this.value_0);
            bw.Write(this.value_1);
            bw.Write(this.value_2);
            bw.Write(this.value_3);
            bw.Write(this.value_4);
            bw.Write(this.value_5);
            bw.Write(this.value_6);
            bw.Write(this.value_7);
            bw.Write(this.value_8);
            bw.Write(this.value_9);
            bw.Write(this.value_10);
            bw.Write(this.value_11);
            bw.Write(this.value_12);
            bw.Write(this.value_13);
            bw.Write(this.value_14);
            bw.Write(this.value_15);
            bw.Write(this.value_16);
            bw.Write(this.value_17);
            bw.Write(this.value_18);
            bw.Write(this.value_19);
            bw.Write(this.icon_id);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.icon_file_name));
            bw.Write(new Byte[256 - this.icon_file_name.Length]);
            bw.Write(this.fx_id);
            bw.Write(this.pos_id);
            bw.Write(this.cast_skill_id);
            bw.Write(this.cast_fx_id);
            bw.Write(this.cast_fx_pos_id);
            bw.Write(this.hit_fx_id);
            bw.Write(this.hit_fx_pos_id);
            bw.Write(this.special_output_timing_id);
            bw.Write(this.special_output_fx_id);
            bw.Write(this.special_output_fx_pos_id);
            bw.Write(this.special_output_fx_delay);
            bw.Write(this.state_fx_id);
            bw.Write(this.state_fx_pos_id);
        }

        public string ToDatabase()
        {
            return "INSERT [dbo].[StateResource] ([state_id], [text_id], [tooltip_id], [is_harmful], [state_time_type], [state_group], [duplicate_group_1], [duplicate_group_2], [duplicate_group_3], [uf_avatar], [uf_summon], [uf_monster], [reiteration_count], [base_effect_id], [fire_interval], [elemental_type], [amplify_base], [amplify_per_skl], [add_damage_base], [add_damage_per_skl], [effect_type], [value_0], [value_1], [value_2], [value_3], [value_4], [value_5], [value_6], [value_7], [value_8], [value_9], [value_10], [value_11], [value_12], [value_13], [value_14], [value_15], [value_16], [value_17], [value_18], [value_19], [icon_id], [icon_file_name], [fx_id], [pos_id], [cast_skill_id], [cast_fx_id], [cast_fx_pos_id], [hit_fx_id], [hit_fx_pos_id], [special_output_timing_id], [special_output_fx_id], [special_output_fx_pos_id], [special_output_fx_delay], [state_fx_id], [state_fx_pos_id]) VALUES ( @Pstate_id, @Ptext_id, @Ptooltip_id, @Pis_harmful, @Pstate_time_type, @Pstate_group, @Pduplicate_group_1, @Pduplicate_group_2, @Pduplicate_group_3, @Puf_avatar, @Puf_summon, @Puf_monster, @Preiteration_count, @Pbase_effect_id, @Pfire_interval, @Pelemental_type, @Pamplify_base, @Pamplify_per_skl, @Padd_damage_base, @Padd_damage_per_skl, @Peffect_type, @Pvalue_0, @Pvalue_1, @Pvalue_2, @Pvalue_3, @Pvalue_4, @Pvalue_5, @Pvalue_6, @Pvalue_7, @Pvalue_8, @Pvalue_9, @Pvalue_10, @Pvalue_11, @Pvalue_12, @Pvalue_13, @Pvalue_14, @Pvalue_15, @Pvalue_16, @Pvalue_17, @Pvalue_18, @Pvalue_19, @Picon_id, @Picon_file_name, @Pfx_id, @Ppos_id, @Pcast_skill_id, @Pcast_fx_id, @Pcast_fx_pos_id, @Phit_fx_id, @Phit_fx_pos_id, @Pspecial_output_timing_id, @Pspecial_output_fx_id, @Pspecial_output_fx_pos_id, @Pspecial_output_fx_delay, @Pstate_fx_id, @Pstate_fx_pos_id )";
        }

        public static String FromDatabase()
        {
            String rString = "SELECT ";
            foreach (FieldInfo fieldInfo in typeof(DB_STATERESOURCE_62).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
            {
                rString += string.Format("[{0}], ", fieldInfo.Name.Substring(1, fieldInfo.Name.IndexOf('>') - 1));
            }
            return rString.Substring(0, rString.Length - 2) + " FROM StateResource ORDER BY state_id";
        }

        public void FromDatabaseExecute(System.Data.SqlClient.SqlDataReader drExecute)
        {
            foreach (FieldInfo fieldInfo in typeof(DB_STATERESOURCE_62).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
            {
                String sTempName = null;
                sTempName = fieldInfo.Name.Substring(1, fieldInfo.Name.IndexOf('>') - 1);

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
