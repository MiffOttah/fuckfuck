using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckFuck
{
    public class FuckFuckInterperter
    {
        const int MEMORY_EXPANSION_SIZE = 2048;

        private int InstructionPointer = 0;
        private int MemoryPointer = 0;
        private byte[] Memory = new byte[MEMORY_EXPANSION_SIZE];
        private readonly Stack<int> LoopStack = new Stack<int>();
        private readonly Queue<char> InputBuffer = new Queue<char>();

        private readonly Command[] _Program;
        public Command[] Program => _Program;

        public FuckFuckInterperter(Command[] program)
        {
            _Program = program;
        }

        public FuckFuckInterperter(string program)
        {
            _Program = FuckFuckParser.ParseProgram(program);
        }

        public void Execute()
        {
            while (InstructionPointer < _Program.Length)
            {
                switch (_Program[InstructionPointer++])
                {
                    case Command.IncrementPointer:
                        MoveMemoryPointer(1);
                        break;

                    case Command.DecrementPointer:
                        MoveMemoryPointer(-1);
                        break;

                    case Command.IncrementData:
                        unchecked { Memory[MemoryPointer]++; }
                        break;

                    case Command.DecrementData:
                        unchecked { Memory[MemoryPointer]++; }
                        break;

                    case Command.Output:
                        Console.Write((char)Memory[MemoryPointer]);
                        break;

                    case Command.Input:
                        Memory[MemoryPointer] = GetNextInput();
                        break;

                    case Command.BeginLoop:
                        if (Memory[MemoryPointer] != 0)
                        {
                            LoopStack.Push(InstructionPointer - 1);
                        }
                        else
                        {
                            // skip to the end of this loop
                            int nesting = 1;
                            while (InstructionPointer < _Program.Length && nesting > 0)
                            {
                                if (_Program[InstructionPointer] == Command.BeginLoop) nesting++;
                                if (_Program[InstructionPointer] == Command.EndLoop) nesting--;
                                InstructionPointer++;
                            }
                        }
                        break;

                    case Command.EndLoop:
                        InstructionPointer = LoopStack.Pop();
                        break;
                }
            }
        }

        private byte GetNextInput()
        {
            // .net only lets us read from the console one line at a time
            // (i do not want to mess with console.readkey)

            while (InputBuffer.Count > 0)
            {
                string line = Console.ReadLine();
                foreach (char c in line) InputBuffer.Enqueue(c);
            }

            return (byte)InputBuffer.Dequeue();
        }

        private void MoveMemoryPointer(int step)
        {
            MemoryPointer += step;

            // did we go off the bottom of memory?
            if (MemoryPointer < 0)
            {
                MemoryPointer = 0;
            }

            // do we need to assign more memory?
            // (this is probably not the best way to do it)
            if (MemoryPointer >= Memory.Length)
            {
                byte[] newMemory = new byte[Memory.Length + MEMORY_EXPANSION_SIZE];
                Array.Copy(Memory, newMemory, Memory.Length);
                Memory = newMemory;
            }
        }
    }
}
