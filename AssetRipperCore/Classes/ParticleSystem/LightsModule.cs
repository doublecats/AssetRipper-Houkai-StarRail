using AssetRipper.Core.Classes.Misc;
using AssetRipper.Core.Classes.ParticleSystem.Curve;
using AssetRipper.Core.Interfaces;
using AssetRipper.Core.IO.Asset;
using AssetRipper.Core.Math.Vectors;
using AssetRipper.Core.Parser.Asset;
using AssetRipper.Core.Project;
using AssetRipper.Core.YAML;
using System.Collections.Generic;

namespace AssetRipper.Core.Classes.ParticleSystem
{
	public sealed class LightsModule : ParticleSystemModule, IDependent
	{
		public LightsModule() { }

		public LightsModule(bool _)
		{
			RandomDistribution = true;
			Color = true;
			Range = true;
			Intensity = true;
			RangeCurve = new MinMaxCurve(1.0f);
			IntensityCurve = new MinMaxCurve(1.0f);
			MaxLights = 20;
		}

		public override void Read(AssetReader reader)
		{
			base.Read(reader);

			Ratio = reader.ReadSingle();
			Light.Read(reader);
			RandomDistribution = reader.ReadBoolean();
			Color = reader.ReadBoolean();
			Range = reader.ReadBoolean();
			Intensity = reader.ReadBoolean();
			RangeCurve.Read(reader);
			IntensityCurve.Read(reader);
			MaxLights = reader.ReadInt32();
			Offset.Read(reader);
		}

		public IEnumerable<PPtr<IUnityObjectBase>> FetchDependencies(DependencyContext context)
		{
			yield return context.FetchDependency(Light, LightName);
		}

		public override YAMLNode ExportYAML(IExportContainer container)
		{
			YAMLMappingNode node = (YAMLMappingNode)base.ExportYAML(container);
			node.Add(RatioName, Ratio);
			node.Add(LightName, Light.ExportYAML(container));
			node.Add(RandomDistributionName, RandomDistribution);
			node.Add(ColorName, Color);
			node.Add(RangeName, Range);
			node.Add(IntensityName, Intensity);
			node.Add(RangeCurveName, RangeCurve.ExportYAML(container));
			node.Add(IntensityCurveName, IntensityCurve.ExportYAML(container));
			node.Add(MaxLightsName, MaxLights);
			return node;
		}

		public float Ratio { get; set; }
		public bool RandomDistribution { get; set; }
		public bool Color { get; set; }
		public bool Range { get; set; }
		public bool Intensity { get; set; }
		public int MaxLights { get; set; }

		public const string RatioName = "ratio";
		public const string LightName = "light";
		public const string RandomDistributionName = "randomDistribution";
		public const string ColorName = "color";
		public const string RangeName = "range";
		public const string IntensityName = "intensity";
		public const string RangeCurveName = "rangeCurve";
		public const string IntensityCurveName = "intensityCurve";
		public const string MaxLightsName = "maxLights";

		public PPtr<Light.Light> Light = new();
		public MinMaxCurve RangeCurve = new();
		public MinMaxCurve IntensityCurve = new();
		public Vector3f Offset = new();
	}
}
