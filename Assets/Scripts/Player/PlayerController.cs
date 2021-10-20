using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int PlayerLives = 100;
    public string PlayerName = "Pedrito";
    public float PlayerSpeed = 100.0f;
    public float x,y,z;

    void Start()
    {
        transform.localScale = new Vector3(x, y, z);


    }
    void Update()
    {
        Movimiento();
    }
    public void Movimiento()
    {
        Debug.Log("posicion en cada frame");
        transform.position += new Vector3(PlayerSpeed * Time.deltaTime, 0, 0);

    }
    public void Heal(int VidaASumar)
    {
        Debug.Log("Suma Vida");
        PlayerLives += VidaASumar;
    }
    public void Damage(int VidaARestar)
    {
        Debug.Log("Resta Vida");
        PlayerLives -= VidaARestar;
    }
}
