using DG.Tweening;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class StudentUpDownScript : MonoBehaviour
{
    [SerializeField]int Up = 80;
    [SerializeField] int Down = 20;
    float time = 0;
    float interval;
    [SerializeField] float intervalMin = 1.0f;
    [SerializeField] float intervalMax = 3.0f;
    [SerializeField] float waitTime = 4f;
    AudioSource sound;
    public bool Speaking = true;
    float count = 0;
    public float damage = 1;
    float startVolume = 0;
    public float muteStudent;

    public bool aaa { get; set; }=false;

    [SerializeField] Transform cameraPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sound = GetComponent<AudioSource>();
        interval = Random.Range(intervalMin, intervalMax);
        sound.volume = startVolume;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time >= interval && Speaking)
        {
            int rndStu = Random.Range(0, 100);
            if (rndStu >= Down)
            {
                if(sound.volume >= 0 && sound.volume < 20)
                {
                    sound.volume += (float)6 / 100;
                }
                if (sound.volume >= 20 && sound.volume < 70)
                {
                    sound.volume += (float)6 / 100;
                }
                if (sound.volume >= 70 && sound.volume < 100)
                {
                    sound.volume += (float)4 / 100;
                }
            }
            else if (rndStu < 100 - Up)
            {
                if (sound.volume > 0 && sound.volume < 20)
                {
                    sound.volume -= (float)2 / 100;
                }
                if (sound.volume >= 20 && sound.volume < 70)
                {
                    sound.volume -= (float)4 / 100;
                }
                if (sound.volume >= 70 && sound.volume < 100)
                {
                    sound.volume -= (float)6 / 100;
                }
            }
            time = 0;
            interval = Random.Range(intervalMin, intervalMax);
        }
    }
    public void Mute()
    {
        Speaking = false;
        muteStudent = sound.volume * damage;
        startVolume = sound.volume - muteStudent;
        damage = damage - (0.04f + (2 * count) / 100);
        count++;
        sound.volume = 0; 
       // Debug.Log(damage);
        StartCoroutine(Wait());
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(waitTime);

        cameraPos.DORotate(new Vector3(0, 0, 0), 1f);
        Speaking = true;
        sound.volume = startVolume;

        aaa = false;
    }
}
