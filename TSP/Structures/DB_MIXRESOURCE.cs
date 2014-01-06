using System;
using System.IO;
using System.Reflection;

namespace ACRM
{
    public class DB_MIXRESOURCE
    {
        public Int32 id { get; set; }
        public Int32 mix_type { get; set; }
        public Int32 mix_value_01 { get; set; }
        public Int32 mix_value_02 { get; set; }
        public Int32 mix_value_03 { get; set; }
        public Int32 mix_value_04 { get; set; }
        public Int32 mix_value_05 { get; set; }
        public Int32 mix_value_06 { get; set; }
        public Int32 sub_material_count { get; set; }
        public Int32 main_type_01 { get; set; }
        public Int32 main_value_01 { get; set; }
        public Int32 main_type_02 { get; set; }
        public Int32 main_value_02 { get; set; }
        public Int32 main_type_03 { get; set; }
        public Int32 main_value_03 { get; set; }
        public Int32 main_type_04 { get; set; }
        public Int32 main_value_04 { get; set; }
        public Int32 main_type_05 { get; set; }
        public Int32 main_value_05 { get; set; }
        public Int32 sub01_type_01 { get; set; }
        public Int32 sub01_value_01 { get; set; }
        public Int32 sub01_type_02 { get; set; }
        public Int32 sub01_value_02 { get; set; }
        public Int32 sub01_type_03 { get; set; }
        public Int32 sub01_value_03 { get; set; }
        public Int32 sub01_type_04 { get; set; }
        public Int32 sub01_value_04 { get; set; }
        public Int32 sub01_type_05 { get; set; }
        public Int32 sub01_value_05 { get; set; }
        public Int32 sub02_type_01 { get; set; }
        public Int32 sub02_value_01 { get; set; }
        public Int32 sub02_type_02 { get; set; }
        public Int32 sub02_value_02 { get; set; }
        public Int32 sub02_type_03 { get; set; }
        public Int32 sub02_value_03 { get; set; }
        public Int32 sub02_type_04 { get; set; }
        public Int32 sub02_value_04 { get; set; }
        public Int32 sub02_type_05 { get; set; }
        public Int32 sub02_value_05 { get; set; }
        public Int32 sub03_type_01 { get; set; }
        public Int32 sub03_value_01 { get; set; }
        public Int32 sub03_type_02 { get; set; }
        public Int32 sub03_value_02 { get; set; }
        public Int32 sub03_type_03 { get; set; }
        public Int32 sub03_value_03 { get; set; }
        public Int32 sub03_type_04 { get; set; }
        public Int32 sub03_value_04 { get; set; }
        public Int32 sub03_type_05 { get; set; }
        public Int32 sub03_value_05 { get; set; }
        public Int32 sub04_type_01 { get; set; }
        public Int32 sub04_value_01 { get; set; }
        public Int32 sub04_type_02 { get; set; }
        public Int32 sub04_value_02 { get; set; }
        public Int32 sub04_type_03 { get; set; }
        public Int32 sub04_value_03 { get; set; }
        public Int32 sub04_type_04 { get; set; }
        public Int32 sub04_value_04 { get; set; }
        public Int32 sub04_type_05 { get; set; }
        public Int32 sub04_value_05 { get; set; }
        public Int32 sub05_type_01 { get; set; }
        public Int32 sub05_value_01 { get; set; }
        public Int32 sub05_type_02 { get; set; }
        public Int32 sub05_value_02 { get; set; }
        public Int32 sub05_type_03 { get; set; }
        public Int32 sub05_value_03 { get; set; }
        public Int32 sub05_type_04 { get; set; }
        public Int32 sub05_value_04 { get; set; }
        public Int32 sub05_type_05 { get; set; }
        public Int32 sub05_value_05 { get; set; }
        public Int32 sub06_type_01 { get; set; }
        public Int32 sub06_value_01 { get; set; }
        public Int32 sub06_type_02 { get; set; }
        public Int32 sub06_value_02 { get; set; }
        public Int32 sub06_type_03 { get; set; }
        public Int32 sub06_value_03 { get; set; }
        public Int32 sub06_type_04 { get; set; }
        public Int32 sub06_value_04 { get; set; }
        public Int32 sub06_type_05 { get; set; }
        public Int32 sub06_value_05 { get; set; }
        public Int32 sub07_type_01 { get; set; }
        public Int32 sub07_value_01 { get; set; }
        public Int32 sub07_type_02 { get; set; }
        public Int32 sub07_value_02 { get; set; }
        public Int32 sub07_type_03 { get; set; }
        public Int32 sub07_value_03 { get; set; }
        public Int32 sub07_type_04 { get; set; }
        public Int32 sub07_value_04 { get; set; }
        public Int32 sub07_type_05 { get; set; }
        public Int32 sub07_value_05 { get; set; }
        public Int32 sub08_type_01 { get; set; }
        public Int32 sub08_value_01 { get; set; }
        public Int32 sub08_type_02 { get; set; }
        public Int32 sub08_value_02 { get; set; }
        public Int32 sub08_type_03 { get; set; }
        public Int32 sub08_value_03 { get; set; }
        public Int32 sub08_type_04 { get; set; }
        public Int32 sub08_value_04 { get; set; }
        public Int32 sub08_type_05 { get; set; }
        public Int32 sub08_value_05 { get; set; }
        public Int32 sub09_type_01 { get; set; }
        public Int32 sub09_value_01 { get; set; }
        public Int32 sub09_type_02 { get; set; }
        public Int32 sub09_value_02 { get; set; }
        public Int32 sub09_type_03 { get; set; }
        public Int32 sub09_value_03 { get; set; }
        public Int32 sub09_type_04 { get; set; }
        public Int32 sub09_value_04 { get; set; }
        public Int32 sub09_type_05 { get; set; }
        public Int32 sub09_value_05 { get; set; }

