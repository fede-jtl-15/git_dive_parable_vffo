using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class ReceiveVolume : MonoBehaviour
{
        public OSC osc;

        public Volume v;
        private Bloom _bloom;
        private Vignette _vignette;
        private FilmGrain _grain;


 
    // Use this for initialization
    void Start () {

       osc.SetAddressHandler("/bloom_intensity", OnReceiveBloom);
       osc.SetAddressHandler("/vignette_intensity", OnReceiveVignette);
       osc.SetAddressHandler("/grain_intensity", OnReceiveGrain);
       v = GetComponent<Volume>();
       v.profile.TryGet (out _bloom);
       v.profile.TryGet (out _vignette);
       v.profile.TryGet (out _grain);

    }
    
    // Update is called once per frame
    void Update () {
    
    }


    void OnReceiveBloom(OscMessage message) {
        float _b_inensity = message.GetFloat(0);

        _bloom.intensity.value = _b_inensity;
        //v.EnableKeyword("_bloom_intensity");
        //v.SetFloat("_bloom_intensity", _b_inensity);
    }

    void OnReceiveVignette(OscMessage message) {
        float _v_inensity = message.GetFloat(0);

        _vignette.intensity.value = _v_inensity;
        //v.EnableKeyword("_bloom_intensity");
        //v.SetFloat("_bloom_intensity", _b_inensity);
    }

    void OnReceiveGrain(OscMessage message) {
        float _g_inensity = message.GetFloat(0);

        _grain.intensity.value = _g_inensity;
        //v.EnableKeyword("_bloom_intensity");
        //v.SetFloat("_bloom_intensity", _b_inensity);
    }
}
