using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;


public class PreguntasManager : MonoBehaviour
{
    [Header("json")]
    public string filePath;
    public string jsonString;

    [Header("Preguntas Actuales")]
    public List<Pregunta> preguntasActuales;
    public int preguntaActual;

    [Header("Otros Scripts")]
    public UIManager uiManager;

    public Boton[] botones;
    void Start()
    {
        TextAsset txtAssets = (TextAsset)Resources.Load("preguntas");
        filePath = Application.dataPath + "/Resources/preguntas.json";
        string jsonString = File.ReadAllText(filePath);
        preguntaActual = 0;
    }



    [System.Serializable]
    public class ListaPreguntas
    {
        public List<Pregunta> preguntas;
    }

    public void ConseguirPreguntasNivel()
    {
        //Leyendo JSON
        string jsonString = File.ReadAllText(filePath);
        ListaPreguntas listaPreguntas = JsonUtility.FromJson<ListaPreguntas>(jsonString);
        foreach (Pregunta pregunta in listaPreguntas.preguntas)
        {
                preguntasActuales.Add(pregunta);
        }
        LanzarPregunta();

        //GUARDANDO JSON
     /* jsonString = JsonUtility.ToJson(listaPreguntas);
        File.WriteAllText(filePath, jsonString);  */
    }

    public void LanzarPregunta()
    {
        uiManager.ActualizarEnunciado(preguntasActuales[preguntaActual].enunciado, preguntasActuales[preguntaActual].nivel, preguntasActuales[preguntaActual].categoria.ToString());
        foreach (Respuesta respuesta in preguntasActuales[preguntaActual].respuestas)
        {
            uiManager.ActualizarBoton(respuesta.texto, respuesta.correcta);
        }
        preguntaActual++;
        uiManager.botonActual = 0;
    }
}
