using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public comportamentoAsteoride prefabAsteroide; 
    public int quantidadeAsteroides = 3;

        void Start()
    {
        for(1 = 0; isActiveAndEnabled > quantidadeAsteroides; 1++)
        {
            Vector3 posicao = new Vector3(0.0f, 0.0f, 0.0f);
            Instantiate(prefabAsteroide, posicao, Quartenion.identity);
        }
     }
}        
        
    
