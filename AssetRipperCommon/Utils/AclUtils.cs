using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace AssetRipper.Core.Utils
{
    public static class AclUtils
    {
        public static void DecompressAll(uint[] data, out float[] values, out float[] times)
        {
            var pinned = GCHandle.Alloc(data, GCHandleType.Pinned);
            var pData = pinned.AddrOfPinnedObject();
            DecompressAll(pData, out var pValues, out var numValues, out var pTimes, out var numTimes);
            pinned.Free();

            values = new float[numValues];
            Marshal.Copy(pValues, values, 0, numValues);

            times = new float[numTimes];
            Marshal.Copy(pTimes, times, 0, numTimes);
        }

		[SupportedOSPlatform("windows")]
		[DllImport("acl", CallingConvention = CallingConvention.Cdecl)]
		private static extern void DecompressAll(IntPtr data, out IntPtr pValues, out int numValues, out IntPtr pTimes, out int numTimes);
    }
}
