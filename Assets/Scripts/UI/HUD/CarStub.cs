using UnityEngine;
using System.Collections;

public class CarStub : MonoBehaviour {
    float speed = 0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow)&&speed<100)
        {
            
            speed++;
        }
        if (Input.GetKey(KeyCode.DownArrow) && speed > 0) 
        { 
            speed--; 
        }

	}
    public float GetSpeed()
    {
        return speed;
    }
}
