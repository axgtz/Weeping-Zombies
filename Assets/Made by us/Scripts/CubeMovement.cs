using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]


public class CubeMovement : MonoBehaviour {
    public float moveSpeed = 5f;
    public float turnSmoothing;
    public Transform theParent;
    public Transform theChild;
    public Vector3 NewPos;
    // Use this for initialization
    void Start() {
        moveSpeed = 5f;
        turnSmoothing = 15f;
        theParent.rotation = theChild.rotation;
        theChild.rotation = Quaternion.identity;

    }

    // Update is called once per frame
    void FixedUpdate() {
        /* float moveHorizontal = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
         float moveVertical = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
         */
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * moveSpeed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * Time.deltaTime * moveSpeed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime * moveSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime * moveSpeed;
        }

    }


}






    /*
     float moveHorizontal = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
     float moveVertical = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
     transform.Translate(moveHorizontal, 0f, moveVertical);
     */


