using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.Diagnostics;

namespace KeepItUpCorrect
{
    class SoundManager
    {
        private static SoundEffect jump;
        private static Song cantTouch;

        private static Song america;
        private static Song deadpool;
        private static Song ironman;
        private static Song spiderman;


        public static void Initialize(ContentManager content)
        {
            try
            {
                jump = content.Load<SoundEffect>(@"Sounds\jump");
                cantTouch = content.Load<Song>(@"Sounds\cantTouch");

                america = content.Load<Song>(@"Sounds\'murica");
                deadpool = content.Load<Song>(@"Sounds\deadpool");
                ironman = content.Load<Song>(@"Sounds\ironman");
                spiderman = content.Load<Song>(@"Sounds\spiderman");
            }
            catch
            {
                Debug.Write("SoundManager Initialization Failed");
            }
        }
        public static void playJump()
        {
            try
            {
                jump.Play();
            }

            catch
            {
                Debug.Write("jump failed");
            }
        }

        public static void playcantTouch()
        {
            try
            {
                if (MediaPlayer.State != MediaState.Playing)
                   MediaPlayer.Play(cantTouch);
            }
            catch
            {
                Debug.Write("cantTouch failed");
            }
        }

        public static void playamerica()
        {
            try
            {
                MediaPlayer.Play(america);
            }

            catch
            {
                Debug.Write("america failed");
            }
        }

        public static void playdeadpool()
        {
            try
            {
                MediaPlayer.Play(deadpool);
            }

            catch
            {
                Debug.Write("deadpool failed");
            }
        }

        public static void playironman()
        {
            try
            {
                MediaPlayer.Play(ironman);
            }

            catch
            {
                Debug.Write("ironman failed");
            }
        }

        public static void playspiderman()
        {
            try
            {
                MediaPlayer.Play(spiderman);
            }

            catch
            {
                Debug.Write("spiderman failed");
            }
        }
        public static void stopSongs()
        {
            MediaPlayer.Stop();
        }

    }
}
