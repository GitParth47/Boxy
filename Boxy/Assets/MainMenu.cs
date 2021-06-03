using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private string In_GameScene = "";
    public void PlayGame()
    {
        SceneManager.LoadScene(In_GameScene);
    }
}
