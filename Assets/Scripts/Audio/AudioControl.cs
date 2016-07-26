using UnityEngine;
using System.Collections;

public class AudioControl : MonoBehaviour {
    public AudioClip startEngineAudio;
    public AudioClip speedUpAudio;
    public AudioClip drivingInsideAudio;
    public AudioClip drivingOutsideAudio;
    public AudioClip hornAudio;
    public AudioClip skiddingAudio;
    public AudioClip warningAudio;
    public AudioClip turnAudio;
    public AudioClip crashAudio;

    private AudioSource[] audiosrcs;
	// Use this for initialization
	void Start () {
        gameObject.AddComponent<AudioSource>();//for default driving audio
        gameObject.AddComponent<AudioSource>();//for hron audio
        gameObject.AddComponent<AudioSource>();//for warning audio
        gameObject.AddComponent<AudioSource>();//for turning
        audiosrcs = GetComponents<AudioSource>();
        foreach (AudioSource audio in audiosrcs)
        {
            audio.spatialBlend = 1.0f;
            audio.loop = true;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void PlayStartEngine()
    {
        audiosrcs[0].PlayOneShot(startEngineAudio);
    }
    public void PlaySpeedUp()
    {
        audiosrcs[0].PlayOneShot(speedUpAudio);
    }
    public void PlayDrivingInside()
    {
        audiosrcs[0].clip = drivingInsideAudio;
        audiosrcs[0].Play();
    }
    public void StopDrivingInside()
    {
        audiosrcs[0].Stop();
    }
    public void PlayDrivingOutside()
    {
        audiosrcs[0].clip = drivingOutsideAudio;
        audiosrcs[0].Play();
    }
    public void StopDrivingOutside()
    {
        audiosrcs[0].Stop();
    }
    public void PlaySkidding()
    {
        audiosrcs[0].PlayOneShot(skiddingAudio);
    }
    public void PlayHorn()
    {
        audiosrcs[1].clip = hornAudio;
        audiosrcs[1].Play();

    }
    public void StopHorn()
    {
        audiosrcs[1].Stop();
    }
    public void PlayWarning()
    {
        audiosrcs[2].clip = warningAudio;
        audiosrcs[2].Play();
    }
    public void StopWarning()
    {
        audiosrcs[2].Stop();
    }
    public void PlayTurn()
    {
        audiosrcs[3].clip = turnAudio;
        audiosrcs[3].Play();
    }
    public void StopTurn()
    {
        audiosrcs[3].Stop();
    }
    public void PlayCrash()
    {
        audiosrcs[0].PlayOneShot(crashAudio);
    }
}