        public void ReadFile(BinaryReader br)
        {
            this.id = br.ReadInt32();
            this.mix_type = br.ReadInt32();
            this.mix_value_01 = br.ReadInt32();
            this.mix_value_02 = br.ReadInt32();
            this.mix_value_03 = br.ReadInt32();
            this.mix_value_04 = br.ReadInt32();
            this.mix_value_05 = br.ReadInt32();
            this.mix_value_06 = br.ReadInt32();
            this.sub_material_count = br.ReadInt32();
            this.main_type_01 = br.ReadInt32();
            this.main_value_01 = br.ReadInt32();
            this.main_type_02 = br.ReadInt32();
            this.main_value_02 = br.ReadInt32();
            this.main_type_03 = br.ReadInt32();
            this.main_value_03 = br.ReadInt32();
            this.main_type_04 = br.ReadInt32();
            this.main_value_04 = br.ReadInt32();
            this.main_type_05 = br.ReadInt32();
            this.main_value_05 = br.ReadInt32();
            this.sub01_type_01 = br.ReadInt32();
            this.sub01_value_01 = br.ReadInt32();
            this.sub01_type_02 = br.ReadInt32();
            this.sub01_value_02 = br.ReadInt32();
            this.sub01_type_03 = br.ReadInt32();
            this.sub01_value_03 = br.ReadInt32();
            this.sub01_type_04 = br.ReadInt32();
            this.sub01_value_04 = br.ReadInt32();
            this.sub01_type_05 = br.ReadInt32();
            this.sub01_value_05 = br.ReadInt32();
            this.sub02_type_01 = br.ReadInt32();
            this.sub02_value_01 = br.ReadInt32();
            this.sub02_type_02 = br.ReadInt32();
            this.sub02_value_02 = br.ReadInt32();
            this.sub02_type_03 = br.ReadInt32();
            this.sub02_value_03 = br.ReadInt32();
            this.sub02_type_04 = br.ReadInt32();
            this.sub02_value_04 = br.ReadInt32();
            this.sub02_type_05 = br.ReadInt32();
            this.sub02_value_05 = br.ReadInt32();
            this.sub03_type_01 = br.ReadInt32();
            this.sub03_value_01 = br.ReadInt32();
            this.sub03_type_02 = br.ReadInt32();
            this.sub03_value_02 = br.ReadInt32();
            this.sub03_type_03 = br.ReadInt32();
            this.sub03_value_03 = br.ReadInt32();
            this.sub03_type_04 = br.ReadInt32();
            this.sub03_value_04 = br.ReadInt32();
            this.sub03_type_05 = br.ReadInt32();
            this.sub03_value_05 = br.ReadInt32();
            this.sub04_type_01 = br.ReadInt32();
            this.sub04_value_01 = br.ReadInt32();
            this.sub04_type_02 = br.ReadInt32();
            this.sub04_value_02 = br.ReadInt32();
            this.sub04_type_03 = br.ReadInt32();
            this.sub04_value_03 = br.ReadInt32();
            this.sub04_type_04 = br.ReadInt32();
            this.sub04_value_04 = br.ReadInt32();
            this.sub04_type_05 = br.ReadInt32();
            this.sub04_value_05 = br.ReadInt32();
            this.sub05_type_01 = br.ReadInt32();
            this.sub05_value_01 = br.ReadInt32();
            this.sub05_type_02 = br.ReadInt32();
            this.sub05_value_02 = br.ReadInt32();
            this.sub05_type_03 = br.ReadInt32();
            this.sub05_value_03 = br.ReadInt32();
            this.sub05_type_04 = br.ReadInt32();
            this.sub05_value_04 = br.ReadInt32();
            this.sub05_type_05 = br.ReadInt32();
            this.sub05_value_05 = br.ReadInt32();
            this.sub06_type_01 = br.ReadInt32();
            this.sub06_value_01 = br.ReadInt32();
            this.sub06_type_02 = br.ReadInt32();
            this.sub06_value_02 = br.ReadInt32();
            this.sub06_type_03 = br.ReadInt32();
            this.sub06_value_03 = br.ReadInt32();
            this.sub06_type_04 = br.ReadInt32();
            this.sub06_value_04 = br.ReadInt32();
            this.sub06_type_05 = br.ReadInt32();
            this.sub06_value_05 = br.ReadInt32();
            this.sub07_type_01 = br.ReadInt32();
            this.sub07_value_01 = br.ReadInt32();
            this.sub07_type_02 = br.ReadInt32();
            this.sub07_value_02 = br.ReadInt32();
            this.sub07_type_03 = br.ReadInt32();
            this.sub07_value_03 = br.ReadInt32();
            this.sub07_type_04 = br.ReadInt32();
            this.sub07_value_04 = br.ReadInt32();
            this.sub07_type_05 = br.ReadInt32();
            this.sub07_value_05 = br.ReadInt32();
            this.sub08_type_01 = br.ReadInt32();
            this.sub08_value_01 = br.ReadInt32();
            this.sub08_type_02 = br.ReadInt32();
            this.sub08_value_02 = br.ReadInt32();
            this.sub08_type_03 = br.ReadInt32();
            this.sub08_value_03 = br.ReadInt32();
            this.sub08_type_04 = br.ReadInt32();
            this.sub08_value_04 = br.ReadInt32();
            this.sub08_type_05 = br.ReadInt32();
            this.sub08_value_05 = br.ReadInt32();
            this.sub09_type_01 = br.ReadInt32();
            this.sub09_value_01 = br.ReadInt32();
            this.sub09_type_02 = br.ReadInt32();
            this.sub09_value_02 = br.ReadInt32();
            this.sub09_type_03 = br.ReadInt32();
            this.sub09_value_03 = br.ReadInt32();
            this.sub09_type_04 = br.ReadInt32();
            this.sub09_value_04 = br.ReadInt32();
            this.sub09_type_05 = br.ReadInt32();
            this.sub09_value_05 = br.ReadInt32();
        }

