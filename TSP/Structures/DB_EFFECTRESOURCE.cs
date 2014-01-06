using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ACRM
{
    public class DB_EFFECTRESOURCE
    {
        public Int32 resource_effect_file_id { get; set; }
        public String resource_effect_file_name { get; set; }

        public void ReadFile(BinaryReader br)
        {
            this.resource_effect_file_id = br.ReadInt32();
            this.resource_effect_file_name = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
        }

        public void SaveFile(BinaryWriter bw)
        {
            bw.Write(this.resource_effect_file_id);
            bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.resource_effect_file_name));
            bw.Write(new Byte[256 - this.resource_effect_file_name.Length]);
        }

        public string ToDatabase()
        {
            return "INSERT INTO [dbo].[EffectResource] ([resource_effect_file_id], [resource_effect_file_name]) VALUES (@Presource_effect_file_id, @Presource_effect_file_name)";
        }

        public static String FromDatabase()
        {
            String rString = "SELECT ";
            foreach (FieldInfo fieldInfo in typeof(DB_EFFECTRESOURCE).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
            {
                rString += string.Format("[{0}], ", fieldInfo.Name.Substring(1, fieldInfo.Name.IndexOf('>') - 1));
            }
            return rString.Substring(0, rString.Length - 2) + " FROM EffectResource ORDER BY resource_effect_file_id";
        }

        public void FromDatabaseExecute(System.Data.SqlClient.SqlDataReader drExecute)
        {
            foreach (FieldInfo fieldInfo in typeof(DB_EFFECTRESOURCE).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
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