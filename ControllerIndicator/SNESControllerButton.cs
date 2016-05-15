using System.Drawing;
using XInputDotNetPure;

namespace ControllerIndicator
{
    public class SNESControllerButton
    {
        public enum Buttons
        {
            A,
            B,
            X,
            Y,
            Up,
            Down,
            Left,
            Right,
            Select,
            Start,
            L,
            R
        };

        private SNESControllerForm form;
        private Image image = null;
        private bool pressed = false;
        private Buttons key_button;

        public Image Image
        {
            get
            {
                return image;
            }
        }

        public bool Pressed
        {
            get
            {
                return pressed;
            }
            set
            {
                if (value)
                    press();
                else
                    unpress();
            }
        }

        public Buttons KeyButton
        {
            get
            {
                return key_button;
            }
        }

        public SNESControllerButton(SNESControllerForm form, Image image, Buttons key_button)
        {
            this.form = form;
            this.image = new Bitmap(image);
            this.key_button = key_button;
            //form.KeyUp += new KeyEventHandler(OnKeyUp);
            //form.KeyDown += new KeyEventHandler(OnKeyDown);
        }

        private void unpress()
        {
            if (pressed == true)
            {
                pressed = false;
                form.UpdateForm = true;
            }
        }

        private void press()
        {
            if (pressed == false)
            {
                pressed = true;
                form.UpdateForm = true;
            }
        }

        public void update()
        {
            GamePadState state = GamePad.GetState(PlayerIndex.One);
            if (state.IsConnected)
            {
                switch(key_button)
                {
                    case Buttons.A:
                        Pressed = (state.Buttons.B == XInputDotNetPure.ButtonState.Pressed);
                        break;
                    case Buttons.B:
                        Pressed = (state.Buttons.A == XInputDotNetPure.ButtonState.Pressed);
                        break;
                    case Buttons.X:
                        Pressed = (state.Buttons.Y == XInputDotNetPure.ButtonState.Pressed);
                        break;
                    case Buttons.Y:
                        Pressed = (state.Buttons.X == XInputDotNetPure.ButtonState.Pressed);
                        break;
                    case Buttons.Up:
                        Pressed = (state.DPad.Up == XInputDotNetPure.ButtonState.Pressed);
                        break;
                    case Buttons.Down:
                        Pressed = (state.DPad.Down == XInputDotNetPure.ButtonState.Pressed);
                        break;
                    case Buttons.Left:
                        Pressed = (state.DPad.Left == XInputDotNetPure.ButtonState.Pressed);
                        break;
                    case Buttons.Right:
                        Pressed = (state.DPad.Right == XInputDotNetPure.ButtonState.Pressed);
                        break;
                    case Buttons.Select:
                        Pressed = (state.Buttons.Back == XInputDotNetPure.ButtonState.Pressed);
                        break;
                    case Buttons.Start:
                        Pressed = (state.Buttons.Start == XInputDotNetPure.ButtonState.Pressed);
                        break;
                    case Buttons.L:
                        Pressed = (state.Buttons.LeftShoulder == XInputDotNetPure.ButtonState.Pressed);
                        break;
                    case Buttons.R:
                        Pressed = (state.Buttons.RightShoulder == XInputDotNetPure.ButtonState.Pressed);
                        break;
                }
            }
            else unpress();
        }

        //public void OnKeyUp(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == KeyCode)
        //    {
        //        pressed = false;
        //        form.Refresh();
        //    }
        //}

        //public void OnKeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == KeyCode)
        //    {
        //        pressed = true;
        //        form.Refresh();
        //    }
        //}
    }
}
