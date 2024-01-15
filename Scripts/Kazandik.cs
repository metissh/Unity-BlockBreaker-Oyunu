using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Kazandik : MonoBehaviour
{
    public GameObject yaziObjesi, playerObjesi, topObjesi;
    public TextMeshProUGUI kazandikYazisi;
    public Transform Blocklar;
    int blockSayisi;
    public static int puanDegeri;
    public TextMeshProUGUI puanYazisi;
    public static int kirilanBlock;

    private void Start()
    {
        puanDegeri = 0;
        kirilanBlock = 0;
    }

    private void Update()
    {
        if (Time.timeScale == 0)
        {
            if (Input.anyKeyDown)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Time.timeScale = 1;
            }
            
        }

        puanYazisi.text = "Puan: " + puanDegeri;
        blockSayisi = Blocklar.childCount;

        if(blockSayisi == 0)
        {
            kazandikYazisi.text = "Tebrikler Kazandýnýz \nPuanýnýz:" +puanDegeri+ "\nKýrdýðýnýz Block: "+ kirilanBlock+ "\n\nTekrar Oynamak Ýçin Bir Tuþa Basýnýz!! ";
            Time.timeScale = 0;
            Destroy(yaziObjesi.gameObject);
            Destroy(playerObjesi.gameObject);
            Destroy(topObjesi.gameObject);
            if (Input.anyKeyDown)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Time.timeScale = 1;
            }
        }

    }


}
