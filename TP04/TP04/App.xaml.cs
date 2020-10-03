﻿using System;
using TP04.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP04
{
    public partial class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = new NavigationPage(new MainPage());
        }
        static Aluno alunoModel;
        public static Aluno AlunoModel
        {
            get
            {
                if (alunoModel == null)
                {
                    alunoModel = new Aluno();
                }
                return alunoModel;
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
