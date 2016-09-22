using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ballmoves : MonoBehaviour
{

    float i=1000;
    float jp=120;
    float cc = 0;
    float finish_f=0;
    

    public float checkpoint_max=7;
    public Text jt;
    public Image panel;
    public Image panel20;
    public Image panel40;
    public Image panel60;
    public Image panel80;
    public Image panel100;
    public AudioClip jamp;

    public Text clear;
    public Text noko;
    float nokorin = 7;

    float time = 5.0f;

    int pp;
    void start()
    {
        
    }
    

    void Update()
    {

        transform.GetComponent<Rigidbody>().AddForce(0f, -4.0f, 0f);
        noko.text = "のこリング: " + nokorin.ToString();

        if (checkpoint_max == cc)
        {

            finish_f = 1f;
            UnityEngine.SceneManagement.SceneManager.LoadScene("clear", LoadSceneMode.Single);


        }

        

        if (Input.GetKey(KeyCode.W))
        {
            if (GetComponent<Rigidbody>().velocity.x < -3.0f && (GetComponent<Rigidbody>().velocity.x + 0.1f) < 0f)
                GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x + 0.1f, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z);
            
            if (GetComponent<Rigidbody>().velocity.x<50f)
            transform.GetComponent<Rigidbody>().AddForce(7.0f, 0, 0f);
            
        }
        if (Input.GetKey(KeyCode.S)) {

            if (GetComponent<Rigidbody>().velocity.x > 3.0f && (GetComponent<Rigidbody>().velocity.x - 0.1f)>0f)
                GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x-0.1f, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z);
           
            if (GetComponent<Rigidbody>().velocity.x > -50f)
            transform.GetComponent<Rigidbody>().AddForce(-7.0f, 0, 0);
            
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (GetComponent<Rigidbody>().velocity.z > 3.0f && (GetComponent<Rigidbody>().velocity.z - 0.1f) > 0f)
                GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z - 0.1f);
            
            if (GetComponent<Rigidbody>().velocity.z > -50f)
            transform.GetComponent<Rigidbody>().AddForce(0f, 0, -7.0f);

        }
        if (Input.GetKey(KeyCode.A))
        {
            if (GetComponent<Rigidbody>().velocity.z < -3 && (GetComponent<Rigidbody>().velocity.z + 0.1f) < 0f)
                GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z + 0.1f);
            
            if (GetComponent<Rigidbody>().velocity.z < 50f)
            transform.GetComponent<Rigidbody>().AddForce(0f, 0, 7.0f);
        
        }


        if (Input.GetKeyDown(KeyCode.Return))
            GetComponent<Rigidbody>().velocity = new Vector3(0, GetComponent<Rigidbody>().velocity.y-10f, 0);

        if (transform.position.y < -10)
        {
            transform.position = new Vector3(30f, 0.5f, 250f);
            transform.Translate(0, 0, 0);
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        }


        if (Input.GetKey(KeyCode.Space) && jp>=120f)
        {
            transform.GetComponent<Rigidbody>().AddForce(0, 4000f, 0);
            GetComponent<AudioSource>().PlayOneShot(jamp);
            jp = 0;
            panel20.color = Color.red;
            panel40.color = Color.red;
            panel60.color = Color.red;
            panel80.color = Color.red;
            panel100.color = Color.red;
        }

        if (jp <= 120f)
        {
           jp=jp+ 20f * Time.deltaTime;
        }
      

        jt.text = "EMPTY";

        if(20 <= jp) panel20.color = Color.green;
        if (40 <= jp) panel40.color = Color.green;
        if (60 <= jp) panel60.color = Color.green;
        if (80 <= jp) panel80.color = Color.green;
        if (100 <= jp) panel100.color = Color.green;

        if (jp < 120f)
        {
           
            panel.color = Color.red;
        }
        else if (jp >= 120f)
        {
            jt.text = "FULLY CHARGED";
            panel.color = Color.green;
        }
    }


    void OnCollisionStay(Collision collision)
    {

        transform.GetComponent<Rigidbody>().AddForce(0f, 25.0f, 0f);

    }

    public void check(float c)
    {

        cc += c;
        nokorin--;
        
    }

   
}