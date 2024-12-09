using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int currentPoints;
    public int duckPoints = 250;

    private void Start()
    {
        currentPoints = 0;
    }
    private void Update()
    {
        Debug.Log(currentPoints);
    }

}
