using System;
using System.IO;
using System.Reflection;

namespace ACRM
{
    public class DB_NPCRESOURCE
    {
        public Int32 id { get; set; }
        public Int32 text_id { get; set; }
        public Int32 name_text_id { get; set; }
        public Int32 race_id { get; set; }
        public Int32 sexsual_id { get; set; }
        public Int32 x { get; set; }
        public Int32 y { get; set; }
        public Int32 z { get; set; }
        public Int32 face { get; set; }
        public Int32 local_flag { get; set; }
        public Byte is_periodic { get; set; }
        public DateTime begin_of_period { get; set; }
        public DateTime end_of_period { get; set; }
        public Int32 face_x { get; set; }
        public Int32 face_y { get; set; }
        public Int32 face_z { get; set; }
        public String model_file { get; set; }
        public Int32 hair_id { get; set; }
        public Int32 face_id { get; set; }
        public Int32 body_id { get; set; }
        public Int32 weapon_item_id { get; set; }
        public Int32 shield_item_id { get; set; }
        public Int32 clothes_item_id { get; set; }
        public Int32 helm_item_id { get; set; }
        public Int32 gloves_item_id { get; set; }
        public Int32 boots_item_id { get; set; }
        public Int32 belt_item_id { get; set; }
        public Int32 mantle_item_id { get; set; }
        public Int32 necklace_item_id { get; set; }
        public Int32 earring_item_id { get; set; }
        public Int32 ring1_item_id { get; set; }
        public Int32 ring2_item_id { get; set; }
        public Int32 motion_id { get; set; }
        public Int32 is_roam { get; set; }
        public Int32 roaming_id { get; set; }
        public Int32 standard_walk_speed { get; set; }
        public Int32 standard_run_speed { get; set; }
        public Int32 walk_speed { get; set; }
        public Int32 run_speed { get; set; }
        public Int32 attackable { get; set; }
        public Int32 offensive_type { get; set; }
        public Int32 spawn_type { get; set; }
        public Int32 chase_range { get; set; }
        public Int32 regen_time { get; set; }
        public Int32 level { get; set; }
        public Int32 stat_id { get; set; }
        public Int32 attack_range { get; set; }
        public Int32 attack_speed_type { get; set; }
        public Int32 hp { get; set; }
        public Int32 mp { get; set; }
        public Int32 attack_point { get; set; }
        public Int32 magic_point { get; set; }
        public Int32 defence { get; set; }
        public Int32 magic_defence { get; set; }
        public Int32 attack_speed { get; set; }
        public Int32 magic_speed { get; set; }
        public Int32 accuracy { get; set; }
        public Int32 avoid { get; set; }
        public Int32 magic_accuracy { get; set; }
        public Int32 magic_avoid { get; set; }
        public String ai_script { get; set; }
        public String contact_script { get; set; }
        public Int32 texture_group { get; set; }

        public void ReadFile(BinaryReader br)
        {
            this.id = br.ReadInt32();
            this.text_id = br.ReadInt32();
            this.name_text_id = br.ReadInt32();
            this.race_id = br.ReadInt32();
            this.sexsual_id = br.ReadInt32();
            this.x = br.ReadInt32();
            this.y = br.ReadInt32();
            this.z = br.ReadInt32();
            this.face = br.ReadInt32();
            this.local_flag = br.ReadInt32();

            if (br.ReadByte() == 255)
            {
                this.is_periodic = 1;
            }
            else
            {
                this.is_periodic = 0;
            }

            this.begin_of_period = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(br.ReadInt32());
            this.end_of_period = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(br.ReadInt32());
            this.face_x = br.ReadInt32();
            this.face_y = br.ReadInt32();
            this.face_z = br.ReadInt32();
            this.model_file = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.hair_id = br.ReadInt32();
            this.face_id = br.ReadInt32();
            this.body_id = br.ReadInt32();
            this.weapon_item_id = br.ReadInt32();
            this.shield_item_id = br.ReadInt32();
            this.clothes_item_id = br.ReadInt32();
            this.helm_item_id = br.ReadInt32();
            this.gloves_item_id = br.ReadInt32();
            this.boots_item_id = br.ReadInt32();
            this.belt_item_id = br.ReadInt32();
            this.mantle_item_id = br.ReadInt32();
            this.necklace_item_id = br.ReadInt32();
            this.earring_item_id = br.ReadInt32();
            this.ring1_item_id = br.ReadInt32();
            this.ring2_item_id = br.ReadInt32();
            this.motion_id = br.ReadInt32();
            this.is_roam = br.ReadInt32();
            this.roaming_id = br.ReadInt32();
            this.standard_walk_speed = br.ReadInt32();
            this.standard_run_speed = br.ReadInt32();
            this.walk_speed = br.ReadInt32();
            this.run_speed = br.ReadInt32();
            this.attackable = br.ReadInt32();
            this.offensive_type = br.ReadInt32();
            this.spawn_type = br.ReadInt32();
            this.chase_range = br.ReadInt32();
            this.regen_time = br.ReadInt32();
            this.level = br.ReadInt32();
            this.stat_id = br.ReadInt32();
            this.attack_range = br.ReadInt32();
            this.attack_speed_type = br.ReadInt32();
            this.hp = br.ReadInt32();
            this.mp = br.ReadInt32();
            this.attack_point = br.ReadInt32();
            this.magic_point = br.ReadInt32();
            this.defence = br.ReadInt32();
            this.magic_defence = br.ReadInt32();
            this.attack_speed = br.ReadInt32();
            this.magic_speed = br.ReadInt32();
            this.accuracy = br.ReadInt32();
            this.avoid = br.ReadInt32();
            this.magic_accuracy = br.ReadInt32();
            this.magic_avoid = br.ReadInt32();
            this.ai_script = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.contact_script = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.texture_group = br.ReadInt32();
        }

