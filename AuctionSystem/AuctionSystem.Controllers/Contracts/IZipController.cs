﻿namespace AuctionSystem.Controllers.Contracts
{
    using Models;

    public interface IZipController
    {
        void AddZip(Zip zip);

        bool IsZipExisting(Zip zip);

        bool UpdateZip(Zip zip, string property, string value);

        Zip GetZipByZipCode(string zipCode);
    }
}