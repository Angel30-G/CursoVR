using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CambiarColor : MonoBehaviour
{
    [SerializeField]
    public GameObject cube; // Referencia al cubo que deseas cambiar de color
    public TMP_Dropdown dropdown; // Referencia al TMP_Dropdown

    // Método llamado cuando se cambia el valor en el Dropdown
    public void OnDropdownValueChanged(int index)
    {
        // Obtener el color seleccionado en el Dropdown
        Color selectedColor = Color.red; // Color por defecto
        switch (index)
        {
            case 0: // Opción 1 del Dropdown
                selectedColor = Color.red;
                break;
            case 1: // Opción 2 del Dropdown
                selectedColor = Color.blue;
                break;
            case 2: // Opción 3 del Dropdown
                selectedColor = Color.green;
                break;
            // Puedes agregar más casos según sea necesario para más colores
        }

        // Cambiar el color del material del cubo
        cube.GetComponent<Renderer>().material.color = selectedColor;
    }
}