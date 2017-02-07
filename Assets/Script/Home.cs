using UnityEngine;
using System.Collections;
using System.IO;

public class Home : MonoBehaviour {

	AssetBundle bundle = null;
	GameObject go = null;

	void Awake() {
		Debug.LogFormat("Home:Awake() stremingAssetsPath={0}", Application.streamingAssetsPath);

		string platformPath = Path.Combine (getBundlePlatform (), "resource_asset");
		// string platformPath = getBundlePlatform () + Path.DirectorySeparatorChar + "resource_asset";
		//string platformPath = "/" + getBundlePlatform () + "/resource_asset";
		 string fullPath = Path.Combine (Application.streamingAssetsPath, platformPath);
		// string fullPath = Application.streamingAssetsPath + platformPath;
		StartCoroutine (LoadAssetBundle (fullPath));
	}

	string getBundlePlatform()
	{
		switch (Application.platform) {
		case RuntimePlatform.Android:
			return "AOS";
	
		case RuntimePlatform.IPhonePlayer:
			return "IOS";

		case RuntimePlatform.OSXEditor:
		case RuntimePlatform.OSXPlayer:
			return "OSX";

		case RuntimePlatform.WindowsEditor:
		case RuntimePlatform.WindowsPlayer:
			return "WIN";

		case RuntimePlatform.PS4:
			return "PS4";		

		default:
			Debug.LogError ("Home:getBundlePlatform() not found platform = " + Application.platform);
			return null;
		}
	}


	void Destroy() {
		bundle.Unload (true);
	}

	IEnumerator LoadAssetBundle(string path) {
		Debug.Log("Home:LoadAssetBundle() path=" + path);

		AssetBundleCreateRequest req = AssetBundle.LoadFromFileAsync (path);
		yield return req;
		bundle = req.assetBundle;

		go = bundle.LoadAsset<GameObject> ("Cube");
		Instantiate (go);
	}

}
