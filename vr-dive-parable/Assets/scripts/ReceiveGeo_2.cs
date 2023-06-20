using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiveGeo_2 : MonoBehaviour
{
        public OSC osc;
        public GameObject Geo_2;


    // Use this for initialization
    void Start () {
       osc.SetAddressHandler("/Geo_OnOff_2", OnReceiveGeoOnOff_2);
    }
    
    // Update is called once per frame
    void Update () {
    
    }

    void OnReceiveGeoOnOff_2(OscMessage message) {
        float G_OnOff_2 = message.GetFloat(0);
        if (G_OnOff_2 == 0)
                {
                    Geo_2.SetActive(false);
                }
                else  Geo_2.SetActive(true);
     }
        
 }

