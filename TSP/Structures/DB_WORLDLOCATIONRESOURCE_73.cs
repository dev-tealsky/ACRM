using System;
using System.Data.SqlClient;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ACRM
{
    public class DB_WORLDLOCATIONRESOURCE_73
    {
        public int ambient_a
        {
            get;
            set;
        }

        public int ambient_b
        {
            get;
            set;
        }

        public int ambient_g
        {
            get;
            set;
        }

        public int ambient_r
        {
            get;
            set;
        }

        public int apply_bgm
        {
            get;
            set;
        }

        public int apply_light
        {
            get;
            set;
        }

        public int apply_location_name
        {
            get;
            set;
        }

        public float aurora_a
        {
            get;
            set;
        }

        public float aurora_h
        {
            get;
            set;
        }

        public float aurora_s
        {
            get;
            set;
        }

        public float aurora_t
        {
            get;
            set;
        }

        public int bgm1_ID
        {
            get;
            set;
        }

        public int bgm1_ratio
        {
            get;
            set;
        }

        public int bgm2_ID
        {
            get;
            set;
        }

        public int bgm2_ratio
        {
            get;
            set;
        }

        public int bgm3_ID
        {
            get;
            set;
        }

        public int bgm3_ratio
        {
            get;
            set;
        }

        public int blank_a
        {
            get;
            set;
        }

        public int blank_b
        {
            get;
            set;
        }

        public int blank_g
        {
            get;
            set;
        }

        public int blank_r
        {
            get;
            set;
        }

        public int blank_resource_ID
        {
            get;
            set;
        }

        public float character_ambient
        {
            get;
            set;
        }

        public float character_diffuse
        {
            get;
            set;
        }

        public int cloud_a
        {
            get;
            set;
        }

        public int cloud_b
        {
            get;
            set;
        }

        public int cloud_g
        {
            get;
            set;
        }

        public int cloud_r
        {
            get;
            set;
        }

        public int cloud_ratio
        {
            get;
            set;
        }

        public string cloud_texture_file
        {
            get;
            set;
        }

        public int diffuse_a
        {
            get;
            set;
        }

        public int diffuse_b
        {
            get;
            set;
        }

        public int diffuse_g
        {
            get;
            set;
        }

        public int diffuse_r
        {
            get;
            set;
        }

        public int display_positoin_x
        {
            get;
            set;
        }

        public int display_positoin_y
        {
            get;
            set;
        }

        public int environmental_sound_equalizer
        {
            get;
            set;
        }

        public int environmental_sound_reverb
        {
            get;
            set;
        }

        public int environmental_sound_volume
        {
            get;
            set;
        }

        public int environmental_sound1_ID
        {
            get;
            set;
        }

        public int environmental_sound1_ratio
        {
            get;
            set;
        }

        public int environmental_sound2_ID
        {
            get;
            set;
        }

        public int environmental_sound2_ratio
        {
            get;
            set;
        }

        public int environmental_sound3_ID
        {
            get;
            set;
        }

        public int environmental_sound3_ratio
        {
            get;
            set;
        }

        public int environmental_sound4_ID
        {
            get;
            set;
        }

        public int environmental_sound4_ratio
        {
            get;
            set;
        }

        public short fixed_terrain_distance
        {
            get;
            set;
        }

        public int fog_a
        {
            get;
            set;
        }

        public int fog_application
        {
            get;
            set;
        }

        public int fog_b
        {
            get;
            set;
        }

        public int fog_g
        {
            get;
            set;
        }

        public int fog_r
        {
            get;
            set;
        }

        public decimal h_end
        {
            get;
            set;
        }

        public decimal h_start
        {
            get;
            set;
        }

        public int id
        {
            get;
            set;
        }

        public float land_specular
        {
            get;
            set;
        }

        public int location_type
        {
            get;
            set;
        }

        public int minimap_ani_file_ID
        {
            get;
            set;
        }

        public string moon_texture_file
        {
            get;
            set;
        }

        public int offset_x
        {
            get;
            set;
        }

        public int offset_y
        {
            get;
            set;
        }

        public int precipitation_max
        {
            get;
            set;
        }

        public int precipitation_min
        {
            get;
            set;
        }

        public int size_x
        {
            get;
            set;
        }

        public int size_y
        {
            get;
            set;
        }

        public int sky_end_a
        {
            get;
            set;
        }

        public int sky_end_b
        {
            get;
            set;
        }

        public int sky_end_g
        {
            get;
            set;
        }

        public int sky_end_r
        {
            get;
            set;
        }

        public int sky_mid_a
        {
            get;
            set;
        }

        public int sky_mid_b
        {
            get;
            set;
        }

        public int sky_mid_g
        {
            get;
            set;
        }

        public int sky_mid_r
        {
            get;
            set;
        }

        public float sky_mid_rate
        {
            get;
            set;
        }

        public int sky_start_a
        {
            get;
            set;
        }

        public int sky_start_b
        {
            get;
            set;
        }

        public int sky_start_g
        {
            get;
            set;
        }

        public int sky_start_r
        {
            get;
            set;
        }

        public int specular_a
        {
            get;
            set;
        }

        public int specular_b
        {
            get;
            set;
        }

        public int specular_g
        {
            get;
            set;
        }

        public int specular_r
        {
            get;
            set;
        }

        public string sun_texture_file
        {
            get;
            set;
        }

        public int text_id
        {
            get;
            set;
        }

        public int time_id
        {
            get;
            set;
        }

        public decimal v_end
        {
            get;
            set;
        }

        public decimal v_start
        {
            get;
            set;
        }

        public int weather_change_time
        {
            get;
            set;
        }

        public int weather_id
        {
            get;
            set;
        }

        public int weather_ratio
        {
            get;
            set;
        }

        public byte worldmap_ani_file_ID
        {
            get;
            set;
        }

        public int x
        {
            get;
            set;
        }

        public int y
        {
            get;
            set;
        }

        public int zoom_map_type
        {
            get;
            set;
        }

        public int zoom_minimap
        {
            get;
            set;
        }

        public int zoom_x
        {
            get;
            set;
        }

        public DB_WORLDLOCATIONRESOURCE_73()
        {
        }

        public static string FromDatabase()
        {
            string str = "SELECT ";
            FieldInfo[] fields = typeof(DB_WORLDLOCATIONRESOURCE_73).GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
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
            FieldInfo[] fields = typeof(DB_WORLDLOCATIONRESOURCE_73).GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
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
            this.fixed_terrain_distance = br.ReadInt16();
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
            this.aurora_t = br.ReadSingle();
            this.aurora_a = br.ReadSingle();
            this.aurora_s = br.ReadSingle();
            this.aurora_h = br.ReadSingle();
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
            bw.Write(this.fixed_terrain_distance);
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
            bw.Write(this.aurora_t);
            bw.Write(this.aurora_a);
            bw.Write(this.aurora_s);
            bw.Write(this.aurora_h);
        }
    }
}
