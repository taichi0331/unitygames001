using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class p_velo : MonoBehaviour {

    public GameObject player;
    public Text tx,ty,tz;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        tx.text = "X="+player.GetComponent<Rigidbody>().velocity.x.ToString();
        ty.text = "Y=" + player.GetComponent<Rigidbody>().velocity.y.ToString();
        tz.text = "Z=" + player.GetComponent<Rigidbody>().velocity.z.ToString();
	
	}
}
