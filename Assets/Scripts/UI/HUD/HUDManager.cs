using UnityEngine;
using System.Collections;

public class HUDManager : MonoBehaviour {
    public UITexture pointer;
    public UILabel speedLabel;
    public CarStub car;
    float speedHistory=0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        speedLabel.text = car.GetSpeed().ToString();
        pointer.parent.transform.Rotate(Vector3.forward,(speedHistory-car.GetSpeed())*2.2f);
        speedHistory = car.GetSpeed();
        pointer.color = car.GetSpeed()/100*Color.red+(1-car.GetSpeed()/100)*Color.blue;
        //pointer.transform.rotation = new Quaternion(0,0,car.GetSpeed(),0);
        //pointer.transform.rotation.z = 10;
	}
}
