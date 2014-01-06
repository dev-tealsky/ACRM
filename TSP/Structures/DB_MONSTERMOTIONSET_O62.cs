using System;
using System.IO;
using System.Reflection;

public class DB_MONSTERMOTIONSET_O71
{
    public Int32 character_id { get; set; }
    public String def { get; set; }
    public String battle { get; set; }
    public String idle { get; set; }
    public String walk { get; set; }
    public String run { get; set; }
    public String be_attack { get; set; }
    public String be_attack2 { get; set; }
    public String dead { get; set; }
    public String flying_dead { get; set; }
    public String take { get; set; }
    public String attack_1 { get; set; }
    public String attack_2 { get; set; }
    public String attack_3 { get; set; }
    public String draw_bow { get; set; }
    public String target_bow { get; set; }
    public String fire_bow { get; set; }
    public String casting_1 { get; set; }
    public String casting_2 { get; set; }
    public String casting_3 { get; set; }
    public String melee_1 { get; set; }
    public String melee_2 { get; set; }
    public String melee_3 { get; set; }
    public String mount { get; set; }
    public String unmount { get; set; }

    public void ReadFile(BinaryReader br)
    {
        this.character_id = br.ReadInt32();
        this.def = br.ReadInt32().ToString();
        this.battle = br.ReadInt32().ToString();
        this.idle = br.ReadInt32().ToString();
        this.walk = br.ReadInt32().ToString();
        this.run = br.ReadInt32().ToString();
        this.be_attack = br.ReadInt32().ToString();
        this.be_attack2 = br.ReadInt32().ToString();
        this.dead = br.ReadInt32().ToString();
        this.flying_dead = br.ReadInt32().ToString();
        this.take = br.ReadInt32().ToString();
        this.attack_1 = br.ReadInt32().ToString();
        this.attack_2 = br.ReadInt32().ToString();
        this.attack_3 = br.ReadInt32().ToString();
        this.draw_bow = br.ReadInt32().ToString();
        this.target_bow = br.ReadInt32().ToString();
        this.fire_bow = br.ReadInt32().ToString();
        this.casting_1 = br.ReadInt32().ToString();
        this.casting_2 = br.ReadInt32().ToString();
        this.casting_3 = br.ReadInt32().ToString();
        this.melee_1 = br.ReadInt32().ToString();
        this.melee_2 = br.ReadInt32().ToString();
        this.melee_3 = br.ReadInt32().ToString();
        this.mount = br.ReadInt32().ToString();
        this.unmount = br.ReadInt32().ToString();
    }

    public void SaveFile(BinaryWriter bw)
    {
        bw.Write(this.character_id);
        bw.Write(Convert.ToInt32(this.def));
        bw.Write(Convert.ToInt32(this.battle));
        bw.Write(Convert.ToInt32(this.idle));
        bw.Write(Convert.ToInt32(this.walk));
        bw.Write(Convert.ToInt32(this.run));
        bw.Write(Convert.ToInt32(this.be_attack));
        bw.Write(Convert.ToInt32(this.be_attack2));
        bw.Write(Convert.ToInt32(this.dead));
        bw.Write(Convert.ToInt32(this.flying_dead));
        bw.Write(Convert.ToInt32(this.take));
        bw.Write(Convert.ToInt32(this.attack_1));
        bw.Write(Convert.ToInt32(this.attack_2));
        bw.Write(Convert.ToInt32(this.attack_3));
        bw.Write(Convert.ToInt32(this.draw_bow));
        bw.Write(Convert.ToInt32(this.target_bow));
        bw.Write(Convert.ToInt32(this.fire_bow));
        bw.Write(Convert.ToInt32(this.casting_1));
        bw.Write(Convert.ToInt32(this.casting_2));
        bw.Write(Convert.ToInt32(this.casting_3));
        bw.Write(Convert.ToInt32(this.melee_1));
        bw.Write(Convert.ToInt32(this.melee_2));
        bw.Write(Convert.ToInt32(this.melee_3));
        bw.Write(Convert.ToInt32(this.mount));
        bw.Write(Convert.ToInt32(this.unmount));
    }

    public string ToDatabase()
    {
        return "INSERT [dbo].[MonsterMotionSet] ([character_id], [def], [battle], [idle], [walk], [run], [be_attack], [be_attack2], [dead], [flying_dead], [take], [attack_1], [attack_2], [attack_3], [draw_bow], [target_bow], [fire_bow], [casting_1], [casting_2], [casting_3], [melee_1], [melee_2], [melee_3], [mount], [unmount]) VALUES ( @Pcharacter_id, @Pdef, @Pbattle, @Pidle, @Pwalk, @Prun, @Pbe_attack, @Pbe_attack2, @Pdead, @Pflying_dead, @Ptake, @Pattack_1, @Pattack_2, @Pattack_3, @Pdraw_bow, @Ptarget_bow, @Pfire_bow, @Pcasting_1, @Pcasting_2, @Pcasting_3, @Pmelee_1, @Pmelee_2, @Pmelee_3, @Pmount, @Punmount )";
    }

    public static String FromDatabase()
    {
        String rString = "SELECT ";
        foreach (FieldInfo fieldInfo in typeof(DB_MONSTERMOTIONSET_O71).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
        {
            rString += string.Format("[{0}], ", fieldInfo.Name.Substring(1, fieldInfo.Name.IndexOf('>') - 1));
        }
        return rString.Substring(0, rString.Length - 2) + " FROM MonsterMotionSet ORDER BY character_id";
    }

    public void FromDatabaseExecute(System.Data.SqlClient.SqlDataReader drExecute)
    {
        foreach (FieldInfo fieldInfo in typeof(DB_MONSTERMOTIONSET_O71).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
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
