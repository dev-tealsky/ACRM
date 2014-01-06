using System;
using System.IO;
using System.Reflection;

namespace ACRM
{
    public class DB_QUESTLINK
    {
        public Int32 npc_id { get; set; }
        public Int32 quest_id { get; set; }
        public Byte flag_start { get; set; }
        public Byte flag_progress { get; set; }
        public Byte flag_end { get; set; }

        public void ReadFile(BinaryReader br)
        {
            this.npc_id = br.ReadInt32();
            this.quest_id = br.ReadInt32();
            this.flag_start = br.ReadByte();
            this.flag_progress = br.ReadByte();
            this.flag_end = br.ReadByte();
        }

        public void SaveFile(BinaryWriter bw)
        {
            bw.Write(this.npc_id);
            bw.Write(this.quest_id);
            bw.Write(this.flag_start);
            bw.Write(this.flag_progress);
            bw.Write(this.flag_end);
        }

        public static String FromDatabase()
        {
            String rString = "SELECT ";
            foreach (FieldInfo fieldInfo in typeof(DB_QUESTLINK).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
            {
                rString += string.Format("[{0}], ", fieldInfo.Name.Substring(1, fieldInfo.Name.IndexOf('>') - 1));
            }
            return rString.Substring(0, rString.Length - 2) + " FROM QuestLinkResource";
        }

        public void FromDatabaseExecute(System.Data.SqlClient.SqlDataReader drExecute)
        {
            foreach (FieldInfo fieldInfo in typeof(DB_QUESTLINK).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
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