using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MagnetBehaviour : MonoBehaviour
{
    public static MagnetBehaviour Instance;
    private MeshRenderer attachedDuckRenderer;
    private Collider attachedDuckCollider;
    public GameManager gameManager;
    


    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        attachedDuckRenderer = GetComponent<MeshRenderer>();
        attachedDuckCollider = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CollectedZone"))
        {
            //GameManager.Instance.CurrentPoints += GameManager.Instance.duckPoints;
            
            attachedDuckRenderer.enabled = false;
            gameManager.currentPoints += gameManager.duckPoints;
            attachedDuckCollider.enabled = false;
        }
    }




}
