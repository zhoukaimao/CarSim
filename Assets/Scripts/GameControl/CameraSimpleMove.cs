using UnityEngine;
using System.Collections;

public class CameraSimpleMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        var dir = Input.GetAxis("Horizontal") * transform.right + Input.GetAxis("Vertical") * transform.forward;
        Camera.main.transform.Translate(dir);
	}
}
