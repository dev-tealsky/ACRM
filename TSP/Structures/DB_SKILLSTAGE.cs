using System;
using System.IO;
using System.Reflection;

namespace ACRM
{
    public class DB_SKILLSTAGE
    {
        public Int32 id { get; set; }
        public Byte elemental { get; set; }
        public Byte type { get; set; }
        public Byte deal_damage { get; set; }
        public Byte has_target { get; set; }
        public Byte corpse_target { get; set; }
        public Byte is_toggle { get; set; }
        public Single casting_time { get; set; }
        public Int32 is_creature_skill { get; set; }
        public Int32 stage_type_id { get; set; }
        public Int32 casting_type_id { get; set; }
        public Int32 casting_start_motion_id { get; set; }
        public Int32 casting_middle_motion_id { get; set; }
        public Int32 casting_fx_set_id { get; set; }
        public Int32 fire_motion_id { get; set; }
        public Int32 fire_fx_set_id { get; set; }
        public Single stage_data_01 { get; set; }
        public Single stage_data_02 { get; set; }
        public Single stage_data_03 { get; set; }
        public Single stage_data_04 { get; set; }
        public Single stage_data_05 { get; set; }
        public Single stage_data_06 { get; set; }
        public Single stage_data_07 { get; set; }
        public Single stage_data_08 { get; set; }
        public Single stage_data_09 { get; set; }
        public Single stage_data_10 { get; set; }
        public Single stage_data_11 { get; set; }
        public Single stage_data_12 { get; set; }
        public Single stage_data_13 { get; set; }
        public Single stage_data_14 { get; set; }
        public Single stage_data_15 { get; set; }
        public Single stage_data_16 { get; set; }
        public Single stage_data_17 { get; set; }
        public Single stage_data_18 { get; set; }
        public Single stage_data_19 { get; set; }
        public Single stage_data_20 { get; set; }
        public Int32 sub_stage_on_hit_id { get; set; }
        public Int32 sub_stage_on_hit_continuous { get; set; }
        public Int32 hit_fx_output_delay { get; set; }
        public Int32 hit_fx_set_id { get; set; }
        public Int32 hit_fx_set_position_id { get; set; }
        public Int32 fire_fx_output_delay { get; set; }
        public Int32 sub_fire_fx_set_id { get; set; }
        public Int32 sub_fire_fx_position { get; set; }

        public void ReadFile(BinaryReader br)
        {
            this.id = br.ReadInt32();
            this.elemental = br.ReadByte();
            this.type = br.ReadByte();
            this.deal_damage = br.ReadByte();
            this.has_target = br.ReadByte();
            this.corpse_target = br.ReadByte();
            this.is_toggle = br.ReadByte();
            br.ReadInt16(); // const 162
            this.casting_time = br.ReadSingle();
            this.is_creature_skill = br.ReadInt32();
            this.stage_type_id = br.ReadInt32();
            this.casting_type_id = br.ReadInt32();
            this.casting_start_motion_id = br.ReadInt32();
            this.casting_middle_motion_id = br.ReadInt32();
            this.casting_fx_set_id = br.ReadInt32();
            this.fire_motion_id = br.ReadInt32();
            this.fire_fx_set_id = br.ReadInt32();
            this.stage_data_01 = br.ReadSingle();
            this.stage_data_02 = br.ReadSingle();
            this.stage_data_03 = br.ReadSingle();
            this.stage_data_04 = br.ReadSingle();
            this.stage_data_05 = br.ReadSingle();
            this.stage_data_06 = br.ReadSingle();
            this.stage_data_07 = br.ReadSingle();
            this.stage_data_08 = br.ReadSingle();
            this.stage_data_09 = br.ReadSingle();
            this.stage_data_10 = br.ReadSingle();
            this.stage_data_11 = br.ReadSingle();
            this.stage_data_12 = br.ReadSingle();
            this.stage_data_13 = br.ReadSingle();
            this.stage_data_14 = br.ReadSingle();
            this.stage_data_15 = br.ReadSingle();
            this.stage_data_16 = br.ReadSingle();
            this.stage_data_17 = br.ReadSingle();
            this.stage_data_18 = br.ReadSingle();
            this.stage_data_19 = br.ReadSingle();
            this.stage_data_20 = br.ReadSingle();
            this.sub_stage_on_hit_id = br.ReadInt32();
            this.sub_stage_on_hit_continuous = br.ReadInt32();
            this.hit_fx_output_delay = br.ReadInt32();
            this.hit_fx_set_id = br.ReadInt32();
            this.hit_fx_set_position_id = br.ReadInt32();
            this.fire_fx_output_delay = br.ReadInt32();
            this.sub_fire_fx_set_id = br.ReadInt32();
            this.sub_fire_fx_position = br.ReadInt32();
        }

