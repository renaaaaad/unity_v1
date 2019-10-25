using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;


public class TrackedImageInfoRuntimeManager : MonoBehaviour
{

    public GameObject avatar1, avatar2;

    [SerializeField]
   public  XRReferenceImageLibrary xrReferenceImageLibrary;

    private ARTrackedImageManager trackImageManager;
    


    // Start is called before the first frame update
    void Start()
    {

        avatar1.gameObject.SetActive(false);
        avatar2.gameObject.SetActive(false);
        trackImageManager = gameObject.AddComponent<ARTrackedImageManager>();
        trackImageManager.referenceLibrary = xrReferenceImageLibrary;
        
     trackImageManager.maxNumberOfMovingImages = 3;
       

        trackImageManager.enabled = true;

        trackImageManager.trackedImagesChanged += OnTrackedImagesChanged;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (ARTrackedImage trackedImage in eventArgs.added)
        {
            if (trackedImage.referenceImage.name.Equals("renad"))
            {
                

                // disable the first one and anable the second one
                avatar1.gameObject.SetActive(false);
                avatar2.gameObject.SetActive(true);
                return;
            } // if image is R 

            if (trackedImage.referenceImage.name.Equals("k"))
            {
                

                // disable the first one and anable the second one
                avatar1.gameObject.SetActive(true);
                avatar2.gameObject.SetActive(false);
                return;
            } // if image is R 
        }


    } //OnTrackedImagesChanged

}
