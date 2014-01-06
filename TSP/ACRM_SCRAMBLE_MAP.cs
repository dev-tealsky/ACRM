using System;

public class ACRM_SCRAMBLE_MAP
{
    public ACRM_SCRAMBLE_MAP()
    {
        int v3;
        int i;
        byte v5;

        for (i = 0; i < 32; ++i)
        {
            map[i] = (byte)i;
        }

        v3 = 3;
        for (i = 0; i < 32; ++i)
        {
            v5 = map[i];
            if (v3 >= 32)
                v3 += -32 * (v3 >> 5);
            map[i] = map[v3];
            map[v3] = v5;
            v3 += i + 3;
        }
        for (i = 0; i < 32; ++i)
        {
            dmap[map[i]] = (byte)i;
        }
    }
    private byte[] map = new byte[32];
    private byte[] dmap = new byte[32];

    private static ACRM_SCRAMBLE_MAP scram_map = new ACRM_SCRAMBLE_MAP();

    public static int bits_scramble(int c)
    {
        int result;
        uint v2;

        result = 0;
        v2 = 0;
        do
        {
            if ((((uint)1 << (int)v2) & c) != 0)
                result |= 1 << scram_map.map[v2];
            ++v2;
        }
        while (v2 < 32);
        return result;
    }

    public static int bits_descramble(int c)
    {
        int result;
        uint v2;

        result = 0;
        v2 = 0;
        do
        {
            if ((((uint)1 << (int)v2) & c) != 0)
                result |= 1 << scram_map.dmap[v2];
            ++v2;
        }
        while (v2 < 32);
        return result;
    }
}
