﻿using CSharpFunctionalExtensions;
using Hng.Application.Features.PaymentIntegrations.Paystack.Dtos.Responses;
using Hng.Domain.Enums;
using MediatR;

namespace Hng.Application.Features.PaymentIntegrations.Paystack.Dtos.Requests
{
    public class InitiateSubscriptionTransactionCommand : IRequest<Result<InitiateSubscriptionTransactionResponse>>
    {
        public string Email { get; set; }
        public decimal Amount { get; set; }
        public SubscriptionPlan Plan { get; set; }
        public SubscriptionFrequency Frequency { get; set; }
    }

    public record SubscriptionInitialized(Guid SubId, string Type = nameof(SubscriptionInitialized));
}