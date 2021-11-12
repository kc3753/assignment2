using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    TransitionManager _transitionManager;
    private void Start()
    {
        _transitionManager = FindObjectOfType<TransitionManager>();
    }

    public void StartGame()
    {
        _transitionManager.LoadScene("Level1");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
