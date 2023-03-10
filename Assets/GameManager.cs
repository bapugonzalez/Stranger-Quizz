using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
//dicta el control del juego, las preguntas, cuando se acaba
public class GameManager : MonoBehaviour
{
	[SerializeField] private AudioClip m_correctSound = null;
	[SerializeField] private AudioClip m_incorrectSound = null;
	[SerializeField] private Color m_correctColor = Color.black;
	[SerializeField] private Color m_incorrectColor = Color.black;
	[SerializeField] private float m_waitTime = 0.0f ;
	
	private PreguntaDB m_quizDB = null;
	private QuizUI m_quizUI = null;
	private AudioSource m_audioSource = null;
	
	private void Start()
	{
		m_quizDB = GameObject.FindObjectOfType<PreguntaDB>();
		m_quizUI = GameObject.FindObjectOfType<QuizUI>();
		m_audioSource = GetComponent<AudioSource>();
		
		NexQuestion();
	}
	
	private void NexQuestion()
	{
		m_quizUI.Construtc(m_quizDB.GetRandom() , GiveAnswer);
	}
	
	private void GiveAnswer(OptionButton optionButton)
	{
		StartCoroutine(GiveAnswerRoutine(optionButton));
	}
	
	private IEnumerator GiveAnswerRoutine(OptionButton optionButton)
	{
		if(m_audioSource.isPlaying)
			m_audioSource.Stop();

		m_audioSource.clip = optionButton.Option.correct ? m_correctSound : m_incorrectSound;
		optionButton.SetColor(optionButton.Option.correct ? m_correctColor : m_incorrectColor);

		m_audioSource.Play();

		yield return new WaitForSeconds(m_waitTime);

		//if(optionButton.Option.correct)
			NexQuestion();
		
		//else
		//	GameOver();
	}
	
	//private void GameOver()
	//{
	//	//Lógica de Game Over
	//	SceneManager.LoadScene(0);
	//}
    
}
