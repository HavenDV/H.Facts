﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using Asteroids.Standard.Enums;

namespace Asteroids.Standard.Interfaces
{
    /// <summary>
    /// Asteroids game engine that will calculate the lines and polygons and react to control key events.
    /// </summary>
    public interface IGameController
    {
        /// <summary>
        /// Start the game engine.
        /// </summary>
        /// <param name="container">Primary <see cref="IGraphicContainer"/> to draw on.</param>
        /// <param name="frameRectangle">Initial game <see cref="Rectangle"/> dimensions to base calculations one.</param>
        Task Initialize(IGraphicContainer container, Rectangle frameRectangle);

        /// <summary>
        /// Current state of the game.
        /// </summary>
        GameMode GameStatus { get; }

        /// <summary>
        /// Resize the game controller calculation rectangle.
        /// </summary>
        /// <param name="frameRectangle">New game <see cref="Rectangle"/> dimensions to base calculations one.</param>
        void ResizeGame(Rectangle frameRectangle);

        /// <summary>
        /// Apply a key-down event to the game.
        /// </summary>
        /// <param name="key"><see cref="PlayKey"/> to apply.</param>
        void KeyDown(PlayKey key);

        /// <summary>
        /// Apply a key-up event to the game.
        /// </summary>
        /// <param name="key"><see cref="PlayKey"/> to apply.</param>
        void KeyUp(PlayKey key);

        /// <summary>
        /// Shutdown the game.
        /// </summary>
        void Dispose();

        /// <summary>
        /// Fires when the game calculation results in a sound stored in <see cref="ActionSounds"/> to be played by UI.
        /// </summary>
        event EventHandler<ActionSound> SoundPlayed;

        /// <summary>
        /// Collection (read-only) of <see cref="ActionSounds"/> used by the game engine and associated WAV <see cref="Stream"/>s.
        /// </summary>
        IDictionary<ActionSound, Stream> ActionSounds { get; }
    }
}
