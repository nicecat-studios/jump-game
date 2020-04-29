using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Player
{
	private float moveInput;

	private SpriteRenderer spriteRenderer;
	public int maxCharge;
	//public RaycastHit2D hit;
	//public Ray ray;

	public float movementSpeed;
	public float jumpForce;

	private bool _isGrounded;
	public bool isGrounded { get { return _isGrounded; } set { _isGrounded = value; } }

	public Transform feetPos;
	public LayerMask whatIsGround;
	public Transform checkRadius;

	private double _charger;
	public double charger
	{
		get { return _charger; }
		set { _charger = value; }
	}

	public float chargeMultiplier;
	public bool isCharging;

	void Start()
	{
		isCharging = false;
		Player.movementSpeed = movementSpeed;
		Player.jumpForce = jumpForce;
		spriteRenderer = GetComponent<SpriteRenderer>();
	}

	void FixedUpdate()
	{
		Player.rbody.velocity += new Vector2(0, -0.75f);
		//ray.origin = feetPos.position;
		//ray.direction = Vector2.down;
		//RaycastHit2D hit = Physics2D.Raycast(origin: transform.position, direction: -Vector2.up, layerMask: whatIsGround, distance: 100);
	}

	void Update()
	{
		//isGrounded = hit.collider == null ? true : false;
		isGrounded = Physics2D.OverlapArea(feetPos.position, checkRadius.position, whatIsGround); //return true for overlap
		moveInput = Input.GetAxis("Horizontal");

		if (Input.GetKeyDown(KeyCode.Escape)) { Application.Quit(); } //temporary exit measure


		if(_isGrounded && Input.GetAxis("Horizontal") != -1 && Input.GetAxis("Horizontal") != 1) { Player.rbody.velocity = new Vector2(0, Player.rbody.velocity.y); }

		if (Input.GetAxis("Horizontal") > 0) { spriteRenderer.flipX = false; }
		if (Input.GetAxis("Horizontal") < 0) { spriteRenderer.flipX = true; }

		if (!isCharging && _isGrounded)
		{
			rbody.velocity = new Vector2(moveInput * movementSpeed, rbody.velocity.y);
		}

		if (_isGrounded && Input.GetButton("Jump") && _charger < maxCharge)
		{
			if (_charger > maxCharge) { _charger = maxCharge; }
			else { _charger += Time.deltaTime * chargeMultiplier; }
			rbody.velocity = new Vector2(0, rbody.velocity.y);
			isCharging = true;
		}

		if (isCharging && !Input.GetButton("Jump"))
		{
			Jump(moveInput, (float)System.Math.Round(_charger, 1));
		}
	}

	void Jump(float direction, float jumpCharge)
	{
		Debug.Log(jumpCharge);
		Player.rbody.velocity = new Vector2((8 - (float)charger) * direction, jumpForce * jumpCharge);
		_charger = 0f;
		isCharging = false;
	}

	void OnCollisionEnter(Collision collision)
    {
		if (!_isGrounded && collision.gameObject.layer == LayerMask.NameToLayer("Wall"))
        {
			rbody.velocity = new Vector2(rbody.velocity.x * -1, rbody.velocity.y);
        }
    }

}