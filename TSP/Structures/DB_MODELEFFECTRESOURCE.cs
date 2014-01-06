using System;
using System.IO;
using System.Reflection;

namespace ACRM
{
    public class DB_MODELEFFECTRESOURCE
    {
        public Int32 id { get; set; }
        public Int32 effect_file_ID { get; set; }
        public Int32 effect_loop { get; set; }
        public Int32 effect_position { get; set; }
        public Int32 swap_event_id { get; set; }
        public Int32 swap_model_ID { get; set; }
        public String bone_name_01 { get; set; }
        public Int32 bone_effect_01 { get; set; }
        public String bone_name_02 { get; set; }
        public Int32 bone_effect_02 { get; set; }
        public String bone_name_03 { get; set; }
        public Int32 bone_effect_03 { get; set; }
        public String bone_name_04 { get; set; }
        public Int32 bone_effect_04 { get; set; }
        public String bone_name_05 { get; set; }
        public Int32 bone_effect_05 { get; set; }
        public String bone_name_06 { get; set; }
        public Int32 bone_effect_06 { get; set; }
        public String bone_name_07 { get; set; }
        public Int32 bone_effect_07 { get; set; }
        public String bone_name_08 { get; set; }
        public Int32 bone_effect_08 { get; set; }
        public String bone_name_09 { get; set; }
        public Int32 bone_effect_09 { get; set; }
        public String bone_name_10 { get; set; }
        public Int32 bone_effect_10 { get; set; }
        public String bone_name_11 { get; set; }
        public Int32 bone_effect_11 { get; set; }
        public String bone_name_12 { get; set; }
        public Int32 bone_effect_12 { get; set; }
        public String bone_name_13 { get; set; }
        public Int32 bone_effect_13 { get; set; }
        public String bone_name_14 { get; set; }
        public Int32 bone_effect_14 { get; set; }
        public String bone_name_15 { get; set; }
        public Int32 bone_effect_15 { get; set; }

        public void ReadFile(BinaryReader br)
        {
            this.id = br.ReadInt32();
            this.effect_file_ID = br.ReadInt32();
            this.effect_loop = br.ReadInt32();
            this.effect_position = br.ReadInt32();
            this.swap_event_id = br.ReadInt32();
            this.swap_model_ID = br.ReadInt32();
            this.bone_name_01 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.bone_name_02 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.bone_name_03 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.bone_name_04 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.bone_name_05 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.bone_name_06 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.bone_name_07 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.bone_name_08 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.bone_name_09 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.bone_name_10 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.bone_name_11 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.bone_name_12 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.bone_name_13 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.bone_name_14 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.bone_name_15 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.bone_effect_01 = br.ReadInt32();
            this.bone_effect_02 = br.ReadInt32();
            this.bone_effect_03 = br.ReadInt32();
            this.bone_effect_04 = br.ReadInt32();
            this.bone_effect_05 = br.ReadInt32();
            this.bone_effect_06 = br.ReadInt32();
            this.bone_effect_07 = br.ReadInt32();
            this.bone_effect_08 = br.ReadInt32();
            this.bone_effect_09 = br.ReadInt32();
            this.bone_effect_10 = br.ReadInt32();
            this.bone_effect_11 = br.ReadInt32();
            this.bone_effect_12 = br.ReadInt32();
            this.bone_effect_13 = br.ReadInt32();
            this.bone_effect_14 = br.ReadInt32();
            this.bone_effect_15 = br.ReadInt32();
        }

