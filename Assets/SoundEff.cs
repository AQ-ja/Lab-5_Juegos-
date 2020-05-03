using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEff : MonoBehaviour
{
    AudioSource loadm;
    // Start is called before the first frame update
    void Start()
    {
        loadm.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        loadm.Play();
    }
}
