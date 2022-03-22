using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;

public class Guardar : MonoBehaviour
{

    [Header("Jugadores")]
    public List<Jugador> lista_de_jugadores;


    public Text texto;
    public InputField input_nombre;

    public string nombre;
    public int puntos;
    public Jugador jugador;

    public UIManager uim;

    [Header("json")]
    public string filePath;
    public string jsonString;

    public void Start()
    {
        TextAsset txtAssets = (TextAsset)Resources.Load("jugadores");
        filePath = Application.dataPath + "/Resources/jugadores.json";
        jsonString = File.ReadAllText(filePath);
    }

    [System.Serializable]
    public class ListaJugadores
    {
        public List<Jugador> jugadores;
    }

    public void ConseguirJugadores()
    {
        string jsonString = File.ReadAllText(filePath);
        ListaJugadores listajugadores = JsonUtility.FromJson<ListaJugadores>(jsonString);
        foreach (Jugador jugadores in listajugadores.jugadores)
        {
            lista_de_jugadores.Add(jugadores);
        }
    }


    public void GuardarJugador()
    {
        SceneManager.LoadScene(0);

        puntos = uim.ObtenerPuntos();
        Debug.Log("El nombre del jugador es: " + jugador.Nombre);
        ListaJugadores listajugadores = JsonUtility.FromJson<ListaJugadores>(jsonString);

        listajugadores.jugadores.Add(jugador);

        jsonString = JsonUtility.ToJson(listajugadores);
        File.WriteAllText(filePath, jsonString);
    }

    public void CapturarNombre()
    {
        nombre = input_nombre.text;
    }


}
