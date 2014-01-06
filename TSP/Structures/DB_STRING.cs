using System;
using System.IO;
using System.Reflection;

namespace ACRM
{
    public class DB_STRING
    {
        public String name { get; set; }
        public Int32 group_id { get; set; }
        public Int32 code { get; set; }
        public String value { get; set; }

        public void ReadFile(BinaryReader br)
        {
            int name_len, value_len;
            name_len = br.ReadInt32();
            value_len = br.ReadInt32();
            this.name = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(name_len));
            this.value = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(value_len));
            this.code = br.ReadInt32();
            this.group_id = br.ReadInt32();
            //this.name = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(1024), lang);
            //this.value = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(1024), lang);
            br.ReadBytes(16);
        }

        public void SaveFile(BinaryWriter bw)
        {
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.name).Length + 1);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.value).Length + 1);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.name));
            bw.Write(new Byte[1]);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.value));
            bw.Write(new Byte[1]);
            bw.Write(this.code);
            bw.Write(this.group_id);
            bw.Write(new Byte[16]);
        }

        public string ToDatabase()
        {
            return "INSERT INTO [dbo].[StringResource] ([name], [group_id], [code], [value]) VALUES (@Pname, @Pgroup_id, @Pcode, @Pvalue)";
        }

        public static String FromDatabase()
        {
            String rString = "SELECT ";
            foreach (FieldInfo fieldInfo in typeof(DB_STRING).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
            {
                rString += string.Format("[{0}], ", fieldInfo.Name.Substring(1, fieldInfo.Name.IndexOf('>') - 1));
            }
            return rString.Substring(0, rString.Length - 2) + " FROM StringResource ORDER BY code";
        }

        public void FromDatabaseExecute(System.Data.SqlClient.SqlDataReader drExecute)
        {
            foreach (FieldInfo fieldInfo in typeof(DB_STRING).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
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
