using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TocarSom : MonoBehaviour
{
    public AudioSource somA;
    
    void TocarA(){
        somA.Play();
    }
    
    void TocarB(){
        somA.Pause();
    }
}
