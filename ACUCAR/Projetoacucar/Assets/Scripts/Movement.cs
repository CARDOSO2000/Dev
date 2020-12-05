using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController2D controller2D;
    // Start is called before the first frame update
    float ParaOLado = 0f;
    float velo = 40f;
    bool pular = false;
    bool crouch = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ParaOLado = Input.GetAxisRaw("Horizontal") * velo ;
        if (Input.GetButtonDown("Jump"))
        {
            pular = true;
        }
        if(Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
        
    }
    private void FixedUpdate()
    {

        controller2D.Move(ParaOLado * Time.fixedDeltaTime, crouch, pular);
        pular = false;
    }
}
