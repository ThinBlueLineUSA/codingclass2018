using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using Object = UnityEngine.Object;

public enum SoundEffect
{
    Jump,
    Laser,
    huh_huh,
    hey,
    doh32,
    Bee,
    ree,
    ChickenTendies,
}

public class AudioManager
{
    static AudioManager instance;

    private Dictionary<SoundEffect, AudioClip> SoundEffects
    { get; set; }

    private AudioSource SoundEffectSource
    { get; set; }

    private AudioSource BGMSource
    { get; set; }

    public static AudioManager Instance
    { get { return instance ?? (instance = new AudioManager()); } }

    private AudioManager()
    {
        SoundEffects = Resources.LoadAll<AudioClip>("")
            .ToDictionary(t => (SoundEffect)Enum.Parse(typeof(SoundEffect), t.name, true));

        SoundEffectSource = new GameObject("SoundEffectSource", typeof(AudioSource)).GetComponent<AudioSource>();
        Object.DontDestroyOnLoad(SoundEffectSource.gameObject);

        BGMSource = new GameObject("BGMSource", typeof(AudioSource)).GetComponent<AudioSource>();
        BGMSource.volume = .5f;
        BGMSource.loop = true;
        Object.DontDestroyOnLoad(BGMSource.gameObject);

        ChangeBGM(Resources.Load<AudioClip>("ChickenTendies"));
    }

    public void PlayOneShot(SoundEffect sound, float volumescale = 1)
    {
        SoundEffectSource.PlayOneShot(SoundEffects[sound], volumescale * 1);
    }

    public void ChangeBGM(AudioClip clip)
    {
        BGMSource.clip = clip;
        BGMSource.Play();
    }
}
