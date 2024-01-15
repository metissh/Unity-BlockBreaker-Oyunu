using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class topEtkilesimi : MonoBehaviour
{
    public Rigidbody2D top;
    public float yatayHiz, dikeyHiz;
    public GameObject topObjesi, playerObjesi, yaziObjesi;
    public TextMeshProUGUI puanYazisi, kazandikYazisi;


    void Start()
    {
        top.velocity=new Vector2(Random.Range(-yatayHiz,yatayHiz),top.velocity.y);    
    }
    private void OnCollisionEnter2D(Collision2D carpma)
    {
        if (carpma.gameObject.tag == "Player")
        {
            top.velocity = new Vector2(top.velocity.x,dikeyHiz);
        }
        
        if(carpma.gameObject.tag == "slduvar")
        {
            top.velocity= new Vector2(yatayHiz,top.velocity.y);
        }
        if (carpma.gameObject.tag == "sgduvar")
        {
            top.velocity = new Vector2(-yatayHiz, top.velocity.y);
        }
        if (carpma.gameObject.tag == "ustduvar")
        {
            top.velocity = new Vector2(top.velocity.x, -dikeyHiz);
        }
        if (carpma.gameObject.tag == "bitis")
        {
            kazandikYazisi.text = "Kaybettiniz \nPuan�n�z:"+ Kazandik.puanDegeri+ "\nK�rd���n�z Block: " + Kazandik.kirilanBlock + "\n\nTekrar Oynamak ��in Bir Tu�a Bas�n�z!! ";
            Time.timeScale = 0;
            Destroy(yaziObjesi.gameObject);
            Destroy(playerObjesi.gameObject);
            
            

        }
    }




}
