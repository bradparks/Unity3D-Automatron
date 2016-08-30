using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

	[Automation( "Lightmapping/Clear Disk Cache" )]
	class LightmappingClearDiskCache0 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.Lightmapping.ClearDiskCache();
			yield break;
		}

	}

	[Automation( "Lightmapping/Bake Async" )]
	class LightmappingBakeAsync1 : Automation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Lightmapping.BakeAsync();
			yield break;
		}

	}

	[Automation( "Lightmapping/Bake" )]
	class LightmappingBake2 : Automation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Lightmapping.Bake();
			yield break;
		}

	}

	[Automation( "Lightmapping/Bake Selected Async" )]
	class LightmappingBakeSelectedAsync3 : Automation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Lightmapping.BakeSelectedAsync();
			yield break;
		}

	}

	[Automation( "Lightmapping/Bake Selected" )]
	class LightmappingBakeSelected4 : Automation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Lightmapping.BakeSelected();
			yield break;
		}

	}

	[Automation( "Lightmapping/Bake Light Probes Only Async" )]
	class LightmappingBakeLightProbesOnlyAsync5 : Automation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Lightmapping.BakeLightProbesOnlyAsync();
			yield break;
		}

	}

	[Automation( "Lightmapping/Bake Light Probes Only" )]
	class LightmappingBakeLightProbesOnly6 : Automation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Lightmapping.BakeLightProbesOnly();
			yield break;
		}

	}

	[Automation( "Lightmapping/Cancel" )]
	class LightmappingCancel7 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.Lightmapping.Cancel();
			yield break;
		}

	}

	[Automation( "Lightmapping/Clear" )]
	class LightmappingClear8 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.Lightmapping.Clear();
			yield break;
		}

	}

	[Automation( "Lightmapping/Clear Lighting Data Asset" )]
	class LightmappingClearLightingDataAsset9 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.Lightmapping.ClearLightingDataAsset();
			yield break;
		}

	}

	[Automation( "Lightmapping/Tetrahedralize" )]
	class LightmappingTetrahedralize10 : Automation {

		public UnityEngine.Vector3[] positions;
		public System.Int32[] outIndices;
		public UnityEngine.Vector3[] outPositions;

		public override IEnumerator Execute() {
			UnityEditor.Lightmapping.Tetrahedralize(positions,out outIndices,out outPositions);
			yield break;
		}

	}

	[Automation( "Lightmapping/Bake Reflection Probe" )]
	class LightmappingBakeReflectionProbe11 : Automation {

		public UnityEngine.ReflectionProbe probe;
		public System.String path;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Lightmapping.BakeReflectionProbe(probe,path);
			yield break;
		}

	}

	[Automation( "Lightmapping/Get Terrain GI Chunks" )]
	class LightmappingGetTerrainGIChunks12 : Automation {

		public UnityEngine.Terrain terrain;
		public System.Int32 numChunksX;
		public System.Int32 numChunksY;

		public override IEnumerator Execute() {
			UnityEditor.Lightmapping.GetTerrainGIChunks(terrain,ref numChunksX,ref numChunksY);
			yield break;
		}

	}

	[Automation( "Lightmapping/Bake Multiple Scenes" )]
	class LightmappingBakeMultipleScenes13 : Automation {

		public System.String[] paths;

		public override IEnumerator Execute() {
			UnityEditor.Lightmapping.BakeMultipleScenes(paths);
			yield break;
		}

	}


#pragma warning restore 0649
}
