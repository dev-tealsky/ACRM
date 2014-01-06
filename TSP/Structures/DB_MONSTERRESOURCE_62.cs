using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;

namespace ACRM
{
    public class DB_MONSTERRESOURCE_62
    {
        public Int32 id { get; set; }
        public Int32 monster_group { get; set; }
        public Int32 name_id { get; set; }
        public Int32 location_id { get; set; }
        public String model { get; set; }
        public Int32 motion_file_id { get; set; }
        public Int32 transform_level { get; set; }
        public Int32 walk_type { get; set; }
        public Int32 slant_type { get; set; }
        public Single size { get; set; }
        public Single scale { get; set; }
        public Single target_fx_size { get; set; }
        public Int32 camera_x { get; set; }
        public Int32 camera_y { get; set; }
        public Int32 camera_z { get; set; }
        public Single target_x { get; set; }
        public Single target_y { get; set; }
        public Single target_z { get; set; }
        public Int32 level { get; set; }
        public Int32 grp { get; set; }
        public Int32 magic_type { get; set; }
        public Int32 race { get; set; }
        public Int32 visible_range { get; set; }
        public Int32 chase_range { get; set; }
        public Int32 f_fisrt_attack { get; set; }
        public Int32 f_group_first_attack { get; set; }
        public Int32 f_response_casting { get; set; }
        public Int32 f_response_race { get; set; }
        public Int32 f_response_battle { get; set; }
        public Int32 monster_type { get; set; }
        public Int32 stat_id { get; set; }
        public Int32 fight_type { get; set; }
        public Int32 monster_skill_link_id { get; set; }
        public Int32 material { get; set; }
        public Int32 weapon_type { get; set; }
        public Int32 attack_motion_speed { get; set; }
        public Int32 ability { get; set; }
        public Int32 standard_walk_spped { get; set; }
        public Int32 standard_run_spped { get; set; }
        public Int32 walk_speed { get; set; }
        public Int32 run_speed { get; set; }
        public Decimal attack_range { get; set; }
        public Decimal hidesense_range { get; set; }
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
        public Int32 taming_id { get; set; }
        public Single taming_percentage { get; set; }
        public Single taming_exp_mod { get; set; }
        public Int32 exp { get; set; }
        public Int32 jp { get; set; }
        public Int32 gold_drop_percentage { get; set; }
        public Int32 gold_min { get; set; }
        public Int32 gold_max { get; set; }
        public Int32 chaos_drop_percentage { get; set; }
        public Int32 chaos_min { get; set; }
        public Int32 chaos_max { get; set; }
        public Int32 exp_2 { get; set; }
        public Int32 jp_2 { get; set; }
        public Int32 gold_min_2 { get; set; }
        public Int32 gold_max_2 { get; set; }
        public Int32 chaos_min_2 { get; set; }
        public Int32 chaos_max_2 { get; set; }
        public Int32 drop_table_link_id { get; set; }
        public Int32 texture_group { get; set; }
        public Int32 local_flag { get; set; }
        public String script_on_dead { get; set; }

        public void ReadFile(BinaryReader br)
        {
            this.id = ACRM_SCRAMBLE_MAP.bits_descramble(br.ReadInt32());
            this.monster_group = br.ReadInt32();
            this.monster_type = br.ReadInt32();
            this.name_id = br.ReadInt32();
            this.location_id = br.ReadInt32();
            this.race = br.ReadInt32();
            this.grp = br.ReadInt32();
            this.transform_level = br.ReadInt32();
            this.level = br.ReadInt32();
            this.size = br.ReadSingle();
            this.scale = br.ReadSingle();
            this.target_fx_size = br.ReadSingle();
            this.walk_type = br.ReadInt32();
            this.slant_type = br.ReadInt32();
            this.visible_range = br.ReadInt32();
            this.chase_range = br.ReadInt32();
            this.magic_type = br.ReadInt32();
            Int32 f = br.ReadInt32();
            this.f_fisrt_attack = (f & 1);
            this.f_group_first_attack = (f & 2) >> 1;
            this.f_response_casting = (f & 4) >> 2;
            this.f_response_race = (f & 8) >> 3;
            this.f_response_battle = (f & 16) >> 4;
            this.hp = br.ReadInt32();
            this.mp = br.ReadInt32();
            this.attack_point = br.ReadInt32();
            this.magic_point = br.ReadInt32();
            this.defence = br.ReadInt32();
            this.magic_defence = br.ReadInt32();
            this.attack_speed = br.ReadInt32();
            br.ReadInt32(); // const 15662004
            this.magic_speed = br.ReadInt32();
            this.accuracy = br.ReadInt32();
            this.avoid = br.ReadInt32();
            this.magic_accuracy = br.ReadInt32();
            this.magic_avoid = br.ReadInt32();
            this.taming_id = br.ReadInt32();
            this.taming_percentage = br.ReadSingle();
            this.taming_exp_mod = br.ReadSingle();
            this.exp = br.ReadInt32();
            this.jp = br.ReadInt32();
            this.monster_skill_link_id = br.ReadInt32();
            this.stat_id = br.ReadInt32();
            this.ability = br.ReadInt32();
            this.standard_walk_spped = br.ReadInt32();
            this.standard_run_spped = br.ReadInt32();
            this.walk_speed = br.ReadInt32();
            this.run_speed = br.ReadInt32();
            this.attack_range = Convert.ToDecimal(br.ReadInt32()) / 100;
            this.hidesense_range = Convert.ToDecimal(br.ReadInt32()) / 100;
            this.gold_drop_percentage = br.ReadInt32();
            this.gold_min = br.ReadInt32();
            this.gold_max = br.ReadInt32();
            this.chaos_drop_percentage = br.ReadInt32();
            this.chaos_min = br.ReadInt32();
            this.chaos_max = br.ReadInt32();
            this.exp_2 = br.ReadInt32();
            this.jp_2 = br.ReadInt32();
            this.gold_min_2 = br.ReadInt32();
            this.gold_max_2 = br.ReadInt32();
            this.chaos_min_2 = br.ReadInt32();
            this.chaos_max_2 = br.ReadInt32();
            this.drop_table_link_id = br.ReadInt32();
            this.texture_group = br.ReadInt32();
            this.local_flag = br.ReadInt32();
            this.model = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.motion_file_id = br.ReadInt32();
            this.weapon_type = br.ReadInt32();
            this.camera_x = br.ReadInt32();
            this.camera_y = br.ReadInt32();
            this.camera_z = br.ReadInt32();
            this.target_x = br.ReadSingle();
            this.target_y = br.ReadSingle();
            this.target_z = br.ReadSingle();
            this.material = br.ReadInt32();
            this.attack_motion_speed = br.ReadInt32();
            this.fight_type = br.ReadInt32();
            this.script_on_dead = "";
        }

