﻿using System;

namespace AssetRipper.Core.Classes.Shader.Enums.GpuProgramType
{
	public enum ShaderGpuProgramType55
	{
		Unknown = 0,
		GLLegacy = 1,
		GLES31AEP = 2,
		GLES31 = 3,
		GLES3 = 4,
		GLES = 5,
		GLCore32 = 6,
		GLCore41 = 7,
		GLCore43 = 8,
		DX9VertexSM20 = 9,
		DX9VertexSM30 = 10,
		DX9PixelSM20 = 11,
		DX9PixelSM30 = 12,
		DX10Level9Vertex = 13,
		DX10Level9Pixel = 14,
		DX11VertexSM40 = 15,
		DX11VertexSM50 = 16,
		DX11PixelSM40 = 17,
		DX11PixelSM50 = 18,
		DX11GeometrySM40 = 19,
		DX11GeometrySM50 = 20,
		DX11HullSM50 = 21,
		DX11DomainSM50 = 22,
		MetalVS = 23,
		MetalFS = 24,
		SPIRV = 25,
		Console = 26,
		//ConsoleVS			= 26,
		ConsoleFS = 27,
		ConsoleHS = 28,
		ConsoleDS = 29,
		ConsoleGS = 30,
		RayTracing = 31,
	}

	public static class ShaderGpuProgramType55Extensions
	{
		public static ShaderGpuProgramType ToGpuProgramType(this ShaderGpuProgramType55 _this)
		{
			return _this switch
			{
				ShaderGpuProgramType55.Unknown => ShaderGpuProgramType.Unknown,
				ShaderGpuProgramType55.GLLegacy => ShaderGpuProgramType.GLLegacy,
				ShaderGpuProgramType55.GLES31AEP => ShaderGpuProgramType.GLES31AEP,
				ShaderGpuProgramType55.GLES31 => ShaderGpuProgramType.GLES31,
				ShaderGpuProgramType55.GLES3 => ShaderGpuProgramType.GLES3,
				ShaderGpuProgramType55.GLES => ShaderGpuProgramType.GLES,
				ShaderGpuProgramType55.GLCore32 => ShaderGpuProgramType.GLCore32,
				ShaderGpuProgramType55.GLCore41 => ShaderGpuProgramType.GLCore41,
				ShaderGpuProgramType55.GLCore43 => ShaderGpuProgramType.GLCore43,
				ShaderGpuProgramType55.DX9VertexSM20 => ShaderGpuProgramType.DX9VertexSM20,
				ShaderGpuProgramType55.DX9VertexSM30 => ShaderGpuProgramType.DX9VertexSM30,
				ShaderGpuProgramType55.DX9PixelSM20 => ShaderGpuProgramType.DX9PixelSM20,
				ShaderGpuProgramType55.DX9PixelSM30 => ShaderGpuProgramType.DX9PixelSM30,
				ShaderGpuProgramType55.DX10Level9Vertex => ShaderGpuProgramType.DX10Level9Vertex,
				ShaderGpuProgramType55.DX10Level9Pixel => ShaderGpuProgramType.DX10Level9Pixel,
				ShaderGpuProgramType55.DX11VertexSM40 => ShaderGpuProgramType.DX11VertexSM40,
				ShaderGpuProgramType55.DX11VertexSM50 => ShaderGpuProgramType.DX11VertexSM50,
				ShaderGpuProgramType55.DX11PixelSM40 => ShaderGpuProgramType.DX11PixelSM40,
				ShaderGpuProgramType55.DX11PixelSM50 => ShaderGpuProgramType.DX11PixelSM50,
				ShaderGpuProgramType55.DX11GeometrySM40 => ShaderGpuProgramType.DX11GeometrySM40,
				ShaderGpuProgramType55.DX11GeometrySM50 => ShaderGpuProgramType.DX11GeometrySM50,
				ShaderGpuProgramType55.DX11HullSM50 => ShaderGpuProgramType.DX11HullSM50,
				ShaderGpuProgramType55.DX11DomainSM50 => ShaderGpuProgramType.DX11DomainSM50,
				ShaderGpuProgramType55.MetalVS => ShaderGpuProgramType.MetalVS,
				ShaderGpuProgramType55.MetalFS => ShaderGpuProgramType.MetalFS,
				ShaderGpuProgramType55.SPIRV => ShaderGpuProgramType.SPIRV,
				ShaderGpuProgramType55.Console => ShaderGpuProgramType.Console,
				ShaderGpuProgramType55.ConsoleFS => ShaderGpuProgramType.Console,
				ShaderGpuProgramType55.ConsoleHS => ShaderGpuProgramType.Console,
				ShaderGpuProgramType55.ConsoleDS => ShaderGpuProgramType.Console,
				ShaderGpuProgramType55.ConsoleGS => ShaderGpuProgramType.Console,
				ShaderGpuProgramType55.RayTracing => ShaderGpuProgramType.RayTracing,
				_ => throw new Exception($"Unsupported gpu program type {_this}"),
			};
		}
	}
}
