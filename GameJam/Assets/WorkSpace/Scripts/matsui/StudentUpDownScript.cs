using System.Collections;
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
    bool Speaking = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sound = GetComponent<AudioSource>();
        interval = Random.Range(intervalMin, intervalMax);
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
        sound.volume = 0;
        StartCoroutine(Wait());
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(waitTime);
        Speaking = true;
    }
}
