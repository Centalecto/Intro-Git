using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Réserveexempledescripts : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }


    //i I k K _ 8 ; .

    //1 Déplacement vers une cible

    //public GameObject targetCible;
    //public float speed = 5f;

    //// Update is called once per frame
    //void Update()
    //{
    //    Vector3 direction = targetCible.transform.position - transform.position;  //Détermine la position relative entre l'objet cible et "nous" pour en faire une direction
    //    transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);  //Prend la direction et on se déplace vers elle


    //    //transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);
    //}




    //2 Déplacement en ligne droite sur un "cable" (avec la possibilité de modifié le début et la fin) avec une TP pour revenir au début

    //public float speed = 5f;
    //public float Xdépart, Xarrivé;  //Création des variables pour la position de début et de fin du parcours

    //void Update()
    //{
    //    transform.position += transform.right * speed * Time.deltaTime;  //Mouvement du Gameobject vers la droite (x-> ++) en fonction de la vitesse et le temps (en fonction des frames par secondes de la simulation)

    //    if (transform.position.x >= Xarrivé)
    //    {
    //        transform.position = new Vector3(Xdépart, transform.position.y, transform.position.z);
    //    }

    //    void DrawLine()
    //    {
    //        Vector3 start = transform.position;  //Détermine la position de départ de l'objet
    //        Vector3 end = start;

    //        start.x = Xdépart;         //Mise en place des variable de début et de fin du parcourspour le tracé (ligne droite)
    //        end.x = Xarrivé;

    //        Debug.DrawLine(start, end, Color.cyan);   //Trace une ligne entre les point de "début et de fin" déterminé juste au dessus, couleur cyan


    //    }

    //    DrawLine();   //Appel de la fonction DrawLine
    //}


    //3 Déplacement sur un cable mais revient à l'origine quand arrivé à la fin

    //public float speed = 5f;
    //public float Xdépart, Xarrivé;
    //public bool Arrivé;

    //void Update()
    //{
    //    if (Arrivé == false)
    //    {
    //        transform.position += Vector3.right * speed * Time.deltaTime;   //Revoir le code ça marche pas comme ça
    //    }

    //    if (transform.position.x >= Xarrivé)
    //    {
    //        Arrivé = true;
    //    }

    //    if (transform.position.x <= Xdépart)
    //    {
    //        Arrivé = false;
    //    }


    //    if (Arrivé == true)
    //    {
    //        transform.position -= Vector3.right * speed * Time.deltaTime;


    //    }

    //    void DrawLine()
    //    {
    //        Vector3 start = transform.position;
    //        Vector3 end = start;

    //        start.x = Xdépart;
    //        end.x = Xarrivé;

    //        Debug.DrawLine(start, end, Color.cyan);


    //    }

    //    DrawLine();
    //}




    //4 TP à l'opposé d'une zone sur un plan 2D (X,Z)

    //public Vector3 min, max;

    //// Update is called once per frame
    //void Update()
    //{
    //    DrawBounds();

    //    //Sur un plan 2D x,z

    //    //La position cible est une copie de la position de l'objet, si aucun warp n'a lieu, l'objet conservera ainsi sa position.
    //    Vector3 targetPos = transform.position;

    //    //Range contient la taille de la zone comprise entre les limites :
    //    Vector3 range = max - min;

    //    if (transform.position.x < min.x)   //Quand on touche une des limite on est envoyé à l'opposé
    //    {
    //        targetPos.x += range.x;
    //    }
    //    else if (transform.position.x > max.x)
    //    {
    //        targetPos.x -= range.x;
    //    }
    //    else if (transform.position.z < min.z)
    //    {
    //        targetPos.z += range.z;
    //    }
    //    else if (targetPos.z > max.z)
    //    {
    //        targetPos.z -= range.z;
    //    }

    //    transform.position = targetPos;  //on effectue la TP







    //}

    //private void DrawBounds()  //On marque la limite de la zone (pour être visible)
    //{
    //    Vector3 range = max - min;
    //    Debug.DrawRay(min, Vector3.right * range.x, Color.green);
    //    Debug.DrawRay(max, -Vector3.right * range.x, Color.green);
    //    Debug.DrawRay(min, Vector3.forward * range.z, Color.green);
    //    Debug.DrawRay(max, -Vector3.forward * range.z, Color.green);
    //}





    //5 Va vers l'avant et tourne sur lui-même

    //public float speed = 5f;
    //public float rotationSpeed = 5f;

    //void Update()
    //{
    //    transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);
    //    transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

    //    //transform.Translate(Vector3.forward)
    //}


    //6 TP sur le transform de la "cible", mettre dans update pour suivre le mouvement de la cible

    //void Start()
    //{
    //    //Transform.position = new Transform.position.target;

    //    transform.position = target.transform.position;
    //}



    // 7 Suivre la "cible" mais avec un décalage (ici un peu au dessus)

    //public GameObject target;
    //public float offsetTop = 1f;  détermine de décalage


    //// Update is called once per frame
    //void Update()
    //{
    //    //transform.position = target.transform.position;     //Comment mettre le "Offset" pour le décalage
    //    transform.position = target.transform.position + Vector3.up * offsetTop;
    //}



    //8 Pour rebondir dans un boite

    //public Vector3 min, max;

    //public float speed = 1f;

    //public Vector3 Movement = new Vector3(1, 0, 1);

    //// Update is called once per frame
    //void Update()
    //{  //Le mouvement finit est une pattern qui se répète

    //    transform.position += Movement * speed * Time.deltaTime;

    //    DrawBounds();

    //    //////La position cible est une copie de la position de l'objet, si aucun warp n'a lieu, l'objet conservera ainsi sa position.
    //    //Vector3 targetPos = transform.position;



    //    //Range contient la taille de la zone comprise entre les limites :
    //    Vector3 range = max - min;

    //    if (transform.position.x < min.x)
    //    {
    //        Movement.x = -Movement.x;
    //    }
    //    else if (transform.position.x > max.x)
    //    {
    //        Movement.x = -Movement.x;
    //    }
    //    else if (transform.position.z < min.z)
    //    {
    //        Movement.z = -Movement.z;
    //    }
    //    else if (transform.position.z > max.z)
    //    {
    //        Movement.z = -Movement.z;
    //    }







    //}

    //private void DrawBounds()
    //{
    //    Vector3 range = max - min;
    //    Debug.DrawRay(min, Vector3.right * range.x, Color.green);
    //    Debug.DrawRay(max, -Vector3.right * range.x, Color.green);
    //    Debug.DrawRay(min, Vector3.forward * range.z, Color.green);
    //    Debug.DrawRay(max, -Vector3.forward * range.z, Color.green);
    //}



}
