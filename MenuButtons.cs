using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    public void ButtonQuitGamePressed()
    {
        GameManager.QuitGame();
    }

    public void ButtonPlayPressed()
    {
        GameManager.LoadNextLevel();
    }
}
