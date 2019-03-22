using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image_C3 : MonoBehaviour {

    public AudioSource Audiosource_1; //goodbye
    public AudioSource Audiosource_2; //hi
    public AudioSource Audiosource_3; //how are you
    public AudioSource Audiosource_4; //let's go
    public AudioSource Audiosource_5; //thank you
    public AudioSource Audiosource_6; //You're welcome

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Click()
    {
        Audiosource_1.Play();
        Debug.Log("get");
    }
}
