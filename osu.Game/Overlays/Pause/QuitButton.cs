﻿using OpenTK.Graphics;
using osu.Framework.Allocation;
using osu.Framework.Audio;
using osu.Game.Graphics;

namespace osu.Game.Overlays.Pause
{
    public class QuitButton : PauseButton
    {
        [BackgroundDependencyLoader]
        private void load(AudioManager audio, OsuColour colours)
        {
            ButtonColour = new Color4(170, 27, 39, 255); // The red from the design isn't in the palette so it's used directly
            SampleHover = audio.Sample.Get(@"Menu/menuclick");
            SampleClick = audio.Sample.Get(@"Menu/menuback");
        }

        public QuitButton()
        {
            Text = @"Quit to Main Menu";
        }
    }
}