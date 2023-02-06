using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Script que controla la interfaz gráfica para las preguntas
public class QuizUI : MonoBehaviour
{
	//Vamos a necesitar un texto para poner la pregunta
	[SerializeField] private Text m_question = null;
	//necesitamos una referencia a los botones que hemos utilizado
	[SerializeField] private List<OptionButton> m_buttonList = null;
	
	/* /Método Construtc nos ayuda a construir el objeto
	enviamos la pregunta Question y enviamos un callback
	que es un método que pasamos a una función que tiene valor de regreso
	lo que coloquemos entre < aquí > que nos va a retornar*/
	public void Construtc(Question q , Action<OptionButton> callback)
	{
		m_question.text = q.text;
		
		for (int n = 0 ; n < m_buttonList.Count ; n++)
		{
			m_buttonList[n].Construtc(q.options[n] , callback);
		}
	}
	
}
