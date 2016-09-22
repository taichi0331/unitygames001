using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Return))
            UnityEngine.SceneManagement.SceneManager.LoadScene("tutorial_zone", LoadSceneMode.Single);
    }
}
