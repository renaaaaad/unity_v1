using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class TrackedImageInfoMultipleManager : MonoBehaviour
{
    public GameObject game;
    public GameObject game2;

    private ARTrackedImageManager m_TrackedImageManager;

    // Start is called before the first frame update

    void Awake()
    {
        
        m_TrackedImageManager = GetComponent<ARTrackedImageManager>();

    }

    void OnEnable()
    {
        m_TrackedImageManager.trackedImagesChanged += OnTrackedImagesChanged;
    }

    void OnDisable()
    {
        m_TrackedImageManager.trackedImagesChanged -= OnTrackedImagesChanged;
    }
    void Start()
    {
        game.SetActive(false);
        game2.SetActive(false);
    }



    void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (ARTrackedImage trackedImage in eventArgs.added)
        {
            if("renad".Equals(trackedImage.referenceImage.name))
            {
                game.SetActive(true);
                game2.SetActive(false);
            }
            
            if ("mada".Equals(trackedImage.referenceImage.name))
            {
                game.SetActive(false);
                game2.SetActive(true);
            }

        }

       
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
