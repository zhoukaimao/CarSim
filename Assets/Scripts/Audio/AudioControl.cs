using UnityEngine;
using System.Collections;

public class AudioControl : MonoBehaviour {
    public AudioClip startEngineAudio;//开启引擎
    public AudioClip idleAudio;//启动后idle
    public AudioClip speedUpAudio;//
    public AudioClip drivingInsideAudio;//行驶中的车内，测试车车内
    public AudioClip drivingOutsideAudio;//其他车行驶声音
    public AudioClip pullupAudio;//停车
    public AudioClip hornAudio;//按喇叭
    public AudioClip skiddingAudio;//刹车
    public AudioClip warningAudio;//警报
    public AudioClip turnAudio;//转向
    public AudioClip crashAudio;//撞车
    public AudioClip environmentAudio;//环境音
    public AudioClip carWiperAudio;//雨刷
    public AudioClip rainOnCarAudio;//雨

    private AudioSource[] audiosrcs;

    float globalVolume=1.0f;//音量

	// Use this for initialization
	void Start () {
        gameObject.AddComponent<AudioSource>();//for default driving audio
        gameObject.AddComponent<AudioSource>();//for hron audio
        gameObject.AddComponent<AudioSource>();//for warning audio
        gameObject.AddComponent<AudioSource>();//for turning
        gameObject.AddComponent<AudioSource>();//for environment
        gameObject.AddComponent<AudioSource>();//for car wiper

        audiosrcs = GetComponents<AudioSource>();
        foreach (AudioSource audio in audiosrcs)
        {
            audio.spatialBlend = 1.0f;
            audio.loop = true;
            audio.volume = globalVolume;
        }

        audiosrcs[0].clip = idleAudio;
        audiosrcs[1].clip = hornAudio;
        audiosrcs[2].clip = warningAudio;
        audiosrcs[3].clip = turnAudio;
        audiosrcs[4].clip = environmentAudio;
        audiosrcs[5].clip = carWiperAudio;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    /// <summary>
    /// 启动引擎
    /// </summary>
    /// <param name="volumeScale"></param>
    public void PlayStartEngine(float volumeScale)
    {
        audiosrcs[0].PlayOneShot(startEngineAudio, volumeScale*globalVolume);
        PlayIdle();
        //saudiosrcs[0].Play(50000);
    }
    public void PlayStartEngine()
    {
        PlayStartEngine(1.0f);
    }
    /// <summary>
    /// 待机
    /// </summary>
    /// <param name="volumeScale"></param>
    public void PlayIdle(float volumeScale)
    {
        audiosrcs[0].volume = globalVolume * volumeScale;
        audiosrcs[0].clip = idleAudio;
        audiosrcs[0].Play();
    }
    public void PlayIdle()
    {
        PlayIdle(1.0f);
    }

    public void StopIdle()
    {
        audiosrcs[0].Stop();
    }

    /// <summary>
    /// 踩油门加速
    /// </summary>
    /// <param name="voluemScale"></param>
    public void PlaySpeedUp(float voluemScale)
    {
        audiosrcs[0].volume = globalVolume * voluemScale;
        audiosrcs[0].clip = speedUpAudio;
        audiosrcs[0].Play();
    }
    public void PlaySpeedUp()
    {
        PlaySpeedUp(1.0f);
    }
    public void StopSpeedUp()
    {
        audiosrcs[0].Stop();
    }

    /// <summary>
    /// 行驶中车内
    /// </summary>
    /// <param name="volumeScale"></param>
    public void PlayDrivingInside(float volumeScale)
    {
        audiosrcs[0].volume = globalVolume * volumeScale;
        audiosrcs[0].clip = drivingInsideAudio;
        audiosrcs[0].Play();
    }
    public void PlayDrivingInside()
    {
        PlayDrivingInside(1.0f);
    }
    public void StopDrivingInside()
    {
        audiosrcs[0].Stop();
    }

    /// <summary>
    /// 行驶中车外
    /// </summary>
    /// <param name="volumeScale"></param>
    public void PlayDrivingOutside(float volumeScale)
    {
        audiosrcs[0].volume = globalVolume * volumeScale;
        audiosrcs[0].clip = drivingOutsideAudio;
        audiosrcs[0].Play();
    }
    public void PlayDrivingOutside()
    {
        PlayDrivingOutside(1.0f);
    }
    public void StopDrivingOutside()
    {
        audiosrcs[0].Stop();
    }

    /// <summary>
    /// 刹车
    /// </summary>
    /// <param name="volumeScale"></param>
    public void PlaySkidding(float volumeScale)
    {
        audiosrcs[0].PlayOneShot(skiddingAudio,globalVolume*volumeScale);
    }
    public void PlaySkidding()
    {
        PlaySkidding(1.0f);
    }
    /// <summary>
    /// 停车
    /// </summary>
    /// <param name="volumeScale"></param>
    public void PlayPullup(float volumeScale)
    {
        audiosrcs[0].PlayOneShot(pullupAudio,volumeScale*globalVolume);
    }
    public void PlayPullup()
    {
        PlayPullup(1.0f);
    }
    /// <summary>
    /// 按喇叭
    /// </summary>
    /// <param name="volumeScale"></param>
    public void PlayHorn(float volumeScale)
    {
        audiosrcs[1].volume = globalVolume * volumeScale;
        audiosrcs[1].Play();

    }
    public void PlayHorn()
    {
        PlayHorn(1.0f);
    }
    public void StopHorn()
    {
        audiosrcs[1].Stop();
    }
    /// <summary>
    /// 警报
    /// </summary>
    /// <param name="volumeScale"></param>
    public void PlayWarning(float volumeScale)
    {
        audiosrcs[2].volume = volumeScale * globalVolume;
        audiosrcs[2].Play();
    }
    public void PlayWarning()
    {
        PlayWarning(1.0f);
    }
    public void StopWarning()
    {
        audiosrcs[2].Stop();
    }

    /// <summary>
    /// 转向
    /// </summary>
    /// <param name="volumeScale"></param>
    public void PlayTurn(float volumeScale)
    {
        audiosrcs[3].volume = globalVolume * volumeScale;
        audiosrcs[3].Play();
    }
    public void PlayTurn()
    {
        PlayTurn(1.0f);
    }
    public void StopTurn()
    {
        audiosrcs[3].Stop();
    }
    /// <summary>
    /// 撞车
    /// </summary>
    /// <param name="volumeScale"></param>
    public void PlayCrash(float volumeScale)
    {
        audiosrcs[0].PlayOneShot(crashAudio,volumeScale*globalVolume);
    }
    public void PlayCrash()
    {
        PlayCrash(1.0f);
    }
    /// <summary>
    /// 环境音
    /// </summary>
    /// <param name="volumeScale"></param>
    public void PlayEnvironment(float volumeScale)
    {
        audiosrcs[4].volume = globalVolume * volumeScale;
        audiosrcs[4].Play();
    }
    public void PlayEnvironment()
    {
        PlayEnvironment(1.0f);
    }
    public void StopEnvironment()
    {
        audiosrcs[4].Stop();
    }
    /// <summary>
    /// 雨声
    /// </summary>
    /// <param name="voluemScale"></param>
    public void PlayRainCar(float voluemScale)
    {
        audiosrcs[4].volume = globalVolume * globalVolume;
        audiosrcs[4].clip = rainOnCarAudio;
        audiosrcs[4].Play();
    }
    public void PlayRainCar()
    {
        PlayRainCar(1.0f);
    }
    public void StopRainCar()
    {
        audiosrcs[4].Stop();
    }
    /// <summary>
    /// 雨刷
    /// </summary>
    /// <param name="volumeScale"></param>
    public void PlayCarWiper(float volumeScale)
    {
        audiosrcs[5].volume = globalVolume * volumeScale;
        audiosrcs[5].Play();
    }
    public void PlayCarWiper()
    {
        PlayCarWiper(1.0f);
    }
    public void StopCarWiper()
    {
        audiosrcs[5].Stop();
    }
}
