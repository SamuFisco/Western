using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer : MonoBehaviour
{
    public float movimientoEjeX;
    public float movimientoEjeZ;

    public float velocidadMovimiento = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimientoEjeX = Input.GetAxis("Vertical") * Time.deltaTime * velocidadMovimiento;
        movimientoEjeZ = Input.GetAxis("Vertical") * Time.deltaTime * velocidadMovimiento;
        transform.Translate( movimientoEjeX, movimientoEjeZ,0f);
    }
}
