#pragma strict
internal var animator:Animator;
var v:float;
var h:float;
var run:float;

function Start () {
	animator=GetComponent (Animator);
}

function Update () {
	v=1;
	h=Input.GetAxis("Horizontal");
	if (animator.GetFloat("Run")==0.2){
		if (Input.GetKeyDown("space")){
			animator.SetBool("Jump",true);
		}
	}
	Sprinting();
	
}

function FixedUpdate (){
	animator.SetFloat("Walk",v);
	animator.SetFloat("Run",run);
	animator.SetFloat("Turn",h);
}

function Sprinting(){
    run=0.2;
}