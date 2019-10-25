using NUnit.Framework;
using RoleplayGame.Items;
using RoleplayGame.Characters;
using System;

namespace RoleplayGame.Library.Test
{
    public class Elfo
    {
        [Test]
        public void TestSacarItemQueNoTiene()
        {
            try
            {
                string nombre = "elfo";
                Elf elf = new Elf(nombre);
                Magic magic = new Magic();
                elf.RemoveItem(magic);
            }
            catch(Exception ex)
            {
                Assert.IsTrue(ex is ItemNotFoundException);
            }
            
        }
    }
}