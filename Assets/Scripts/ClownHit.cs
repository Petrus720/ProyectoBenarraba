using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClownHit : MonoBehaviour
{
    public Animator clownAnimator;
    public CanvaController canvaController; 

    private void Start()
    {
        clownAnimator = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("colitis");
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("labala");
            clownAnimator.Play("ClownAnimHit");
            Destroy(gameObject,1f);
        }
    }
}
