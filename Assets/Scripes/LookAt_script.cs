using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt_script : MonoBehaviour
{
    //****************************************************** varibles ************************************************************



    public Transform target1;

    public Transform target2;



    //****************************************************** functions ************************************************************

    // Start is called before the first frame update
    void Start()
    {

    }//Start

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target1);
        transform.LookAt(target1, Vector3.left);

        transform.LookAt(target2);
        transform.LookAt(target2, Vector3.left);
    }//Update
}
