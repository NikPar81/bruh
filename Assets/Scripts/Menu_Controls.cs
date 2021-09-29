using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Controls : MonoBehaviour
{
    public void PlayPressed()
    {
        SceneManager.LoadScene("startScene");
    }
    public void ExitPressed()
    {
        Application.Quit();
    }
}
