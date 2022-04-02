using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comportamento : MonoBehaviour
{
  public float aceleracao = 3.0f;
  public float velocidadeMaxima = 180.0f;
  public Rigidbody2D jogadorRb;  
   
     void Start()
    {
        transform.position = new Vector3 (0.0f, 0.0f, 0.0f);
    }

    void FixedUpdate()
    {
        
    if (Input.GetKey(KeyCode.W))
    {
       
          Vector3 direcao = transform.up * aceleracao; // Vector3 direcao =  new Vector3 (0.0f, 1.0f * aceleracao, 0.0f);
          jogadorRb.AddForce(direcao, ForceMode2D.Force); //Adicionar Força na movimentação, efeito mais suvizado!
    }


    if (Input.GetKey(KeyCode.A))
 {     
    jogadorRb.rotation = jogadorRb.rotation + (180.0f * Time.deltaTime); //jogadorRb.rolation = jogadorRb.rolation +  (180.0f * Time.deltaTime);
 }
 if (Input.GetKey(KeyCode.D))
   {
           jogadorRb.rotation -= jogadorRb.rotation  * Time.deltaTime; //jogadorRb.rolation = jogadorRb.rolation +  (180.0f * Time.deltaTime);
   }
 if (jogadorRb.velocity.magnitude > 10.0f)
 {
     jogadorRb.velocity = Vector2.ClampMagnitude(jogadorRb.velocity, velocidadeMaxima); //Através do Rigidbody controlar a mmagnitude do objeto

 }
 }
}
   