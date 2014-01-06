using System;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ACRM 
{
public class DB_WORLDLOCATIONRESOURCE_62
{
    public Int32 id { get; set; }
    public Int32 text_id { get; set; }
    public Int32 x { get; set; }
    public Int32 y { get; set; }
    public Int32 apply_location_name { get; set; }
    public Int32 apply_light { get; set; }
    public Int32 apply_bgm { get; set; }
    public Int32 location_type { get; set; }
    public Int32 fog_application { get; set; }
    public Int32 time_id { get; set; }
    public Int32 weather_id { get; set; }
    public Int32 cloud_ratio { get; set; }
    public Int32 weather_change_time { get; set; }
    public Int32 weather_ratio { get; set; }
    public Int32 sky_start_a { get; set; }
    public Int32 sky_start_r { get; set; }
    public Int32 sky_start_g { get; set; }
    public Int32 sky_start_b { get; set; }
    public Int32 sky_mid_a { get; set; }
    public Int32 sky_mid_r { get; set; }
    public Int32 sky_mid_g { get; set; }
    public Int32 sky_mid_b { get; set; }
    public Int32 sky_end_a { get; set; }
    public Int32 sky_end_r { get; set; }
    public Int32 sky_end_g { get; set; }
    public Int32 sky_end_b { get; set; }
    public Single sky_mid_rate { get; set; }
    public Int32 diffuse_a { get; set; }
    public Int32 diffuse_r { get; set; }
    public Int32 diffuse_g { get; set; }
    public Int32 diffuse_b { get; set; }
    public Int32 ambient_a { get; set; }
    public Int32 ambient_r { get; set; }
    public Int32 ambient_g { get; set; }
    public Int32 ambient_b { get; set; }
    public Int32 specular_a { get; set; }
    public Int32 specular_r { get; set; }
    public Int32 specular_g { get; set; }
    public Int32 specular_b { get; set; }
    public Int32 fog_a { get; set; }
    public Int32 fog_r { get; set; }
    public Int32 fog_g { get; set; }
    public Int32 fog_b { get; set; }
    public Decimal v_start { get; set; }
    public Decimal v_end { get; set; }
    public Decimal h_start { get; set; }
    public Decimal h_end { get; set; }
    //public Int16 fixed_terrain_distance { get; set; }
    public Int32 cloud_a { get; set; }
    public Int32 cloud_r { get; set; }
    public Int32 cloud_g { get; set; }
    public Int32 cloud_b { get; set; }
    public Single land_specular { get; set; }
    public Single character_diffuse { get; set; }
    public Single character_ambient { get; set; }
    public String sun_texture_file { get; set; }
    public String moon_texture_file { get; set; }
    public String cloud_texture_file { get; set; }
    public Int32 bgm1_ID { get; set; }
    public Int32 bgm2_ID { get; set; }
    public Int32 bgm3_ID { get; set; }
    public Int32 bgm1_ratio { get; set; }
    public Int32 bgm2_ratio { get; set; }
    public Int32 bgm3_ratio { get; set; }
    public Int32 environmental_sound1_ID { get; set; }
    public Int32 environmental_sound2_ID { get; set; }
    public Int32 environmental_sound3_ID { get; set; }
    public Int32 environmental_sound4_ID { get; set; }
    public Int32 environmental_sound1_ratio { get; set; }
    public Int32 environmental_sound2_ratio { get; set; }
    public Int32 environmental_sound3_ratio { get; set; }
    public Int32 environmental_sound4_ratio { get; set; }
    public Int32 environmental_sound_reverb { get; set; }
    public Int32 environmental_sound_volume { get; set; }
    public Int32 environmental_sound_equalizer { get; set; }
    public Int32 minimap_ani_file_ID { get; set; }
    public Byte worldmap_ani_file_ID { get; set; }
    public Int32 zoom_map_type { get; set; }
    public Int32 display_positoin_x { get; set; }
    public Int32 display_positoin_y { get; set; }
    public Int32 zoom_x { get; set; }
    public Int32 offset_x { get; set; }
    public Int32 offset_y { get; set; }
    public Int32 size_x { get; set; }
    public Int32 size_y { get; set; }
    public Int32 blank_resource_ID { get; set; }
    public Int32 blank_a { get; set; }
    public Int32 blank_r { get; set; }
    public Int32 blank_g { get; set; }
    public Int32 blank_b { get; set; }
    public Int32 zoom_minimap { get; set; }
    public Int32 precipitation_min { get; set; }
    public Int32 precipitation_max { get; set; }

    public static string FromDatabase()
    {
        string str = "SELECT ";
        FieldInfo[] fields = typeof(DB_WORLDLOCATIONRESOURCE_62).GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
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
        FieldInfo[] fields = typeof(DB_WORLDLOCATIONRESOURCE_62).GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
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
        this.text_id = br.ReadInt32();
        this.x = br.ReadInt32();
        this.y = br.ReadInt32();
        this.apply_location_name = br.ReadInt32();
        this.apply_light = br.ReadInt32();
        this.apply_bgm = br.ReadInt32();
        this.location_type = br.ReadInt32();
        this.fog_application = br.ReadInt32();
        this.time_id = br.ReadInt32();
        this.weather_id = br.ReadInt32();
        this.cloud_ratio = br.ReadInt32();
        this.weather_change_time = br.ReadInt32();
        this.weather_ratio = br.ReadInt32();
        this.sky_start_a = br.ReadInt32();
        this.sky_start_r = br.ReadInt32();
        this.sky_start_g = br.ReadInt32();
        this.sky_start_b = br.ReadInt32();
        this.sky_mid_a = br.ReadInt32();
        this.sky_mid_r = br.ReadInt32();
        this.sky_mid_g = br.ReadInt32();
        this.sky_mid_b = br.ReadInt32();
        this.sky_end_a = br.ReadInt32();
        this.sky_end_r = br.ReadInt32();
        this.sky_end_g = br.ReadInt32();
        this.sky_end_b = br.ReadInt32();
        this.sky_mid_rate = br.ReadSingle();
        this.diffuse_a = br.ReadInt32();
        this.diffuse_r = br.ReadInt32();
        this.diffuse_g = br.ReadInt32();
        this.diffuse_b = br.ReadInt32();
        this.ambient_a = br.ReadInt32();
        this.ambient_r = br.ReadInt32();
        this.ambient_g = br.ReadInt32();
        this.ambient_b = br.ReadInt32();
        this.specular_a = br.ReadInt32();
        this.specular_r = br.ReadInt32();
        this.specular_g = br.ReadInt32();
        this.specular_b = br.ReadInt32();
        this.fog_a = br.ReadInt32();
        this.fog_r = br.ReadInt32();
        this.fog_g = br.ReadInt32();
        this.fog_b = br.ReadInt32();
        this.v_start = Convert.ToDecimal(br.ReadSingle());
        this.v_end = Convert.ToDecimal(br.ReadSingle());
        this.h_start = Convert.ToDecimal(br.ReadSingle());
        this.h_end = Convert.ToDecimal(br.ReadSingle());
        this.cloud_a = br.ReadInt32();
        this.cloud_r = br.ReadInt32();
        this.cloud_g = br.ReadInt32();
        this.cloud_b = br.ReadInt32();
        this.land_specular = br.ReadSingle();
        this.character_diffuse = br.ReadSingle();
        this.character_ambient = br.ReadSingle();
        this.sun_texture_file = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
        this.moon_texture_file = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
        this.cloud_texture_file = ACRM_BYTE_CONVERTER.BytesToString(br.ReadBytes(256));
        this.bgm1_ID = br.ReadInt32();
        this.bgm2_ID = br.ReadInt32();
        this.bgm3_ID = br.ReadInt32();
        this.bgm1_ratio = br.ReadInt32();
        this.bgm2_ratio = br.ReadInt32();
        this.bgm3_ratio = br.ReadInt32();
        this.environmental_sound1_ID = br.ReadInt32();
        this.environmental_sound2_ID = br.ReadInt32();
        this.environmental_sound3_ID = br.ReadInt32();
        this.environmental_sound4_ID = br.ReadInt32();
        this.environmental_sound1_ratio = br.ReadInt32();
        this.environmental_sound2_ratio = br.ReadInt32();
        this.environmental_sound3_ratio = br.ReadInt32();
        this.environmental_sound4_ratio = br.ReadInt32();
        this.environmental_sound_reverb = br.ReadInt32();
        this.environmental_sound_volume = br.ReadInt32();
        this.environmental_sound_equalizer = br.ReadInt32();
        this.minimap_ani_file_ID = br.ReadInt32();
        this.worldmap_ani_file_ID = br.ReadByte();
        this.zoom_map_type = br.ReadInt32();
        this.display_positoin_x = br.ReadInt32();
        this.display_positoin_y = br.ReadInt32();
        this.zoom_x = br.ReadInt32();
        this.offset_x = br.ReadInt32();
        this.offset_y = br.ReadInt32();
        this.size_x = br.ReadInt32();
        this.size_y = br.ReadInt32();
        this.blank_resource_ID = br.ReadInt32();
        this.blank_a = br.ReadInt32();
        this.blank_r = br.ReadInt32();
        this.blank_g = br.ReadInt32();
        this.blank_b = br.ReadInt32();
        this.zoom_minimap = br.ReadInt32();
        this.precipitation_min = br.ReadInt32();
        this.precipitation_max = br.ReadInt32();
    }

    public void SaveFile(BinaryWriter bw)
    {
        bw.Write(this.id);
        bw.Write(this.text_id);
        bw.Write(this.x);
        bw.Write(this.y);
        bw.Write(this.apply_location_name);
        bw.Write(this.apply_light);
        bw.Write(this.apply_bgm);
        bw.Write(this.location_type);
        bw.Write(this.fog_application);
        bw.Write(this.time_id);
        bw.Write(this.weather_id);
        bw.Write(this.cloud_ratio);
        bw.Write(this.weather_change_time);
        bw.Write(this.weather_ratio);
        bw.Write(this.sky_start_a);
        bw.Write(this.sky_start_r);
        bw.Write(this.sky_start_g);
        bw.Write(this.sky_start_b);
        bw.Write(this.sky_mid_a);
        bw.Write(this.sky_mid_r);
        bw.Write(this.sky_mid_g);
        bw.Write(this.sky_mid_b);
        bw.Write(this.sky_end_a);
        bw.Write(this.sky_end_r);
        bw.Write(this.sky_end_g);
        bw.Write(this.sky_end_b);
        bw.Write(this.sky_mid_rate);
        bw.Write(this.diffuse_a);
        bw.Write(this.diffuse_r);
        bw.Write(this.diffuse_g);
        bw.Write(this.diffuse_b);
        bw.Write(this.ambient_a);
        bw.Write(this.ambient_r);
        bw.Write(this.ambient_g);
        bw.Write(this.ambient_b);
        bw.Write(this.specular_a);
        bw.Write(this.specular_r);
        bw.Write(this.specular_g);
        bw.Write(this.specular_b);
        bw.Write(this.fog_a);
        bw.Write(this.fog_r);
        bw.Write(this.fog_g);
        bw.Write(this.fog_b);
        bw.Write(Convert.ToSingle(this.v_start));
        bw.Write(Convert.ToSingle(this.v_end));
        bw.Write(Convert.ToSingle(this.h_start));
        bw.Write(Convert.ToSingle(this.h_end));
        bw.Write(this.cloud_a);
        bw.Write(this.cloud_r);
        bw.Write(this.cloud_g);
        bw.Write(this.cloud_b);
        bw.Write(this.land_specular);
        bw.Write(this.character_diffuse);
        bw.Write(this.character_ambient);
        bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.sun_texture_file));
        bw.Write(new byte[256 - this.sun_texture_file.Length]);
        bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.moon_texture_file));
        bw.Write(new byte[256 - this.moon_texture_file.Length]);
        bw.Write(ACRM_BYTE_CONVERTER.StringToBytes(this.cloud_texture_file));
        bw.Write(new byte[256 - this.cloud_texture_file.Length]);
        bw.Write(this.bgm1_ID);
        bw.Write(this.bgm2_ID);
        bw.Write(this.bgm3_ID);
        bw.Write(this.bgm1_ratio);
        bw.Write(this.bgm2_ratio);
        bw.Write(this.bgm3_ratio);
        bw.Write(this.environmental_sound1_ID);
        bw.Write(this.environmental_sound2_ID);
        bw.Write(this.environmental_sound3_ID);
        bw.Write(this.environmental_sound4_ID);
        bw.Write(this.environmental_sound1_ratio);
        bw.Write(this.environmental_sound2_ratio);
        bw.Write(this.environmental_sound3_ratio);
        bw.Write(this.environmental_sound4_ratio);
        bw.Write(this.environmental_sound_reverb);
        bw.Write(this.environmental_sound_volume);
        bw.Write(this.environmental_sound_equalizer);
        bw.Write(this.minimap_ani_file_ID);
        bw.Write(this.worldmap_ani_file_ID);
        bw.Write(this.zoom_map_type);
        bw.Write(this.display_positoin_x);
        bw.Write(this.display_positoin_y);
        bw.Write(this.zoom_x);
        bw.Write(this.offset_x);
        bw.Write(this.offset_y);
        bw.Write(this.size_x);
        bw.Write(this.size_y);
        bw.Write(this.blank_resource_ID);
        bw.Write(this.blank_a);
        bw.Write(this.blank_r);
        bw.Write(this.blank_g);
        bw.Write(this.blank_b);
        bw.Write(this.zoom_minimap);
        bw.Write(this.precipitation_min);
        bw.Write(this.precipitation_max);
    }

    public string ToDatabase()
    {
        return "INSERT INTO [dbo].[WorldLocation] (id, text_id, x, y, apply_location_name, apply_light, apply_bgm, location_type, fog_application, time_id, weather_id, cloud_ratio, weather_change_time, weather_ratio, sky_start_a, sky_start_r, sky_start_g, sky_start_b, sky_mid_a, sky_mid_r, sky_mid_g, sky_mid_b, sky_end_a, sky_end_r, sky_end_g, sky_end_b, sky_mid_rate, diffuse_a, diffuse_r, diffuse_g, diffuse_b, ambient_a, ambient_r, ambient_g, ambient_b, specular_a, specular_r, specular_g, specular_b, fog_a, fog_r, fog_g, fog_b, v_start, v_end, h_start, h_end, cloud_a, cloud_r, cloud_g, cloud_b, land_specular, character_diffuse, character_ambient, sun_texture_file, moon_texture_file, cloud_texture_file, bgm1_ID, bgm2_ID, bgm3_ID, bgm1_ratio, bgm2_ratio, bgm3_ratio, environmental_sound1_ID, environmental_sound2_ID, environmental_sound3_ID, environmental_sound4_ID, environmental_sound1_ratio, environmental_sound2_ratio, environmental_sound3_ratio, environmental_sound4_ratio, environmental_sound_reverb, environmental_sound_volume, environmental_sound_equalizer, minimap_ani_file_ID, worldmap_ani_file_ID, zoom_map_type, display_positoin_x, display_positoin_y, zoom_x, offset_x, offset_y, size_x, size_y, blank_resource_ID, blank_a, blank_r, blank_g, blank_b, zoom_minimap, precipitation_min, precipitation_max, aurora_t, aurora_a, aurora_s, aurora_h) VALUES (@id, @text_id, @x, @y, @apply_location_name, @apply_light, @apply_bgm, @location_type, @fog_application, @time_id, @weather_id, @cloud_ratio, @weather_change_time, @weather_ratio, @sky_start_a, @sky_start_r, @sky_start_g, @sky_start_b, @sky_mid_a, @sky_mid_r, @sky_mid_g, @sky_mid_b, @sky_end_a, @sky_end_r, @sky_end_g, @sky_end_b, @sky_mid_rate, @diffuse_a, @diffuse_r, @diffuse_g, @diffuse_b, @ambient_a, @ambient_r, @ambient_g, @ambient_b, @specular_a, @specular_r, @specular_g, @specular_b, @fog_a, @fog_r, @fog_g, @fog_b, @v_start, @v_end, @h_start, @h_end, @cloud_a, @cloud_r, @cloud_g, @cloud_b, @land_specular, @character_diffuse, @character_ambient, @sun_texture_file, @moon_texture_file, @cloud_texture_file, @bgm1_ID, @bgm2_ID, @bgm3_ID, @bgm1_ratio, @bgm2_ratio, @bgm3_ratio, @environmental_sound1_ID, @environmental_sound2_ID, @environmental_sound3_ID, @environmental_sound4_ID, @environmental_sound1_ratio, @environmental_sound2_ratio, @environmental_sound3_ratio, @environmental_sound4_ratio, @environmental_sound_reverb, @environmental_sound_volume, @environmental_sound_equalizer, @minimap_ani_file_ID, @worldmap_ani_file_ID, @zoom_map_type, @display_positoin_x, @display_positoin_y, @zoom_x, @offset_x, @offset_y, @size_x, @size_y, @blank_resource_ID, @blank_a, @blank_r, @blank_g, @blank_b, @zoom_minimap, @precipitation_min, @precipitation_max, @aurora_t, @aurora_a, @aurora_s, @aurora_h)";
    }
}
}
