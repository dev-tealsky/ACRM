using System;
using System.IO;
using System.Reflection;

namespace ACRM
{
    public class DB_SKILLTREERESOURCE_62
    {
        public Int32 job_id { get; set; }
        public Int32 skill_id { get; set; }
        public Int32 min_skill_lv { get; set; }
        public Int32 max_skill_lv { get; set; }
        public Int32 lv { get; set; }
        public Int32 job_lv { get; set; }
        public float jp_ratio { get; set; }
        public Int32 need_skill_id_1 { get; set; }
        public Int32 need_skill_lv_1 { get; set; }
        public Int32 need_skill_id_2 { get; set; }
        public Int32 need_skill_lv_2 { get; set; }
        public Int32 need_skill_id_3 { get; set; }
        public Int32 need_skill_lv_3 { get; set; }
        //public Int32 cenhance_min { get; set; }
        //public Int32 cenhance_max { get; set; }

        public void ReadFile(BinaryReader br)
        {
            this.job_id = br.ReadInt32();
            this.skill_id = br.ReadInt32();
            this.min_skill_lv = br.ReadInt32();
            this.max_skill_lv = br.ReadInt32();
            this.lv = br.ReadInt32();
            this.job_lv = br.ReadInt32();
            this.jp_ratio = br.ReadSingle();
            this.need_skill_id_1 = br.ReadInt32();
            this.need_skill_id_2 = br.ReadInt32();
            this.need_skill_id_3 = br.ReadInt32();
            this.need_skill_lv_1 = br.ReadInt32();
            this.need_skill_lv_2 = br.ReadInt32();
            this.need_skill_lv_3 = br.ReadInt32();
            //this.cenhance_min = br.ReadInt32();
            //this.cenhance_max = br.ReadInt32();
        }

        public void SaveFile(BinaryWriter bw)
        {
            bw.Write(this.skill_id);
            bw.Write(this.min_skill_lv);
            bw.Write(this.max_skill_lv);
            bw.Write(this.lv);
            bw.Write(this.job_lv);
            bw.Write(this.jp_ratio);
            bw.Write(this.need_skill_id_1);
            bw.Write(this.need_skill_id_2);
            bw.Write(this.need_skill_id_3);
            bw.Write(this.need_skill_lv_1);
            bw.Write(this.need_skill_lv_2);
            bw.Write(this.need_skill_lv_3);
            //bw.Write(this.cenhance_min);
            //bw.Write(this.cenhance_max);
        }

        public int get_number(int id, int count, System.ComponentModel.BindingList<DB_SKILLTREERESOURCE_62> blskilltreeRes)
        {
            int num = 0;

            foreach (DB_SKILLTREERESOURCE_62 skilltreeRes in blskilltreeRes)
            {
                if (skilltreeRes.job_id == id)
                {
                    num++;
                }
            }
            return num;
        }

        public string ToDatabase()
        {
            return "INSERT [dbo].[SkillTreeResource] ([job_id], [skill_id], [min_skill_lv], [max_skill_lv], [lv], [job_lv], [jp_ratio], [need_skill_id_1], [need_skill_lv_1], [need_skill_id_2], [need_skill_lv_2], [need_skill_id_3], [need_skill_lv_3]) VALUES ( @Pjob_id, @Pskill_id, @Pmin_skill_lv, @Pmax_skill_lv, @Plv, @Pjob_lv, @Pjp_ratio, @Pneed_skill_id_1, @Pneed_skill_lv_1, @Pneed_skill_id_2, @Pneed_skill_lv_2, @Pneed_skill_id_3, @Pneed_skill_lv_3)";
        }

        public static String FromDatabase()
        {
            String rString = "SELECT ";
            foreach (FieldInfo fieldInfo in typeof(DB_SKILLTREERESOURCE_62).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
            {
                rString += string.Format("[{0}], ", fieldInfo.Name.Substring(1, fieldInfo.Name.IndexOf('>') - 1));
            }
            return rString.Substring(0, rString.Length - 2) + " FROM SkillTreeResource ORDER BY job_id";
        }

        public void FromDatabaseExecute(System.Data.SqlClient.SqlDataReader drExecute)
        {
            foreach (FieldInfo fieldInfo in typeof(DB_SKILLTREERESOURCE_62).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
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