        public void SaveFile(BinaryWriter bw)
        {
            bw.Write(this.id);
            bw.Write(this.effect_file_ID);
            bw.Write(this.effect_loop);
            bw.Write(this.effect_position);
            bw.Write(this.swap_event_id);
            bw.Write(this.swap_model_ID);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.bone_name_01));
            bw.Write(new Byte[256 - this.bone_name_01.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.bone_name_02));
            bw.Write(new Byte[256 - this.bone_name_02.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.bone_name_03));
            bw.Write(new Byte[256 - this.bone_name_03.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.bone_name_04));
            bw.Write(new Byte[256 - this.bone_name_04.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.bone_name_05));
            bw.Write(new Byte[256 - this.bone_name_05.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.bone_name_06));
            bw.Write(new Byte[256 - this.bone_name_06.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.bone_name_07));
            bw.Write(new Byte[256 - this.bone_name_07.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.bone_name_08));
            bw.Write(new Byte[256 - this.bone_name_08.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.bone_name_09));
            bw.Write(new Byte[256 - this.bone_name_09.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.bone_name_10));
            bw.Write(new Byte[256 - this.bone_name_10.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.bone_name_11));
            bw.Write(new Byte[256 - this.bone_name_11.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.bone_name_12));
            bw.Write(new Byte[256 - this.bone_name_12.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.bone_name_13));
            bw.Write(new Byte[256 - this.bone_name_13.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.bone_name_14));
            bw.Write(new Byte[256 - this.bone_name_14.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.bone_name_15));
            bw.Write(new Byte[256 - this.bone_name_15.Length]);
            bw.Write(this.bone_effect_01);
            bw.Write(this.bone_effect_02);
            bw.Write(this.bone_effect_03);
            bw.Write(this.bone_effect_04);
            bw.Write(this.bone_effect_05);
            bw.Write(this.bone_effect_06);
            bw.Write(this.bone_effect_07);
            bw.Write(this.bone_effect_08);
            bw.Write(this.bone_effect_09);
            bw.Write(this.bone_effect_10);
            bw.Write(this.bone_effect_11);
            bw.Write(this.bone_effect_12);
            bw.Write(this.bone_effect_13);
            bw.Write(this.bone_effect_14);
            bw.Write(this.bone_effect_15);
        }

        public string ToDatabase()
        {
            return "INSERT [dbo].[ModelEffectResource] ([id], [effect_file_ID], [effect_loop], [effect_position], [swap_event_id], [swap_model_ID], [bone_name_01], [bone_effect_01], [bone_name_02], [bone_effect_02], [bone_name_03], [bone_effect_03], [bone_name_04], [bone_effect_04], [bone_name_05], [bone_effect_05], [bone_name_06], [bone_effect_06], [bone_name_07], [bone_effect_07], [bone_name_08], [bone_effect_08], [bone_name_09], [bone_effect_09], [bone_name_10], [bone_effect_10], [bone_name_11], [bone_effect_11], [bone_name_12], [bone_effect_12], [bone_name_13], [bone_effect_13], [bone_name_14], [bone_effect_14], [bone_name_15], [bone_effect_15]) VALUES ( @Pid, @Peffect_file_ID, @Peffect_loop, @Peffect_position, @Pswap_event_id, @Pswap_model_ID, @Pbone_name_01, @Pbone_effect_01, @Pbone_name_02, @Pbone_effect_02, @Pbone_name_03, @Pbone_effect_03, @Pbone_name_04, @Pbone_effect_04, @Pbone_name_05, @Pbone_effect_05, @Pbone_name_06, @Pbone_effect_06, @Pbone_name_07, @Pbone_effect_07, @Pbone_name_08, @Pbone_effect_08, @Pbone_name_09, @Pbone_effect_09, @Pbone_name_10, @Pbone_effect_10, @Pbone_name_11, @Pbone_effect_11, @Pbone_name_12, @Pbone_effect_12, @Pbone_name_13, @Pbone_effect_13, @Pbone_name_14, @Pbone_effect_14, @Pbone_name_15, @Pbone_effect_15 )";
        }

        public static String FromDatabase()
        {
            String rString = "SELECT ";
            foreach (FieldInfo fieldInfo in typeof(DB_MODELEFFECTRESOURCE).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
            {
                rString += string.Format("[{0}], ", fieldInfo.Name.Substring(1, fieldInfo.Name.IndexOf('>') - 1));
            }
            return rString.Substring(0, rString.Length - 2) + " FROM ModelEffectResource ORDER BY id";
        }

        public void FromDatabaseExecute(System.Data.SqlClient.SqlDataReader drExecute)
        {
            foreach (FieldInfo fieldInfo in typeof(DB_MODELEFFECTRESOURCE).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
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
