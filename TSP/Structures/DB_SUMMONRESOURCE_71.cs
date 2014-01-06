using System;
using System.IO;
using System.Reflection;

namespace ACRM
{
    public class DB_SUMMONRESOURCE_71
    {
        public Int32 id { get; set; }
        public Int32 model_id { get; set; }
        public Int32 name_id { get; set; }
        public Int32 type { get; set; }
        public Int32 magic_type { get; set; }
        public Byte rate { get; set; }
        public Int32 stat_id { get; set; }
        public Single size { get; set; }
        public Single scale { get; set; }
        public Single target_fx_size { get; set; }
        public Int32 standard_walk_speed { get; set; }
        public Int32 standard_run_speed { get; set; }
        public Int32 riding_speed { get; set; }
        public Int32 run_speed { get; set; }
        public Byte is_riding_only { get; set; }
        public Int32 riding_motion_type { get; set; }
        public Decimal attack_range { get; set; }
        public Int32 walk_type { get; set; }
        public Int32 slant_type { get; set; }
        public Int32 material { get; set; }
        public Int32 weapon_type { get; set; }
        public Int32 attack_motion_speed { get; set; }
        public Int32 form { get; set; }
        public Int32 evolve_target { get; set; }
        public Int32 camera_x { get; set; }
        public Int32 camera_y { get; set; }
        public Int32 camera_z { get; set; }
        public Single target_x { get; set; }
        public Single target_y { get; set; }
        public Single target_z { get; set; }
        public String model { get; set; }
        public Int32 motion_file_id { get; set; }
        public Int32 face_id { get; set; }
        public String face_file_name { get; set; }
        public Int32 card_id { get; set; }
        public String script_text { get; set; }
        public String illust_file_name { get; set; }
        public Int32 text_feature_id { get; set; }
        public Int32 text_name_id { get; set; }
        public Int32 skill1_id { get; set; }
        public Int32 skill1_text_id { get; set; }
        public Int32 skill2_id { get; set; }
        public Int32 skill2_text_id { get; set; }
        public Int32 skill3_id { get; set; }
        public Int32 skill3_text_id { get; set; }
        public Int32 skill4_id { get; set; }
        public Int32 skill4_text_id { get; set; }
        public Int32 skill5_id { get; set; }
        public Int32 skill5_text_id { get; set; }
        public Int32 texture_group { get; set; }
        public Int32 local_flag { get; set; }

        public void ReadFile(System.IO.BinaryReader br)
        {
            this.id = br.ReadInt32();
            this.model_id = br.ReadInt32();
            this.name_id = br.ReadInt32();
            this.type = br.ReadInt32();
            this.magic_type = br.ReadInt32();
            this.rate = br.ReadByte();
            // br.ReadInt32();
            //br.ReadInt32();
            // br.ReadInt32();
            this.stat_id = br.ReadInt32();
            this.size = br.ReadSingle();
            this.scale = br.ReadSingle();
            this.target_fx_size = br.ReadSingle();
            this.standard_walk_speed = br.ReadInt32();
            this.standard_run_speed = br.ReadInt32();
            this.riding_speed = br.ReadInt32();
            this.run_speed = br.ReadInt32();
            this.is_riding_only = br.ReadByte();
            this.riding_motion_type = br.ReadInt32();
            this.attack_range = Convert.ToDecimal(br.ReadInt32()) / 100;
            this.walk_type = br.ReadInt32();
            this.slant_type = br.ReadInt32();
            this.material = br.ReadInt32();
            this.weapon_type = br.ReadInt32();
            this.attack_motion_speed = br.ReadInt32();
            this.form = br.ReadInt32();
            this.evolve_target = br.ReadInt32();
            this.camera_x = br.ReadInt32();
            this.camera_y = br.ReadInt32();
            this.camera_z = br.ReadInt32();
            this.target_x = br.ReadSingle();
            this.target_y = br.ReadSingle();
            this.target_z = br.ReadSingle();
            this.model = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.motion_file_id = br.ReadInt32();
            this.face_id = br.ReadInt32();
            this.face_file_name = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.card_id = br.ReadInt32();
            this.illust_file_name = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.text_feature_id = br.ReadInt32();
            this.text_name_id = br.ReadInt32();
            this.skill1_id = br.ReadInt32();
            this.skill1_text_id = br.ReadInt32();
            this.skill2_id = br.ReadInt32();
            this.skill2_text_id = br.ReadInt32();
            this.skill3_id = br.ReadInt32();
            this.skill3_text_id = br.ReadInt32();
            this.skill4_id = br.ReadInt32();
            this.skill4_text_id = br.ReadInt32();
            this.skill5_id = br.ReadInt32();
            this.skill5_text_id = br.ReadInt32();
            this.texture_group = br.ReadInt32();
            this.local_flag = br.ReadInt32();
        }

        public void SaveFile(BinaryWriter bw)
        {
            bw.Write(this.id);
            bw.Write(this.model_id);
            bw.Write(this.name_id);
            bw.Write(this.type);
            bw.Write(this.magic_type);
            bw.Write(this.rate);
            bw.Write(this.stat_id);
            bw.Write(this.size);
            bw.Write(this.scale);
            bw.Write(this.target_fx_size);
            bw.Write(this.standard_walk_speed);
            bw.Write(this.standard_run_speed);
            bw.Write(this.riding_speed);
            bw.Write(this.run_speed);
            bw.Write(this.is_riding_only);
            bw.Write(this.riding_motion_type);
            bw.Write(Convert.ToInt32(this.attack_range * 100));
            bw.Write(this.walk_type);
            bw.Write(this.slant_type);
            bw.Write(this.material);
            bw.Write(this.weapon_type);
            bw.Write(this.attack_motion_speed);
            bw.Write(this.form);
            bw.Write(this.evolve_target);
            bw.Write(this.camera_x);
            bw.Write(this.camera_y);
            bw.Write(this.camera_z);
            bw.Write(this.target_x);
            bw.Write(this.target_y);
            bw.Write(this.target_z);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.model));
            bw.Write(new Byte[256 - this.model.Length]);
            bw.Write(this.motion_file_id);
            bw.Write(this.face_id);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.face_file_name));
            bw.Write(new Byte[256 - this.face_file_name.Length]);
            bw.Write(this.card_id);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.illust_file_name));
            bw.Write(new Byte[256 - this.illust_file_name.Length]);
            bw.Write(this.text_feature_id);
            bw.Write(this.text_name_id);
            bw.Write(this.skill1_id);
            bw.Write(this.skill1_text_id);
            bw.Write(this.skill2_id);
            bw.Write(this.skill2_text_id);
            bw.Write(this.skill3_id);
            bw.Write(this.skill3_text_id);
            bw.Write(this.skill4_id);
            bw.Write(this.skill4_text_id);
            bw.Write(this.skill5_id);
            bw.Write(this.skill5_text_id);
            bw.Write(this.texture_group);
            bw.Write(this.local_flag);
        }

        public string ToDatabase()
        {
            return "";
        }

        public static String FromDatabase()
        {
            String rString = "SELECT ";
            foreach (FieldInfo fieldInfo in typeof(DB_SUMMONRESOURCE_71).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
            {
                rString += string.Format("[{0}], ", fieldInfo.Name.Substring(1, fieldInfo.Name.IndexOf('>') - 1));
            }
            return rString.Substring(0, rString.Length - 2) + " FROM SummonResource ORDER BY id";
        }

        public void FromDatabaseExecute(System.Data.SqlClient.SqlDataReader drExecute)
        {
            foreach (FieldInfo fieldInfo in typeof(DB_SUMMONRESOURCE_71).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
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
