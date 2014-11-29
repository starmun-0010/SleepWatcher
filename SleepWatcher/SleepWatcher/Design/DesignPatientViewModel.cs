﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Expression.Interactivity.Core;
using SleepWatcher.Entites;
using SleepWatcher.ViewModel;
using SleepWatcher.ViewModel.PatientViewModel;

namespace SleepWatcher.Design
{
    public class DesignPatientViewModel :ViewModelBase, IPatientViewModel
    {
        public ObservableCollection<Patient> Patients { get; set; }
        public IViewModelBase CurrentViewModel { get; set; }

        public ActionCommand SwitchToAddPatientViewCommmand { get; set; }

        public Patient Patient { get; set; }

        public DesignPatientViewModel()
        {
            CurrentViewModel= new DesignSinglePatientViewModel();
            Patient = new Patient
            {
                FirstName = "Patient",
                LastName = "Kzam",
                Steps = new List<Step>() { new Step() { StepName = StepName.Approved } }
            };
         
            
            Patients = new ObservableCollection<Patient>
            {
                new Patient
                {
                    FirstName = "Patient",
                    LastName = "Kzam",
                    Steps = new List<Step>() {new Step() {StepName = StepName.Approved}}
                },
                 new Patient
                {
                    FirstName = "Patient",
                    LastName = "Kzam",
                    Steps = new List<Step>() {new Step() {StepName = StepName.Delivery, IsCancled=true}}
                },
                  new Patient
                {
                    FirstName = "Patient",
                    LastName = "Kzam",
                    Steps = new List<Step>() {new Step() {StepName = StepName.Approved, IsCompleted = true}}
                },
                  new Patient
                {
                    FirstName = "Patient",
                    LastName = "Kzam",
                    Steps = new List<Step>() {new Step() {StepName = StepName.Approved}}
                },
                 new Patient
                {
                    FirstName = "Patient",
                    LastName = "Kzam",
                    Steps = new List<Step>() {new Step() {StepName = StepName.Delivery, IsCancled=true}}
                },
                  new Patient
                {
                    FirstName = "Patient",
                    LastName = "Kzam",
                    Steps = new List<Step>() {new Step() {StepName = StepName.Approved, IsCompleted = true}}
                }
            };


        }

    }
}
