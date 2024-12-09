using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvaController : MonoBehaviour
{
    public TMP_Text duckText;
    public GameManager gameManager;

    private void Start()
    {
        gameManager  = FindObjectOfType<GameManager>();
    }
    private void OnGUI()
    {
        duckText.text = "Puntuación: " + gameManager.currentPoints.ToString("0000");
    }
}
