using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public int Score { get; set; }
    public float Timer { get; set; }
    [SerializeField] public float maxTime;
    public int NumPeople { get; set; }
    [SerializeField] int kiso = 10;
    [SerializeField] AudioSource sound;
    [SerializeField] AudioClip endSound;
    [SerializeField] Image lastImage;
    [SerializeField] string nextSceneName;
    public StudentUpDownScript upDown;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float count = 0;

    void Start()
    {
        Timer = maxTime;
        lastImage.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //•bŠÔŒ¸­
        if (count >= 1)
        {
            SubTime(1);
            count -= count;
        }

        if (Timer <= 0)
        {
            AudioSystems.instance.PlaySoundSE(0, endSound);
            lastImage.enabled = true;
            AudioSystems.instance.ResultScore = Score;
            AudioSystems.instance.ResultPeple = NumPeople;

            SceneManager.LoadScene(nextSceneName);
        }


        count += Time.deltaTime;
    }
    public void Add()
    {
       // Debug.Log(upDown.muteStudent);
        Score += kiso * (int)(upDown.muteStudent * 100 / 20);
        Debug.Log(Score);
    }

    public void SubTime(float sub)
    {
        Timer -= sub;
    }
}