        public void SaveFile(BinaryWriter bw)
        {
            bw.Write(this.id);
            bw.Write(this.text_id);
            bw.Write(this.name_text_id);
            bw.Write(this.race_id);
            bw.Write(this.sexsual_id);
            bw.Write(this.x);
            bw.Write(this.y);
            bw.Write(this.z);
            bw.Write(this.face);
            bw.Write(this.local_flag);

            if (this.is_periodic == 1)
            {
                bw.Write(Convert.ToByte(255));
            }
            else
            {
                bw.Write(Convert.ToByte(0));
            }

            bw.Write(Convert.ToInt32((this.begin_of_period - new DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalSeconds));
            bw.Write(Convert.ToInt32((this.end_of_period - new DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalSeconds));
            bw.Write(this.face_x);
            bw.Write(this.face_y);
            bw.Write(this.face_z);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.model_file));
            bw.Write(new Byte[256 - this.model_file.Length]);
            bw.Write(this.hair_id);
            bw.Write(this.face_id);
            bw.Write(this.body_id);
            bw.Write(this.weapon_item_id);
            bw.Write(this.shield_item_id);
            bw.Write(this.clothes_item_id);
            bw.Write(this.helm_item_id);
            bw.Write(this.gloves_item_id);
            bw.Write(this.boots_item_id);
            bw.Write(this.belt_item_id);
            bw.Write(this.mantle_item_id);
            bw.Write(this.necklace_item_id);
            bw.Write(this.earring_item_id);
            bw.Write(this.ring1_item_id);
            bw.Write(this.ring2_item_id);
            bw.Write(this.motion_id);
            bw.Write(this.is_roam);
            bw.Write(this.roaming_id);
            bw.Write(this.standard_walk_speed);
            bw.Write(this.standard_run_speed);
            bw.Write(this.walk_speed);
            bw.Write(this.run_speed);
            bw.Write(this.attackable);
            bw.Write(this.offensive_type);
            bw.Write(this.spawn_type);
            bw.Write(this.chase_range);
            bw.Write(this.regen_time);
            bw.Write(this.level);
            bw.Write(this.stat_id);
            bw.Write(this.attack_range);
            bw.Write(this.attack_speed_type);
            bw.Write(this.hp);
            bw.Write(this.mp);
            bw.Write(this.attack_point);
            bw.Write(this.magic_point);
            bw.Write(this.defence);
            bw.Write(this.magic_defence);
            bw.Write(this.attack_speed);
            bw.Write(this.magic_speed);
            bw.Write(this.accuracy);
            bw.Write(this.avoid);
            bw.Write(this.magic_accuracy);
            bw.Write(this.magic_avoid);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.ai_script));
            bw.Write(new Byte[256 - this.ai_script.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.contact_script));
            bw.Write(new Byte[256 - this.contact_script.Length]);
            bw.Write(this.texture_group);
        }

        public string ToDatabase()
        {
            return "INSERT INTO [dbo].[NPCResource] (id,text_id,name_text_id,race_id,sexsual_id,x,y,z,face,local_flag,is_periodic,begin_of_period,end_of_period,face_x,face_y,face_z,model_file,hair_id,face_id,body_id,weapon_item_id,shield_item_id,clothes_item_id,helm_item_id,gloves_item_id,boots_item_id,belt_item_id,mantle_item_id,necklace_item_id,earring_item_id,ring1_item_id,ring2_item_id,motion_id,is_roam,roaming_id,standard_walk_speed,standard_run_speed,walk_speed,run_speed,attackable,offensive_type,spawn_type,chase_range,regen_time,level,stat_id,attack_range,attack_speed_type,hp,mp,attack_point,magic_point,defence,magic_defence,attack_speed,magic_speed,accuracy,avoid,magic_accuracy,magic_avoid,ai_script,contact_script,texture_group) VALUES (@id,@text_id,@name_text_id,@race_id, @sexsual_id,@x,@y,@z,@face,@local_flag,@is_periodic,@begin_of_period,@end_of_period,@face_x,@face_y,@face_z,@model_file,@hair_id,@face_id,@body_id,@weapon_item_id,@shield_item_id,@clothes_item_id,@helm_item_id,@gloves_item_id,@boots_item_id,@belt_item_id,@mantle_item_id,@necklace_item_id,@earring_item_id,@ring1_item_id,@ring2_item_id,@motion_id,@is_roam,@roaming_id,@standard_walk_speed,@standard_run_speed,@walk_speed,@run_speed,@attackable,@offensive_type,@spawn_type,@chase_range,@regen_time,@level,@stat_id,@attack_range,@attack_speed_type,@hp,@mp,@attack_point,@magic_point,@defence,@magic_defence,@attack_speed,@magic_speed,@accuracy,@avoid,@magic_accuracy,@magic_avoid,@ai_script,@contact_script,@texture_group)";
        }

        public static String FromDatabase()
        {
            String rString = "SELECT ";
            foreach (FieldInfo fieldInfo in typeof(DB_NPCRESOURCE).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
            {
                rString += string.Format("[{0}], ", fieldInfo.Name.Substring(1, fieldInfo.Name.IndexOf('>') - 1));
            }
            return rString.Substring(0, rString.Length - 2) + " FROM NPCResource ORDER BY id";
        }

        public void FromDatabaseExecute(System.Data.SqlClient.SqlDataReader drExecute)
        {
            foreach (FieldInfo fieldInfo in typeof(DB_NPCRESOURCE).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
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
                else if (fieldInfo.FieldType == typeof(DateTime))
                {
                    fieldInfo.SetValue(this, Convert.ToDateTime(drExecute[sTempName]));
                }
            }
        }
    }
}
