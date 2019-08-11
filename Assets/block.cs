using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour {
    public AudioClip sound1;
    AudioSource audioSource;
	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "CubeTag" || collision.gameObject.tag == "GroundTag")
        {
            Debug.Log("playSE");
            audioSource.PlayOneShot(sound1);
        }
    }
}
