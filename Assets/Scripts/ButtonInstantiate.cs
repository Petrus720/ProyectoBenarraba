using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInstantiate : MonoBehaviour
{
    public GameObject[] instantiationOnScene;
    
    public Transform[] instantiatePositions;

    public void DestroyInstantiationBefore()
    {
        instantiationOnScene = GameObject.FindGameObjectsWithTag("Instantiated");
        foreach (GameObject inst in instantiationOnScene)
        {
            Destroy(inst);
        }
    }
    public void Instantiation(GameObject prefab)
    {
        DestroyInstantiationBefore();
        foreach (Transform pos in instantiatePositions)
        {
            Instantiate(prefab, pos.position, Quaternion.identity);
        }
    }

}
