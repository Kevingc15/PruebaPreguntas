using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boton : MonoBehaviour
{

    public Text texto;
    public bool correcto;
    public Image apariencia;
    [Header("Otros Scripts")]
    public GameController gameController;

    private void Start()
    {
        apariencia = gameObject.GetComponent<Image>();
    }

    public void enviarRespuesta()
    {
      
        StartCoroutine(Colorear());
    }

    IEnumerator Colorear()
    {
        if (correcto == true)
        {
            apariencia.color = Color.green;
        }
        else
        {
            apariencia.color = Color.red;
        }

        yield return new WaitForSeconds(2);
        apariencia.color = Color.white;
        if (correcto == true)
        {
            gameController.RespuestaCorrecta();
        }
        else
        {
            gameController.RespuestaIncorrecta();
        }

    }


}
