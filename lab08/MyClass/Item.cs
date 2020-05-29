using System;
using System.Collections.Generic;
using System.Text;

namespace MyClass
{
    abstract class Item : IComparable
    {
        int IComparable.CompareTo(object obj)
        {
            Item it = (Item)obj;
            if (this.invNumber == it.invNumber) return 0;
            else if (this.invNumber > it.invNumber) return 1;
            else return -1;
        }
        public abstract void Return(); 
        protected long invNumber;
        protected bool taken;
        public Item(long invNumber, bool taken) {
            this.invNumber = invNumber;
            this.taken = taken; }
        public Item() { this.taken = true; }
        public bool IsAvailable()
        {
            if (taken == true)
                return true;
            else
                return false;
        }
        public long GetInvNumber() {  return invNumber; }
        public virtual void Print() {
            Console.WriteLine("Состояние единицы хранения:\nИнвентарный номер: {0}\n Наличие: {1}", invNumber, taken);  }
        private void Take() { taken = false; }
        public void TakeItem() {  if (this.IsAvailable()) this.Take(); }
        public bool returnSrok { get; private set; }
        public void ReturnSrok() {  returnSrok = true; }
    }}
