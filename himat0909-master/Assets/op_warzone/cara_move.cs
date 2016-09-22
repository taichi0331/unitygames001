using UnityEngine;
using System.Collections;

public class cara_move : MonoBehaviour {

    public float x, y, z;
    private float x1, y1, z1;
    private int i;
    private float j;



    // Use this for initialization
	void Start () {
        i = Random.Range(0, 100);
	}
	




	// Update is called once per frame
	void Update () {


        j = Random.Range(0, 100);

        if(j<5)
            transform.Rotate(new Vector3(0, j*2, 0f));
        if(95<j)
            transform.Rotate(new Vector3(0, (j-100f)*2, 0f));

        if (transform.position.x > 49 || transform.position.x < -49 || transform.position.z > 49 || transform.position.z<-49){
            
            

            if (i<50)
                transform.Rotate(new Vector3(0, 2.5f, 0f));
            if(i>=50)
                transform.Rotate(new Vector3(0, -2.5f, 0f));
        
        }

        //transform.position += new Vector3(x, y, z);
        transform.Translate(x, 0, z);

	}


   
  
    
}
