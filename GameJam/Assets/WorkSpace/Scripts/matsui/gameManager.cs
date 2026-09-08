using UnityEngine;

public class gameManager : MonoBehaviour
{
    public int Score { get; set; }
    public float Time {  get; set; }
    public int NumPeople {  get; set; }
    [SerializeField]int kiso = 10;
    [SerializeField] AudioSource sound;
    public StudentUpDownScript upDown;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Add()
    {
       // Debug.Log(upDown.muteStudent);
        Score += kiso * (int)(upDown.muteStudent * 100 / 20);
        Debug.Log(Score);
    }
}
