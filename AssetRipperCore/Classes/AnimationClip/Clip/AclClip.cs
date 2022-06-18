using AssetRipper.Core.IO.Asset;

namespace AssetRipper.Core.Classes.AnimationClip.Clip
{
	public sealed class AclClip : IAssetReadable
	{
		public uint[] ClipData { get; set; }

		public uint CurveCount { get; set; }

		public uint ConstCurveCount { get; set; }
		public void Read(AssetReader reader)
		{
			ClipData = reader.ReadUInt32Array();
			CurveCount = reader.ReadUInt32();
			ConstCurveCount = reader.ReadUInt32();
		}
	}
}
