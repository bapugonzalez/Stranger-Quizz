using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Para acceder a todos los componentes de interfaz gráfica
using UnityEngine.UI;

//Script para representar las opciones del juego
//El OptionButton son los botones que el jugado puede usar para seleccionar una respuesta u otra

/*Como vamos a requerir que este componente tenga un botón
colocamos [RequireComponent(typeof(Button))] obliga o fuerza
a al objeto que le colocamos esto tenga un componente Button
Cuando lo añadamos si no posee un componente button va a añadir un componente button*/

[RequireComponent(typeof(Button))]
[RequireComponent(typeof(Image))]
public class OptionButton : MonoBehaviour
{
	private Text m_text = null;
	private Button m_button = null;
	private Image m_image = null;
	private Color m_originalColor = Color.black;
	
	public Option Option { get; set;}
	
	
	private void Awake()
	{
		m_button = GetComponent<Button>();
		m_image = GetComponent<Image>();
		m_text = transform.GetChild(0).GetComponent<Text>();
		
		m_originalColor = m_image.color;
	}
	
	/*Método público para inicializaro
	Vamos a recibir la opción que queremos mostrar,
	si es correcta y nos va a mostrar el texto
	y vamos a recibir un callback de Option
	Esto es un método que vamos a llamar cuando el jugador selecciones la opción
	y notifica qué opción está seleccionando */
	public void Construtc(Option option , Action<OptionButton> callback)
	{
		m_text.text = option.text;
		
		m_button.onClick.RemoveAllListeners();
		
		m_button.enabled = true;
		//Nos aseguramos que la imagen tenga la imagen original
		m_image.color = m_originalColor;
		
		Option = option;
		
		m_button.onClick.AddListener(delegate
		{
			callback(this);
		});
	}
	
	public void SetColor(Color c)
	{
		m_button.enabled = false;
		m_image.color = c;
	}
}
