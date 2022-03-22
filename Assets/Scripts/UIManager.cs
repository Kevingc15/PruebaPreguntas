using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public Text ronda;
    public Text enunciadoPregunta;
    public Text categoria;
    public int botonActual;
    public Boton[] botones;
    public int preguntaActual;
    public Text puntos;
    public int puntaje;

    public PreguntasManager preguntasManager;
    void Start()
    {
        preguntaActual = 0;
        botonActual = 0;
        puntaje = 0;
    }

    public void ActualizarEnunciado(string enunciado, int ronda, string categoria)
    {
        enunciadoPregunta.text = enunciado;
        this.ronda.text = "Ronda: " + ronda;
        this.categoria.text = "Categoria: "+ categoria;
        Debug.Log("Categoria: " + categoria);
    }

    public void ActualizarBoton(string respuesta, bool correcta)
    {
        botones[botonActual].texto.text = respuesta;
        botones[botonActual].correcto = correcta;
        botonActual++;
    }

    public void AumentarPuntos()
    {
        puntaje+= 100;
        puntos.text = puntaje.ToString();
    }

    public int ObtenerPuntos()
    {
        return puntaje;
    }
}
