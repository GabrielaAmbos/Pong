using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaController : MonoBehaviour
{
    public Rigidbody2D meuRigidbody2D;
    private Vector2 minhaVelocidade;
    public float velocidade = 5f;

    // Start is called before the first frame update
    void Start()
    {
        minhaVelocidade.x = -velocidade;
        meuRigidbody2D.velocity = minhaVelocidade;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
