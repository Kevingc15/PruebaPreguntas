using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;

public class Resultados : MonoBehaviour
{

    [Header("json")]
    public string filePath;
    public string jsonString;

    public GameObject item;
    public Text nombre;
    public Text puntos;

    [System.Serializable]
    public class ListaJugadores
    {
        public List<Jugador> jugadores;
    }

    public void Start()
    {
        TextAsset txtAssets = (TextAsset)Resources.Load("jugadores");
        filePath = Application.dataPath + "/Resources/jugadores.json";
        jsonString = File.ReadAllText(filePath);
    }
}
