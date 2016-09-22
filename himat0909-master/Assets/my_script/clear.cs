using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class clear : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.R))
            UnityEngine.SceneManagement.SceneManager.LoadScene("tutorial_zone", LoadSceneMode.Single);
        if (Input.GetKey(KeyCode.T))
            UnityEngine.SceneManagement.SceneManager.LoadScene("start", LoadSceneMode.Single);


    }
}
