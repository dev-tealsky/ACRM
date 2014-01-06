using System;
using System.IO;
using System.Reflection;

namespace ACRM
{
    public class DB_SKILLTREEDISPLAY_62
    {
        public Int32 job_id { get; set; }
        public Int32 slot_v { get; set; }
        public Int32 skill1_id { get; set; }
        public Int32 skill2_id { get; set; }
        public Int32 skill3_id { get; set; }
        public Int32 skill4_id { get; set; }
        public Int32 skill5_id { get; set; }

        public void ReadFile(BinaryReader br)
        {
            this.job_id = br.ReadInt32();
            this.slot_v = br.ReadInt32();
            this.skill1_id = br.ReadInt32();
            this.skill2_id = br.ReadInt32();
            this.skill3_id = br.ReadInt32();
            this.skill4_id = br.ReadInt32();
            this.skill5_id = br.ReadInt32();
        }

        public void SaveFile(BinaryWriter bw)
        {
            bw.Write(this.job_id);
            bw.Write(this.slot_v);
            bw.Write(this.skill1_id);
            bw.Write(this.skill2_id);
            bw.Write(this.skill3_id);
            bw.Write(this.skill4_id);
            bw.Write(this.skill5_id);
        }

        public string ToDatabase()
        {
            return "INSERT [dbo].[SkillTreeDisplay] ([job_id], [slot_v], [skill1_id], [skill2_id], [skill3_id], [skill4_id], [skill5_id]) VALUES ( @Pjob_id, @Pslot_v, @Pskill1_id, @Pskill2_id, @Pskill3_id, @Pskill4_id, @Pskill5_id )";
        }

        public static String FromDatabase()
        {
            String rString = "SELECT ";
            foreach (FieldInfo fieldInfo in typeof(DB_SKILLTREEDISPLAY_62).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
            {
                rString += string.Format("[{0}], ", fieldInfo.Name.Substring(1, fieldInfo.Name.IndexOf('>') - 1));
            }
            return rString.Substring(0, rString.Length - 2) + " FROM SkillTreeDisplay ORDER BY job_id";
        }

        public void FromDatabaseExecute(System.Data.SqlClient.SqlDataReader drExecute)
        {
            foreach (FieldInfo fieldInfo in typeof(DB_SKILLTREEDISPLAY_62).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
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
