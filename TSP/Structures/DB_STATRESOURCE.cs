using System;
using System.IO;
using System.Reflection;

namespace ACRM
{
    public class DB_STATRESOURCE
    {
        public Int16 id { get; set; }
        public Int16 str { get; set; }
        public Int16 vit { get; set; }
        public Int16 dex { get; set; }
        public Int16 agi { get; set; }
        public Int16 Int { get; set; }
        public Int16 men { get; set; }
        public Int16 luk { get; set; }

        public void ReadFile(BinaryReader br)
        {
            this.id = br.ReadInt16();
            this.str = br.ReadInt16();
            this.vit = br.ReadInt16();
            this.dex = br.ReadInt16();
            this.agi = br.ReadInt16();
            this.Int = br.ReadInt16();
            this.men = br.ReadInt16();
            this.luk = br.ReadInt16();
        }

        public void SaveFile(BinaryWriter bw)
        {
            bw.Write(this.id);
            bw.Write(this.str);
            bw.Write(this.vit);
            bw.Write(this.dex);
            bw.Write(this.agi);
            bw.Write(this.Int);
            bw.Write(this.men);
            bw.Write(this.luk);
        }

        public string ToDatabase()
        {
            return "INSERT [dbo].[StatResource] ([id], [str], [vit], [dex], [agi], [int], [men], [luk]) VALUES ( @Pid, @Pstr, @Pvit, @Pdex, @Pagi, @Pint, @Pmen, @Pluk )";
        }

        public static String FromDatabase()
        {
            String rString = "SELECT ";
            foreach (FieldInfo fieldInfo in typeof(DB_STATRESOURCE).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
            {
                rString += string.Format("[{0}], ", fieldInfo.Name.Substring(1, fieldInfo.Name.IndexOf('>') - 1));
            }
            return rString.Substring(0, rString.Length - 2) + " FROM StatResource ORDER BY id";
        }

        public void FromDatabaseExecute(System.Data.SqlClient.SqlDataReader drExecute)
        {
            foreach (FieldInfo fieldInfo in typeof(DB_STATRESOURCE).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
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
