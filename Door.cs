using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFivePrototypes
{
    class Door(int passcode)
    {
        public int Passcode { get; set; } =  passcode;
        public DoorStatus DoorStatus { get; set; } = DoorStatus.Locked;

        public List<(string Label, Action Command)> Actions =>
        [
            ("Open Door", () => this.Open()),
            ("Close Door", () => this.Close()),
            ("Unlock Door", () => this.Unlock()),
            ("Lock Door", () => this.Lock()),
            ("Change Door Passcode", () => this.ChangePasscode()),
            ("Exit", () => Environment.Exit(0))

        ];

        public void Open()
        {
            if(this.DoorStatus == DoorStatus.Closed || this.DoorStatus == DoorStatus.Unlocked)
            {
                this.DoorStatus = DoorStatus.Open;
                Console.WriteLine("You Opened the door.");
            }
            else if (this.DoorStatus == DoorStatus.Open)
            {
                Console.WriteLine("The door is already opened.");
            }
            else
            {
                Console.WriteLine("The door is locked!");
            }
        }

        public void Close()
        {
            if(this.DoorStatus == DoorStatus.Open)
            {
                this.DoorStatus = DoorStatus.Closed;
                Console.WriteLine("You closed the door.");
            }
            else
            {
                Console.WriteLine($"The door is not open. The door is currently {this.DoorStatus}.");
            }
        }

        public void Unlock()
        {

            if(this.DoorStatus == DoorStatus.Locked)
            {
                Console.WriteLine("What is the passcode to the door?");
                int.TryParse(Console.ReadLine(), out int passcode);

                if(passcode == this.Passcode)
                {
                    this.DoorStatus = DoorStatus.Unlocked;
                    Console.WriteLine($"You unlocked the door.");
                }
                else
                {
                    Console.WriteLine($"{passcode} is not the correct passcode.");
                }
            }
            else
            {
                Console.WriteLine($"Door is not locked. Currently door is {this.DoorStatus}");
            }
        }

        public void Lock()
        {
            if(this.DoorStatus == DoorStatus.Open)
            {
                Console.WriteLine("The door is opened. You need to close the door first.");
            }
            else
            {
                this.DoorStatus = DoorStatus.Locked;
                Console.WriteLine("You locked the door.");
            }
        }

        public void ChangePasscode()
        {
            Console.WriteLine("Enter current passcode.");
            int.TryParse(Console.ReadLine(), out int inputPasscode);

            if(inputPasscode == this.Passcode)
            {
                Console.WriteLine("Inputted Passcode was correct. Enter new passcode for your door.");
                int.TryParse(Console.ReadLine(), out int newPasscode);

                this.Passcode = newPasscode;
                Console.WriteLine("You changed the passcode!");
            }
            else
            {
                Console.WriteLine($"Current passcode is not {inputPasscode}");
            }
        }
    }

    enum DoorStatus
    {
        Locked,
        Unlocked,
        Closed,
        Open
    }
}
