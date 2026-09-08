using DG.Tweening;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class DamareScript : MonoBehaviour
{
    public int damage = 1;
    //public int kari = 50;
    [SerializeField] GameObject cameraObject;
    [SerializeField] GameObject CutInObject;
    [SerializeField] AudioClip damare;
    [SerializeField] Transform cameraPos;
    Animator animator;
    public gameManager gameManager;
    [SerializeField] StudentUpDownScript upDown;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator=CutInObject.GetComponent<Animator>();
        CutInObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (upDown.Speaking && Keyboard.current.enterKey.wasPressedThisFrame)
        {
            CutInObject.SetActive(true);
            upDown.aaa = true;

            // Instantiate(CutInObject, new Vector3(0, 12.5f, 10.5f), Quaternion.Euler(25, 0, 0));

            animator.SetTrigger("damare");

            AudioSystems.instance.PlaySoundSE(1, damare);
            cameraPos.DORotate(new Vector3(0, 180, 0), 0.3f);

            gameManager.upDown.Mute();
            gameManager.Add();
        }
    }
}
