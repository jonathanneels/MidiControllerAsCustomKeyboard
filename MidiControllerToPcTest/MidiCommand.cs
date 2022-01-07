using System;
 using WindowsInput;

namespace MidiControllerToPcTest
{

  public  static class MidiCommand
    {
        public static InputSimulator simulate = new InputSimulator(); //REF: https://github.com/michaelnoonan/inputsimulator%20%20&%20%20https://stackoverflow.com/questions/25987445/installed-inputsimulator-via-nuget-no-members-accessible

        public static void executeMidiCommand(string commandNote, int velocity, ref bool isActionLocked)

        {
            if (!isActionLocked)
            {
                isActionLocked = true;

                //   simulate.Keyboard.TextEntry(commandNote);


                if (velocity< 51)
                {
                    if (System.Windows.Forms.Control.IsKeyLocked(System.Windows.Forms.Keys.CapsLock))
                    {
                        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.CAPITAL);
                        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.CAPITAL);
                        Console.WriteLine("The Caps Lock key is set OFF.");

                    }

}
                else if (velocity >= 51)
{
    if (!System.Windows.Forms.Control.IsKeyLocked(System.Windows.Forms.Keys.CapsLock))
    {
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.CAPITAL);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.CAPITAL);
        Console.WriteLine("The Caps Lock key is set ON.");
    }
}

switch (commandNote.ToLower())
{
    case "a":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_A);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_A);
        break;
    case "b":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_B);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_B);
        break;
    case "c":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_C);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_C);
        break;
    case "d":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_D);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_D);
        break;
    case "e":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_E);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_E);
        break;
    case "f":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_F);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_F);
        break;
    case "g":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_G);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_G);
        break;
    case "h":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_H);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_H);
        break;
    case "i":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_I);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_I);
        break;
    case "j":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_J);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_J);
        break;
    case "k":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_K);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_K);
        break;
    case "l":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_L);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_L);
        break;
    case "m":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_M);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_M);
        break;
    case "n":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_N);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_N);
        break;
    case "o":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_O);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_O);
        break;
    case "p":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_P);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_P);
        break;
    case "q":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_Q);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_Q);
        break;
    case "r":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_R);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_R);
        break;
    case "s":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_S);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_S);
        break;
    case "t":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_T);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_T);
        break;
    case "u":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_U);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_U);
        break;
    case "v":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_V);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_V);
        break;
    case "w":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_W);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_W);
        break;
    case "x":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_X);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_X);
        break;
    case "y":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_Y);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_Y);
        break;
    case "z":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_M);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_M);
        break;
    case "0":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_0);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_0);
        break;
    case "1":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_1);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_1);
        break;
    case "2":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_2);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_2);
        break;
    case "3":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_3);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_3);
        break;
    case "4":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_4);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_4);
        break;
    case "5":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_5);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_5);
        break;
    case "6":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_6);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_6);
        break;
    case "7":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_7);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_7);
        break;
    case "8":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_8);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_8);
        break;
    case "9":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_9);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_9);
        break;
    case "down":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.DOWN);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.DOWN);
        break;
    case "left":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.LEFT);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.LEFT);
        break;
    case "right":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.RIGHT);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.RIGHT);
        break;
    case "up":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.UP);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.UP);
        break;
    case "lwin":
    case "win":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.LWIN);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.LWIN);
        break;
    case "rwin":
            simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.RWIN);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.RWIN);
        break;
    case "escape":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.ESCAPE );
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.ESCAPE);
        break;
    case "tab":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.TAB);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.TAB);
        break;
    case "space":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.SPACE);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.SPACE);
        break;
    case "return":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.RETURN);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.RETURN);
        break;
    case "f1":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.F1);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.F1);
        break;
    case "f2":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.F2);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.F2);
        break;
    case "f3":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.F3);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.F3);
        break;
    case "f4":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.F4);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.F4);
        break;
    case "f5":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.F5);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.F5);
        break;
    case "f6":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.F6);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.F6);
        break;
    case "f7":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.F7);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.F7);
        break;
    case "f8":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.F8);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.F8);
        break;
    case "f9":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.F9);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.F9);
        break;
        case "f10":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.F10);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.F10);
        break;
    case "f11":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.F11);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.F11);
        break;
    case "f12":
        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.F12);
        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.F12);
        break;
                    case "numlock":
                        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.NUMLOCK);
                        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.NUMLOCK);
                        break;
                    case "numpad0":
                    case "num0":
                    case "n0":
                        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.NUMPAD0);
                        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.NUMPAD0);
                        break;
                    case "numpad1":
                    case "num1":
                    case "n1":
                        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.NUMPAD1);
                        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.NUMPAD1);
                        break;
                    case "numpad2":
                    case "num2":
                    case "n2":
                        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.NUMPAD2);
                        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.NUMPAD2);
                        break;
                    case "numpad3":
                    case "num3":
                    case "n3":
                        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.NUMPAD3);
                        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.NUMPAD3);
                        break;
                    case "numpad4":
                    case "num4":
                    case "n4":
                        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.NUMPAD4);
                        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.NUMPAD4);
                        break;
                    case "numpad5":
                    case "num5":
                    case "n5":
                        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.NUMPAD5);
                        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.NUMPAD5);
                        break;
                    case "numpad6":
                    case "num6":
                    case "n6":
                        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.NUMPAD6);
                        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.NUMPAD6);
                        break;
                    case "numpad7":
                    case "num7":
                    case "n7":
                        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.NUMPAD7);
                        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.NUMPAD7);
                        break;
                    case "numpad8":
                    case "num8":
                    case "n8":
                        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.NUMPAD8);
                        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.NUMPAD8);
                        break;
                    case "numpad9":
                    case "num9":
                    case "n9":
                        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.NUMPAD9);
                        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.NUMPAD9);
                        break;
                    case "plus":
                     case "+":
                        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.OEM_PLUS);
                        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.OEM_PLUS);
                        break;
                    case "min":
                    case "-":
                        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.OEM_MINUS );
                        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.OEM_MINUS);
                        break;
                    case "comma":
                    case ",":
                        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.OEM_COMMA);
                        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.OEM_COMMA);
                        break;
                    case "decimal":
                    case "/":
                        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.DECIMAL );
                        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.DECIMAL);
                        break;
                    case "period":
                    case ".":
                        simulate.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.OEM_PERIOD);
                        simulate.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.OEM_PERIOD);
                        break;

                    default:
                        try
                        {

                            if (commandNote.StartsWith("CHAR")) //FMI: https://www.cs.cmu.edu/~pattis/15-1XX/common/handouts/ascii.html
                            {
                                commandNote= ((char)Int32.Parse(commandNote.Replace("CHAR","").Trim())).ToString(); //ref: https://tools.oratory.com/altcodes.html

                            }
                            if (velocity >= 51)
                            {
                                simulate.Keyboard.TextEntry(commandNote.ToUpper());
                            }
                            else if (velocity < 51)
                            {
                                simulate.Keyboard.TextEntry(commandNote.ToLower());
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        break;

}
         



            }

        }
    }
}
