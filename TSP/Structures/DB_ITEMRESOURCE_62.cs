using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;

namespace ACRM
{
    public class DB_ITEMRESOURCE_62
    {
        public int id { get; set; }
        public int name_id { get; set; }
        public int tooltip_id { get; set; }
        public int type { get; set; }
        public int Group { get; set; }
        public int Class { get; set; }
        public int wear_type { get; set; }
        public int Set_id { get; set; }
        public int Set_part_flag { get; set; }
        public byte grade { get; set; }
        public int rank { get; set; }
        public int level { get; set; }
        public int enhance { get; set; }
        public int socket { get; set; }
        public int status_flag { get; set; }
        public int limit_deva { get; set; }
        public int limit_asura { get; set; }
        public int limit_gaia { get; set; }
        public int limit_fighter { get; set; }
        public int limit_hunter { get; set; }
        public int limit_magician { get; set; }
        public int limit_summoner { get; set; }
        public int use_min_level { get; set; }
        public int use_max_level { get; set; }
        public int target_min_level { get; set; }
        public int target_max_level { get; set; }
        public int range { get; set; }
        public float weight { get; set; }
        public int price { get; set; }
        public int huntaholic_point { get; set; }
        public int ethereal_durability { get; set; }
        public int endurance { get; set; }
        public int material { get; set; }
        public int summon_id { get; set; }
        public int item_use_flag { get; set; }
        public int available_period { get; set; }
        public short decrease_type { get; set; }
        public decimal throw_range { get; set; }
        public int base_type_0 { get; set; }
        public double base_var1_0 { get; set; }
        public double base_var2_0 { get; set; }
        public int base_type_1 { get; set; }
        public double base_var1_1 { get; set; }
        public double base_var2_1 { get; set; }
        public int base_type_2 { get; set; }
        public double base_var1_2 { get; set; }
        public double base_var2_2 { get; set; }
        public int base_type_3 { get; set; }
        public double base_var1_3 { get; set; }
        public double base_var2_3 { get; set; }
        public int opt_type_0 { get; set; }
        public double opt_var1_0 { get; set; }
        public double opt_var2_0 { get; set; }
        public int opt_type_1 { get; set; }
        public double opt_var1_1 { get; set; }
        public double opt_var2_1 { get; set; }
        public int opt_type_2 { get; set; }
        public double opt_var1_2 { get; set; }
        public double opt_var2_2 { get; set; }
        public int opt_type_3 { get; set; }
        public double opt_var1_3 { get; set; }
        public double opt_var2_3 { get; set; }
        public int effect_id { get; set; }
        public short enhance_0_id { get; set; }
        public decimal enhance_0_01 { get; set; }
        public decimal enhance_0_02 { get; set; }
        public decimal enhance_0_03 { get; set; }
        public decimal enhance_0_04 { get; set; }
        public short enhance_1_id { get; set; }
        public decimal enhance_1_01 { get; set; }
        public decimal enhance_1_02 { get; set; }
        public decimal enhance_1_03 { get; set; }
        public decimal enhance_1_04 { get; set; }
        public int skill_id { get; set; }
        public int state_id { get; set; }
        public int state_level { get; set; }
        public int state_time { get; set; }
        public int cool_time { get; set; }
        public short cool_time_group { get; set; }
        public int model_type_dem { get; set; }
        public int model_type_def { get; set; }
        public int model_type_asm { get; set; }
        public int model_type_asf { get; set; }
        public int model_type_gaf { get; set; }
        public int model_type_gam { get; set; }
        public byte deco_model_change { get; set; }
        public string model_00 { get; set; }
        public string model_01 { get; set; }
        public string model_02 { get; set; }
        public string model_03 { get; set; }
        public string model_04 { get; set; }
        public string model_05 { get; set; }
        public string model_06 { get; set; }
        public string model_07 { get; set; }
        public string model_08 { get; set; }
        public string model_09 { get; set; }
        public string model_10 { get; set; }
        public string model_11 { get; set; }
        public string model_12 { get; set; }
        public string model_13 { get; set; }
        public string model_14 { get; set; }
        public string model_15 { get; set; }
        public string model_16 { get; set; }
        public string model_17 { get; set; }
        public string texture_filename { get; set; }
        public string drop_type { get; set; }
        public int icon_id { get; set; }
        public string icon_file_name { get; set; }
        public string script_text { get; set; }

