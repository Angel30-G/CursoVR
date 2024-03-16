using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuBotones : MonoBehaviour
{
    public Button acceptButton;
    public Button cancelButton;
    public GameObject cubo;
    public GameObject esfera;

    private Vector3 initialPositionCubo;
    private Vector3 initialPositionEsfera;
    private Color originalColorCubo;
    private Color originalColorEsfera;

    void Start()
    {
        // Guardar el estado inicial del cubo
        initialPositionCubo = cubo.transform.position;
        originalColorCubo = cubo.GetComponent<Renderer>().material.color;

        // Guardar el estado inicial de la esfera
        initialPositionEsfera = esfera.transform.position;
        originalColorEsfera = esfera.GetComponent<Renderer>().material.color;

        // Asignar los métodos a los botones
        acceptButton.onClick.AddListener(Aceptar);
        cancelButton.onClick.AddListener(Cancelar);
    }

    public void Aceptar()
    {
        // Acciones al aceptar
        Debug.Log("Acción Aceptar realizada.");

        // Cambiar color del cubo a blanco
        cubo.GetComponent<Renderer>().material.color = Color.white;

        // Cambiar color de la esfera a rojo
        esfera.GetComponent<Renderer>().material.color = Color.black;
    }

    public void Cancelar()
    {
        // Acciones al cancelar
        Debug.Log("Acción Cancelar realizada.");

        // Reiniciar al estado inicial
        ReiniciarEstadoInicial();
    }

    public void ReiniciarEstadoInicial()
    {
        // Restaurar el estado inicial del cubo
        cubo.transform.position = initialPositionCubo;
        cubo.GetComponent<Renderer>().material.color = originalColorCubo;

        // Restaurar el estado inicial de la esfera
        esfera.transform.position = initialPositionEsfera;
        esfera.GetComponent<Renderer>().material.color = originalColorEsfera;
    }
}
