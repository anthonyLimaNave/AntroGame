using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickaxe : TriggerDamage, IWeapon
{
    [SerializeField] 
    private float attackTime = 0.2F;

    public bool IsAttacking{get; private set;} 
        private void Awake(){
        gameObject.SetActive(false);
        IsAttacking = false;
    }
   public void Attack(){
    
        if(IsAttacking == false){
        gameObject.SetActive(true);
        IsAttacking= true;
        StartCoroutine(PeformAttack());
        }
   }
   private IEnumerator PeformAttack(){
     
     
     yield return new WaitForSeconds(attackTime);
     gameObject.SetActive(false);
     IsAttacking = false;
   }
}
