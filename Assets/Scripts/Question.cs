using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Tiene que descender de MonoBehaviour porque lo queremos añadir en un gameObject
public class Question : MonoBehaviour
{
	//El string es el texto de la pregunta
	public	string			text		=	null;
	
	//lista para almacenar las opciones que le vamos a dar al jugador
	//La representación de nuestras preguntas
	public	List<Option>	options 	=	null;
}
/* Simplemente tenemos que crear un objeto que se llame Pregunta_1 y le añadimos este script Question
y lo guardamos como Prefab */