        public void SaveFile(BinaryWriter bw)
        {
            bw.Write(id);
            bw.Write(elemental);
            bw.Write(type);
            bw.Write(deal_damage);
            bw.Write(has_target);
            bw.Write(corpse_target);
            bw.Write(is_toggle);
            bw.Write(Convert.ToInt16(162));
            bw.Write(casting_time);
            bw.Write(is_creature_skill);
            bw.Write(stage_type_id);
            bw.Write(casting_type_id);
            bw.Write(casting_start_motion_id);
            bw.Write(casting_middle_motion_id);
            bw.Write(casting_fx_set_id);
            bw.Write(fire_motion_id);
            bw.Write(fire_fx_set_id);
            bw.Write(stage_data_01);
            bw.Write(stage_data_02);
            bw.Write(stage_data_03);
            bw.Write(stage_data_04);
            bw.Write(stage_data_05);
            bw.Write(stage_data_06);
            bw.Write(stage_data_07);
            bw.Write(stage_data_08);
            bw.Write(stage_data_09);
            bw.Write(stage_data_10);
            bw.Write(stage_data_11);
            bw.Write(stage_data_12);
            bw.Write(stage_data_13);
            bw.Write(stage_data_14);
            bw.Write(stage_data_15);
            bw.Write(stage_data_16);
            bw.Write(stage_data_17);
            bw.Write(stage_data_18);
            bw.Write(stage_data_19);
            bw.Write(stage_data_20);
            bw.Write(sub_stage_on_hit_id);
            bw.Write(sub_stage_on_hit_continuous);
            bw.Write(hit_fx_output_delay);
            bw.Write(hit_fx_set_id);
            bw.Write(hit_fx_set_position_id);
            bw.Write(fire_fx_output_delay);
            bw.Write(sub_fire_fx_set_id);
            bw.Write(sub_fire_fx_position);
        }

        public string ToDatabase()
        {
            return "INSERT [dbo].[SkillStage] ([id], [elemental], [type], [deal_damage], [has_target], [corpse_target], [is_toggle], [casting_time], [is_creature_skill], [stage_type_id], [casting_type_id], [casting_start_motion_id], [casting_middle_motion_id], [casting_fx_set_id], [fire_motion_id], [fire_fx_set_id], [stage_data_01], [stage_data_02], [stage_data_03], [stage_data_04], [stage_data_05], [stage_data_06], [stage_data_07], [stage_data_08], [stage_data_09], [stage_data_10], [stage_data_11], [stage_data_12], [stage_data_13], [stage_data_14], [stage_data_15], [stage_data_16], [stage_data_17], [stage_data_18], [stage_data_19], [stage_data_20], [sub_stage_on_hit_id], [sub_stage_on_hit_continuous], [hit_fx_output_delay], [hit_fx_set_id], [hit_fx_set_position_id], [fire_fx_output_delay], [sub_fire_fx_set_id], [sub_fire_fx_position]) VALUES ( @Pid, @Pelemental, @Ptype, @Pdeal_damage, @Phas_target, @Pcorpse_target, @Pis_toggle, @Pcasting_time, @Pis_creature_skill, @Pstage_type_id, @Pcasting_type_id, @Pcasting_start_motion_id, @Pcasting_middle_motion_id, @Pcasting_fx_set_id, @Pfire_motion_id, @Pfire_fx_set_id, @Pstage_data_01, @Pstage_data_02, @Pstage_data_03, @Pstage_data_04, @Pstage_data_05, @Pstage_data_06, @Pstage_data_07, @Pstage_data_08, @Pstage_data_09, @Pstage_data_10, @Pstage_data_11, @Pstage_data_12, @Pstage_data_13, @Pstage_data_14, @Pstage_data_15, @Pstage_data_16, @Pstage_data_17, @Pstage_data_18, @Pstage_data_19, @Pstage_data_20, @Psub_stage_on_hit_id, @Psub_stage_on_hit_continuous, @Phit_fx_output_delay, @Phit_fx_set_id, @Phit_fx_set_position_id, @Pfire_fx_output_delay, @Psub_fire_fx_set_id, @Psub_fire_fx_position )";
        }

        public static String FromDatabase()
        {
            String rString = "SELECT ";
            foreach (FieldInfo fieldInfo in typeof(DB_SKILLSTAGE).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
            {
                rString += string.Format("[{0}], ", fieldInfo.Name.Substring(1, fieldInfo.Name.IndexOf('>') - 1));
            }
            return rString.Substring(0, rString.Length - 2) + " FROM SkillStage ORDER BY id";
        }

        public void FromDatabaseExecute(System.Data.SqlClient.SqlDataReader drExecute)
        {
            foreach (FieldInfo fieldInfo in typeof(DB_SKILLSTAGE).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
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