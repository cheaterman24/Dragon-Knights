using UnityEngine;
using System.Collections;

public class CloudController : MonoBehaviour {

	public float R;
	private Vector3 newpos;
	public Renderer ren; 
	public bool onCam = false;
	private float scale;

	// Use this for initialization
	void Start () {
		scale = Random.Range (0.5f, 1f);
		R = scale / 20;
		newpos = transform.position;
		ren = gameObject.GetComponent<Renderer>();

		if (scale > 0.75f) {
			ren.sortingOrder = 0;
		} else
			ren.sortingOrder = 2;
		
		transform.localScale = new Vector3 (scale, scale, scale);
	}

	void OnBecameInvisible()
	{
		onCam =  true;
	}
	
	// Update is called once per frame
	void Update () {

		newpos.x += R;
		transform.position = newpos;
		if (onCam) {
			Destroy (gameObject);
			CloudGen.numLoaded--;
			onCam = false;
		}

	
	}
}
