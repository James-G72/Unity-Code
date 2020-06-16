using UnityEngine;
using System.Collections;

// This script hides the gameObject it is assigned to as hidden when you hit play. Tis was used to hide the main mesh.
public class HideOnPlay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
