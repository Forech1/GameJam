using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Kotodama_SpSeetTest", menuName = "Scriptable Objects/Kotodama_SpSeetTest")]
public class Kotodama_SpSeetTest : ScriptableObject
{

    public List<Kotodama_Element> questions = new List<Kotodama_Element>();
    [SerializeField] string resourcesName= "Questions";

    [SerializeField] private int startRow = 1;
    [SerializeField] private int endRow = 100;

    public void SetUp()
    {
        questions.Clear();

        TextAsset csv = Resources.Load<TextAsset>(resourcesName);

        string[] lines = csv.text.Split('\n');

        // CSVの行番号は1から指定できるようにする
        int startIndex = Mathf.Max(1, startRow);
        int endIndex = Mathf.Min(endRow, lines.Length - 1);


        // 1行目はヘッダーなので飛ばす
        for (int i = startIndex; i <= endIndex; i++)
        {
            string[] data = lines[i].Split(',');

            if (data.Length < 3)
                continue;

            Kotodama_Element question = new Kotodama_Element();

            question.Id = int.Parse(data[0]);
            question.FripText = data[1];
            question.InputText = data[2];
            question.Score = int.Parse(data[3]);

            questions.Add(question);
        }

        Debug.Log("読み込んだ問題数：" + questions.Count);
    }

    //インデックスから検索
    public Kotodama_Element GetByIndex(int index)
    {
        //範囲外ならnull
        if (index < 0 || index >= questions.Count)
            return null;

        return questions[index];
    }

    //ランダム検索
    public Kotodama_Element GetByRandom()
    {
        int tar = Random.Range(0, questions.Count - 1);

        return questions[tar];
    }

}
