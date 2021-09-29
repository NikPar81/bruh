using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Food : MonoBehaviour
{
    public float kolbasa, sir, golodForSecond; // golodForSecond голод за секунду
    public Image KolbasaH, SirH;

    public void Start()
    {
        PlayerPrefs.SetFloat("kolbasa", kolbasa);
        PlayerPrefs.SetFloat("sir", kolbasa);
    }
    private void Update()
    {
        kolbasa = PlayerPrefs.GetFloat("kolbasa");
        sir = PlayerPrefs.GetFloat("sir");
        if (kolbasa > 100) { kolbasa = 100; }
        if (sir > 100) { sir = 100; }
        kolbasa -= Time.deltaTime * golodForSecond;
        sir -= Time.deltaTime * golodForSecond;
        KolbasaH.fillAmount = kolbasa / 100;
        SirH.fillAmount = sir / 100;
        PlayerPrefs.SetFloat("kolbasa", kolbasa);
        PlayerPrefs.SetFloat("sir", sir);
        if((kolbasa <= 0) | (sir <= 0))
        {
            Debug.Log("Smert");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
