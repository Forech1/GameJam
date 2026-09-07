using System;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class Text_kotodama_Input_Test : MonoBehaviour
{
    public string inputText { get; set; } = "";

    [SerializeField] TextMeshPro fripper_I_K;

    public Action<char> IsInput {  get; set; }

    private void Start()
    {
        
    }

    private void OnEnable()
    {
        Keyboard.current.onTextInput += OnTextInput;

    }
    private void OnDisable()
    {
        Keyboard.current.onTextInput -= OnTextInput;
    }

    private void OnTextInput(char character)
    {
        IsInput?.Invoke(character);
        TextSetFrip(Color.black);

        // Debug.Log("åªç›ÇÃì¸óÕÅF" + inputText);
    }

    void TextSetFrip(Color fontcolor)
    {
        fripper_I_K.text = inputText;

        fripper_I_K.color = fontcolor;
    }

    public void SetInput(int index,char charactor)
    {
       var chars = inputText.ToCharArray();
        chars[index]=charactor;
        inputText = new string(chars);
    }

}
