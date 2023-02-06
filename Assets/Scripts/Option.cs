
//La clase tiene que ser serializable para poder editarla desde el Inspector
[System.Serializable]


//Aquí vamos a almacenar la opción por separado, no necesitamos el MonoBihaviour
public class Option
{
	//el texto de la opción que le vamos a dar al jugador
	public 	string	text	=	null;
	
	//bool es para ver si la opción es correcta o incorrecta
	public	bool	correct =	false; 
}
