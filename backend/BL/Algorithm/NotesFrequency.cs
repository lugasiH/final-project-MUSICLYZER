using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Algorithm
{
   public class NotesFrequency
    {
        public const double C0 = 16.35;
        public const double CD0 = 17.32;
        public const double D0 = 18.35;
        public const double DD0 = 19.45;
        public const double E0 = 20.60;
        public const double F0 = 21.83;
        public const double FD0 = 23.12;
        public const double G0 = 24.50;
        public const double GD0 = 25.96;
        public const double A0 = 27.50;
        public const double AD0 = 29.14;
        public const double B0 = 30.87;

        public const double C1 = 32.70;
        public const double CD1 = 34.65;
        public const double D1 = 36.71;
        public const double DD1 = 38.89;
        public const double E1 = 41.20;
        public const double F1 = 43.65;
        public const double FD1 = 46.25;
        public const double G1 = 49.00;
        public const double GD1 = 51.91;
        public const double A1 = 55.00;
        public const double AD1 = 58.27;
        public const double B1 = 61.74;

        public const double C2 = 65.41;
        public const double CD2 = 69.30;
        public const double D2 = 73.42;
        public const double DD2 = 77.78;
        public const double E2 = 82.41;
        public const double F2 = 87.31;
        public const double FD2 = 92.50;
        public const double G2 = 98.00;
        public const double GD2 = 103.83;
        public const double A2 = 110.00;
        public const double AD2 = 116.54;
        public const double B2 = 123.47;

        public const double C3 = 130.81;
        public const double CD3 = 138.59;
        public const double D3 = 146.83;
        public const double DD3 = 155.56;
        public const double E3 = 164.81;
        public const double F3 = 174.61;
        public const double FD3 = 185.00;
        public const double G3 = 196.00;
        public const double GD3 = 207.65;
        public const double A3 = 220.00;
        public const double AD3 = 233.08;
        public const double B3 = 246.94;

        public const double C4 = 261.63;
        public const double CD4 = 277.18;
        public const double D4 = 293.66;
        public const double DD4 = 311.13;
        public const double E4 = 329.63;
        public const double F4 = 349.23;
        public const double FD4 = 369.99;
        public const double G4 = 392.00;
        public const double GD4 = 415.30;
        public const double A4 = 440.00;
        public const double AD4 = 466.16;
        public const double B4 = 493.88;

        public const double C5 = 523.25;
        public const double CD5 = 554.37;
        public const double D5 = 587.33;
        public const double DD5 = 622.25;
        public const double E5 = 659.25;
        public const double F5 = 698.46;
        public const double FD5 = 739.99;
        public const double G5 = 783.99;
        public const double GD5 = 830.61;
        public const double A5 = 880.00;
        public const double AD5 = 932.33;
        public const double B5 = 987.77;

        public const double C6 = 1046.50;
        public const double CD6 = 1108.73;
        public const double D6 = 1174.66;
        public const double DD6 = 1244.51;
        public const double E6 = 1318.51;
        public const double F6 = 1396.91;
        public const double FD6 = 1479.98;
        public const double G6 = 1567.98;
        public const double GD6 = 1661.22;
        public const double A6 = 1760.00;
        public const double AD6 = 1864.66;
        public const double B6 = 1975.53;

        public const double C7 = 2093.00;
        public const double CD7 = 2217.46;
        public const double D7 = 2349.32;
        public const double DD7 = 2489.02;
        public const double E7 = 2637.02;
        public const double F7 = 2793.83;
        public const double FD7 = 2959.96;
        public const double G7 = 3135.96;
        public const double GD7 = 3322.44;
        public const double A7 = 3520.00;
        public const double AD7 = 3729.31;
        public const double B7 = 3951.07;

        public const double C8 = 4186.01;
        public const double CD8 = 4434.92;
        public const double D8 = 4698.63;
        public const double DD8 = 4978.03;
        public const double E8 = 5274.04;
        public const double F8 = 5587.65;
        public const double FD8 = 5919.91;
        public const double G8 = 6271.93;
        public const double GD8 = 6644.88;
        public const double A8 = 7040.00;
        public const double AD8 = 7458.62;
        public const double B8 = 7902.13;
    }
}
