using System;
using System.IO;
using System.Reflection;

namespace ACRM
{
    public class DB_JOBRESOURCE
    {
        public Int32 id { get; set; }
        public Int32 text_id { get; set; }
        public Int32 stati_id { get; set; }
        public Byte job_class { get; set; }
        public Byte job_depth { get; set; }
        public Int16 up_lv { get; set; }
        public Int16 up_jlv { get; set; }
        public Int16 available_job_0 { get; set; }
        public Int16 available_job_1 { get; set; }
        public Int16 available_job_2 { get; set; }
        public Int16 available_job_3 { get; set; }
        public Int32 icon_id { get; set; }
        public String icon_file_name { get; set; }

        public void ReadFile(BinaryReader br)
        {
            this.id = br.ReadInt32();
            this.text_id = br.ReadInt32();
            this.stati_id = br.ReadInt32();
            this.job_class = br.ReadByte();
            this.job_depth = br.ReadByte();
            this.up_lv = br.ReadInt16();
            this.up_jlv = br.ReadInt16();
            this.available_job_0 = br.ReadInt16();
            this.available_job_1 = br.ReadInt16();
            this.available_job_2 = br.ReadInt16();
            this.available_job_3 = br.ReadInt16();
            br.ReadInt16(); // const 163
            this.icon_id = br.ReadInt32();
            this.icon_file_name = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
        }

        public void SaveFile(BinaryWriter bw)
        {
            bw.Write(this.id);
            bw.Write(this.text_id);
            bw.Write(this.stati_id);
            bw.Write(this.job_class);
            bw.Write(this.job_depth);
            bw.Write(this.up_lv);
            bw.Write(this.up_jlv);
            bw.Write(this.available_job_0);
            bw.Write(this.available_job_1);
            bw.Write(this.available_job_2);
            bw.Write(this.available_job_3);
            bw.Write(Convert.ToInt16(163));
            bw.Write(this.icon_id);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.icon_file_name));
            bw.Write(new Byte[256 - this.icon_file_name.Length]);
        }

        public string ToDatabase()
        {
            return "INSERT [dbo].[JobResource] ([id], [text_id], [stati_id], [job_class], [job_depth], [up_lv], [up_jlv], [available_job_0], [available_job_1], [available_job_2], [available_job_3], [icon_id], [icon_file_name]) VALUES ( @Pid, @Ptext_id, @Pstati_id, @Pjob_class, @Pjob_depth, @Pup_lv, @Pup_jlv, @Pavailable_job_0, @Pavailable_job_1, @Pavailable_job_2, @Pavailable_job_3, @Picon_id, @Picon_file_name )";
        }

        public static String FromDatabase()
        {
            String rString = "SELECT ";
            foreach (FieldInfo fieldInfo in typeof(DB_JOBRESOURCE).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
            {
                rString += string.Format("[{0}], ", fieldInfo.Name.Substring(1, fieldInfo.Name.IndexOf('>') - 1));
            }
            return rString.Substring(0, rString.Length - 2) + " FROM JobResource ORDER BY id";
        }

        public void FromDatabaseExecute(System.Data.SqlClient.SqlDataReader drExecute)
        {
            foreach (FieldInfo fieldInfo in typeof(DB_JOBRESOURCE).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
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
