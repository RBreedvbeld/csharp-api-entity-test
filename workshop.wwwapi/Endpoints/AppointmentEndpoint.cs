﻿using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using workshop.wwwapi.DTO;
using workshop.wwwapi.Models;
using workshop.wwwapi.Repository;
using static workshop.wwwapi.Endpoints.PatientEndpoints;

namespace workshop.wwwapi.Endpoints
{
    public static class AppointmentEndpoint
    {
        public record CreateAppointmentPayload(DateTime Booking, int PatientId, int DoctorId);

        public static void ConfigurationAppointmentEndpoint(this WebApplication app)
        {
            var bookings = app.MapGroup("bookings");

            bookings.MapPost("/createappointment", CreateAppointment);
        }



        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> CreateAppointment(CreateAppointmentPayload payload, IAppointmentRepository IRepository)
        {
           /* if (payload.PatientId == null || payload.DoctorId == null)
            {
                return Results.BadRequest("All fields are required!");
            }
*/
         /*   Patient? patient = await IRepository.GetPatients();
            if (patient == null)
            {
                return Results.NotFound("Patient not found.");
            }*/
            Appointment? appointment = await IRepository.CreateAppointment(payload.Booking, payload.PatientId , payload.DoctorId);
            if (appointment == null) return TypedResults.BadRequest("All fields are required!");
            return TypedResults.Ok(AppointmentResponseDTO.FromRepository(appointment));
        }
    }
}