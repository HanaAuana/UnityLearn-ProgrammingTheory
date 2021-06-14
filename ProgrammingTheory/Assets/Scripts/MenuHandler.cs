using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuHandler : MonoBehaviour
{
    private GameManager manager;
    public Button startButton;
    public TMP_InputField nameInput;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameManager.Instance;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void setPlayerName()
    {
        string typedName = nameInput.text;
        if(typedName == null)
        {
            typedName = "Name";
        }
        manager.PlayerName = nameInput.text;
    }
}
