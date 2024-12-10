using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvaController : MonoBehaviour
{
    public TMP_Text gameText;
    public int currentPoints;
    public int gamePoints;

    private void Start()
    {
        currentPoints = 0;
    }
    private void OnGUI()
    {
        gameText.text = "Puntuación: " + currentPoints.ToString("0000");
    }
}
