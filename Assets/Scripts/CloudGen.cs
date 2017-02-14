using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CloudGen : MonoBehaviour {

	public static List <GameObject> loaded = new List<GameObject>();
	private static Object[] cloudObjs;
	public static int numLoaded = 0;

	// Use this for initialization
	void Start () {

		cloudObjs = Resources.LoadAll ("Prefabs", typeof(GameObject));
		if (numLoaded < 4) {
			loaded.Add ((GameObject)cloudObjs [Random.Range (0, cloudObjs.Length - 1)]);
			Instantiate (loaded [loaded.Count - 1],transform.position = new Vector3 (Random.Range(-40f,-25f), Random.Range(-10f,10f), Random.Range(-1f,0f)), Quaternion.identity);
			numLoaded++;
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		// take random cloud prefab from cloudobjs array and add to list of loaded clouds
		if (numLoaded < 4) {
			loaded.Add ((GameObject)cloudObjs [Random.Range (0, cloudObjs.Length - 1)]);
			Instantiate (loaded [loaded.Count - 1],transform.position = new Vector3 (Random.Range(-40f,-25f), Random.Range(-10f,10f), Random.Range(-1f,0f)), Quaternion.identity);
			numLoaded++;
		}
			
	}
}
