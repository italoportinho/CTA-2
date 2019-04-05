using System;
using CTA.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CTA.Tests.ViewModel
{
    [TestClass]
    public class RegisterViewModelTest
    {
        [TestMethod]
        public void ValidaEmail()
        {
            RegisterViewModel register = new RegisterViewModel()
            {
                Email = "lalala",
                Password = "teste",
                ConfirmPassword = "teste"
            };

            
        }
    }
}
