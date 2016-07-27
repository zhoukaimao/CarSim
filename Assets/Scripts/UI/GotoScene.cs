using UnityEngine;
using System.Collections;


public class GotoScene : MonoBehaviour {

    public string targetScene;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnClick()
    {
        Application.LoadLevel(targetScene);
    }
}
