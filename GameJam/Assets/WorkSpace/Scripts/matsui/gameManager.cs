using UnityEngine;

public class gameManager : MonoBehaviour
{
    public int Score { get; set; }
    public float Time {  get; set; }
    public int NumPeople {  get; set; }
    [SerializeField]int kiso = 10;
    [SerializeField] AudioSource sound;
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
        Score += kiso * (int)(sound.volume * 100 / 20);
        Debug.Log(Score);
    }
}
