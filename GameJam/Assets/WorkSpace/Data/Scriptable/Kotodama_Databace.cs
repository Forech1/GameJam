using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "Kotodama_Databace", menuName = "kotodamaData/Kotodama_Databace")]
public class Kotodama_Databace : ScriptableObject
{
    //生データ
    [SerializeField] List<Kotodama_Element> listPattern;

    //読み取り専用
    public IReadOnlyList<Kotodama_Element> ListPatterns => listPattern;

    // modeをtrueにすると、tagが設定されていても既定値を使用して取得します

    //名前から取得
    //public Kotodama_Element ListGetName(string name, bool mode = false)
    //{
    //    List<Kotodama_Element> lists = listPattern;

    //    //if (allData != null && tagAll != Products.None)
    //    //{

    //    //    Debug.Log(allData.GetList().Count + " " + allData.GetList().FindAll(x => x.GetProductType() == tagAll).Count);
    //    //    lists = allData.GetList().FindAll(x => x.GetProductType() == tagAll);
    //    //}


    //    //FirstOrDefault初めに見つかった条件にあうものを出力
    //    return lists.FirstOrDefault(enter => enter.Id == name);
    //}

    //インデックスから検索
    public Kotodama_Element GetByIndex(int index)
    {
        //範囲外ならnull
        if (index < 0 || index >= ListPatterns.Count)
            return null;

        return ListPatterns[index];
    }

    //ランダム検索
    public Kotodama_Element GetByRandom(int index)
    {
        int tar = Random.Range(0, ListPatterns.Count-1);

        return ListPatterns[tar];
    }

}
