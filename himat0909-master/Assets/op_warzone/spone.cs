using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class spone : MonoBehaviour
{
    public int number;
    public float x1,x2,y1,y2,z1,z2;
    public  GameObject cara;
    private int i=0;


    public int r = 150;
    public int b = 150;

    public Text bt;
    public Text rt;

    Quaternion q;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        birth();

    }

    void birth()
    {

        if (i < number)
        {


            //オブジェクトの座標
            float x = Random.Range(x1, x2);
            float y = Random.Range(y1, y2);
            float z = Random.Range(z1, z2);

            if (cara.tag == "red_s")
                q = new Quaternion(0f, 0f, 0f, 0f);

            if (cara.tag == "blue_s")
                q = new Quaternion(0f, 5f, 0f, 0f);


           // print("z");
            Vector3 pos = new Vector3(x, y, z) /*+ ground.position*/;
            GameObject.Instantiate(cara, pos, q);

            ////オブジェクトを生産
            //Instantiate(cara, new Vector3(x, y, z), Quaternion.identity);


            i++;

        }

       

    }



    void rd()
    {
        r--;

        rt.text = r.ToString();
    }


    void bd()
    {
        b--;

        bt.text = b.ToString();

    }

}
