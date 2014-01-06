using System;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ACRM
{
    public class DB_TITLERESOURCE
    {
        public Int32 id { get; set; }
        public Int32 name_id { get; set; }
        public Int32 tooltip_id { get; set; }
        public Int32 status_id { get; set; }
        public Byte rate { get; set; }
        public Int16 opt_type_0 { get; set; }
        public Single opt_var1_0 { get; set; }
        public Single opt_var2_0 { get; set; }
        public Int16 opt_type_1 { get; set; }
        public Single opt_var1_1 { get; set; }
        public Single opt_var2_1 { get; set; }
        public Int16 opt_type_2 { get; set; }
        public Single opt_var1_2 { get; set; }
        public Single opt_var2_2 { get; set; }
        public Int16 opt_type_3 { get; set; }
        public Single opt_var1_3 { get; set; }
        public Single opt_var2_3 { get; set; }
        public Int16 opt_type_4 { get; set; }
        public Single opt_var1_4 { get; set; }
        public Single opt_var2_4 { get; set; }
        public Int16 opt_type_5 { get; set; }
        public Single opt_var1_5 { get; set; }
        public Single opt_var2_5 { get; set; }
        public Int16 opt_type_6 { get; set; }
        public Single opt_var1_6 { get; set; }
        public Single opt_var2_6 { get; set; }
        public Int16 opt_type_7 { get; set; }
        public Single opt_var1_7 { get; set; }
        public Single opt_var2_7 { get; set; }
        public Int32 effect_id { get; set; }
        public Int32 local_flag { get; set; }
        public Byte is_periodic { get; set; }
        public DateTime begin_of_period { get; set; }
        public DateTime end_of_period { get; set; }

        public void ReadFile(BinaryReader br)
        {
            this.id = br.ReadInt32();
            this.name_id = br.ReadInt32();
            this.tooltip_id = br.ReadInt32();
            this.status_id = br.ReadInt32();
            this.rate = br.ReadByte();
            this.opt_type_0 = br.ReadInt16();
            this.opt_type_1 = br.ReadInt16();
            this.opt_type_2 = br.ReadInt16();
            this.opt_type_3 = br.ReadInt16();
            this.opt_type_4 = br.ReadInt16();
            this.opt_type_5 = br.ReadInt16();
            this.opt_type_6 = br.ReadInt16();
            this.opt_type_7 = br.ReadInt16();
            this.opt_var1_0 = br.ReadSingle();
            this.opt_var1_1 = br.ReadSingle();
            this.opt_var1_2 = br.ReadSingle();
            this.opt_var1_3 = br.ReadSingle();
            this.opt_var1_4 = br.ReadSingle();
            this.opt_var1_5 = br.ReadSingle();
            this.opt_var1_6 = br.ReadSingle();
            this.opt_var1_7 = br.ReadSingle();
            this.opt_var2_0 = br.ReadSingle();
            this.opt_var2_1 = br.ReadSingle();
            this.opt_var2_2 = br.ReadSingle();
            this.opt_var2_3 = br.ReadSingle();
            this.opt_var2_4 = br.ReadSingle();
            this.opt_var2_5 = br.ReadSingle();
            this.opt_var2_6 = br.ReadSingle();
            this.opt_var2_7 = br.ReadSingle();
            this.effect_id = br.ReadInt32();
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
        }

        public void SaveFile(BinaryWriter bw)
        {

        }

        public static string FromDatabase()
        {
            string str = "SELECT ";
            FieldInfo[] fields = typeof(DB_TITLERESOURCE).GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            for (int i = 0; i < (int)fields.Length; i++)
            {
                FieldInfo fieldInfo = fields[i];
                str = string.Concat(str, string.Format("[{0}], ", fieldInfo.Name.Substring(1, fieldInfo.Name.IndexOf('>') - 1)));
            }
            string str1 = string.Concat(str.Substring(0, str.Length - 2), " FROM WorldLocation ORDER BY id");
            return str1;
        }

        public void FromDatabaseExecute(SqlDataReader drExecute)
        {
            FieldInfo[] fields = typeof(DB_TITLERESOURCE).GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
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

    }
}

