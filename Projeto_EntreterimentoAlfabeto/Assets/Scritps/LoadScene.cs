using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
    // Cenas

public class LoadScene : MonoBehaviour
{
   public void CarregarCena(string nomeCena){
       SceneManager.LoadScene(nomeCena);
   } 

   
}