        public void ReadFile(BinaryReader br)
        {
            this.id = br.ReadInt32();
            this.name_id = br.ReadInt32();
            this.type = br.ReadInt32();
            this.Group = br.ReadInt32();
            this.Class = br.ReadInt32();
            this.Set_id = br.ReadInt32();
            this.Set_part_flag = br.ReadInt32();
            this.grade = br.ReadByte();
            this.rank = br.ReadInt32();
            this.level = br.ReadInt32();
            this.enhance = br.ReadInt32();
            this.socket = br.ReadInt32();
            this.status_flag = br.ReadInt32();
            this.use_min_level = br.ReadInt32();
            this.use_max_level = br.ReadInt32();
            this.target_min_level = br.ReadInt32();
            this.target_max_level = br.ReadInt32();
            this.range = br.ReadInt32();
            this.weight = br.ReadSingle();
            this.price = br.ReadInt32();
            this.huntaholic_point = br.ReadInt32();
            this.ethereal_durability = br.ReadInt32();
            this.endurance = br.ReadInt32();
            this.wear_type = br.ReadInt32();
            byte num = br.ReadByte();
            this.limit_deva = (num & 4) >> 2;
            this.limit_asura = (num & 8) >> 3;
            this.limit_gaia = (num & 16) >> 4;
            num = br.ReadByte();
            this.limit_fighter = (num & 4) >> 2;
            this.limit_hunter = (num & 8) >> 3;
            this.limit_magician = (num & 16) >> 4;
            this.limit_summoner = (num & 32) >> 5;
            br.ReadInt16();
            int use_flag = br.ReadInt32();
            br.ReadInt32();
            this.material = br.ReadInt32();
            this.summon_id = br.ReadInt32();
            this.throw_range = Convert.ToDecimal(br.ReadInt32());
            this.base_type_0 = br.ReadInt16();
            this.base_type_1 = br.ReadInt16();
            this.base_type_2 = br.ReadInt16();
            this.base_type_3 = br.ReadInt16();
            this.base_var1_0 = br.ReadDouble();
            this.base_var1_1 = br.ReadDouble();
            this.base_var1_2 = br.ReadDouble();
            this.base_var1_3 = br.ReadDouble();
            this.base_var2_0 = br.ReadDouble();
            this.base_var2_1 = br.ReadDouble();
            this.base_var2_2 = br.ReadDouble();
            this.base_var2_3 = br.ReadDouble();
            this.opt_type_0 = br.ReadInt16();
            this.opt_type_1 = br.ReadInt16();
            this.opt_type_2 = br.ReadInt16();
            this.opt_type_3 = br.ReadInt16();
            this.opt_var1_0 = br.ReadDouble();
            this.opt_var1_1 = br.ReadDouble();
            this.opt_var1_2 = br.ReadDouble();
            this.opt_var1_3 = br.ReadDouble();
            this.opt_var2_0 = br.ReadDouble();
            this.opt_var2_1 = br.ReadDouble();
            this.opt_var2_2 = br.ReadDouble();
            this.opt_var2_3 = br.ReadDouble();
            this.effect_id = br.ReadInt32();
            this.enhance_0_id = br.ReadInt16();
            this.enhance_1_id = br.ReadInt16();
            this.enhance_0_01 = Convert.ToDecimal(br.ReadSingle());
            this.enhance_0_02 = Convert.ToDecimal(br.ReadSingle());
            this.enhance_0_03 = Convert.ToDecimal(br.ReadSingle());
            this.enhance_0_04 = Convert.ToDecimal(br.ReadSingle());
            this.enhance_1_01 = Convert.ToDecimal(br.ReadSingle());
            this.enhance_1_02 = Convert.ToDecimal(br.ReadSingle());
            this.enhance_1_03 = Convert.ToDecimal(br.ReadSingle());
            this.enhance_1_04 = Convert.ToDecimal(br.ReadSingle());
            this.skill_id = br.ReadInt32();
            this.state_id = br.ReadInt32();
            this.state_level = br.ReadInt32();
            this.state_time = br.ReadInt32();
            br.ReadByte();
            this.cool_time = br.ReadInt32();
            this.cool_time_group = br.ReadInt16();
            this.available_period = br.ReadInt32();
            this.decrease_type = br.ReadInt16();
            br.ReadInt16(); //49
            this.model_type_dem = br.ReadInt32();
            this.model_type_def = br.ReadInt32();
            this.model_type_asm = br.ReadInt32();
            this.model_type_asf = br.ReadInt32();
            this.model_type_gam = br.ReadInt32();
            this.model_type_gaf = br.ReadInt32();
            this.deco_model_change = br.ReadByte();
            this.model_00 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.model_01 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.model_02 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.model_03 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.model_04 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.model_05 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.model_06 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.model_07 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.model_08 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.model_09 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.model_10 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.model_11 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.model_12 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.model_13 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.model_14 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.model_15 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.model_16 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.model_17 = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.texture_filename = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.drop_type = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            br.ReadBytes(3);
            this.icon_id = br.ReadInt32();
            this.icon_file_name = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
            this.script_text = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(512));
            this.tooltip_id = br.ReadInt32();
        }

