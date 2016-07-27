using UnityEngine;
using System.Collections;

public class SendSetiing : MonoBehaviour {
    public string Weather;
    public double VoiceStrength;
	// Use this for initialization
	void Start () {
        Weather = GameObject.FindGameObjectWithTag("SelectDif").GetComponent<UIPopupList>().value;
        VoiceStrength = GameObject.FindGameObjectWithTag("Voice").GetComponent<UISlider>().value;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnClick()
    {

        Debug.Log(Weather);
        Debug.Log(VoiceStrength);
    }
}
