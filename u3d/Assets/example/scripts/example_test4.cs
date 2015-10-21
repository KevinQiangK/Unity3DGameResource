using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using GameResource;


public class example_test4 : MonoBehaviour
{
	// Use this for initialization
	void Start ()
	{
		AssetBundle ab = null;

		string path = ""+Application.dataPath + "/example/bundle/item.unity3d";
		if(FileLoader.IsExist(path))
		{
			byte[] data = FileLoader.ReadAllBytes(path);
			ab = AssetBundleLoader.CreateFromMemoryImmediate(data);
			GameObject.Instantiate(ab.mainAsset);
		}

		path = ""+Application.dataPath + "/example/bundle/Button.unity3d";
		if(FileLoader.IsExist(path))
		{
			byte[] data = FileLoader.ReadAllBytes(path);
			ab = AssetBundleLoader.CreateFromMemoryImmediate(data);
			GameObject.Instantiate(ab.mainAsset);
		}

		path = ""+Application.dataPath + "/example/bundle/Terrain.unity3d";
		if(FileLoader.IsExist(path))
		{
			byte[] data = FileLoader.ReadAllBytes(path);
			ab = AssetBundleLoader.CreateFromMemoryImmediate(data);
			GameObject.Instantiate(ab.mainAsset);
		}
	}
}
