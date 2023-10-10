using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp
{
    /* Not so optimal implemntation of a coffee machine */

    public enum CoffeeMakerState { Ready, Brewing, CleanReservoir, Descale, Completed, Error }
    public class CoffeeMaker
    {
        private CoffeeMakerState _state;

        public CoffeeMaker()
        {
            _state = CoffeeMakerState.Ready;
        }

        public void PressGo()
        {
            switch (_state)
            {
                case CoffeeMakerState.Ready:
                    _state = CoffeeMakerState.Brewing;
                    Brew();
                    break;
                case CoffeeMakerState.CleanReservoir:
                    _state = CoffeeMakerState.Descale;
                    Descale();
                    break;

                case CoffeeMakerState.Descale:
                    _state = CoffeeMakerState.Ready;

                    break;

                default:
                    break;
            }
        }

        public void TimePassed(int units)
        {
            switch (_state)
            {
                case CoffeeMakerState.Ready:
                    if (units > 3100)
                    {
                        _state = CoffeeMakerState.CleanReservoir;
                        CleanReservoir();
                    }
                    break;
                case CoffeeMakerState.Brewing:
                    if (units > 1)
                    {
                        _state = CoffeeMakerState.Completed;
                    }
                    break;
                default:
                    break;
            }
        }

        public void CupTaken()
        {
            switch (_state)
            {
                case CoffeeMakerState.Completed:
                    _state = CoffeeMakerState.Ready;

                    break;
                case CoffeeMakerState.Brewing:

                    StopMachine();
                    LogError("taken cup while brewing");
                    _state = CoffeeMakerState.Error;

                    break;
                default:
                    break;
            }

        }

        public void StopMachine() { }
        public void Descale() { }
        public void CleanReservoir() { }
        public void Brew() { }

        public void LogError(string err) { }


    }
