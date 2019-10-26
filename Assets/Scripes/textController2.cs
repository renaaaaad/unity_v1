using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textController2 : MonoBehaviour
{

    public Text uitext;
    public string[] subAudio2Text;

    private int index;
    public float typeingspeed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        subAudio2Text = new string[3];

        uitext.text = " ";

        subAudio2Text[0] = "In writing, the words point and purpose are almost synonymous.\n Your point is your purpose, and how you decide to make your point \n clear to your reader is also your purpose. Writers have a point and a purpose for every paragraph that they create";
        subAudio2Text[1] = " Writers write descriptive paragraphs because their purpose\n is to describe something. Their point \n is that something is beautiful or disgusting or strangely intriguing.";
        subAudio2Text[2] = "Writers write persuasive and argument paragraphs because their \n purpose is to persuade or convince someone. Their point is that their \n reader should see things a particular way and possibly take action on that new way of seeing things";

        StartCoroutine(Type());

    }

    public void Activite()

    {
        uitext.text = " ";
        //StartCoroutine(Type());

    }

    IEnumerator Type()
    {

       
        foreach (char letter in subAudio2Text[index].ToCharArray())
        {
            uitext.text += letter;
            yield return new WaitForSeconds(typeingspeed);

        }
        yield return new WaitForSeconds(5);

        nextsub();
    } //Type

    public void nextsub()
    {
        
        if (index < subAudio2Text.Length - 1)
        {

            index++;
            uitext.text = " ";
            StartCoroutine(Type());
        }
        else
            uitext.text = " ";
    } //nextsub


    // Update is called once per frame
    void Update()
    {
        
    }
}
