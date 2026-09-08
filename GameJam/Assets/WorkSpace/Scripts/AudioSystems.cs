using DG.Tweening.Core.Easing;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;

public class AudioSystems : MonoBehaviour
{
    public static AudioSystems instance;

    [SerializeField] AudioSource BgmSource;
    [SerializeField] List<AudioSource> SeSource = new List<AudioSource>();

    public int ResultScore { get; set; }
        public int ResultPeple { get; set; }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);

        BgmSource.spatialBlend = 0f;
        foreach (AudioSource source in SeSource)
        {
            if (source != null)
            {
                source.spatialBlend = 0;
            }
        }
    }

    public void PlaySoundBGM(AudioClip clip=null)
    {
        if (clip != null)
            BgmSource.clip = clip;

        BgmSource.clip = clip;
        BgmSource.Play();
    }
    public void StopSoundBGM() {

        BgmSource.Stop();
    }
    public void SetSoundVolBGM(float volume) {

        BgmSource.volume = Mathf.Clamp01(volume);
    }

    public void PlaySoundSE(int index, AudioClip clip=null)
    {
        if (index > SeSource.Count)
            return;

        if (clip != null)
            SeSource[index].clip = clip;

        SeSource[index].Play();
    }
    public void StopSoundSE(int index)
    {
        if (index > SeSource.Count)
            return;

        SeSource[index].Stop();
    }
    public void SetSoundVolSE(int index, float volume)
    {
        if (index > SeSource.Count)
            return;

        SeSource[index].volume = Mathf.Clamp01(volume);
    }
}
