using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace ACRM
{
    public class DB_ENHANCERESOURCE
    {
        //Define the columns for this db/rdb
        //--------------------------------------
        public Int32 enhance_id { get; set; }
        public Byte enhance_type { get; set; }
        public Byte fail_result { get; set; }
        public Byte max_enhance { get; set; }
        public Int32 local_flag { get; set; }
        public Int32 need_item { get; set; }
        public Single percentage_1 { get; set; }
        public Single percentage_2 { get; set; }
        public Single percentage_3 { get; set; }
        public Single percentage_4 { get; set; }
        public Single percentage_5 { get; set; }
        public Single percentage_6 { get; set; }
        public Single percentage_7 { get; set; }
        public Single percentage_8 { get; set; }
        public Single percentage_9 { get; set; }
        public Single percentage_10 { get; set; }
        public Single percentage_11 { get; set; }
        public Single percentage_12 { get; set; }
        public Single percentage_13 { get; set; }
        public Single percentage_14 { get; set; }
        public Single percentage_15 { get; set; }
        public Single percentage_16 { get; set; }
        public Single percentage_17 { get; set; }
        public Single percentage_18 { get; set; }
        public Single percentage_19 { get; set; }
        public Single percentage_20 { get; set; }
        //----------------------------------------

        //Read the physical file
        public void ReadFile(BinaryReader br)
        {
            this.enhance_id = br.ReadInt32(); //4 byte
            this.enhance_type = br.ReadByte(); //1 byte
            this.fail_result = br.ReadByte(); //1 byte
            this.max_enhance = br.ReadByte(); //1 byte
            this.local_flag = br.ReadInt32(); //4 byte
            this.need_item = br.ReadInt32();
            this.percentage_1 = br.ReadSingle();
            this.percentage_2 = br.ReadSingle();
            this.percentage_3 = br.ReadSingle();
            this.percentage_4 = br.ReadSingle();
            this.percentage_5 = br.ReadSingle();
            this.percentage_6 = br.ReadSingle();
            this.percentage_7 = br.ReadSingle();
            this.percentage_8 = br.ReadSingle();
            this.percentage_9 = br.ReadSingle();
            this.percentage_10 = br.ReadSingle();
            this.percentage_11 = br.ReadSingle();
            this.percentage_12 = br.ReadSingle();
            this.percentage_13 = br.ReadSingle();
            this.percentage_14 = br.ReadSingle();
            this.percentage_15 = br.ReadSingle();
            this.percentage_16 = br.ReadSingle();
            this.percentage_17 = br.ReadSingle();
            this.percentage_18 = br.ReadSingle();
            this.percentage_19 = br.ReadSingle();
            this.percentage_20 = br.ReadSingle();
        }

        public void SaveFile(BinaryWriter bw)
        {
            bw.Write(this.enhance_id);
            bw.Write(this.enhance_type);
            bw.Write(this.fail_result);
            bw.Write(this.max_enhance);
            bw.Write(this.local_flag);
            bw.Write(this.need_item);
            bw.Write(this.percentage_1);
            bw.Write(this.percentage_2);
            bw.Write(this.percentage_3);
            bw.Write(this.percentage_4);
            bw.Write(this.percentage_5);
            bw.Write(this.percentage_6);
            bw.Write(this.percentage_7);
            bw.Write(this.percentage_8);
            bw.Write(this.percentage_9);
            bw.Write(this.percentage_10);
            bw.Write(this.percentage_11);
            bw.Write(this.percentage_12);
            bw.Write(this.percentage_13);
            bw.Write(this.percentage_14);
            bw.Write(this.percentage_15);
            bw.Write(this.percentage_16);
            bw.Write(this.percentage_17);
            bw.Write(this.percentage_18);
            bw.Write(this.percentage_19);
            bw.Write(this.percentage_20);
        }

        public static String FromDatabase()
        {
            String rString = "SELECT ";
            foreach (FieldInfo fieldInfo in typeof(DB_ENHANCERESOURCE).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
            {
                rString += string.Format("[{0}], ", fieldInfo.Name.Substring(1, fieldInfo.Name.IndexOf('>') - 1));
            }
            return rString.Substring(0, rString.Length - 2) + " FROM EnhanceResource ORDER BY enhance_id";
        }

        public void FromDatabaseExecute(System.Data.SqlClient.SqlDataReader drExecute)
        {
            foreach (FieldInfo fieldInfo in typeof(DB_ENHANCERESOURCE).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
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
