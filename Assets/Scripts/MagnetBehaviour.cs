using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MagnetBehaviour : MonoBehaviour
{
    public static MagnetBehaviour Instance;
    private MeshRenderer attachedDuckRenderer;
    private Collider attachedDuckCollider;
    public CanvaController canvaController;
    


    private void Start()
    {
        canvaController = GameObject.Find("CanvasDuck").GetComponent<CanvaController>();
        attachedDuckRenderer = GetComponent<MeshRenderer>();
        attachedDuckCollider = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CollectedZone"))
        {
 
            attachedDuckRenderer.enabled = false;
            canvaController.currentPoints += canvaController.gamePoints;
            attachedDuckCollider.enabled = false;
        }
    }




}
