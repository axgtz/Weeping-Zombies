using UnityEngine;
using System.Collections;

public class Chase2 : MonoBehaviour
{
    public Transform Camera;
    public float MoveSpeed = 0.1f;
    public float MaxDist = 10;
    public float MinDist = 5;
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()

    {

        transform.Translate(0, 0.4f, 0);
        

        transform.LookAt(Camera);
        //transform.position = new Vector3(RigidBodyFPSController.position.x, transform.position.y - 0.5f, transform.position.z);

        if (Vector3.Distance(transform.position, Camera.position) >= MinDist){

           transform.position += transform.forward * MoveSpeed * Time.deltaTime;
            




            if (Vector3.Distance(transform.position,Camera.position) <= MaxDist){
                //Here Call any function U want Like Shoot at here or something
            }

        }
    }
    
}
