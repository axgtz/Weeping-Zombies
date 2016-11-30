using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Chase : MonoBehaviour
{
    public Transform Camera;
    public float MoveSpeed = 0.1f;
    public float MaxDist = 10;
    public float MinDist = 5;
    public Text menuText;
    void Start()
    {
        //wayPoint = GameObject.Find("wayPoint");

    }

    // Update is called once per frame
    void FixedUpdate()

    {
        /*
        wayPointPos = new Vector3(wayPoint.transform.position.x, transform.position.y, wayPoint.transform.position.z);
        //Here, the zombie's will follow the waypoint.
        transform.position = Vector3.MoveTowards(transform.position, wayPointPos, speed * Time.deltaTime);
        */


        transform.LookAt(Camera);
        //transform.position = new Vector3(RigidBodyFPSController.position.x, transform.position.y - 0.5f, transform.position.z);
        if (Vector3.Distance(transform.position, Camera.position) <= MinDist)
        {
            menuText.text = "You're dead.";

        }
        if (Vector3.Distance(transform.position, Camera.position) >= MinDist){

           transform.position += transform.forward * MoveSpeed * Time.deltaTime;





            if (Vector3.Distance(transform.position,Camera.position) <= MaxDist){
                //Here Call any function U want Like Shoot at here or something
            }

        }
    
    }
    
}
