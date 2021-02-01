using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyScript : MonoBehaviour
{
    AudioSource audioSource;
    public AudioSource musicSource;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2);
        musicSource.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
