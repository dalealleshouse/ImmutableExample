//  --------------------------------
//  <copyright file="Planets.cs" >
//      Copyright (c) 2015 All rights reserved.
//  </copyright>
//  <author>Alleshouse, Dale</author>
//  <date>11/29/2015</date>
//  ---------------------------------

namespace PlanetRepository
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    using DomainF;

    public class PlanetRepository
    {
        static readonly Lazy<IEnumerable<Planet>> LazyPlanets = new Lazy<IEnumerable<Planet>>(BuildPlanets);

        public IEnumerable<Planet> Planets() => LazyPlanets.Value;

        static IEnumerable<Planet> BuildPlanets()
            =>
                new ReadOnlyCollection<Planet>(
                    new[]
                        {
                            new Planet(
                                name: "Mercury",
                                massKg: 328500000000000000000000M,
                                equatorialDiameterKm: 4879,
                                polarDiameterKm: 4879,
                                equatorialCircumferenceKm: 15329,
                                orbitalDistanceKm: 57909227,
                                orbitPeriodEarthDays: 87.97M,
                                minSurfaceTemperatureCelsius: -173,
                                maxSurfaceTemperatureCelsius: 427),
                            new Planet(
                                name: "Venus",
                                massKg: 4867000000000000000000000M,
                                equatorialDiameterKm: 12104,
                                polarDiameterKm: 12104,
                                equatorialCircumferenceKm: 38025,
                                orbitalDistanceKm: 108209475,
                                orbitPeriodEarthDays: 224.70M,
                                minSurfaceTemperatureCelsius: 462,
                                maxSurfaceTemperatureCelsius: 462),
                            new Planet(
                                name: "Earth",
                                massKg: 5972000000000000000000000M,
                                equatorialDiameterKm: 12756,
                                polarDiameterKm: 12714,
                                equatorialCircumferenceKm: 40030,
                                orbitalDistanceKm: 149598262,
                                orbitPeriodEarthDays: 365.26M,
                                minSurfaceTemperatureCelsius: -88,
                                maxSurfaceTemperatureCelsius: 58),
                            new Planet(
                                name: "Mars",
                                massKg: 639000000000000000000000M,
                                equatorialDiameterKm: 6805,
                                polarDiameterKm: 6755,
                                equatorialCircumferenceKm: 21297,
                                orbitalDistanceKm: 227943824,
                                orbitPeriodEarthDays: 686.98M,
                                minSurfaceTemperatureCelsius: -87,
                                maxSurfaceTemperatureCelsius: -5),
                            new Planet(
                                name: "Jupiter",
                                massKg: 1898130000000000000000000000M,
                                equatorialDiameterKm: 142984,
                                polarDiameterKm: 133709,
                                equatorialCircumferenceKm: 439264,
                                orbitalDistanceKm: 778340821,
                                orbitPeriodEarthDays: 4332.82M,
                                minSurfaceTemperatureCelsius: -108,
                                maxSurfaceTemperatureCelsius: -108),
                            new Planet(
                                name: "Saturn",
                                massKg: 568300000000000000000000000M,
                                equatorialDiameterKm: 120536,
                                polarDiameterKm: 108728,
                                equatorialCircumferenceKm: 365882,
                                orbitalDistanceKm: 1426666422,
                                orbitPeriodEarthDays: 10755.70M,
                                minSurfaceTemperatureCelsius: -139,
                                maxSurfaceTemperatureCelsius: -139),
                            new Planet(
                                name: "Uranus",
                                massKg: 86810000000000000000000000M,
                                equatorialDiameterKm: 51118,
                                polarDiameterKm: 49946,
                                equatorialCircumferenceKm: 159354,
                                orbitalDistanceKm: 2870658186,
                                orbitPeriodEarthDays: 30687.15M,
                                minSurfaceTemperatureCelsius: -197,
                                maxSurfaceTemperatureCelsius: -197),
                            new Planet(
                                name: "Neptune",
                                massKg: 102400000000000000000000000M,
                                equatorialDiameterKm: 49528,
                                polarDiameterKm: 48682,
                                equatorialCircumferenceKm: 155600,
                                orbitalDistanceKm: 4498396441,
                                orbitPeriodEarthDays: 60190.03M,
                                minSurfaceTemperatureCelsius: -201,
                                maxSurfaceTemperatureCelsius: -201),
                        });
    }

}