using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mavi_block : MonoBehaviour
{
    public int blokSagligi;
    MeshRenderer ressam;
    public Material maviKirik;
    public AudioSource blokSesi;
    private void Start()
    {
        ressam = GetComponent<MeshRenderer>();
    }
    private void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag == "top")
        {
            blokSagligi--;
            Kazandik.puanDegeri += 10;
            blokSesi.Play();
        }
        if (blokSagligi == 0)
        {
            Destroy(this.gameObject);
            Kazandik.puanDegeri += 20;
        }
        if(blokSagligi == 1)
        {
            ressam.material = maviKirik;
            Kazandik.kirilanBlock += 1;
        }
    }
    void Update()
    {

    }
}
