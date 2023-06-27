using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveButton : MonoBehaviour
{
    public float horizontal;
    public float speed = 8f;
    public float jumpingPower = 16f;
    private bool isFacingRight = true;
    public bool isJumping;
    public float jumpTimeCounter;
    public float jumpTime;

    private bool canDash = true;
    private bool isDashing;
    public float dashingPower = 24f;
    public float dashingTime = 0.2f;
    public float dashingCooldown = 1f;
    public float checkRadius = 0.2f;
    private bool isGrounded;



    [SerializeField] public Rigidbody2D rb;
    [SerializeField] public Transform groundCheck;
    [SerializeField] public LayerMask groundLayer;
    [SerializeField] public TrailRenderer tr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
