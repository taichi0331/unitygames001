
using UnityEngine.UI;

using UnityEngine;
using System.Collections;

public class btukari : MonoBehaviour
{


    private float i = 255f, j, s, k = 255f,r=255f;

    public GameObject field;

    void start()
    {


        //field = GameObject.Find("fiels");

    }

    void OnCollisionEnter(Collision col)
    {

        j = Random.Range(0f, 99f);

        if (col.gameObject.tag != gameObject.tag && col.gameObject.tag != "stage")
        {




            if (k < j)
            {
                Destroy(gameObject);
            }

            k = k - 3f;
            r = r - 5f;


        }


    }

    void OnCollisionStay(Collision col)
    {

        j = Random.Range(0f, 200f);

        if (col.gameObject.tag != gameObject.tag && col.gameObject.tag != "stage")
        {
            


            if (k < j)
            {


                if ("red_s" == gameObject.tag)
                {
                    
                    field.SendMessage("rd", 1f);
                    

                }
                if ("blue_s" == gameObject.tag)
                {
                    field.SendMessage("bd", 1f);

                }

                //transform.position = new Vector3(10000f, 10000f, 10000f);
                Destroy(gameObject);
            }



            k = k - 3f;

            r = r - 5f;



        }




    }


    void Update()
    {



      

        if (transform.position.y < -10)
        {


            if ("red_s" == gameObject.tag)
            {
                field.SendMessage("rd", 1f);

            }
            if ("blue_s" == gameObject.tag)
            {
                field.SendMessage("bd", 1f);

            }

           // transform.position = new Vector3(1000f, 1000f, 1000f);


            Destroy(gameObject);
        }


    }


}