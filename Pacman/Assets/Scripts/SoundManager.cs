using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // Start is called before the first frame update

    public static AudioClip comer,comerGrande, fondo;
    static AudioSource audioSrc;

    void Start()
    {
        comer = Resources.Load<AudioClip>("munch_1");
        fondo = Resources.Load<AudioClip>("siren_1");
        comerGrande = Resources.Load<AudioClip>("munch_2");
        audioSrc = GetComponent<AudioSource>();
        audioSrc.Play();
    }


    public static void playSound(string clip)
    {

        if(clip == "coin") {
            audioSrc.PlayOneShot(comer);
        } else if(clip == "bigCoin"){
            audioSrc.PlayOneShot(comerGrande);
        } else if(clip == "stop") {
            audioSrc.Stop();
        }
        
         
    }
}
