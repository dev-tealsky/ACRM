using System;
using System.IO;
using System.Reflection;

public class DB_ITEMEFFECTRESOURCE
{
    public Int32 id { get; set; }
    public Int32 ordinal_id { get; set; }
    public Int32 tooltip_id { get; set; }
    public Int16 effect_type { get; set; }
    public Int16 effect_id { get; set; }
    public Int16 effect_level { get; set; }
    public Double value_0 { get; set; }
    public Double value_1 { get; set; }
    public Double value_2 { get; set; }
    public Double value_3 { get; set; }
    public Double value_4 { get; set; }
    public Double value_5 { get; set; }
    public Double value_6 { get; set; }
    public Double value_7 { get; set; }
    public Double value_8 { get; set; }
    public Double value_9 { get; set; }
    public Double value_10 { get; set; }
    public Double value_11 { get; set; }
    public Double value_12 { get; set; }
    public Double value_13 { get; set; }
    public Double value_14 { get; set; }
    public Double value_15 { get; set; }
    public Double value_16 { get; set; }
    public Double value_17 { get; set; }
    public Double value_18 { get; set; }
    public Double value_19 { get; set; }

    public void ReadFile(BinaryReader br)
    {
        this.id = br.ReadInt32();
        this.ordinal_id = br.ReadInt32();
        this.tooltip_id = br.ReadInt32();
        br.ReadByte(); // const 255
        this.effect_id = br.ReadInt16();
        if (this.effect_id == 1) { this.effect_type = 1; }
        else if (this.effect_id == 2) { this.effect_type = 2; }
        else if (this.effect_id == 4) { this.effect_type = 4; }
        else { this.effect_type = 3; }
        this.effect_level = br.ReadInt16();
        this.value_0 = br.ReadDouble();
        this.value_1 = br.ReadDouble();
        this.value_2 = br.ReadDouble();
        this.value_3 = br.ReadDouble();
        this.value_4 = br.ReadDouble();
        this.value_5 = br.ReadDouble();
        this.value_6 = br.ReadDouble();
        this.value_7 = br.ReadDouble();
        this.value_8 = br.ReadDouble();
        this.value_9 = br.ReadDouble();
        this.value_10 = br.ReadDouble();
        this.value_11 = br.ReadDouble();
        this.value_12 = br.ReadDouble();
        this.value_13 = br.ReadDouble();
        this.value_14 = br.ReadDouble();
        this.value_15 = br.ReadDouble();
        this.value_16 = br.ReadDouble();
        this.value_17 = br.ReadDouble();
        this.value_18 = br.ReadDouble();
        this.value_19 = br.ReadDouble();
        br.ReadInt32();
    }

    public void SaveFile(BinaryWriter bw)
    {
        bw.Write(this.id);
        bw.Write(this.ordinal_id);
        bw.Write(this.tooltip_id);
        bw.Write(Convert.ToByte(255));
        bw.Write(this.effect_id);
        bw.Write(this.effect_level);
        bw.Write(this.value_0);
        bw.Write(this.value_1);
        bw.Write(this.value_2);
        bw.Write(this.value_3);
        bw.Write(this.value_4);
        bw.Write(this.value_5);
        bw.Write(this.value_6);
        bw.Write(this.value_7);
        bw.Write(this.value_8);
        bw.Write(this.value_9);
        bw.Write(this.value_10);
        bw.Write(this.value_11);
        bw.Write(this.value_12);
        bw.Write(this.value_13);
        bw.Write(this.value_14);
        bw.Write(this.value_15);
        bw.Write(this.value_16);
        bw.Write(this.value_17);
        bw.Write(this.value_18);
        bw.Write(this.value_19);
        bw.Write(new Byte[4]);
    }

    public string ToDatabase()
    {
        return "INSERT [dbo].[ItemEffectResource] ([id], [ordinal_id], [tooltip_id], [min_level], [max_level], [effect_type], [effect_id], [effect_level], [value_0], [value_1], [value_2], [value_3], [value_4], [value_5], [value_6], [value_7], [value_8], [value_9], [value_10], [value_11], [value_12], [value_13], [value_14], [value_15], [value_16], [value_17], [value_18], [value_19]) VALUES ( @Pid, @Pordinal_id, @Ptooltip_id, @Pmin_level, @Pmax_level, @Peffect_type, @Peffect_id, @Peffect_level, @Pvalue_0, @Pvalue_1, @Pvalue_2, @Pvalue_3, @Pvalue_4, @Pvalue_5, @Pvalue_6, @Pvalue_7, @Pvalue_8, @Pvalue_9, @Pvalue_10, @Pvalue_11, @Pvalue_12, @Pvalue_13, @Pvalue_14, @Pvalue_15, @Pvalue_16, @Pvalue_17, @Pvalue_18, @Pvalue_19 )";
    }

    public static String FromDatabase()
    {
        String rString = "SELECT ";
        foreach (FieldInfo fieldInfo in typeof(DB_ITEMEFFECTRESOURCE).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
        {
            rString += string.Format("[{0}], ", fieldInfo.Name.Substring(1, fieldInfo.Name.IndexOf('>') - 1));
        }
        return rString.Substring(0, rString.Length - 2) + " FROM ItemEffectResource ORDER BY id";
    }

    public void FromDatabaseExecute(System.Data.SqlClient.SqlDataReader drExecute)
    {
        foreach (FieldInfo fieldInfo in typeof(DB_ITEMEFFECTRESOURCE).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
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
