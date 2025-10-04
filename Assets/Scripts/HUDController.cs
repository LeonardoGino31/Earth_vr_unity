using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class HUDController : MonoBehaviour
{
    [Header("Botones UI")]
    public Button btnTemperatura;
    public Button btnClorofila;
    public Button btnCorrientes;

    [Header("Capas (Persona D)")]
    public GameObject capaTemperatura;
    public GameObject capaClorofila;
    public GameObject capaCorrientes;

    void Start()
    {
        // Listeners de botones
        btnTemperatura.onClick.AddListener(() => ToggleLayer(capaTemperatura));
        btnClorofila.onClick.AddListener(() => ToggleLayer(capaClorofila));
        btnCorrientes.onClick.AddListener(() => ToggleLayer(capaCorrientes));
    }

    void ToggleLayer(GameObject layer)
    {
        if (layer != null)
        {
            layer.SetActive(!layer.activeSelf);
        }
    }
}

