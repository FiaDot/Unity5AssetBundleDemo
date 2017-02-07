using UnityEngine;
using System.Collections;
using System.IO;

public class Home : MonoBehaviour {

	AssetBundle bundle = null;
	GameObject go = null;

	void Awake() {
		Debug.Log ("Home:Awake()");
		StartCoroutine (LoadAssetBundle (Path.Combine (Application.streamingAssetsPath, getBundlePlatform() + "/resource_asset")));
	}

	string getBundlePlatform()
	{
		switch (Application.platform) {
		case RuntimePlatform.Android:
			return "AOS";
		case RuntimePlatform.OSXEditor:
			return "OSX";
		case RuntimePlatform.PS4:
			return "PS4";
		default:
			return null;
		}
	}


	void Destroy() {
		bundle.Unload (true);
	}

	IEnumerator LoadAssetBundle(string path) {
		AssetBundleCreateRequest req = AssetBundle.LoadFromFileAsync (path);
		yield return req;
		bundle = req.assetBundle;

		go = bundle.LoadAsset<GameObject> ("Cube");
		Instantiate (go);
	}

}
