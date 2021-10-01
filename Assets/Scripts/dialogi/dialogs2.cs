using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogs2 : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;

    void Start()
    {
        panel1.SetActive(false);
        panel2.SetActive(false);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Mouse")
        {
            panel1.SetActive(true);

        }
        if (collision.tag == "Cat")
        {
            panel2.SetActive(true);

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Mouse")
        {
            panel1.SetActive(false);

        }

        if (collision.tag == "Cat")
        {
            panel2.SetActive(false);

        }
    }
}
