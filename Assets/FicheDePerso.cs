using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FicheDePerso : MonoBehaviour {

    public class StatsDuPerso {
        public string Name;
        public int Strenght;
        public int Constitution;
        public int Intelligence;

        public StatsDuPerso (string name, int strenght, int constitution, int intelligence)
        {
            this.Name = name;
            this.Strenght = strenght;
            this.Constitution = constitution;
            this.Intelligence = intelligence;

        }
    }

    public Text characteristiques;

    StatsDuPerso cyclop = new StatsDuPerso("Cyclop", 17, 16, 8);
    StatsDuPerso hobgob = new StatsDuPerso("Hobgobelin", 15, 14, 11);
    StatsDuPerso kobold = new StatsDuPerso("Kobold", 12, 10, 12);
    StatsDuPerso gob = new StatsDuPerso("Gobelin", 11, 11, 13);

    List<StatsDuPerso> personnages = new List<StatsDuPerso>();
 


    // Use this for initialization
    void Start () {

        personnages.Add(cyclop);
        personnages.Add(hobgob);
        personnages.Add(kobold);
        personnages.Add(gob);

        characteristiques.text = ("Name : " + cyclop.Name + "\n\n\nStrengh : " + cyclop.Strenght + "\n\nConstitution : " + cyclop.Constitution + "\n\nIntelligence : " + cyclop.Intelligence);


        Debug.Log("Le " + personnages[0].Name + " a " + personnages[0].Strenght + " en Force !!!!");
        Debug.Log("Le " + personnages[1].Name + " a " + personnages[1].Strenght + " en Force !!!!");
        Debug.Log("Le " + personnages[2].Name + " a " + personnages[2].Strenght + " en Force !!!!");
        Debug.Log("Le " + personnages[3].Name + " a " + personnages[3].Strenght + " en Force !!!!");

    }

    public void AfficherStatsCyclop()
    {
        characteristiques.text = ("Name : " + cyclop.Name + "\n\n\nStrengh : " + cyclop.Strenght + "\n\nConstitution : " + cyclop.Constitution + "\n\nIntelligence : " + cyclop.Intelligence);
    }

    public void AfficherStatsHobgob()
    {
        characteristiques.text = ("Name : " + hobgob.Name + "\n\n\nStrengh : " + hobgob.Strenght + "\n\nConstitution : " + hobgob.Constitution + "\n\nIntelligence : " + hobgob.Intelligence);
    }

    public void AfficherStatsKobold()
    {
        characteristiques.text = ("Name : " + kobold.Name + "\n\n\nStrengh : " + kobold.Strenght + "\n\nConstitution : " + kobold.Constitution + "\n\nIntelligence : " + kobold.Intelligence);
    }

    public void AfficherStatsGob()
    {
        characteristiques.text = ("Name : " + gob.Name + "\n\n\nStrengh : " + gob.Strenght + "\n\nConstitution : " + gob.Constitution + "\n\nIntelligence : " + gob.Intelligence);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
