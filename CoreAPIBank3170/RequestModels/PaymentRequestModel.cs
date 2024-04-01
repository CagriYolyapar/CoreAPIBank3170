﻿namespace CoreAPIBank3170.RequestModels
{
    public class PaymentRequestModel
    {
        public string CardNumber { get; set; }
        public string CardUserName { get; set; }
        public string CCV { get; set; }
        public int ExpiryYear { get; set; }
        public int ExpiryMonth { get; set; }
        public decimal ShoppingPrice { get; set; }
    }
}
