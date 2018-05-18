using UnityEngine;
using System.Collections;

public class AudioDelay : MonoBehaviour {

	public float time=0.2F;
	public GameObject audio,audio2;
	void Start () {
		Destroy (audio);
		StartCoroutine (delay ());
	}

	IEnumerator delay(){
		yield return new WaitForSeconds (time);
		audio2.SetActive (true);
	//	AudioClip
	
	}
}
