using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabinetDoorDrop : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        KinematicDisable();
    }

    void KinematicDisable()
    {
        rb.isKinematic = false;
    }
}
