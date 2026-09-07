using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{ 
    [SerializeField] private GameObject firstSelected;
    [SerializeField] private string game;

    void Start()
    {
        EventSystem.current.SetSelectedGameObject(firstSelected);
    }

    public void StartButton()
    {
        SceneManager.LoadScene(game);

    }
    public void EndButton()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif

    }
}
