﻿using System.Collections.ObjectModel;
using Microsoft.Expression.Interactivity.Core;
using SleepWatcher.Entites;

namespace SleepWatcher.ViewModel.PatientViewModel
{
    public interface ISinglePatientViewModel : IViewModelBase
    {
        Patient Patient { get; set; }
        Step SelectedStep { get; set; }
        Note SelectedNote { get; set; }
        ActionCommand SwitchToAddPatientViewModelCommand { get; }
        ActionCommand AddNewNoteCommand { get; }
        ActionCommand MarkCompleteCommand { get; }
        ActionCommand MarkCanceledCommand { get; }
        ActionCommand ClearView { get; }
        ObservableCollection<Step> Steps { get; set; }
        ObservableCollection<Note> Notes { get; set; }
        ActionCommand MarkUnCanceledCommand { get; }
    }
}