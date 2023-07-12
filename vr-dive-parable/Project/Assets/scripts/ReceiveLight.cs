using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiveLight : MonoBehaviour
{
        public OSC osc;
        //public Material mat;
        public GameObject Geo_1;


    // Use this for initialization
    void Start () {
       osc.SetAddressHandler("/light", OnReceiveLight);
    }
    
    // Update is called once per frame
    void Update () {
    
    }


    void OnReceiveLight(OscMessage message) {
        float Light_OnOff = message.GetFloat(0);
        if (Light_OnOff == 0)
                {
                    Geo_1.SetActive(false);
                }
                else  Geo_1.SetActive(true);
     }
        
 }

