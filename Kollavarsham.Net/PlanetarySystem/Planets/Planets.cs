namespace Kollavarsham.Net.PlanetarySystem.Planets
{
    public class Planets
    {
        public Star Star { get; } = new Star();
        public Sun Sun { get; } = new Sun();
        public Moon Moon { get; } = new Moon();
        public Mercury Mercury { get; } = new Mercury();
        public Venus Venus { get; } = new Venus();
        public Mars Mars { get; } = new Mars();
        public Jupiter Jupiter { get; } = new Jupiter();
        public Saturn Saturn { get; } = new Saturn();
        public Candrocca Candrocca { get; } = new Candrocca();
        public Rahu Rahu { get; } = new Rahu();

        public void InitializeYugaRotations(System system)
        {
            // common values across the systems
            Sun.YugaRotation = 4320000;
            Moon.YugaRotation = 57753336;
            Jupiter.YugaRotation = 364220;

            var isSuryaSiddhantaSystem = system == System.SuryaSiddhanta;

            // # Saura, HIL, p.15 && # Latadeva/Ardharatrika, HIL, p.15
            Star.YugaRotation = isSuryaSiddhantaSystem ? 1582237800 : 1582237828;
            Mercury.YugaRotation = isSuryaSiddhantaSystem ? 17937000 : 17937060;
            Venus.YugaRotation = isSuryaSiddhantaSystem ? 7022388 : 7022376;
            Mars.YugaRotation = isSuryaSiddhantaSystem ? 2296824 : 2296832;
            Saturn.YugaRotation = isSuryaSiddhantaSystem ? 146564 : 146568;
            Candrocca.YugaRotation = isSuryaSiddhantaSystem ? 488219 : 488203;
            Rahu.YugaRotation = isSuryaSiddhantaSystem ? -232226 : -232238;
            
            InitializePlanetaryConstants();
        }

        private void InitializePlanetaryConstants() {
            // star
            Star.Rotation = 0;
            Star.Sighra = 0;
            Star.Apogee = 0;
            Star.MandaCircumference = 0;
            Star.SighraCircumference = 0;

            // sun
            Sun.Rotation = Sun.YugaRotation;
            Sun.Sighra = Sun.YugaRotation;
            Sun.Apogee = 77 + 17.0 / 60.0;
            Sun.MandaCircumference = 13 + 50.0 / 60.0;
            Sun.SighraCircumference = 0;

            // moon
            Moon.Rotation = Moon.YugaRotation;
            Moon.Sighra = 0;
            Moon.Apogee = 0;
            Moon.MandaCircumference = 31 + 50.0 / 60.0;
            Moon.SighraCircumference = 0;

            // mercury
            Mercury.Rotation = Sun.YugaRotation;
            Mercury.Sighra = Mercury.YugaRotation;
            Mercury.Apogee = 220 + 27.0 / 60.0;
            Mercury.MandaCircumference = 29;
            Mercury.SighraCircumference = 131.5;

            // venus
            Venus.Rotation = Sun.YugaRotation;
            Venus.Sighra = Venus.YugaRotation;
            Venus.Apogee = 79 + 50.0 / 60.0;
            Venus.MandaCircumference = 11.5;
            Venus.SighraCircumference = 261;

            // mars
            Mars.Rotation = Mars.YugaRotation;
            Mars.Sighra = Sun.YugaRotation;
            Mars.Apogee = 130 + 2.0 / 60.0;
            Mars.MandaCircumference = 73.5;
            Mars.SighraCircumference = 233.5;

            // jupiter
            Jupiter.Rotation = Jupiter.YugaRotation;
            Jupiter.Sighra = Sun.YugaRotation;
            Jupiter.Apogee = 171 + 18.0 / 60.0;
            Jupiter.MandaCircumference = 32.5;
            Jupiter.SighraCircumference = 71;

            // saturn
            Saturn.Rotation = Saturn.YugaRotation;
            Saturn.Sighra = Sun.YugaRotation;
            Saturn.Apogee = 236 + 37.0 / 60.0;
            Saturn.MandaCircumference = 48.5;
            Saturn.SighraCircumference = 39.5;

            // Candrocca
            Candrocca.Rotation = Candrocca.YugaRotation;
            Candrocca.Sighra = 0;
            Candrocca.Apogee = 0;
            Candrocca.MandaCircumference = 0;
            Candrocca.SighraCircumference = 0;

            // Rahu
            Rahu.Rotation = Rahu.YugaRotation;
            Rahu.Sighra = 0;
            Rahu.Apogee = 0;
            Rahu.MandaCircumference = 0;
            Rahu.SighraCircumference = 0;
        }
        
    }
}