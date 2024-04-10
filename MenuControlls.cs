using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{
    public void PlayGame1()
    {
        SceneManager.LoadScene("GameScene01");
    }
    public void PlayGame2()
    {
        SceneManager.LoadScene("GameScene02");
    }
    public void PlayGame3()
    {
        SceneManager.LoadScene("GameScene03");
    }
    public void PlayGame4()
    {
        SceneManager.LoadScene("GameScene04");
    }
    public void MenuGame()
    {
        SceneManager.LoadScene("MenuScene");
    }
}