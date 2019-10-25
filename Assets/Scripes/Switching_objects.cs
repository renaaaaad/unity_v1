using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switching_objects : MonoBehaviour
{
    //****************************************************** varibles ************************************************************

    [SerializeField]
    float _timeBetweenSpawns = 5f;

    float currentTimer = 0f;

    bool _ok;

    public GameObject avatar1, avatar2;

    int whichAvatarIsOn = 1;

    //****************************************************** functions ************************************************************
    void Start()
    {
        _ok = true;
        avatar1.gameObject.SetActive(true);
        avatar2.gameObject.SetActive(false);

    }//Start

    // Update is called once per frame
    void Update()
    {

        if (_ok)
        {
            currentTimer += Time.deltaTime;

            if (currentTimer >= _timeBetweenSpawns)
            {
                currentTimer = 0;

                switch (whichAvatarIsOn)
                {

                    // if the first avatar is on
                    case 1:

                        // then the second avatar is on now
                        whichAvatarIsOn = 2;

                        // disable the first one and anable the second one
                        avatar1.gameObject.SetActive(false);
                        avatar2.gameObject.SetActive(true);
                        break;

                    // if the second avatar is on
                    case 2:

                        // then the first avatar is on now
                        whichAvatarIsOn = 1;

                        // disable the second one and anable the first one
                        avatar1.gameObject.SetActive(true);
                        avatar2.gameObject.SetActive(false);
                        break;

                } //switch



            } //currentTimer >= _timeBetweenSpawns
        } //_ok

    }//Update
}
