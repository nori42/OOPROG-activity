using System.Media;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Game.Classes
{
     class Character
    {
        protected int health;
        protected int basicDamage;
        protected int armor;
        public Thread IdleAnimation;
        public PictureBox characterBox;
        public int Health {
            get { return health; }
            set { health = value; }
        }

        public int BasicDamage {
            get { return basicDamage; }
        }

        public int Armor {
            get { return armor; }
        }

        
        //Polymorph
        public virtual void playDeathSound()
        {
            SoundPlayer defaultDeathSound = new SoundPlayer();

            defaultDeathSound.Play();
        }


        delegate void UpdateSizeDelagate( int h);
        void UpdatePlayerSize(int h)
        {
            characterBox.Size = new Size(characterBox.Width, characterBox.Height - h);
            characterBox.Location = new Point(characterBox.Location.X, characterBox.Location.Y + h);
        }
        public void StartIdleAnimation()
        {
            IdleAnimation = new Thread(() => {
                int frame = 1;
                int maxFrame = 6; // Count frames of the animation

                while (true)
                {
                    if (frame > maxFrame)
                    {
                        frame = 1;
                    }
                    //Change the size every 200ms
                    if (characterBox.IsHandleCreated)
                    {
                        if (frame <= 3)
                        {
                            characterBox.BeginInvoke(new UpdateSizeDelagate(UpdatePlayerSize), 2);
                            WaitEvent.Wait(200);
                        }
                        else
                        {
                            characterBox.BeginInvoke(new UpdateSizeDelagate(UpdatePlayerSize), -2);
                            WaitEvent.Wait(200);
                        }
                        frame++;
                    }
                }
            });

            IdleAnimation.IsBackground = true;
            IdleAnimation.Start();
        }
    }
}
