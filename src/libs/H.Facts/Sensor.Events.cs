#pragma warning disable CA1034 // Preserve the public API formerly emitted by EventGenerator.

#nullable enable

namespace H.Facts
{
    public partial class Sensor
    {
        /// <summary>
        ///
        /// </summary>
        public class FactReceivedEventArgs : global::System.EventArgs
        {
            /// <summary>
            ///
            /// </summary>
            public global::H.Facts.Fact Fact { get; }

            /// <summary>
            ///
            /// </summary>
            public FactReceivedEventArgs(global::H.Facts.Fact fact)
            {
                Fact = fact;
            }

            /// <summary>
            ///
            /// </summary>
            public void Deconstruct(out global::H.Facts.Fact fact)
            {
                fact = Fact;
            }

            /// <summary>
            ///
            /// </summary>
            public override string ToString()
            {
                return $"(Fact={Fact})";
            }
        }
    }
}

#nullable enable

namespace H.Facts
{
    public partial class Sensor
    {
        /// <summary>
        /// </summary>
        public event global::System.EventHandler<global::H.Facts.Sensor.FactReceivedEventArgs>? FactReceived;

        /// <summary>
        /// A helper method to raise the FactReceived event.
        /// </summary>
        protected virtual global::H.Facts.Sensor.FactReceivedEventArgs OnFactReceived(global::H.Facts.Sensor.FactReceivedEventArgs args)
        {
            FactReceived?.Invoke(this, args);

            return args;
        }

        /// <summary>
        /// A helper method to raise the FactReceived event.
        /// </summary>
        protected virtual global::H.Facts.Sensor.FactReceivedEventArgs OnFactReceived(
            global::H.Facts.Fact fact)
        {
            var args = new global::H.Facts.Sensor.FactReceivedEventArgs(fact);
            FactReceived?.Invoke(this, args);

            return args;
        }
    }
}
