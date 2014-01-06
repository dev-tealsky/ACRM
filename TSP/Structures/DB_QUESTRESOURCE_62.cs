using System;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ACRM
{
    public class DB_QUESTRESOURCE_62
    {
    public Int32 id { get; set; }
    public Int32 text_id_quest { get; set; }
    public Int32 text_id_summary { get; set; }
    public Int32 text_id_status { get; set; }
    public Int32 limit_begin_time { get; set; }
    public Int32 limit_end_time { get; set; }
    public Int32 limit_level { get; set; }
    public Int32 limit_job_level { get; set; }
    public Int32 limit_max_level { get; set; }
    public Int32 limit_max_job_level { get; set; }
    public Int32 limit_deva { get; set; }
    public Int32 limit_asura { get; set; }
    public Int32 limit_gaia { get; set; }
    public Int32 limit_fighter { get; set; }
    public Int32 limit_hunter { get; set; }
    public Int32 limit_magician { get; set; }
    public Int32 limit_summoner { get; set; }
    public Int32 limit_job { get; set; }
    public Int32 job_depth { get; set; }
    public Int32 limit_favor_group_id { get; set; }
    public Int32 limit_favor { get; set; }
    public Int32 repeatable { get; set; }
    public Int32 invoke_condition { get; set; }
    public Int32 invoke_value { get; set; }
    public Int16 time_limit_type { get; set; }
    public Int32 time_limit { get; set; }
    public Int32 type { get; set; }
    public Int32 value1 { get; set; }
    public Int32 value2 { get; set; }
    public Int32 value3 { get; set; }
    public Int32 value4 { get; set; }
    public Int32 value5 { get; set; }
    public Int32 value6 { get; set; }
    public Int32 value7 { get; set; }
    public Int32 value8 { get; set; }
    public Int32 value9 { get; set; }
    public Int32 value10 { get; set; }
    public Int32 value11 { get; set; }
    public Int32 value12 { get; set; }
    public Int32 drop_group_id { get; set; }
    public Int32 quest_difficulty { get; set; }
    public Int32 favor_group_id { get; set; }
    public Int32 hate_group_id { get; set; }
    public Int32 favor { get; set; }
    public Int32 exp { get; set; }
    public Int32 jp { get; set; }
    public Int32 holicpoint { get; set; }
    public Int32 gold { get; set; }
    public Int32 default_reward_id { get; set; }
    public Int32 default_reward_level { get; set; }
    public Int32 default_reward_quantity { get; set; }
    public Int32 optional_reward_id1 { get; set; }
    public Int32 optional_reward_level1 { get; set; }
    public Int32 optional_reward_quantity1 { get; set; }
    public Int32 optional_reward_id2 { get; set; }
    public Int32 optional_reward_level2 { get; set; }
    public Int32 optional_reward_quantity2 { get; set; }
    public Int32 optional_reward_id3 { get; set; }
    public Int32 optional_reward_level3 { get; set; }
    public Int32 optional_reward_quantity3 { get; set; }
    public Int32 optional_reward_id4 { get; set; }
    public Int32 optional_reward_level4 { get; set; }
    public Int32 optional_reward_quantity4 { get; set; }
    public Int32 optional_reward_id5 { get; set; }
    public Int32 optional_reward_level5 { get; set; }
    public Int32 optional_reward_quantity5 { get; set; }
    public Int32 optional_reward_id6 { get; set; }
    public Int32 optional_reward_level6 { get; set; }
    public Int32 optional_reward_quantity6 { get; set; }
    public Int32 forequest1 { get; set; }
    public Int32 forequest2 { get; set; }
    public Int32 forequest3 { get; set; }
    public Int32 or_flag { get; set; }
    public Int32 show_target_type { get; set; }
    public Int32 show_target_id { get; set; }

        public static string FromDatabase()
        {
            string str = "SELECT ";
            FieldInfo[] fields = typeof(DB_QUESTRESOURCE_62).GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            for (int i = 0; i < (int)fields.Length; i++)
            {
                FieldInfo fieldInfo = fields[i];
                str = string.Concat(str, string.Format("[{0}], ", fieldInfo.Name.Substring(1, fieldInfo.Name.IndexOf('>') - 1)));
            }
            string str1 = string.Concat(str.Substring(0, str.Length - 2), " FROM QuestResource ORDER BY id");
            return str1;
        }

        public void FromDatabaseExecute(SqlDataReader drExecute)
        {
            FieldInfo[] fields = typeof(DB_QUESTRESOURCE_62).GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
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

        public void ReadFile(BinaryReader br)
        {
            this.id = br.ReadInt32();
            this.text_id_quest = br.ReadInt32();
            this.text_id_summary = br.ReadInt32();
            this.text_id_status = br.ReadInt32();
            this.limit_begin_time = br.ReadInt32();
            this.limit_end_time = br.ReadInt32();
            this.limit_level = br.ReadInt32();
            this.limit_job_level = br.ReadInt32();
            this.limit_max_level = br.ReadInt32();
            this.limit_max_job_level = br.ReadInt32();
            int num = br.ReadInt32();
            if (num == 0)
            {
                this.limit_deva = 0;
                this.limit_asura = 0;
                this.limit_gaia = 0;
                this.limit_fighter = 0;
                this.limit_hunter = 0;
                this.limit_magician = 0;
                this.limit_summoner = 0;
            }
            else if (num == 240)
            {
                this.limit_deva = 0;
                this.limit_asura = 0;
                this.limit_gaia = 0;
                this.limit_fighter = 1;
                this.limit_hunter = 1;
                this.limit_magician = 1;
                this.limit_summoner = 1;
            }
            else if (num == 242)
            {
                this.limit_deva = 1;
                this.limit_asura = 0;
                this.limit_gaia = 0;
                this.limit_fighter = 1;
                this.limit_hunter = 1;
                this.limit_magician = 1;
                this.limit_summoner = 1;
            }
            else if (num == 244)
            {
                this.limit_deva = 0;
                this.limit_asura = 1;
                this.limit_gaia = 0;
                this.limit_fighter = 1;
                this.limit_hunter = 1;
                this.limit_magician = 1;
                this.limit_summoner = 1;
            }
            else if (num == 248)
            {
                this.limit_deva = 0;
                this.limit_asura = 0;
                this.limit_gaia = 1;
                this.limit_fighter = 1;
                this.limit_hunter = 1;
                this.limit_magician = 1;
                this.limit_summoner = 1;
            }
            else if (num == 254)
            {
                this.limit_deva = 1;
                this.limit_asura = 1;
                this.limit_gaia = 1;
                this.limit_fighter = 1;
                this.limit_hunter = 1;
                this.limit_magician = 1;
                this.limit_summoner = 1;
            }
            this.limit_job = br.ReadInt32();
            this.limit_favor = br.ReadInt32();
            this.repeatable = br.ReadInt32();
            if (this.repeatable != 1989726721)
            {
                this.repeatable = 0;
            }
            else
            {
                this.repeatable = 1;
            }
            this.invoke_condition = br.ReadInt32();
            this.invoke_value = br.ReadInt32();
            this.time_limit_type = br.ReadInt16();
            if (this.time_limit_type != 17921)
            {
                this.time_limit_type = 0;
            }
            else
            {
                this.time_limit_type = 1;
            }
            br.ReadInt16();
            this.time_limit = br.ReadInt32();
            this.type = br.ReadInt32();
            this.value1 = br.ReadInt32();
            this.value2 = br.ReadInt32();
            this.value3 = br.ReadInt32();
            this.value4 = br.ReadInt32();
            this.value5 = br.ReadInt32();
            this.value6 = br.ReadInt32();
            this.value7 = br.ReadInt32();
            this.value8 = br.ReadInt32();
            this.value9 = br.ReadInt32();
            this.value10 = br.ReadInt32();
            this.value11 = br.ReadInt32();
            this.value12 = br.ReadInt32();
            this.drop_group_id = br.ReadInt32();
            this.quest_difficulty = br.ReadInt32();
            this.favor = br.ReadInt32();
            this.exp = br.ReadInt32();
            this.jp = br.ReadInt32();
            this.holicpoint = br.ReadInt32();
            this.gold = br.ReadInt32();
            this.default_reward_id = br.ReadInt32();
            this.default_reward_level = br.ReadInt32();
            this.default_reward_quantity = br.ReadInt32();
            this.optional_reward_id1 = br.ReadInt32();
            this.optional_reward_level1 = br.ReadInt32();
            this.optional_reward_quantity1 = br.ReadInt32();
            this.optional_reward_id2 = br.ReadInt32();
            this.optional_reward_level2 = br.ReadInt32();
            this.optional_reward_quantity2 = br.ReadInt32();
            this.optional_reward_id3 = br.ReadInt32();
            this.optional_reward_level3 = br.ReadInt32();
            this.optional_reward_quantity3 = br.ReadInt32();
            this.optional_reward_id4 = br.ReadInt32();
            this.optional_reward_level4 = br.ReadInt32();
            this.optional_reward_quantity4 = br.ReadInt32();
            this.optional_reward_id5 = br.ReadInt32();
            this.optional_reward_level5 = br.ReadInt32();
            this.optional_reward_quantity5 = br.ReadInt32();
            this.optional_reward_id6 = br.ReadInt32();
            this.optional_reward_level6 = br.ReadInt32();
            this.optional_reward_quantity6 = br.ReadInt32();
            this.forequest1 = br.ReadInt32();
            this.forequest2 = br.ReadInt32();
            this.forequest3 = br.ReadInt32();
            this.or_flag = br.ReadInt16();
            if (this.or_flag != 256)
            {
                this.or_flag = 0;
            }
            else
            {
                this.or_flag = 1;
            }
            br.ReadBytes(2);
        }

        public void SaveFile(BinaryWriter bw)
        {
            bw.Write(this.id);
            bw.Write(this.text_id_quest);
            bw.Write(this.text_id_summary);
            bw.Write(this.text_id_status);
            bw.Write(this.limit_begin_time);
            bw.Write(this.limit_end_time);
            bw.Write(this.limit_level);
            bw.Write(this.limit_job_level);
            bw.Write(this.limit_max_level);
            bw.Write(this.limit_max_job_level);
            if (!(this.limit_deva != 0 || this.limit_asura != 0 || this.limit_gaia != 0 || this.limit_fighter != 1 || this.limit_hunter != 1 || this.limit_magician != 1 ? true : this.limit_summoner != 1))
            {
                bw.Write(Convert.ToInt32(240));
            }
            else if (!(this.limit_deva != 1 || this.limit_asura != 0 || this.limit_gaia != 0 || this.limit_fighter != 1 || this.limit_hunter != 1 || this.limit_magician != 1 ? true : this.limit_summoner != 1))
            {
                bw.Write(Convert.ToInt32(242));
            }
            else if (!(this.limit_deva != 0 || this.limit_asura != 1 || this.limit_gaia != 0 || this.limit_fighter != 1 || this.limit_hunter != 1 || this.limit_magician != 1 ? true : this.limit_summoner != 1))
            {
                bw.Write(Convert.ToInt32(244));
            }
            else if (!(this.limit_deva != 0 || this.limit_asura != 0 || this.limit_gaia != 1 || this.limit_fighter != 1 || this.limit_hunter != 1 || this.limit_magician != 1 ? true : this.limit_summoner != 1))
            {
                bw.Write(Convert.ToInt32(248));
            }
            else if ((this.limit_deva != 1 || this.limit_asura != 1 || this.limit_gaia != 1 || this.limit_fighter != 1 || this.limit_hunter != 1 || this.limit_magician != 1 ? true : this.limit_summoner != 1))
            {
                bw.Write(Convert.ToInt32(0));
            }
            else
            {
                bw.Write(Convert.ToInt32(254));
            }
            bw.Write(this.limit_job);
            bw.Write(this.limit_favor);
            if (this.repeatable != 1)
            {
                this.repeatable = 1989726720;
            }
            else
            {
                this.repeatable = 1989726721;
            }
            bw.Write(this.repeatable);
            bw.Write(this.invoke_condition);
            bw.Write(this.invoke_value);
            if (this.time_limit_type != 1)
            {
                this.time_limit_type = 17920;
            }
            else
            {
                this.time_limit_type = 17921;
            }
            bw.Write(this.time_limit_type);
            bw.Write(Convert.ToInt16(22));
            bw.Write(this.time_limit);
            bw.Write(this.type);
            bw.Write(this.value1);
            bw.Write(this.value2);
            bw.Write(this.value3);
            bw.Write(this.value4);
            bw.Write(this.value5);
            bw.Write(this.value6);
            bw.Write(this.value7);
            bw.Write(this.value8);
            bw.Write(this.value9);
            bw.Write(this.value10);
            bw.Write(this.value11);
            bw.Write(this.value12);
            bw.Write(this.drop_group_id);
            bw.Write(this.quest_difficulty);
            bw.Write(this.favor);
            bw.Write(this.exp);
            bw.Write(this.jp);
            bw.Write(this.holicpoint);
            bw.Write(this.gold);
            bw.Write(this.default_reward_id);
            bw.Write(this.default_reward_level);
            bw.Write(this.default_reward_quantity);
            bw.Write(this.optional_reward_id1);
            bw.Write(this.optional_reward_level1);
            bw.Write(this.optional_reward_quantity1);
            bw.Write(this.optional_reward_id2);
            bw.Write(this.optional_reward_level2);
            bw.Write(this.optional_reward_quantity2);
            bw.Write(this.optional_reward_id3);
            bw.Write(this.optional_reward_level3);
            bw.Write(this.optional_reward_quantity3);
            bw.Write(this.optional_reward_id4);
            bw.Write(this.optional_reward_level4);
            bw.Write(this.optional_reward_quantity4);
            bw.Write(this.optional_reward_id5);
            bw.Write(this.optional_reward_level5);
            bw.Write(this.optional_reward_quantity5);
            bw.Write(this.optional_reward_id6);
            bw.Write(this.optional_reward_level6);
            bw.Write(this.optional_reward_quantity6);
            bw.Write(this.forequest1);
            bw.Write(this.forequest2);
            bw.Write(this.forequest3);
            if (this.or_flag != 1)
            {
                this.or_flag = 0;
            }
            else
            {
                this.or_flag = 256;
            }
            bw.Write(this.or_flag);
        }

        public string ToDatabase()
        {
            return "INSERT [dbo].[QuestResource] ([id], [text_id_quest], [text_id_summary], [text_id_status], [limit_begin_time], [limit_end_time], [limit_level], [limit_job_level], [limit_max_level], [limit_max_job_level], [limit_deva], [limit_asura], [limit_gaia], [limit_fighter], [limit_hunter], [limit_magician], [limit_summoner], [limit_job], [job_depth], [limit_favor_group_id], [limit_favor], [repeatable], [invoke_condition], [invoke_value], [time_limit_type], [time_limit], [type], [value1], [value2], [value3], [value4], [value5], [value6], [value7], [value8], [value9], [value10], [value11], [value12], [drop_group_id], [quest_difficulty], [favor_group_id], [hate_group_id], [favor], [exp], [jp], [holicpoint], [gold], [default_reward_id], [default_reward_level], [default_reward_quantity], [optional_reward_id1], [optional_reward_level1], [optional_reward_quantity1], [optional_reward_id2], [optional_reward_level2], [optional_reward_quantity2], [optional_reward_id3], [optional_reward_level3], [optional_reward_quantity3], [optional_reward_id4], [optional_reward_level4], [optional_reward_quantity4], [optional_reward_id5], [optional_reward_level5], [optional_reward_quantity5], [optional_reward_id6], [optional_reward_level6], [optional_reward_quantity6], [forequest1], [forequest2], [forequest3], [or_flag], [script_start_text], [script_end_text], [script_drop_text], [show_target_type], [show_target_id], [mark_hide], [cool_time], [accept_cool_time]) VALUES ( @Pid, @Ptext_id_quest, @Ptext_id_summary, @Ptext_id_status, @Plimit_begin_time, @Plimit_end_time, @Plimit_level, @Plimit_job_level, @Plimit_max_level, @Plimit_max_job_level, @Plimit_deva, @Plimit_asura, @Plimit_gaia, @Plimit_fighter, @Plimit_hunter, @Plimit_magician, @Plimit_summoner, @Plimit_job, @Pjob_depth, @Plimit_favor_group_id, @Plimit_favor, @Prepeatable, @Pinvoke_condition, @Pinvoke_value, @Ptime_limit_type, @Ptime_limit, @Ptype, @Pvalue1, @Pvalue2, @Pvalue3, @Pvalue4, @Pvalue5, @Pvalue6, @Pvalue7, @Pvalue8, @Pvalue9, @Pvalue10, @Pvalue11, @Pvalue12, @Pdrop_group_id, @Pquest_difficulty, @Pfavor_group_id, @Phate_group_id, @Pfavor, @Pexp, @Pjp, @Pholicpoint, @Pgold, @Pdefault_reward_id, @Pdefault_reward_level, @Pdefault_reward_quantity, @Poptional_reward_id1, @Poptional_reward_level1, @Poptional_reward_quantity1, @Poptional_reward_id2, @Poptional_reward_level2, @Poptional_reward_quantity2, @Poptional_reward_id3, @Poptional_reward_level3, @Poptional_reward_quantity3, @Poptional_reward_id4, @Poptional_reward_level4, @Poptional_reward_quantity4, @Poptional_reward_id5, @Poptional_reward_level5, @Poptional_reward_quantity5, @Poptional_reward_id6, @Poptional_reward_level6, @Poptional_reward_quantity6, @Pforequest1, @Pforequest2, @Pforequest3, @Por_flag, @Pscript_start_text, @Pscript_end_text, @Pscript_drop_text, @Pshow_target_type, @Pshow_target_id, @Pmark_hide, @Pcool_time, @Paccept_cool_time )";
        }

        public string UpdateDatabase()
        {
            return "UPDATE dbo.QuestResource SET exp = @exp, jp = @jp, gold = @gold, holicpoint = @holicpoint, value1 = @value1, value2 = @value2, value3 = @value3, value4 = @value4, value5 = @value5, value6 = @value6, value7 = @value7, value8 = @value8, value9 = @value9, value10 = @value10, value11 = @value11, value12 = @value12, default_reward_id = @default_reward_id, default_reward_level = @default_reward_level, default_reward_quantity = @default_reward_quantity, optional_reward_id1 = @optional_reward_id1, optional_reward_level1 = @optional_reward_level1, optional_reward_quantity1 = @optional_reward_quantity1, optional_reward_id2 = @optional_reward_id2, optional_reward_level2 = @optional_reward_level2, optional_reward_quantity2 = @optional_reward_quantity2, optional_reward_id3 = @optional_reward_id3, optional_reward_level3 = @optional_reward_level3, optional_reward_quantity3 = @optional_reward_quantity3, optional_reward_id4 = @optional_reward_id4, optional_reward_level4 = @optional_reward_level4, optional_reward_quantity4 = @optional_reward_quantity4, optional_reward_id5 = @optional_reward_id5, optional_reward_level5 = @optional_reward_level5, optional_reward_quantity5 = @optional_reward_quantity5, optional_reward_id6 = @optional_reward_id6, optional_reward_level6 = @optional_reward_level6, optional_reward_quantity6 = @optional_reward_quantity6 WHERE id = @id";
        }
    }
}
