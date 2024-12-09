using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInstantiate : MonoBehaviour
{
    public GameObject prefab;
    public GameObject[] ropesOnScene;
    public Transform instantiatePosition;

    public Transform[] clownInstantiatePositions;
    public void RopeInstantiaton()
    {
       foreach (GameObject rope in ropesOnScene)
        {
            Destroy(rope);
        }
        Instantiate(prefab, instantiatePosition.position, Quaternion.identity);
    }

    public void ClownInstantiation()
    {
        foreach (Transform clownPos in clownInstantiatePositions)
        {
            Instantiate(prefab, clownPos.position, Quaternion.identity);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        ropesOnScene = GameObject.FindGameObjectsWithTag("Rope");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
