using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Kotodama_KadaiMnager : MonoBehaviour
{
    [SerializeField] Kotodama_SpSeetTest databace;
    string fripKadai;
    string inputkadai;
    [SerializeField] TextMeshProUGUI fripper_F;
    [SerializeField] List<TextMeshProUGUI> fripper_I;
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
        inputer.TextSetFrip(Color.black);
        databace.SetUp();
        ResetKadai(databace.GetByRandom());
    }
    protected void ResetKadai(Kotodama_Element nextEl)
    {
        fripKadai = nextEl.FripText;
        inputkadai = nextEl.InputText;

        fripper_F.text = fripKadai;

        foreach (var t in fripper_I)
            t.text = inputkadai;

        updateText();

    }



    private void InputExamination(char inputEl)
    {
        //現在の入力と同じの場合
        if (inputkadai[nowChar] == inputEl)
        {
            Debug.Log("正解");
            nowChar++;
            updateText();

            //クリアした場合再セット
            if(nowChar>= inputkadai.Length)
            {
                nowChar = 0;
                ResetKadai(databace.GetByRandom());
            }
                
        }
        else
        {
            Debug.Log("間違い");

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
