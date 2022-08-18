﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorCrud.Shared.Models;


namespace BlazorCrud.Server.Interface
{
    public interface IDataAccessProvider
    {
        void AddPatientRecord(Patient patient);
        void UpdatePatientRecord(Patient patient);
        void DeletePatientRecord(int id);
        Patient GetPatientSingleRecord(int id);
        List<Patient> GetPatientRecords();
    }
}
