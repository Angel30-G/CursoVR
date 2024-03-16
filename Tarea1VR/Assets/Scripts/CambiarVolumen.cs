using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class CambiarVolumen : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    // Start is called before the first frame update

    public void controlMusica(float sliderMusica){
      audioMixer.SetFloat("VolumenMusica", Mathf.Log10(sliderMusica) * 20);
    }

}
