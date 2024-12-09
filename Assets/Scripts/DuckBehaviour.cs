using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.AI;

public class DuckBehaviour : MonoBehaviour
{
    private MeshRenderer DuckRenderer;
    private Collider DuckCollider;

    //[Header("Patrol")]
    //[SerializeField] private GameObject patrolPointsContainer;
    //private List<Transform> patrolPoints = new List<Transform>();
    //private int destinationPoint = 0; //internal index to next destination
    //private NavMeshAgent agent;

    private void Start()
    {
        //agent = GetComponent<NavMeshAgent>();

        ////Take all the children of patrolPointContainer and add them in the patrolPoints array
        //foreach (Transform child in patrolPointsContainer.transform)
        //    patrolPoints.Add(child);

        ////randomly chose first destiantionPoint
        //destinationPoint = Random.Range(0, patrolPoints.Count);

        ////First time go to Next Patrol
        //GotoNextPatrolPoint();

        DuckRenderer = GetComponent<MeshRenderer>();
        DuckCollider = GetComponent<Collider>();
    }

    ///// <summary>
    ///// Enemy Go to next destinationPoint
    ///// </summary>
    //private void GotoNextPatrolPoint()
    //{
    //    if (agent.remainingDistance <= 0.01f)
    //    {
    //        //choose next destinationPoint in the List
    //        //cycling to the start if necessary
    //        destinationPoint = (destinationPoint + 1) % patrolPoints.Count;
    //    }

    //    //Restart the stopping distance to 0 to posibility the Patrol
    //    agent.stoppingDistance = 0f;

    //    //set the agent to the currently destination Point
    //    agent.SetDestination(patrolPoints[destinationPoint].position);

    //}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Magnet"))
        {
            DuckRenderer.enabled = false;
            DuckCollider.enabled = false;
            collision.gameObject.transform.parent.GetChild(12).gameObject.GetComponent<Collider>().enabled = true;
            collision.gameObject.transform.parent.GetChild(12).gameObject.GetComponent<MeshRenderer>().enabled = true;
        }
    }

}
