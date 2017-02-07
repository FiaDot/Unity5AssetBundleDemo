﻿using UnityEditor;

public class CreateAssetBundles
{	
	[MenuItem ("Assets/Build AssetBundles - Android")]
	static void BuildAllAssetBundlesAOS()
	{
		BuildPipeline.BuildAssetBundles("Assets/AssetBundles/AOS"
			, BuildAssetBundleOptions.None
			, BuildTarget.Android);
	}	    

	[MenuItem("Bundles/Build AssetBundles - OSX")]
	static void BuildAllAssetBundlesOSX() {
		BuildPipeline.BuildAssetBundles ("Assets/StreamingAssets/OSX"
			, BuildAssetBundleOptions.None
			, BuildTarget.StandaloneOSXUniversal);
	}


	[MenuItem("Bundles/Build AssetBundles - PS4")]
	static void BuildAllAssetBundlesPS4() {
		BuildPipeline.BuildAssetBundles ("Assets/StreamingAssets/PS4"
			, BuildAssetBundleOptions.None
			, BuildTarget.PS4);
	}

}