        public void SaveFile(BinaryWriter bw)
        {
            bw.Write(this.id);
            bw.Write(this.mix_type);
            bw.Write(this.mix_value_01);
            bw.Write(this.mix_value_02);
            bw.Write(this.mix_value_03);
            bw.Write(this.mix_value_04);
            bw.Write(this.mix_value_05);
            bw.Write(this.mix_value_06);
            bw.Write(this.sub_material_count);
            bw.Write(this.main_type_01);
            bw.Write(this.main_value_01);
            bw.Write(this.main_type_02);
            bw.Write(this.main_value_02);
            bw.Write(this.main_type_03);
            bw.Write(this.main_value_03);
            bw.Write(this.main_type_04);
            bw.Write(this.main_value_04);
            bw.Write(this.main_type_05);
            bw.Write(this.main_value_05);
            bw.Write(this.sub01_type_01);
            bw.Write(this.sub01_value_01);
            bw.Write(this.sub01_type_02);
            bw.Write(this.sub01_value_02);
            bw.Write(this.sub01_type_03);
            bw.Write(this.sub01_value_03);
            bw.Write(this.sub01_type_04);
            bw.Write(this.sub01_value_04);
            bw.Write(this.sub01_type_05);
            bw.Write(this.sub01_value_05);
            bw.Write(this.sub02_type_01);
            bw.Write(this.sub02_value_01);
            bw.Write(this.sub02_type_02);
            bw.Write(this.sub02_value_02);
            bw.Write(this.sub02_type_03);
            bw.Write(this.sub02_value_03);
            bw.Write(this.sub02_type_04);
            bw.Write(this.sub02_value_04);
            bw.Write(this.sub02_type_05);
            bw.Write(this.sub02_value_05);
            bw.Write(this.sub03_type_01);
            bw.Write(this.sub03_value_01);
            bw.Write(this.sub03_type_02);
            bw.Write(this.sub03_value_02);
            bw.Write(this.sub03_type_03);
            bw.Write(this.sub03_value_03);
            bw.Write(this.sub03_type_04);
            bw.Write(this.sub03_value_04);
            bw.Write(this.sub03_type_05);
            bw.Write(this.sub03_value_05);
            bw.Write(this.sub04_type_01);
            bw.Write(this.sub04_value_01);
            bw.Write(this.sub04_type_02);
            bw.Write(this.sub04_value_02);
            bw.Write(this.sub04_type_03);
            bw.Write(this.sub04_value_03);
            bw.Write(this.sub04_type_04);
            bw.Write(this.sub04_value_04);
            bw.Write(this.sub04_type_05);
            bw.Write(this.sub04_value_05);
            bw.Write(this.sub05_type_01);
            bw.Write(this.sub05_value_01);
            bw.Write(this.sub05_type_02);
            bw.Write(this.sub05_value_02);
            bw.Write(this.sub05_type_03);
            bw.Write(this.sub05_value_03);
            bw.Write(this.sub05_type_04);
            bw.Write(this.sub05_value_04);
            bw.Write(this.sub05_type_05);
            bw.Write(this.sub05_value_05);
            bw.Write(this.sub06_type_01);
            bw.Write(this.sub06_value_01);
            bw.Write(this.sub06_type_02);
            bw.Write(this.sub06_value_02);
            bw.Write(this.sub06_type_03);
            bw.Write(this.sub06_value_03);
            bw.Write(this.sub06_type_04);
            bw.Write(this.sub06_value_04);
            bw.Write(this.sub06_type_05);
            bw.Write(this.sub06_value_05);
            bw.Write(this.sub07_type_01);
            bw.Write(this.sub07_value_01);
            bw.Write(this.sub07_type_02);
            bw.Write(this.sub07_value_02);
            bw.Write(this.sub07_type_03);
            bw.Write(this.sub07_value_03);
            bw.Write(this.sub07_type_04);
            bw.Write(this.sub07_value_04);
            bw.Write(this.sub07_type_05);
            bw.Write(this.sub07_value_05);
            bw.Write(this.sub08_type_01);
            bw.Write(this.sub08_value_01);
            bw.Write(this.sub08_type_02);
            bw.Write(this.sub08_value_02);
            bw.Write(this.sub08_type_03);
            bw.Write(this.sub08_value_03);
            bw.Write(this.sub08_type_04);
            bw.Write(this.sub08_value_04);
            bw.Write(this.sub08_type_05);
            bw.Write(this.sub08_value_05);
            bw.Write(this.sub09_type_01);
            bw.Write(this.sub09_value_01);
            bw.Write(this.sub09_type_02);
            bw.Write(this.sub09_value_02);
            bw.Write(this.sub09_type_03);
            bw.Write(this.sub09_value_03);
            bw.Write(this.sub09_type_04);
            bw.Write(this.sub09_value_04);
            bw.Write(this.sub09_type_05);
            bw.Write(this.sub09_value_05);
        }

        public static String FromDatabase()
        {
            String rString = "SELECT ";
            foreach (FieldInfo fieldInfo in typeof(DB_MIXRESOURCE).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
            {
                rString += string.Format("[{0}], ", fieldInfo.Name.Substring(1, fieldInfo.Name.IndexOf('>') - 1));
            }
            return rString.Substring(0, rString.Length - 2) + " FROM MixResource";
        }

        public void FromDatabaseExecute(System.Data.SqlClient.SqlDataReader drExecute)
        {
            foreach (FieldInfo fieldInfo in typeof(DB_MIXRESOURCE).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
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
