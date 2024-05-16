using System;

namespace Projeto_de_aula
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

            
    }


    public class EnemyAI : MonoBehavior
    {
        /* tipos de dados */
        int valor = 30;
        float a1 = 3.5f;
        string catacteres = "Nome do personagem";
        bool VerdadeiroOuFalso = false;

        /* usados no exemplo */
        int speed;
        string enemyName;
        float health;

        /* array / lista*/
        int [] intArray = new int[] {1,2,3,4,5,6,7,8,9,10};

        List<int> intList = new List<int>() {1,2,3,4,5,6,7,8,9,10};


        void Movement()
        {
            /* Alterando arrays e listas  */
            intList.Add(11);
            intList.Remove(11);

            /* leitura de arrays e listas */
            foreach (int intNumbers in intArray)
            {
                
            }

            for (int i = 0; i < intArray.length; i++)
            {
                int currentNumber = intArray[i]
            }
            /* específicade de listas em for */
            for (int i = 0; i < intList.count; i++)
            {
                int currentNumber = intList[i]
            }


            if (speed >= 0 && health > 0)
            {
                
            }

            void Dead()
            {
                if(health <= 0)
                {

                }
            }

            void Attack()
            {
                EnemyWeapon.damage= 30;
                EnemyWeapon.firerate = 0.4f;
                EnemyWeapon.Shoot();
            }
        }
    }


    public class EnemyWeapon

    {
        public float damage;
        public float firerate;

        public void Shoot()
        {

        }
    }

    void Explosao(int ValorDano){
        //Tocar efeito sonoro
        //Aplicar efeito de flash
        //Aplicar ValorDano de dano na vida do personagem


    }
}