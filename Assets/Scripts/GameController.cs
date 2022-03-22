using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{


    [Header("Otros Scripts")]
    public PreguntasManager preguntasManager;
    public UIManager uiManager;

    public GameObject gameover;
    public GameObject buttonDesable;

    public GameObject juego;
    public GameObject captura;

    public string nombre;
    void Start()
    {
        preguntasManager.ConseguirPreguntasNivel();
        gameover.SetActive(false);
        juego.SetActive(false);
        captura.SetActive(true);
    }

    public void RespuestaCorrecta()
    {
        uiManager.AumentarPuntos();
        preguntasManager.LanzarPregunta();
    }

    public void RespuestaIncorrecta()
    {
        buttonDesable.SetActive(false);
        juego.SetActive(false);
        gameover.SetActive(true);
    }

    public void IniciarJuego()
    {
        captura.SetActive(false);
        juego.SetActive(true);
    }

    public void Salir()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene(0);
        Debug.Log("salir");
    }

    public void NuevoJuego()
    {
        SceneManager.LoadScene(1);
    }



}
