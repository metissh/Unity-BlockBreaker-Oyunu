using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int blokSagligi;
    public AudioSource blokSesi;
    


    private void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag == "top")
        {
            blokSagligi--;
            blokSesi.Play();
        }
        if (blokSagligi == 0)
        {
            Destroy(this.gameObject);
            Kazandik.puanDegeri += 10;
            Kazandik.kirilanBlock += 1;
        }
    }
    void Update()
    {
        
    }
}
