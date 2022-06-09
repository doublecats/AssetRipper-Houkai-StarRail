using AssetRipper.Core.Classes.Misc;
using AssetRipper.Core.Parser.Files.BundleFile.IO;

namespace AssetRipper.Core.Parser.Files.BundleFile.Parser
{
	public sealed class BlocksInfo : IBundleReadable
	{
		/// <summary>
		/// 5.2.0 and greater
		/// </summary>
		private static bool HasHoukaiStarRailBlocksInfo(BundleType signature) => signature == BundleType.ENCR;

		public void Read(BundleReader reader)
		{
			if (!HasHoukaiStarRailBlocksInfo(reader.Signature)) 
			{
				Hash.Read(reader);
			}
			StorageBlocks = reader.ReadBundleArray<StorageBlock>();
		}

		public StorageBlock[] StorageBlocks { get; set; }

		public Hash128 Hash = new();
	}
}
