using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

public class Image_Recognition : MonoBehaviour
{
    private ARTrackedImageManager aRTrackedImageManager;

    public GameObject avatar1, avatar2;

    int whichAvatarIsOn = 1;

    //----------------------------------------------- image recongnition -----------------------------------------------------


    private void Awake()
    {
        aRTrackedImageManager = FindObjectOfType<ARTrackedImageManager>();
    }//Awake



    private void OnEnable()
    {
        
         aRTrackedImageManager.trackedImagesChanged += changeImage; 
    }//OnEnable


    private void OnDisable()
    {
        aRTrackedImageManager.trackedImagesChanged -= changeImage;

    }//OnDisable


    private void changeImage(ARTrackedImagesChangedEventArgs arImage)
    {
        print("renad"); 
        foreach(var trackedImage in arImage.added)
        {
            if (trackedImage.name.Equals("renad"))
            {
                whichAvatarIsOn = 1;

                // disable the first one and anable the second one
                avatar1.gameObject.SetActive(false);
                avatar2.gameObject.SetActive(true);
                return;
            } // if image is R 

            if (trackedImage.name.Equals("k"))
            {
                whichAvatarIsOn = 2;

                // disable the first one and anable the second one
                avatar1.gameObject.SetActive(true);
                avatar2.gameObject.SetActive(false);
                return;
            } // if image is R 
        } //foreach

    }//changeImage
    //-----------------------------------------------  End image recongnition -----------------------------------------------------


    void Start()
    {
      

        avatar1.gameObject.SetActive(false);
        avatar2.gameObject.SetActive(false);

    }//Start

    void Update()
    {

    }//Update
} //class
