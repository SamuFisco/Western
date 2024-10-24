using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class InicioPartida : MonoBehaviour
{
    // Start is called before the first frame update
    public float time = 60f;
    public float inicioPartida = 5f;
    public float value = 60f;
    
    
    //public GameObject[] cubes = new GameObject[10];
    //public float timer, interval = 5f;
    //public values;
    //public float waitTime = 0f;



    public void TextMeshProUGUI()
    {
       
    }
    void Start()
    {
       
    }
    

    // Update is called once per frame
    void Update()
    {

        // Input.GetAxis("time");
        time -= Time.deltaTime;
        Time.time.ToString();
        Debug.Log("time");

    }


}