        public void SaveFile(BinaryWriter br)
        {
            br.Write(this.id);
            br.Write(this.name_id);
            br.Write(this.type);
            br.Write(this.Group);
            br.Write(this.Class);
            br.Write(this.Set_id);
            br.Write(this.Set_part_flag);
            br.Write(this.grade);
            br.Write(this.rank);
            br.Write(this.level);
            br.Write(this.enhance);
            br.Write(this.socket);
            br.Write(this.status_flag);
            br.Write(this.use_min_level);
            br.Write(this.use_max_level);
            br.Write(this.target_min_level);
            br.Write(this.target_max_level);
            br.Write(this.range);
            br.Write(this.weight);
            br.Write(this.price);
            br.Write(this.huntaholic_point);
            br.Write(this.ethereal_durability);
            br.Write(this.endurance);
            br.Write(this.wear_type);
            byte num = 0;
            if (this.limit_deva != 0)
            {
                num = (byte)(num | 4);
            }
            if (this.limit_asura != 0)
            {
                num = (byte)(num | 8);
            }
            if (this.limit_gaia != 0)
            {
                num = (byte)(num | 16);
            }
            br.Write(num);
            byte num1 = 0;
            if (this.limit_fighter != 0)
            {
                num1 = (byte)(num1 | 4);
            }
            if (this.limit_hunter != 0)
            {
                num1 = (byte)(num1 | 8);
            }
            if (this.limit_magician != 0)
            {
                num1 = (byte)(num1 | 16);
            }
            if (this.limit_summoner != 0)
            {
                num1 = (byte)(num1 | 32);
            }
            br.Write(num1);
            br.Write(new byte[2]);
            br.Write(item_use_flag);
            br.Write(item_use_flag);
            br.Write(this.material);
            br.Write(this.summon_id);
            br.Write(Convert.ToInt32(this.throw_range));
            br.Write((ushort)this.base_type_0);
            br.Write((ushort)this.base_type_1);
            br.Write((ushort)this.base_type_2);
            br.Write((ushort)this.base_type_3);
            br.Write(Convert.ToDouble(this.base_var1_0));
            br.Write(Convert.ToDouble(this.base_var1_1));
            br.Write(Convert.ToDouble(this.base_var1_2));
            br.Write(Convert.ToDouble(this.base_var1_3));
            br.Write(Convert.ToDouble(this.base_var2_0));
            br.Write(Convert.ToDouble(this.base_var2_1));
            br.Write(Convert.ToDouble(this.base_var2_2));
            br.Write(Convert.ToDouble(this.base_var2_3));
            br.Write((ushort)this.opt_type_0);
            br.Write((ushort)this.opt_type_1);
            br.Write((ushort)this.opt_type_2);
            br.Write((ushort)this.opt_type_3);
            br.Write(Convert.ToDouble(this.opt_var1_0));
            br.Write(Convert.ToDouble(this.opt_var1_1));
            br.Write(Convert.ToDouble(this.opt_var1_2));
            br.Write(Convert.ToDouble(this.opt_var1_3));
            br.Write(Convert.ToDouble(this.opt_var2_0));
            br.Write(Convert.ToDouble(this.opt_var2_1));
            br.Write(Convert.ToDouble(this.opt_var2_2));
            br.Write(Convert.ToDouble(this.opt_var2_3));
            br.Write(this.effect_id);
            br.Write((ushort)this.enhance_0_id);
            br.Write((ushort)this.enhance_1_id);
            br.Write(Convert.ToSingle(this.enhance_0_01));
            br.Write(Convert.ToSingle(this.enhance_0_02));
            br.Write(Convert.ToSingle(this.enhance_0_03));
            br.Write(Convert.ToSingle(this.enhance_0_04));
            br.Write(Convert.ToSingle(this.enhance_1_01));
            br.Write(Convert.ToSingle(this.enhance_1_02));
            br.Write(Convert.ToSingle(this.enhance_1_03));
            br.Write(Convert.ToSingle(this.enhance_1_04));
            br.Write(this.skill_id);
            br.Write(this.state_id);
            br.Write(this.state_level);
            br.Write(this.state_time);
            br.Write(new byte[1]);
            br.Write(this.cool_time);
            br.Write((ushort)this.cool_time_group);
            br.Write(this.available_period);
            br.Write((ushort)this.decrease_type);
            br.Write((ushort)49);
            br.Write(this.model_type_def);
            br.Write(this.model_type_dem);
            br.Write(this.model_type_asf);
            br.Write(this.model_type_asm);
            br.Write(this.model_type_gaf);
            br.Write(this.model_type_gam);
            br.Write(this.deco_model_change);
            br.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.model_00, 256));
            br.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.model_01, 256));
            br.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.model_02, 256));
            br.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.model_03, 256));
            br.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.model_04, 256));
            br.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.model_05, 256));
            br.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.model_06, 256));
            br.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.model_07, 256));
            br.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.model_08, 256));
            br.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.model_09, 256));
            br.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.model_10, 256));
            br.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.model_11, 256));
            br.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.model_12, 256));
            br.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.model_13, 256));
            br.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.model_14, 256));
            br.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.model_15, 256));
            br.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.model_16, 256));
            br.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.model_17, 256));
            br.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.texture_filename, 256));
            br.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.drop_type, 256));
            br.Write(new byte[3]);
            br.Write(this.icon_id);
            br.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.icon_file_name, 256));
            br.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.script_text, 512));
            br.Write(this.tooltip_id);
        }

        public string ToDatabase()
        {
            return "INSERT [dbo].[ItemResource] ([id], [name_id], [tooltip_id], [type], [group], [class], [wear_type], [set_id], [set_part_flag], [grade], [rank], [level], [enhance], [socket], [status_flag], [limit_deva], [limit_asura], [limit_gaia], [limit_fighter], [limit_hunter], [limit_magician], [limit_summoner], [use_min_level], [use_max_level], [target_min_level], [target_max_level], [range], [weight], [price], [huntaholic_point], [ethereal_durability], [endurance], [material], [summon_id], [item_use_flag], [available_period], [decrease_type], [throw_range], [base_type_0], [base_var1_0], [base_var2_0], [base_type_1], [base_var1_1], [base_var2_1], [base_type_2], [base_var1_2], [base_var2_2], [base_type_3], [base_var1_3], [base_var2_3], [opt_type_0], [opt_var1_0], [opt_var2_0], [opt_type_1], [opt_var1_1], [opt_var2_1], [opt_type_2], [opt_var1_2], [opt_var2_2], [opt_type_3], [opt_var1_3], [opt_var2_3], [effect_id], [enhance_0_id], [enhance_0_01], [enhance_0_02], [enhance_0_03], [enhance_0_04], [enhance_1_id], [enhance_1_01], [enhance_1_02], [enhance_1_03], [enhance_1_04], [skill_id], [state_id], [state_level], [state_time], [cool_time], [cool_time_group], [model_type_dem], [model_type_def], [model_type_asm], [model_type_asf], [model_type_gam], [model_type_gaf], [deco_model_change], [model_00], [model_01], [model_02], [model_03], [model_04], [model_05], [model_06], [model_07], [model_08], [model_09], [model_10], [model_11], [model_12], [model_13], [model_14], [model_15], [model_16], [model_17], [texture_filename], [drop_type], [icon_id], [icon_file_name], [script_text]) VALUES ( @Pid, @Pname_id, @Ptooltip_id, @Ptype, @Pgroup, @Pclass, @Pwear_type, @Pset_id, @Pset_part_flag, @Pgrade, @Prank, @Plevel, @Penhance, @Psocket, @Pstatus_flag, @Plimit_deva, @Plimit_asura, @Plimit_gaia, @Plimit_fighter, @Plimit_hunter, @Plimit_magician, @Plimit_summoner, @Puse_min_level, @Puse_max_level, @Ptarget_min_level, @Ptarget_max_level, @Prange, @Pweight, @Pprice, @Phuntaholic_point, @Pethereal_durability, @Pendurance, @Pmaterial, @Psummon_id, @Pitem_use_flag, @Pavailable_period, @Pdecrease_type, @Pthrow_range, @Pbase_type_0, @Pbase_var1_0, @Pbase_var2_0, @Pbase_type_1, @Pbase_var1_1, @Pbase_var2_1, @Pbase_type_2, @Pbase_var1_2, @Pbase_var2_2, @Pbase_type_3, @Pbase_var1_3, @Pbase_var2_3, @Popt_type_0, @Popt_var1_0, @Popt_var2_0, @Popt_type_1, @Popt_var1_1, @Popt_var2_1, @Popt_type_2, @Popt_var1_2, @Popt_var2_2, @Popt_type_3, @Popt_var1_3, @Popt_var2_3, @Peffect_id, @Penhance_0_id, @Penhance_0_01, @Penhance_0_02, @Penhance_0_03, @Penhance_0_04, @Penhance_1_id, @Penhance_1_01, @Penhance_1_02, @Penhance_1_03, @Penhance_1_04, @Pskill_id, @Pstate_id, @Pstate_level, @Pstate_time, @Pcool_time, @Pcool_time_group, @Pmodel_type_dem, @Pmodel_type_def, @Pmodel_type_asm, @Pmodel_type_asf, @Pmodel_type_gam, @Pmodel_type_gaf, @Pdeco_model_change, @Pmodel_00, @Pmodel_01, @Pmodel_02, @Pmodel_03, @Pmodel_04, @Pmodel_05, @Pmodel_06, @Pmodel_07, @Pmodel_08, @Pmodel_09, @Pmodel_10, @Pmodel_11, @Pmodel_12, @Pmodel_13, @Pmodel_14, @Pmodel_15, @Pmodel_16, @Pmodel_17, @Ptexture_filename, @Pdrop_type, @Picon_id, @Picon_file_name, @Pscript_text )";
        }

        public static String FromDatabase()
        {
            String rString = "SELECT ";
            foreach (FieldInfo fieldInfo in typeof(DB_ITEMRESOURCE_62).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
            {
                rString += string.Format("[{0}], ", fieldInfo.Name.Substring(1, fieldInfo.Name.IndexOf('>') - 1));
            }
            return rString.Substring(0, rString.Length - 2) + " FROM ItemResource ORDER BY id";
        }

        public void FromDatabaseExecute(System.Data.SqlClient.SqlDataReader drExecute)
        {
            foreach (FieldInfo fieldInfo in typeof(DB_ITEMRESOURCE_62).GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
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
