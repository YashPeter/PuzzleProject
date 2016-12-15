using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player{
	float posx;
	float posy;
	int direction;
	int frame;
	int framelimit;
	public Player(float posx, float posy, int framelimit){
		this.posx = posx;
		this.posy = posy;
		direction = 0;
		frame = 0;
		this.framelimit = frame;
	}
	public float getposx(){
		return posx;
	}

	public float getposy(){
		return posy;
	}

	public float getdirection(){
		return direction;
	}

	public float getframe(){
		return frame;
	}

	public void move(){
		switch (direction) {
		case 0:
			posy -= 1;
			updateframe ();
		break;	
		case 1:
			posx += 1;
			updateframe ();
			break;	
		case 2:
			posy += 1;
			updateframe ();
			break;	
		case 3:
			posx -= 1;
			updateframe ();
			break;	
		}
	}

	public void updateframe(){
		if (frame == framelimit) {
			frame = 0;
		} else {
			frame += 1;
		}
	}

	public void setdirection(int direction){
		this.direction = direction;
	}
}
