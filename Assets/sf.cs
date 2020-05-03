using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sf : MonoBehaviour
{
    AudioSource fmu;
    // Start is called before the first frame update
    void Start()
    {
        fmu.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        fmu.Play();
    }
}
