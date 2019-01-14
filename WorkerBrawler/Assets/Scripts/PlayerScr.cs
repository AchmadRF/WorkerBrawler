using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScr : MonoBehaviour {

    public int player;
    public string attackBtn,dashBtn,jumpBtn;
    
    public Animator anim;
    SpriteRenderer thisSprite;
    Rigidbody2D PlayerRB;
    public Transform[] colplace = new Transform[2];
    public Collider2D atkCol;
    string axis;
    public bool walk = true;

	// Use this for initialization
	void Start () {
        thisSprite = gameObject.GetComponent<SpriteRenderer>();
        PlayerRB = gameObject.GetComponentInChildren<Rigidbody2D>();
        if (player == 1)
        {
            axis = "HorizontalP1";
            attackBtn = "joystick " + player +" button 1";
            jumpBtn = "joystick " + player + " button 0";
            dashBtn = "joystick " + player + " button 5";
        }
        if (player == 2)
        {
            axis = "HorizontalP2";
            attackBtn = "joystick " + player + " button 1";
            jumpBtn = "joystick " + player + " button 0";
            dashBtn = "joystick " + player + " button 5";
        }
        if (player == 3)
        {
            axis = "HorizontalP3";
            attackBtn = "joystick " + player + " button 1";
            jumpBtn = "joystick " + player + " button 0";
            dashBtn = "joystick " + player + " button 5";
        }
        if (player == 4)
        {
            axis = "HorizontalP4";
            attackBtn = "joystick " + player + " button 1";
            jumpBtn = "joystick " + player + " button 0";
            dashBtn = "joystick " + player + " button 5";
        }
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetAxis(axis) != 0 && walk == true)
        {
            anim.Play("Run");
        }
        else {
           // anim.Play("idle1");
        }
        if (Input.GetAxis(axis) > 0 && walk == true)
        {
            thisSprite.flipX = false;
            atkCol.transform.position = new Vector3(colplace[0].position.x, colplace[0].transform.position.y, 0);
            transform.Translate(new Vector3(4*Time.deltaTime, 0, 0));
        }
        if (Input.GetAxis(axis) < 0 && walk == true)
        {
            thisSprite.flipX = true;
            atkCol.transform.position = new Vector3(colplace[1].position.x,colplace[1].transform.position.y,0);
            transform.Translate(new Vector3(-4 * Time.deltaTime, 0, 0));

        }
        if (Input.GetKeyDown(attackBtn))
        {
            anim.Play("Attack");
        }
        if (Input.GetKeyDown(dashBtn))
        {
            anim.Play("Dash");
        }
        if (Input.GetKeyDown(jumpBtn))
        {
            anim.Play("Jump");
        }

    }
}
