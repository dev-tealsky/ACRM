using System;
using System.IO;
using System.Reflection;

namespace ACRM
{
    public class DB_ENHANCEFX
    {
        public Int32 id { get; set; }
        public Int32 enhance_level { get; set; }
        public Int32 enhance_color_r { get; set; }
        public Int32 enhance_color_g { get; set; }
        public Int32 enhance_color_b { get; set; }
        public Int32 wt_length { get; set; }
        public Int32 wt_width { get; set; }
        public Int32 wt00_a { get; set; }
        public Int32 wt00_r { get; set; }
        public Int32 wt00_g { get; set; }
        public Int32 wt00_b { get; set; }
        public Int32 wt01_a { get; set; }
        public Int32 wt01_r { get; set; }
        public Int32 wt01_g { get; set; }
        public Int32 wt01_b { get; set; }
        public Int32 wt10_a { get; set; }
        public Int32 wt10_r { get; set; }
        public Int32 wt10_g { get; set; }
        public Int32 wt10_b { get; set; }
        public Int32 wt11_a { get; set; }
        public Int32 wt11_r { get; set; }
        public Int32 wt11_g { get; set; }
        public Int32 wt11_b { get; set; }
        public Int32 wt_texture_ID { get; set; }

        public void ReadFile(BinaryReader br)
        {
            foreach (FieldInfo field in typeof(DB_ENHANCEFX).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
            {
                if (field.FieldType == typeof(Byte))
                {
                    field.SetValue(this, br.ReadByte());
                }
                else if (field.FieldType == typeof(Int16))
                {
                    field.SetValue(this, br.ReadInt16());
                }
                else if (field.FieldType == typeof(Int32))
                {
                    field.SetValue(this, br.ReadInt32());
                }
                else if (field.FieldType == typeof(Int64))
                {
                    field.SetValue(this, br.ReadInt64());
                }
                else if (field.FieldType == typeof(Single))
                {
                    field.SetValue(this, br.ReadSingle());
                }
                else if (field.FieldType == typeof(Decimal))
                {
                    field.SetValue(this, Convert.ToDecimal(br.ReadSingle()));
                }
                else if (field.FieldType == typeof(Double))
                {
                    field.SetValue(this, Convert.ToDouble(br.ReadSingle()));
                }
                else if (field.FieldType == typeof(String))
                {
                    field.SetValue(this, ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256)));
                }
            }
        }

        public void Save(BinaryWriter bw)
        {
            foreach (FieldInfo field in typeof(DB_ENHANCEFX).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
            {
                if (field.FieldType == typeof(String))
                {
                    bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(field.GetValue(this).ToString(), 256));
                }
                else if (field.FieldType == typeof(Decimal) || field.FieldType == typeof(Double))
                {
                    bw.Write(Convert.ToSingle(field.GetValue(this)));
                }
                else
                {
                    bw.Write((dynamic)field.GetValue(this));
                }
            }
        }

        public string ToDatabase()
        {
            string a = "INSERT INTO EnhanceFX (";
            string b = ") VALUES (";
            foreach (FieldInfo field in typeof(DB_ENHANCEFX).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
            {
                a += string.Format("{0}, ", field.Name.Substring(1, field.Name.IndexOf('>') - 1));
                if (field.FieldType == typeof(String))
                {
                    b += string.Format("'{0}', ", field.GetValue(this));
                }
                else if (field.FieldType == typeof(Decimal) || field.FieldType == typeof(Double) || field.FieldType == typeof(Single))
                {
                    b += string.Format("{0}, ", field.GetValue(this).ToString().Replace(',', '.'));
                }
                else
                {
                    b += string.Format("{0}, ", field.GetValue(this));
                }
            }
            a = a.Substring(0, a.Length - 2);
            b = b.Substring(0, b.Length - 2);
            b += ")";
            return a + b;
        }

        public static String FromDatabase()
        {
            String rString = "SELECT ";
            foreach (FieldInfo field in typeof(DB_ENHANCEFX).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
            {
                rString += string.Format("{0}, ", field.Name.Substring(1, field.Name.IndexOf('>') - 1));
            }
            return rString.Substring(0, rString.Length - 2) + " FROM EnhanceFX ORDER by id";
        }

        public void FromDatabaseExecute(System.Data.SqlClient.SqlDataReader drExecute)
        {
            foreach (FieldInfo field in typeof(DB_ENHANCEFX).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
            {
                String sTempName = field.Name.Substring(1, field.Name.IndexOf('>') - 1);
                if (field.FieldType == typeof(Byte))
                {
                    field.SetValue(this, Convert.ToByte(drExecute[sTempName]));
                }
                else if (field.FieldType == typeof(Int16))
                {
                    field.SetValue(this, Convert.ToInt16(drExecute[sTempName]));
                }
                else if (field.FieldType == typeof(Int32))
                {
                    field.SetValue(this, Convert.ToInt32(drExecute[sTempName]));
                }
                else if (field.FieldType == typeof(Int64))
                {
                    field.SetValue(this, Convert.ToInt64(drExecute[sTempName]));
                }
                else if (field.FieldType == typeof(Single))
                {
                    field.SetValue(this, Convert.ToSingle(drExecute[sTempName]));
                }
                else if (field.FieldType == typeof(Decimal))
                {
                    field.SetValue(this, Convert.ToDecimal(drExecute[sTempName]));
                }
                else if (field.FieldType == typeof(Double))
                {
                    field.SetValue(this, Convert.ToDouble(drExecute[sTempName]));
                }
                else if (field.FieldType == typeof(String))
                {
                    field.SetValue(this, drExecute[sTempName].ToString());
                }
            }
        }

        public static void SearchList(System.Windows.Forms.ComboBox search_list)
        {
            search_list.Items.Clear();
            foreach (FieldInfo field in typeof(DB_ENHANCEFX).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
            {
                search_list.Items.Add(field.Name.Substring(1, field.Name.IndexOf('>') - 1));
            }
            search_list.SelectedIndex = 0;
        }

    }
}