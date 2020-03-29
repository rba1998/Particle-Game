using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ParticleSystemStarter
{
    /// <summary>
    /// A struct representing a single particle in a particle system 
    /// </summary>
    public struct Particle
    {
        /// <summary>
        /// The current position of the particle
        /// </summary>
        public Vector2 Position;

        /// <summary>
        /// The current velocity of the particle
        /// </summary>
        public Vector2 Velocity;

        /// <summary>
        /// The current acceleration of the particle
        /// </summary>
        public Vector2 Acceleration;

        /// <summary>
        /// The current scale of the particle
        /// </summary>
        public float Scale;

        /// <summary>
        /// The current life of the particle
        /// </summary>
        public float Life;

        /// <summary>
        /// The current color of the particle
        /// </summary>
        public Color Color;
    }

    /// <summary>
    /// A class representing a particle system 
    /// </summary>
    public class ParticleSystem
    {
        /// <summary>
        /// The collection of particles 
        /// </summary>
        private Particle[] particles;

        /// <summary>
        /// The texture this particle system uses 
        /// </summary>
        private Texture2D texture;

        /// <summary>
        /// The SpriteBatch this particle system uses
        /// </summary>
        private SpriteBatch spriteBatch;

        /// <summary>
        /// A random number generator used by the system 
        /// </summary>
        private Random random = new Random();

        /// <summary>
        /// The next index in the particles array to use when spawning a particle
        /// </summary>
        private int nextIndex = 0;

        /// <summary>
        /// The emitter location for this particle system 
        /// </summary>
        public Vector2 Emitter { get; set; }

        /// <summary>
        /// The rate of particle spawning 
        /// </summary>
        public int SpawnPerFrame { get; set; }

        /// <summary>
        /// Constructs a new particle engine 
        /// </summary>
        /// <param name="graphicsDevice">The graphics device</param>
        /// <param name="size">The maximum number of particles in the system</param>
        /// <param name="texture">The texture of the particles</param> 
        public ParticleSystem(GraphicsDevice graphicsDevice, int size, Texture2D texture)
        {
            this.particles = new Particle[size];
            this.spriteBatch = new SpriteBatch(graphicsDevice);
            this.texture = texture;
        }

        /// <summary> 
        /// Updates the particle system, spawining new particles and 
        /// moving all live particles around the screen 
        /// </summary>
        /// <param name="gameTime">A structure representing time in the game</param>
        public void Update(GameTime gameTime)
        {
            // Part 1: Spawn Particles
            for (int i = 0; i < SpawnPerFrame; i++)
            {
                // TODO: Spawn Particle at nextIndex

                // Advance the index 
                nextIndex++;
                if (nextIndex > particles.Length - 1) nextIndex = 0;
            }

            // Part 2: Update Particles
        }
    }
}
