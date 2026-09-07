using UnityEngine;

[CreateAssetMenu(fileName = "Kotodama_Element", menuName = "kotodamaData/Kotodama_Element")]
public class Kotodama_Element : ScriptableObject
{
    [SerializeField] public int Id;
   [SerializeField] public string FripText;
   [SerializeField] public string InputText;
    [SerializeField] public int Score;
}
