using TMPro;
using UnityEngine;

public class ScoreFriper : MonoBehaviour
{
    TextMeshProUGUI textMeshProUGUI;
    [SerializeField]gameManager gameMnager_;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        textMeshProUGUI.text = gameMnager_.Score.ToString();
    }
}
