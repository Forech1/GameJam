using TMPro;
using UnityEngine;

public class Kotodama_Return : MonoBehaviour
{
    [SerializeField] TextMeshPro bord;
    [SerializeField] float breakLine = 19f;
    [SerializeField] int limit = 19;

    int breakcount = 0;

    private void Start()
    {
        bord.text = "";
    }

    public void LineBreak(string nextB)
    {
        float bT =0;
        float bA = 0;

        int endIndex = bord.text.Length - 1;
        int startIndex = bord.text.LastIndexOf('\n', endIndex);
        startIndex++;
        string nowB = bord.text.Substring(
            startIndex,
            endIndex - startIndex + 1
        );

        //一番下の行の文字列の文字幅を確認
        foreach (char c in nowB)
        {
            // 半角文字
            if (c <= 0x7F)
            {
                bT += 0.5f;
            }
            // 全角文字
            else
            {
                bT += 1.0f;
            }

        }
        //新たな文字数の文字幅獲得
        foreach (char c in nextB)
        {
            // 半角文字
            if (c <= 0x7F)
            {
                bA += 0.5f;
            }
            // 全角文字
            else
            {
                bA += 1.0f;
            }
        }
        //改行敷居より多い場合は改行
        if(bT+bA > breakLine)
        {
            breakcount++;
            bord.text += '\n';
        }

        //限界の場合は表示しない
        if (breakcount >= limit)
            return;

        //ボード追加
        bord.text += nextB;

    }
}
