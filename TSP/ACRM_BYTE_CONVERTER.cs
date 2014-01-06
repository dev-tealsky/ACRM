using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACRM
{
    public class ACRM_BYTE_CONVERTER
    {
        public static Byte[] StringToBytes(string str)
        {
            Byte[] bytes = null;
            bytes = Encoding.GetEncoding("ASCII").GetBytes(str);
            return bytes;
        }

        public static Byte[] StringToBytes(string str, int size)
        {
            Byte[] bytes = new Byte[size];
            byte[] buffer = Encoding.GetEncoding("ASCII").GetBytes(str);
            try
            {
                for (int i = 0; i < buffer.Length; i++)
                {
                    bytes[i] = buffer[i];
                }
            }catch
            {
                System.Windows.Forms.MessageBox.Show(Encoding.Default.GetString(buffer));
            }
            return bytes;
        }

        public static string BytesToString(byte[] b)
        {
            int num = 0;
            for (int i = 0; i < (int)b.Length && b[i] > 0; i++)
            {
                num++;
            }
            byte[] numArray = new byte[num];
            for (int i = 0; i < num && b[i] > 0; i++)
            {
                numArray[i] = b[i];
            }

            return Encoding.ASCII.GetString(numArray);
        }

        //Handle request for file header info
        public static Byte[] GetFileHeader()
        {
            Byte[] result = new Byte[128];
            Byte[] bTmp = Encoding.ASCII.GetBytes(string.Format("{0}{1}{2}", DateTime.Now.Year, GetDate(DateTime.Now.Month), GetDate(DateTime.Now.Day)));
            for (int iCount = 0; iCount < bTmp.Length; iCount++)
            {
                result[iCount] = bTmp[iCount];
            }
            return result;
        }

        static String GetDate(Int32 pInt)
        {
            if (pInt >= 10)
                return pInt.ToString();
            else
                return string.Format("0{0}", pInt);
        }
    }
}
