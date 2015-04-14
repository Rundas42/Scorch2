#pragma strict

public static var levelCount: int;
private var num : int;

num = Random.Range(1,4);

function LoadFirstLevel() {
	Application.LoadLevel(Random.Range(num,Application.levelCount -1));
}
function ExitGame() {
	Application.Quit();
}