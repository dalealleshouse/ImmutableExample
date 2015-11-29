//  --------------------------------
//  <copyright file="UnitTest1.cs" >
//      Copyright (c) 2015 All rights reserved.
//  </copyright>
//  <author>Alleshouse, Dale</author>
//  <date>11/29/2015</date>
//  ---------------------------------

namespace Domain.Tests
{
    using DomainC;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PlanetDomainCShould
    {
        [TestMethod]
        public void BeUnEqualForObjectsWithDifferentValues()
        {
            var p1 = new Planet(
                name: "Mercury",
                massKg: 328500000000000000000000M,
                equatorialDiameterKm: 4879,
                polarDiameterKm: 4879,
                equatorialCircumferenceKm: 15329,
                orbitalDistanceKm: 57909227,
                orbitPeriodEarthDays: 87.97M,
                minSurfaceTemperatureCelsius: -173,
                maxSurfaceTemperatureCelsius: 427);

            var p2 = new Planet(
                name: "Venus",
                massKg: 4867000000000000000000000M,
                equatorialDiameterKm: 12104,
                polarDiameterKm: 12104,
                equatorialCircumferenceKm: 38025,
                orbitalDistanceKm: 108209475,
                orbitPeriodEarthDays: 224.70M,
                minSurfaceTemperatureCelsius: 462,
                maxSurfaceTemperatureCelsius: 462);

            Assert.IsFalse(p1.Equals(p2));
            Assert.IsFalse(p2.Equals(p1));
        }

        [TestMethod]
        public void BeEqualForObjectsWithSameValues()
        {
            var p1 = new Planet(
                name: "Mercury",
                massKg: 328500000000000000000000M,
                equatorialDiameterKm: 4879,
                polarDiameterKm: 4879,
                equatorialCircumferenceKm: 15329,
                orbitalDistanceKm: 57909227,
                orbitPeriodEarthDays: 87.97M,
                minSurfaceTemperatureCelsius: -173,
                maxSurfaceTemperatureCelsius: 427);

            var p2 = new Planet(
                name: "Mercury",
                massKg: 328500000000000000000000M,
                equatorialDiameterKm: 4879,
                polarDiameterKm: 4879,
                equatorialCircumferenceKm: 15329,
                orbitalDistanceKm: 57909227,
                orbitPeriodEarthDays: 87.97M,
                minSurfaceTemperatureCelsius: -173,
                maxSurfaceTemperatureCelsius: 427);

            Assert.IsTrue(p1.Equals(p2));
            Assert.IsTrue(p2.Equals(p1));
        }
    }
}