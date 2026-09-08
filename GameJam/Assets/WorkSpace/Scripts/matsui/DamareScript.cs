using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class DamareScript : MonoBehaviour
{
    public int damage = 1;
    //public int kari = 50;
    [SerializeField] GameObject cameraObject;
    [SerializeField] GameObject CutInObject;
    public gameManager gameManager;
    public StudentUpDownScript upDown;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (upDown.Speaking && Keyboard.current.enterKey.wasPressedThisFrame)
        {
            Instantiate(CutInObject, new Vector3(0, 12.5f, 10.5f), Quaternion.Euler(25, 0, 0));

            gameManager.upDown.Mute();
            gameManager.Add();
        }
    }
}
