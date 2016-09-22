using System;
using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour
{

    public AudioClip jamp;
    public GameObject player;

    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnTriggerEnter()
    {
        float p = 1.0f;
        player.SendMessage("check", p);
        GetComponent<AudioSource>().PlayOneShot(jamp);
        transform.position=new Vector3(1000f,1000f,1000f);
    }
}
