using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ACRM
{
    public class DB_FIELDPROPRESOURCE_73
    {
        public Int32 id { get; set; }
        public Int32 text_id { get; set; }
        public Int32 tooltip_id { get; set; }
        public Int32 type { get; set; }
        public Int32 local_flag { get; set; }
        public Int32 casting_time { get; set; }
        public Int32 use_count { get; set; }
        public Int32 regen_time { get; set; }
        public Int32 life_time { get; set; }
        public Single casting_range { get; set; }
        public Single target_fx_size { get; set; }
        public Int32 limit_min_level { get; set; }
        public Int32 limit_max_level { get; set; }
        public Byte limit_deva { get; set; }
        public Byte limit_asura { get; set; }
        public Byte limit_gaia { get; set; }
        public Byte limit_fighter { get; set; }
        public Byte limit_hunter { get; set; }
        public Byte limit_magician { get; set; }
        public Byte limit_summoner { get; set; }
        public Int32 limit_job { get; set; }
        public Int32 activation_condition { get; set; }
        public Int32 activation_value1 { get; set; }
        public Int32 activation_value2 { get; set; }
        public Int32 activation2_condition { get; set; }
        public Int32 activation2_value1 { get; set; }
        public Int32 activation2_value2 { get; set; }
        public Int32 activate_id { get; set; }
        public Int32 drop_item_id_00 { get; set; }
        public Int32 drop_item_ratio_00 { get; set; }
        public Int32 drop_item_count_min_00 { get; set; }
        public Int32 drop_item_count_max_00 { get; set; }
        public Int32 drop_item_level_min_00 { get; set; }
        public Int32 drop_item_level_max_00 { get; set; }
        public Int32 drop_item_id_01 { get; set; }
        public Int32 drop_item_ratio_01 { get; set; }
        public Int32 drop_item_count_min_01 { get; set; }
        public Int32 drop_item_count_max_01 { get; set; }
        public Int32 drop_item_level_min_01 { get; set; }
        public Int32 drop_item_level_max_01 { get; set; }
        public String script_text { get; set; }
        public String file_name { get; set; }
        public Int16 terrain_check { get; set; }
        public Int16 worldmap_check_type { get; set; }

        public void ReadFile(BinaryReader br)
        {
            this.id = br.ReadInt32();
            this.text_id = br.ReadInt32();
            this.tooltip_id = br.ReadInt32();
            this.type = br.ReadInt32();
            this.local_flag = br.ReadInt32();
            this.casting_time = br.ReadInt32();
            this.use_count = br.ReadInt32();
            this.regen_time = br.ReadInt32();
            this.life_time = br.ReadInt32();
            this.casting_range = br.ReadSingle();
            this.target_fx_size = br.ReadSingle();
            this.limit_min_level = br.ReadInt32();
            this.limit_max_level = br.ReadInt32();
            this.limit_deva = br.ReadByte();
            this.limit_asura = br.ReadByte();
            this.limit_gaia = br.ReadByte();
            this.limit_fighter = br.ReadByte();
            this.limit_hunter = br.ReadByte();
            this.limit_magician = br.ReadByte();
            this.limit_summoner = br.ReadByte();
            this.limit_job = br.ReadInt32();
            this.activation_condition = br.ReadInt32();
            this.activation_value1 = br.ReadInt32();
            this.activation_value2 = br.ReadInt32();
            this.activation2_condition = br.ReadInt32();
            this.activation2_value1 = br.ReadInt32();
            this.activation2_value2 = br.ReadInt32();
            this.activate_id = br.ReadInt32();
            this.drop_item_id_00 = br.ReadInt32();
            this.drop_item_ratio_00 = br.ReadInt32();
            this.drop_item_count_min_00 = br.ReadInt32();
            this.drop_item_count_max_00 = br.ReadInt32();
            this.drop_item_level_min_00 = br.ReadInt32();
            this.drop_item_level_max_00 = br.ReadInt32();
            this.drop_item_id_01 = br.ReadInt32();
            this.drop_item_ratio_01 = br.ReadInt32();
            this.drop_item_count_min_01 = br.ReadInt32();
            this.drop_item_count_max_01 = br.ReadInt32();
            this.drop_item_level_min_01 = br.ReadInt32();
            this.drop_item_level_max_01 = br.ReadInt32();
            this.script_text = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.file_name = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.terrain_check = br.ReadInt16();
            br.ReadInt16();
            this.worldmap_check_type = br.ReadInt16();
        }

        public void SaveFile(BinaryWriter bw)
        {
            bw.Write(this.id);
            bw.Write(this.text_id);
            bw.Write(this.tooltip_id);
            bw.Write(this.type);
            bw.Write(this.local_flag);
            bw.Write(this.casting_time);
            bw.Write(this.use_count);
            bw.Write(this.regen_time);
            bw.Write(this.life_time);
            bw.Write(this.casting_range);
            bw.Write(this.target_fx_size);
            bw.Write(this.limit_min_level);
            bw.Write(this.limit_max_level);
            bw.Write(this.limit_deva);
            bw.Write(this.limit_asura);
            bw.Write(this.limit_gaia);
            bw.Write(this.limit_fighter);
            bw.Write(this.limit_hunter);
            bw.Write(this.limit_magician);
            bw.Write(this.limit_summoner);
            bw.Write(this.limit_job);
            bw.Write(this.activation_condition);
            bw.Write(this.activation_value1);
            bw.Write(this.activation_value2);
            bw.Write(this.activation2_condition);
            bw.Write(this.activation2_value1);
            bw.Write(this.activation2_value2);
            bw.Write(this.activate_id);
            bw.Write(this.drop_item_id_00);
            bw.Write(this.drop_item_ratio_00);
            bw.Write(this.drop_item_count_min_00);
            bw.Write(this.drop_item_count_max_00);
            bw.Write(this.drop_item_level_min_00);
            bw.Write(this.drop_item_level_max_00);
            bw.Write(this.drop_item_id_01);
            bw.Write(this.drop_item_ratio_01);
            bw.Write(this.drop_item_count_min_01);
            bw.Write(this.drop_item_count_max_01);
            bw.Write(this.drop_item_level_min_01);
            bw.Write(this.drop_item_level_max_01);

            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(script_text));
            bw.Write(new Byte[256 - ACRM_BYTE_CONVERTER.StringToBytes(script_text).Length]);

            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(file_name));
            bw.Write(new Byte[256 - ACRM_BYTE_CONVERTER.StringToBytes(file_name).Length]);

            bw.Write(this.terrain_check);
            bw.Write(new Byte[2]);
            bw.Write(this.worldmap_check_type);
        }

        public static String FromDatabase()
        {
            String rString = "SELECT ";
            foreach (FieldInfo fieldInfo in typeof(DB_FIELDPROPRESOURCE_73).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
            {
                rString += string.Format("[{0}], ", fieldInfo.Name.Substring(1, fieldInfo.Name.IndexOf('>') - 1));
            }
            return rString.Substring(0, rString.Length - 2) + " FROM FieldPropResource ORDER BY id";
        }

        public void FromDatabaseExecute(System.Data.SqlClient.SqlDataReader drExecute)
        {
            foreach (FieldInfo fieldInfo in typeof(DB_FIELDPROPRESOURCE_73).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
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