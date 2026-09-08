using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimeFriper : MonoBehaviour
{
    Image image;
    gameManager gameMnager_;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        image = GetComponent<Image>();
        gameMnager_ = FindAnyObjectByType<gameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        var timeammm = gameMnager_.Timer / gameMnager_.maxTime;

        image.fillAmount = 1 - timeammm;


    }
}
