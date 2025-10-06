using System;

public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading) =>
        reading switch
        {
            > uint.MaxValue => ToBufferLong(reading),
            > int.MaxValue => ToBufferUint((uint)reading),
            > ushort.MaxValue => ToBufferInt((int)reading),
            >= 0 => ToBufferUshort((ushort)reading),
            >= short.MinValue => ToBufferShort((short)reading),
            >= int.MinValue => ToBufferInt((int)reading),
            _ => ToBufferLong(reading)
        };

    private static byte[] ToBufferLong(long reading)
    {
        byte[] bytes = new byte[9];
        bytes[0] = 256 - 8;
        int i = 1;
        foreach (byte b in BitConverter.GetBytes(reading))
        {
            bytes[i] = b;
            i++;
        }
        return bytes;
    }

    private static byte[] ToBufferUint(uint reading)
    {
        byte[] bytes = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        bytes[0] = 4;
        int i = 1;
        foreach (byte b in BitConverter.GetBytes(reading))
        {
            bytes[i] = b;
            i++;
        }
        return bytes;
    }

    private static byte[] ToBufferUshort(ushort reading)
    {
        byte[] bytes = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        bytes[0] = 2;
        int i = 1;
        foreach (byte b in BitConverter.GetBytes(reading))
        {
            bytes[i] = b;
            i++;
        }
        return bytes;
    }

    private static byte[] ToBufferShort(short reading)
    {
        byte[] bytes = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        bytes[0] = 256 - 2;
        int i = 1;
        foreach (byte b in BitConverter.GetBytes(reading))
        {
            bytes[i] = b;
            i++;
        }
        return bytes;
    }

    private static byte[] ToBufferInt(int reading)
    {
        byte[] bytes = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        bytes[0] = 256 - 4;
        int i = 1;
        foreach (byte b in BitConverter.GetBytes(reading))
        {
            bytes[i] = b;
            i++;
        }
        return bytes;
    }

    public static long FromBuffer(byte[] buffer) => buffer[0] switch
    {
        256 - 8 or 4 or 2 => BitConverter.ToInt64(buffer, 1),
        256 - 4 => BitConverter.ToInt32(buffer, 1),
        256 - 2 => BitConverter.ToInt16(buffer, 1),
        _ => 0,
    };
}
