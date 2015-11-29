//  --------------------------------
//  <copyright file="Planet.cs" >
//      Copyright (c) 2015 All rights reserved.
//  </copyright>
//  <author>Alleshouse, Dale</author>
//  <date>11/29/2015</date>
//  ---------------------------------
namespace DomainC
{
    public class Planet
    {
        public Planet(
            string name,
            decimal massKg,
            decimal equatorialDiameterKm,
            decimal polarDiameterKm,
            decimal equatorialCircumferenceKm,
            decimal orbitalDistanceKm,
            decimal orbitPeriodEarthDays,
            decimal minSurfaceTemperatureCelsius,
            decimal maxSurfaceTemperatureCelsius)
        {
            this.Name = name;
            this.MassKg = massKg;
            this.EquatorialDiameterKm = equatorialDiameterKm;
            this.PolarDiameterKm = polarDiameterKm;
            this.EquatorialCircumferenceKm = equatorialCircumferenceKm;
            this.OrbitalDistanceKm = orbitalDistanceKm;
            this.OrbitPeriodEarthDays = orbitPeriodEarthDays;
            this.MinSurfaceTemperatureCelsius = minSurfaceTemperatureCelsius;
            this.MaxSurfaceTemperatureCelsius = maxSurfaceTemperatureCelsius;
        }

        public string Name { get; }

        public decimal MassKg { get; }

        public decimal EquatorialDiameterKm { get; }

        public decimal PolarDiameterKm { get; }

        public decimal EquatorialCircumferenceKm { get; }

        public decimal OrbitalDistanceKm { get; }

        public decimal OrbitPeriodEarthDays { get; }

        public decimal MinSurfaceTemperatureCelsius { get; }

        public decimal MaxSurfaceTemperatureCelsius { get; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            return obj.GetType() == this.GetType() && this.Equals((Planet)obj);
        }


        protected bool Equals(Planet other)
            =>
                string.Equals(this.Name, other.Name) && this.MassKg == other.MassKg && this.EquatorialDiameterKm == other.EquatorialDiameterKm
                && this.PolarDiameterKm == other.PolarDiameterKm && this.EquatorialCircumferenceKm == other.EquatorialCircumferenceKm
                && this.OrbitalDistanceKm == other.OrbitalDistanceKm && this.OrbitPeriodEarthDays == other.OrbitPeriodEarthDays
                && this.MinSurfaceTemperatureCelsius == other.MinSurfaceTemperatureCelsius && this.MaxSurfaceTemperatureCelsius == other.MaxSurfaceTemperatureCelsius;

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (this.Name?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ this.MassKg.GetHashCode();
                hashCode = (hashCode * 397) ^ this.EquatorialDiameterKm.GetHashCode();
                hashCode = (hashCode * 397) ^ this.PolarDiameterKm.GetHashCode();
                hashCode = (hashCode * 397) ^ this.EquatorialCircumferenceKm.GetHashCode();
                hashCode = (hashCode * 397) ^ this.OrbitalDistanceKm.GetHashCode();
                hashCode = (hashCode * 397) ^ this.OrbitPeriodEarthDays.GetHashCode();
                hashCode = (hashCode * 397) ^ this.MinSurfaceTemperatureCelsius.GetHashCode();
                hashCode = (hashCode * 397) ^ this.MaxSurfaceTemperatureCelsius.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator ==(Planet left, Planet right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Planet left, Planet right)
        {
            return !Equals(left, right);
        }
    }
}