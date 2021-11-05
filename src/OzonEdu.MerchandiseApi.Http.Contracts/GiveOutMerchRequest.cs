﻿using CSharpCourse.Core.Lib.Enums;

namespace OzonEdu.MerchandiseApi.Http.Contracts
{
    public sealed class GiveOutMerchRequest
    {
        // TODO: что будет на входе через rest api? employeeId или employeeEmail+employeeName?
        //public long EmployeeId { get; set; }

        public string EmployeeEmail { get; set; }

        public string EmployeeName { get; set; }

        public MerchType MerchType { get; set; }
    }
}
