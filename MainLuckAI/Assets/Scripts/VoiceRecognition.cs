using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.Windows.Speech;

public class VoiceRecognition : MonoBehaviour
{
	private KeywordRecognizer keywordRecognizer;
	private Dictionary<string, Action> actions = new Dictionary<string, Action>();
	// Emotional particle systems:
	public  ParticleSystem angryParticles;
	public  ParticleSystem rainbowParticles;
	public  ParticleSystem sadParticles;

void Start()
{
	actions.Add("forward", Forward);
	actions.Add("up", Up);
	actions.Add("down", Down);
	actions.Add("back", Back);
	actions.Add("I feel angry", DisappointedReaction);
	actions.Add("I feel happy", PleasedReaction);
	actions.Add("I feel sad", SadReaction);

	keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray()); //SLista de palabras que reconoce. Las traducira a actions keys.
	keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
	keywordRecognizer.Start();
}

private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
{
	Debug.Log(speech.text);
	actions[speech.text].Invoke();
}

//poner en esta parte los efectos de las particulas a cambiar. Primera prueba solo para mover al personaje

private void Forward()
{
	transform.Translate(1,0,0); //buscar las variables para cada uno de los efectos de particulas
}

private void Back()
{
	transform.Translate(-1,0,0); //buscar las variables para cada uno de los efectos de particulas
}

private void Up()
{
	angryParticles.Play(); //buscar las variables para cada uno de los efectos de particulas
}

private void Down()
{
	transform.Translate(-1,0,0); //buscar las variables para cada uno de los efectos de particulas
}

private void DisappointedReaction()
{
	angryParticles.Play();
}

private void PleasedReaction()
{
	rainbowParticles.Play();
}

private void SadReaction()
{
	sadParticles.Play();
}

}
