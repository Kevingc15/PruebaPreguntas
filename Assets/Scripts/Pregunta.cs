using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Pregunta
{
    public int nivel;
    public string categoria;
    public string enunciado;
    public List<Respuesta> respuestas;
}
