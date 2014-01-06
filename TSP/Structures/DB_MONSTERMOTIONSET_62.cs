using System;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ACRM
{
    public class DB_MONSTERMOTIONSET_62
    {
        public string attack_1
        {
            get;
            set;
        }

        public string attack_2
        {
            get;
            set;
        }

        public string attack_3
        {
            get;
            set;
        }

        public string battle
        {
            get;
            set;
        }

        public string be_attack
        {
            get;
            set;
        }

        public string be_attack2
        {
            get;
            set;
        }

        public string casting_1
        {
            get;
            set;
        }

        public string casting_2
        {
            get;
            set;
        }

        public string casting_3
        {
            get;
            set;
        }

        public int character_id
        {
            get;
            set;
        }

        public string dead
        {
            get;
            set;
        }

        public string def
        {
            get;
            set;
        }

        public string draw_bow
        {
            get;
            set;
        }

        public string fire_bow
        {
            get;
            set;
        }

        public string flying_dead
        {
            get;
            set;
        }

        public string idle
        {
            get;
            set;
        }

        public string melee_1
        {
            get;
            set;
        }

        public string melee_2
        {
            get;
            set;
        }

        public string melee_3
        {
            get;
            set;
        }

        public string mount
        {
            get;
            set;
        }

        public string run
        {
            get;
            set;
        }

        public string take
        {
            get;
            set;
        }

        public string target_bow
        {
            get;
            set;
        }

        public string unmount
        {
            get;
            set;
        }

        public string walk
        {
            get;
            set;
        }

        public static string FromDatabase()
        {
            string str = "SELECT ";
            FieldInfo[] fields = typeof(DB_MONSTERMOTIONSET_62).GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            for (int i = 0; i < (int)fields.Length; i++)
            {
                FieldInfo fieldInfo = fields[i];
                str = string.Concat(str, string.Format("[{0}], ", fieldInfo.Name.Substring(1, fieldInfo.Name.IndexOf('>') - 1)));
            }
            string str1 = string.Concat(str.Substring(0, str.Length - 2), " FROM MonsterMotionSet ORDER BY character_id");
            return str1;
        }

        public void FromDatabaseExecute(SqlDataReader drExecute)
        {
            FieldInfo[] fields = typeof(DB_MONSTERMOTIONSET_62).GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            for (int i = 0; i < (int)fields.Length; i++)
            {
                FieldInfo fieldInfo = fields[i];
                string str = null;
                str = fieldInfo.Name.Substring(1, fieldInfo.Name.IndexOf('>') - 1);
                if (fieldInfo.FieldType == typeof(string))
                {
                    fieldInfo.SetValue(this, drExecute[str].ToString());
                }
                else if (fieldInfo.FieldType == typeof(short))
                {
                    fieldInfo.SetValue(this, Convert.ToInt16(drExecute[str]));
                }
                else if (fieldInfo.FieldType == typeof(int))
                {
                    fieldInfo.SetValue(this, Convert.ToInt32(drExecute[str]));
                }
                else if (fieldInfo.FieldType == typeof(float))
                {
                    fieldInfo.SetValue(this, Convert.ToSingle(drExecute[str]));
                }
                else if (fieldInfo.FieldType == typeof(decimal))
                {
                    fieldInfo.SetValue(this, Convert.ToDecimal(drExecute[str]));
                }
                else if (fieldInfo.FieldType == typeof(double))
                {
                    fieldInfo.SetValue(this, Convert.ToDouble(drExecute[str]));
                }
                else if (fieldInfo.FieldType == typeof(byte))
                {
                    fieldInfo.SetValue(this, Convert.ToByte(drExecute[str]));
                }
            }
        }

        public void ReadFile(BinaryReader br)
        {
            this.character_id = br.ReadInt32();
            this.def = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.battle = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.idle = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.walk = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.run = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.be_attack = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.be_attack2 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.dead = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.flying_dead = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.take = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.attack_1 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.attack_2 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.attack_3 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.draw_bow = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.target_bow = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.fire_bow = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.casting_1 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.casting_2 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.casting_3 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.melee_1 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.melee_2 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.melee_3 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.mount = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.unmount = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
        }

        public void SaveFile(BinaryWriter bw)
        {
            bw.Write(this.character_id);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.def));
            bw.Write(new byte[256 - this.def.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.battle));
            bw.Write(new byte[256 - this.battle.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.idle));
            bw.Write(new byte[256 - this.idle.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.walk));
            bw.Write(new byte[256 - this.walk.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.run));
            bw.Write(new byte[256 - this.run.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.be_attack));
            bw.Write(new byte[256 - this.be_attack.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.be_attack2));
            bw.Write(new byte[256 - this.be_attack2.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.dead));
            bw.Write(new byte[256 - this.dead.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.flying_dead));
            bw.Write(new byte[256 - this.flying_dead.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.take));
            bw.Write(new byte[256 - this.take.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.attack_1));
            bw.Write(new byte[256 - this.attack_1.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.attack_2));
            bw.Write(new byte[256 - this.attack_2.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.attack_3));
            bw.Write(new byte[256 - this.attack_3.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.draw_bow));
            bw.Write(new byte[256 - this.draw_bow.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.target_bow));
            bw.Write(new byte[256 - this.target_bow.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.fire_bow));
            bw.Write(new byte[256 - this.fire_bow.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.casting_1));
            bw.Write(new byte[256 - this.casting_1.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.casting_2));
            bw.Write(new byte[256 - this.casting_2.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.casting_3));
            bw.Write(new byte[256 - this.casting_3.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.melee_1));
            bw.Write(new byte[256 - this.melee_1.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.melee_2));
            bw.Write(new byte[256 - this.melee_2.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.melee_3));
            bw.Write(new byte[256 - this.melee_3.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.mount));
            bw.Write(new byte[256 - this.mount.Length]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.unmount));
            bw.Write(new byte[256 - this.unmount.Length]);
        }

        public string ToDatabase()
        {
            return "INSERT [dbo].[MonsterMotionSet] ([character_id], [def], [battle], [idle], [walk], [run], [be_attack], [be_attack2], [dead], [flying_dead], [take], [attack_1], [attack_2], [attack_3], [draw_bow], [target_bow], [fire_bow], [casting_1], [casting_2], [casting_3], [melee_1], [melee_2], [melee_3], [mount], [unmount]) VALUES ( @Pcharacter_id, @Pdef, @Pbattle, @Pidle, @Pwalk, @Prun, @Pbe_attack, @Pbe_attack2, @Pdead, @Pflying_dead, @Ptake, @Pattack_1, @Pattack_2, @Pattack_3, @Pdraw_bow, @Ptarget_bow, @Pfire_bow, @Pcasting_1, @Pcasting_2, @Pcasting_3, @Pmelee_1, @Pmelee_2, @Pmelee_3, @Pmount, @Punmount )";
        }
    }
}
