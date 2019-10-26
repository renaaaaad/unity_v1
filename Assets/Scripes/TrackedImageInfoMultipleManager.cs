using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class TrackedImageInfoMultipleManager : MonoBehaviour
{
    public GameObject game;
    public GameObject game2;
    public AudioClip audio1, audio2;
    public AudioSource audioSource;
    public GameObject subMange;
    private ARTrackedImageManager m_TrackedImageManager;
    private TextController textController1;
    private textController2 textController2;

    public GameObject text1;
    public GameObject text2;

    public Image image;

    // Start is called before the first frame update

    void Awake()
    {

        m_TrackedImageManager = GetComponent<ARTrackedImageManager>();
        textController1 = FindObjectOfType<TextController>();
        textController2 = FindObjectOfType<textController2>();
        text1 = GameObject.Find("subtitleManager");
        text2 = GameObject.Find("subtitle2");

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
        image.enabled = false;
        //text1.SetActive(false);
        //text2.SetActive(false);
    }



    void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        image.enabled = true;


        foreach (ARTrackedImage trackedImage in eventArgs.added)
        {
            if ("renad".Equals(trackedImage.referenceImage.name))
            {
                game.SetActive(true);
                game2.SetActive(false);
                audioSource.Pause();
                audioSource.clip = audio1;
                audioSource.Play();
                //text1.GetComponent<TextController>().enabled = true;

            }

            if ("mada".Equals(trackedImage.referenceImage.name))
            {
                game.SetActive(false);
                game2.SetActive(true);
                audioSource.Pause();
                audioSource.clip = audio2; 
                audioSource.Play();
        //          text1.SetActive(false);
        //text2.SetActive(false);
            }


        }


    }


    // Update is called once per frame
    void Update()
    {

    }
}
