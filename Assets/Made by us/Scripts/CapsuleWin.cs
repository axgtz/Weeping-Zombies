using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CapsuleWin : MonoBehaviour {
    public Text menuText;
    public Transform Camera;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(transform.position, Camera.position) <= 1)
        {
            menuText.text = "Congratulations, you can now swallow me.";

        }
    }
}
