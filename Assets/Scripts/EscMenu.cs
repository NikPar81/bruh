using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscMenu : MonoBehaviour
{
    public GameObject GUI1;
    public bool act = false;
    public void Start()
    {
        GUI1.SetActive(act);
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            act = !act;
            GUI1.SetActive(act);
        }
    }
    public void Zanovo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void QuitInMenu()
    {
        SceneManager.LoadScene("menu");
    }
}
