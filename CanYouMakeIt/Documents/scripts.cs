//tekee p muuttujaan 2d positionin x.y
Vector2 p = new Vector2 (0,0);
Debug.Log (p);


//antaa kolmelle este1 gameobjectille eri paikan = 0, 2, 4
public GameObject este1;

for (int i=0;i<3;i++) {
	GameObject myRoadInstance = Instantiate(este1,	new Vector2(0.7f, i*2), Quaternion.identity) as GameObject;
}


//Gameobjectien luonti tapahtuu randomisti ja objectien haku tapahtuu tiedostoista polusta: Resources/Prefabs/...
for (int i=0;i<50;i++) {
	int r = Random.Range (1, 7);
	GameObject obj = GameObject.Find ("Assets/Resources/Prefabs/este0");

	esterata2 = (Instantiate(Resources.Load("Prefabs/Este"+r),	new Vector2(0.7f, i*4), Quaternion.identity) as GameObject).transform.parent = esteet.transform;
}