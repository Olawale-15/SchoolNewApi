﻿namespace SchoolNewApi.DTOs
{
    public class UpdateStudentRequestModel
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Address { get; set; } = default!;
    }
}