        public void SaveFile(BinaryWriter bw)
        {
            bw.Write(this.mobidconvert(this.id.ToString()));
            bw.Write(this.monster_group);
            bw.Write(this.monster_type);
            bw.Write(this.name_id);
            bw.Write(this.location_id);
            bw.Write(this.race);
            bw.Write(this.grp);
            bw.Write(this.transform_level);
            bw.Write(this.level);
            bw.Write(this.size);
            bw.Write(this.scale);
            bw.Write(this.target_fx_size);
            bw.Write(this.walk_type);
            bw.Write(this.slant_type);
            bw.Write(this.visible_range);
            bw.Write(this.chase_range);
            bw.Write(this.magic_type);
            Int32 f = 0;
            if (f_fisrt_attack != 0) f |= 1;
            if (f_group_first_attack != 0) f |= 2;
            if (f_response_casting != 0) f |= 4;
            if (f_response_race != 0) f |= 8;
            if (f_response_battle != 0) f |= 16;
            bw.Write(f);
            bw.Write(this.hp);
            bw.Write(this.mp);
            bw.Write(this.attack_point);
            bw.Write(this.magic_point);
            bw.Write(this.defence);
            bw.Write(this.magic_defence);
            bw.Write(this.attack_speed);
            bw.Write(Convert.ToInt32(15662004));
            bw.Write(this.magic_speed);
            bw.Write(this.accuracy);
            bw.Write(this.avoid);
            bw.Write(this.magic_accuracy);
            bw.Write(this.magic_avoid);
            bw.Write(this.taming_id);
            bw.Write(this.taming_percentage);
            bw.Write(this.taming_exp_mod);
            bw.Write(this.exp);
            bw.Write(this.jp);
            bw.Write(this.monster_skill_link_id);
            bw.Write(this.stat_id);
            bw.Write(this.ability);
            bw.Write(this.standard_walk_spped);
            bw.Write(this.standard_run_spped);
            bw.Write(this.walk_speed);
            bw.Write(this.run_speed);
            bw.Write(Convert.ToInt32(attack_range) * 100);
            bw.Write(Convert.ToInt32(hidesense_range) * 100);
            bw.Write(this.gold_drop_percentage);
            bw.Write(this.gold_min);
            bw.Write(this.gold_max);
            bw.Write(this.chaos_drop_percentage);
            bw.Write(this.chaos_min);
            bw.Write(this.chaos_max);
            bw.Write(this.exp_2);
            bw.Write(this.jp_2);
            bw.Write(this.gold_min_2);
            bw.Write(this.gold_max_2);
            bw.Write(this.chaos_min_2);
            bw.Write(this.chaos_max_2);
            bw.Write(this.drop_table_link_id);
            bw.Write(this.texture_group);
            bw.Write(this.local_flag);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.model));
            bw.Write(new Byte[256 - this.model.Length]);
            bw.Write(this.motion_file_id);
            bw.Write(this.weapon_type);
            bw.Write(this.camera_x);
            bw.Write(this.camera_y);
            bw.Write(this.camera_z);
            bw.Write(this.target_x);
            bw.Write(this.target_y);
            bw.Write(this.target_z);
            bw.Write(this.material);
            bw.Write(this.attack_motion_speed);
            bw.Write(this.fight_type);
        }

        private Int32 mobidconvert(string id)
        {
            int[] encodeMap = new int[32] { 4, 21, 1, 18, 11, 26, 5, 0, 3, 31, 2, 27, 20, 13, 24, 14, 6, 8, 7, 9, 15, 17, 19, 29, 12, 10, 23, 30, 16, 22, 25, 28 };
            int[] decodeMap = new int[32];
            int i;
            int[] decode = new int[32];
            decode = GetIntBitArray((Convert.ToInt32(id)));
            for (i = 0; i < 32; i++)
                decodeMap[encodeMap[i]] = decode[i];
            Int32 checkmobid = GetBitArrayInt(decodeMap);
            return checkmobid;
        }

        private int GetBitArrayInt(int[] n)
        {
            string abc = null;

            for (int i = 0; i < 32; i++)
                abc = abc + n[i].ToString();
            return Convert.ToInt32(abc, 2);
        }

        private static int[] GetIntBitArray(int n)
        {
            int[] b = new int[32];
            int pos = 31;
            int i = 0;

            while (i < 32)
            {
                if ((n & (1 << i)) != 0)
                {
                    b[pos] = 1;
                }
                else
                {
                    b[pos] = 0;
                }
                pos--;
                i++;
            }
            string abc = null;
            for (int k = 0; k < 32; k++)
                abc = abc + b[k].ToString();
            //MessageBox.Show(abc);
            return b;
        }

        public string ToDatabase()
        {
            return "INSERT [dbo].[MonsterResource] ([id], [monster_group], [name_id], [location_id], [model], [motion_file_id], [transform_level], [walk_type], [slant_type], [size], [scale], [target_fx_size], [camera_x], [camera_y], [camera_z], [target_x], [target_y], [target_z], [level], [grp], [magic_type], [race], [visible_range], [chase_range], [f_fisrt_attack], [f_group_first_attack], [f_response_casting], [f_response_race], [f_response_battle], [monster_type], [stat_id], [fight_type], [monster_skill_link_id], [material], [weapon_type], [attack_motion_speed], [ability], [standard_walk_spped], [standard_run_spped], [walk_speed], [run_speed], [attack_range], [hidesense_range], [hp], [mp], [attack_point], [magic_point], [defence], [magic_defence], [attack_speed], [magic_speed], [accuracy], [avoid], [magic_accuracy], [magic_avoid], [taming_id], [taming_percentage], [taming_exp_mod], [exp], [jp], [gold_drop_percentage], [gold_min], [gold_max], [chaos_drop_percentage], [chaos_min], [chaos_max], [exp_2], [jp_2], [gold_min_2], [gold_max_2], [chaos_min_2], [chaos_max_2], [drop_table_link_id], [texture_group], [local_flag], [script_on_dead]) VALUES ( @Pid, @Pmonster_group, @Pname_id, @Plocation_id, @Pmodel, @Pmotion_file_id, @Ptransform_level, @Pwalk_type, @Pslant_type, @Psize, @Pscale, @Ptarget_fx_size, @Pcamera_x, @Pcamera_y, @Pcamera_z, @Ptarget_x, @Ptarget_y, @Ptarget_z, @Plevel, @Pgrp, @Pmagic_type, @Prace, @Pvisible_range, @Pchase_range, @Pf_fisrt_attack, @Pf_group_first_attack, @Pf_response_casting, @Pf_response_race, @Pf_response_battle, @Pmonster_type, @Pstat_id, @Pfight_type, @Pmonster_skill_link_id, @Pmaterial, @Pweapon_type, @Pattack_motion_speed, @Pability, @Pstandard_walk_spped, @Pstandard_run_spped, @Pwalk_speed, @Prun_speed, @Pattack_range, @Phidesense_range, @Php, @Pmp, @Pattack_point, @Pmagic_point, @Pdefence, @Pmagic_defence, @Pattack_speed, @Pmagic_speed, @Paccuracy, @Pavoid, @Pmagic_accuracy, @Pmagic_avoid, @Ptaming_id, @Ptaming_percentage, @Ptaming_exp_mod, @Pexp, @Pjp, @Pgold_drop_percentage, @Pgold_min, @Pgold_max, @Pchaos_drop_percentage, @Pchaos_min, @Pchaos_max, @Pexp_2, @Pjp_2, @Pgold_min_2, @Pgold_max_2, @Pchaos_min_2, @Pchaos_max_2, @Pdrop_table_link_id, @Ptexture_group, @Plocal_flag, @Pscript_on_dead )";
        }

        public static String FromDatabase()
        {
            String rString = "SELECT ";
            foreach (FieldInfo fieldInfo in typeof(DB_MONSTERRESOURCE_62).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
            {
                rString += string.Format("[{0}], ", fieldInfo.Name.Substring(1, fieldInfo.Name.IndexOf('>') - 1));
            }
            return rString.Substring(0, rString.Length - 2) + " FROM MonsterResource";
        }

        public void FromDatabaseExecute(System.Data.SqlClient.SqlDataReader drExecute)
        {
            foreach (FieldInfo fieldInfo in typeof(DB_MONSTERRESOURCE_62).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
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
