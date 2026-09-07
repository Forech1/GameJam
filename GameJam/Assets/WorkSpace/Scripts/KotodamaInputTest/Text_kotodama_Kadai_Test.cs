using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Windows;

public class Text_kotodama_Kadai_Test : MonoBehaviour
{
    [SerializeField] string fripKadai;
    [SerializeField] string inputkadai;
    [SerializeField] TextMeshPro fripper_F;
    [SerializeField] List<TextMeshPro> fripper_I;
    int nowChar = 0;

    [SerializeField] Kotodama_Input inputer;

    private void OnEnable()
    {
        inputer.IsInput += InputExamination;
    }
    private void OnDisable()
    {
        inputer.IsInput -= InputExamination;
    }

    private void Start()
    {
        ResetKadai();
    }
    protected void ResetKadai()
    {
        fripper_F.text = fripKadai;

        foreach(var t in fripper_I)
            t.text = inputkadai;

        inputer.inputText = new string(' ', inputkadai.Length);


        for (int i = 0; i < inputkadai.Length; i++)
        {
            inputer.inputText += $"<color=#00000000>{inputkadai[i]}</color>";
        }

    }

    

    private void InputExamination(char inputEl)
    {
        //åªç›ÇÃì¸óÕÇ∆ìØÇ∂ÇÃèÍçá
        if (inputkadai[nowChar] == inputEl)
        {
            Debug.Log("ê≥â");
            nowChar++;
            updateText();
        }
        else
        {
            Debug.Log("ä‘à·Ç¢");
            
        }
        

    }

   void updateText()
    {
        string result = "";


        for (int i = 0; i < inputkadai.Length; i++)
        {
            if (i < nowChar)
            {
                result += inputkadai[i];
            }
            else
            {
                result += $"<color=#00000000>{inputkadai[i]}</color>";
            }
        }

        inputer.inputText = result;
    }

}
