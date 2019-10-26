using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{ //singlton proporty

    public static TextController Instence { get; private set; }
    public Text uitext;
    public static string[] subAudio1;
    public int[] subAudio1Time;
    public string[] subAudio1Text;
    public string[] subAudio2Text;
    public string[] subTemp;


    private int index;
    public float typeingspeed;
    //public AudioClip audioClip;
    //public AudioSource audioSource;
    //private const float _RATE = 44100.0f;
    //public int objnmb = -1;

    //// Start is called before the first frame update
    void Start()
    {

        subAudio1 = new string[3];
        subAudio1Time = new int[3];
        subAudio1Text = new string[3];
        subAudio2Text = new string[3];

        subAudio1[0] = "1| Hi, This is a Directer of English" + "\n" + "I have something Exited to talk about today \n" + "i am now Doing, Audio Tweets";
        subAudio1[1] = "13| What is an Audio tweets? What is a strange word!\n Well What I am doing is I am doing small little broadcast on twitter \nand I am doing this almost everyday";
        subAudio1[2] = "29| because it is so easy I use my phone and I record a short talk about some topic \nmy daily life normal life and then I uplode it on twitter";

       
        for (int i = 0; i < subAudio1.Length; i++)
        {
            string[] splitTemp = subAudio1[i].Split('|');
            subAudio1Time[i] = Int32.Parse(splitTemp[0]);
            subAudio1Text[i] = splitTemp[1];
        }


        //audioSource.clip = audioClip;
        //audioSource.Play();
        StartCoroutine(Type());

    } //Start


    public void Activite()

    {
        uitext.text = " ";
        //StartCoroutine(Type());

    }
    IEnumerator Type()
    {


        foreach (char letter in subAudio1Text[index].ToCharArray())
        {
            uitext.text += letter;
            yield return new WaitForSeconds(typeingspeed);

        }
        yield return new WaitForSeconds(5);

        nextsub();
    } //Type

    public void nextsub()
    {
      

        if (index < subAudio1Text.Length - 1)
        {

            index++;
            uitext.text = " ";
            StartCoroutine(Type());
        }
        else
            uitext.text = " ";
    } //nextsub



    private void Update()
    {

    }//Update
} //class
