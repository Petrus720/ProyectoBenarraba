using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Net : MonoBehaviour
{
    public CanvaController canvaController;
    public ButtonInstantiate buttonInstantiate;
    public GameObject prefab;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Basketball"))
        {
            canvaController.currentPoints += canvaController.gamePoints;
            other.gameObject.GetComponent<SphereCollider>().enabled = false;
            Destroy(other, 1f);
            buttonInstantiate.Instantiation(prefab);
        }
    }
}
