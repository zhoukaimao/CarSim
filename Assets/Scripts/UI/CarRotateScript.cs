using UnityEngine;
using System.Collections;

public class CarRotateScript : MonoBehaviour {
    public int x = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (x < 400)
        { 
            transform.Rotate(0, 0, -2 * Time.deltaTime, Space.Self);
            x++;
        }
        else if (x >= 400 && x < 800)
        {
            transform.Rotate(0, 0, 2 * Time.deltaTime, Space.Self);
            x++;
        }
        else if (x >= 800 && x < 1200)
        {
            transform.Rotate(0, 0, 2 * Time.deltaTime, Space.Self);
            x++;
        }
        else if (x >= 1200 && x < 1600)
        {
            transform.Rotate(0, 0, -2 * Time.deltaTime, Space.Self);
            x++;
        }
        else
        {
            x = 0;
        }
	}
}
