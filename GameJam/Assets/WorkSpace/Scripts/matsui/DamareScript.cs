using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class DamareScript : MonoBehaviour
{
    [SerializeField]int damage = 30;
    public int kari = 50;
    [SerializeField] GameObject cameraObject;
    [SerializeField] GameObject CutInObject;
    int count = 0;
    bool isStudent = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isStudent && Keyboard.current.enterKey.wasPressedThisFrame)
        {
            isStudent = false;
            cameraObject.transform.Rotate(50, 180, 0);
            if(kari - damage > 0)
            {
                kari = kari - damage;
                damage = damage - 2 * count;
            }
            else
            {
                kari = 0;
            }
            count++;
            Instantiate(CutInObject, new Vector3(0, 12.5f, 10.5f), Quaternion.Euler(25, 0, 0));
        }
    }
}
