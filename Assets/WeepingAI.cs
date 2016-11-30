using UnityEngine;
using System.Collections;

public class WeepingAI : MonoBehaviour
{

    public Transform RigidBodyFPSController;
    MeshRenderer objectRenderer;
    Vector3 originalPos;
    public bool inTrigger = false;
    public float dotProduct;
    bool canHurt = false;

    // Use this for initialization
    void Start()
    {
        originalPos = transform.position;
        objectRenderer = GetComponentInChildren<MeshRenderer>();
    }


    void FixedUpdate()
    {
        if (!inTrigger)
        {
            transform.position = originalPos;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
        if (inTrigger)
        {
            if (CheckIfOffScreen())
            {
                //All move code here;
                transform.LookAt(new Vector3(RigidBodyFPSController.position.x, transform.position.y, RigidBodyFPSController.position.z));
                if (Vector3.Distance(RigidBodyFPSController.position, transform.position) > 5)
                {
                    transform.position = RigidBodyFPSController.position - RigidBodyFPSController.forward;
                }
            }
        }
    }


    //If hes in his quadrant
    IEnumerator OnTriggerStay(Collider col)
    {
        yield return new WaitForFixedUpdate();
        if (col.CompareTag("WeepingQuadrant"))
        {
            //Check if the player can see it
            inTrigger = true;

        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("WeepingQuadrant"))
            inTrigger = false;

    }

    bool CheckIfOffScreen()
    {
        Vector3 playerFwd = RigidBodyFPSController.forward;
        Vector3 targetDir = (RigidBodyFPSController.position - transform.position).normalized;
        dotProduct = Vector3.Dot(playerFwd, targetDir);
        if (dotProduct < -0.5)
        {
            return false;
        }
        else
        {
            return true;
        }

    }
}