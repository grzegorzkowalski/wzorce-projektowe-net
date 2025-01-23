using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateCharacter
{
    // Interfejs stanu
    public interface ICharacterState
    {
        void Attack();
        void Heal();
    }

    // Konkretny stan: Zdrowy
    public class HealthyState : ICharacterState
    {
        private Character _character;

        public HealthyState(Character character)
        {
            _character = character;
        }

        public void Attack()
        {
            Console.WriteLine("Postać atakuje w pełni sił.");
        }

        public void Heal()
        {
            Console.WriteLine("Postać jest już zdrowa.");
        }
    }

    // Konkretny stan: Ranny
    public class WoundedState : ICharacterState
    {
        private Character _character;

        public WoundedState(Character character)
        {
            _character = character;
        }

        public void Attack()
        {
            Console.WriteLine("Postać atakuje, ale jest osłabiona.");
        }

        public void Heal()
        {
            Console.WriteLine("Postać się leczy.");
            _character.SetState(_character.HealthyState);
        }
    }

    // Konkretny stan: Nieprzytomny
    public class UnconsciousState : ICharacterState
    {
        private Character _character;

        public UnconsciousState(Character character)
        {
            _character = character;
        }

        public void Attack()
        {
            Console.WriteLine("Postać jest nieprzytomna i nie może atakować.");
        }

        public void Heal()
        {
            Console.WriteLine("Postać się leczy.");
            _character.SetState(_character.WoundedState);
        }
    }

    // Klasa kontekstowa: Postać
    public class Character
    {
        public ICharacterState HealthyState { get; private set; }
        public ICharacterState WoundedState { get; private set; }
        public ICharacterState UnconsciousState { get; private set; }

        private ICharacterState _currentState;

        public Character()
        {
            HealthyState = new HealthyState(this);
            WoundedState = new WoundedState(this);
            UnconsciousState = new UnconsciousState(this);
            _currentState = HealthyState; // Stan początkowy
        }

        public void SetState(ICharacterState state)
        {
            _currentState = state;
        }

        public void Attack()
        {
            _currentState.Attack();
        }

        public void Heal()
        {
            _currentState.Heal();
        }
    }
}
