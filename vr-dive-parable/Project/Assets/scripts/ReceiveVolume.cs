using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

public class ReceiveVolume : MonoBehaviour
{
        public OSC osc;

        public Volume volume;
        private Bloom _bloom;
        private Vignette _vignette;
        private FilmGrain _grain;
        private ChromaticAberration _chromaticAberration;
        private Exposure _exposure;
        //public Volume _glitch;
        


 
    // Use this for initialization
    void Start () {

       osc.SetAddressHandler("/gotas_bloom", OnReceiveBloom);
       osc.SetAddressHandler("/vignette_intensity", OnReceiveVignette);
       osc.SetAddressHandler("/gotas_grain", OnReceiveGrain);
       osc.SetAddressHandler("/gotas_chrom_aberration", OnReceiveChAberration);
       osc.SetAddressHandler("/gotas_exposure", OnReceiveExposure);
       //osc.SetAddressHandler("/gotas_g_jitter", OnReceiveJitter);
       volume = GetComponent<Volume>();
       volume.profile.TryGet (out _bloom);
       volume.profile.TryGet (out _vignette);
       volume.profile.TryGet (out _grain);
       volume.profile.TryGet (out _chromaticAberration);
       volume.profile.TryGet (out _exposure);
       //_glitch = GetComponent<Volume>();
    }
    
    // Update is called once per frame
    void Update () {
    
    }


    void OnReceiveBloom(OscMessage message) {
        float gotas_bloom = message.GetFloat(0);
        _bloom.intensity.value = gotas_bloom;
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

        //intensity.m_Value
        _grain.intensity.value = _g_inensity;
        //v.EnableKeyword("_bloom_intensity");
        //v.SetFloat("_bloom_intensity", _b_inensity);
    }

    void OnReceiveChAberration(OscMessage message) {
        float _chrA_inensity = message.GetFloat(0);

        //intensity.m_Value
        _chromaticAberration.intensity.value = _chrA_inensity;
        //v.EnableKeyword("_bloom_intensity");
        //v.SetFloat("_bloom_intensity", _b_inensity);
    }

    void OnReceiveExposure(OscMessage message) {
        float _exp_compensation = message.GetFloat(0);

        //intensity.m_Value
        _exposure.fixedExposure.value = _exp_compensation;
        //v.EnableKeyword("_bloom_intensity");
        //v.SetFloat("_bloom_intensity", _b_inensity);
    }

    /*void OnReceiveJitter(OscMessage message) {
        float _jitter = message.GetFloat(0);

        //intensity.m_Value
        _glitch.jitter.value = _jitter;
        //v.EnableKeyword("_bloom_intensity");
        //v.SetFloat("_bloom_intensity", _b_inensity);
    }*/
}
