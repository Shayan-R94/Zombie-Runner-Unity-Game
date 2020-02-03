using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

    private bool called = false;
    private Rigidbody rigidbody;

    // Use this for initialization
    void Start () {
        rigidbody = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void Update () {

    }

    void OnDispatchHelicopter()
    {
        // Play sound.
        rigidbody.velocity = new Vector3(0, 0, 50f);

        called = true;
    }
}
