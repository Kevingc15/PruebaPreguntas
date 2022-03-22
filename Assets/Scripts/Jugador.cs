using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Jugador
{
    public string nombre;
    public int puntos;

    public string Nombre { get { return nombre; } set { nombre = value; } }
}
