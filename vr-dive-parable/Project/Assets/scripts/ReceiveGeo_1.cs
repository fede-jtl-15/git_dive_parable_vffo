using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiveGeo_1 : MonoBehaviour
{
        public OSC osc;
        //public Material mat;
        public GameObject Geo_1;


    // Use this for initialization
    void Start () {
       /*osc.SetAddressHandler( "/CubeXYZ" , OnReceiveXYZ );
       osc.SetAddressHandler("/CubeX", OnReceiveX);
       osc.SetAddressHandler("/CubeY", OnReceiveY);
       osc.SetAddressHandler("/CubeZ", OnReceiveZ);*/
       //osc.SetAddressHandler("/noise_offset", OnReceiveOffset);
       osc.SetAddressHandler("/Geo_OnOff_1", OnReceiveGeoOnOff_1);
    }
    
    // Update is called once per frame
    void Update () {
    
    }

    /*void OnReceiveXYZ(OscMessage message){
        float x = message.GetFloat(0);
        float y = message.GetFloat(1);
        float z = message.GetFloat(2);

        transform.position = new Vector3(x,y,z);
    }

    void OnReceiveX(OscMessage message) {
        float x = message.GetFloat(0);

        Vector3 position = transform.position;

        position.x = x;

        transform.position = position;
    }

    void OnReceiveY(OscMessage message) {
        float y = message.GetFloat(0);

        Vector3 position = transform.position;

        position.y = y;

        transform.position = position;
    }

    void OnReceiveZ(OscMessage message) {
        float z = message.GetFloat(0);

        Vector3 position = transform.position;

        position.z = z;

        transform.position = position;
    }*/

    /*void OnReceiveOffset(OscMessage message) {
        float offset = message.GetFloat(0);

        mat.EnableKeyword("_noise_offset");

        mat.SetFloat("_noise_offset", offset);
    }*/

    void OnReceiveGeoOnOff_1(OscMessage message) {
        float G_OnOff_1 = message.GetFloat(0);
        if (G_OnOff_1 == 0)
                {
                    Geo_1.SetActive(false);
                }
                else  Geo_1.SetActive(true);
     }
        
 }

