using System;
using System.Data;
using CampusLostAndFound.DAL;

namespace CampusLostAndFound.BLL
{
    public class clsClaim
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ClaimID { get; set; }
        public int ItemID { get; set; }
        public string ClaimantName { get; set; }
        public string Phone { get; set; }
        public string VerificationResult { get; set; }
        public string ClaimStatus { get; set; } // "Pending", "Approved", "Rejected"
        public int CreatedBy { get; set; }

        public clsClaim()
        {
            this.ClaimID = -1;
            this.ItemID = -1;
            this.ClaimantName = "";
            this.Phone = "";
            this.VerificationResult = "";
            this.ClaimStatus = "Pending";
            this.CreatedBy = -1;
            this.Mode = enMode.AddNew;
        }

        private clsClaim(int claimID, int itemID, string claimantName, string phone,
            string verificationResult, string claimStatus, int createdBy)
        {
            this.ClaimID = claimID;
            this.ItemID = itemID;
            this.ClaimantName = claimantName;
            this.Phone = phone;
            this.VerificationResult = verificationResult;
            this.ClaimStatus = claimStatus;
            this.CreatedBy = createdBy;
            this.Mode = enMode.Update;
        }

        public static clsClaim Find(int claimID)
        {
            int itemID = -1, createdBy = -1;
            string claimantName = "", phone = "", verificationResult = "", claimStatus = "";

            if (clsClaimDataAccess.GetClaimInfoByID(claimID, ref itemID, ref claimantName,
                ref phone, ref verificationResult, ref claimStatus, ref createdBy))
            {
                return new clsClaim(claimID, itemID, claimantName, phone, verificationResult, claimStatus, createdBy);
            }
            return null;
        }

        private bool _AddNewClaim()
        {
            this.ClaimID = clsClaimDataAccess.AddNewClaim(this.ItemID, this.ClaimantName,
                this.Phone, this.VerificationResult, this.ClaimStatus, this.CreatedBy);
            return (this.ClaimID != -1);
        }

        private bool _UpdateClaim()
        {
            return clsClaimDataAccess.UpdateClaim(this.ClaimID, this.ItemID, this.ClaimantName,
                this.Phone, this.VerificationResult, this.ClaimStatus);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewClaim())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateClaim();
            }
            return false;
        }

        public bool Approve(string verificationNotes = "")
        {
            // Prevent approving if another claim for this item is already approved
            if (this.ItemID != -1 && clsClaimDataAccess.HasApprovedClaimForItem(this.ItemID))
                return false;

            this.ClaimStatus = "Approved";
            if (!string.IsNullOrWhiteSpace(verificationNotes))
                this.VerificationResult = verificationNotes;

            if (this.Save())
            {
                // Automatically update linked Item status to "Claimed"
                clsItem item = clsItem.Find(this.ItemID);
                if (item != null)
                {
                    item.Status = "Claimed";
                    item.Save();
                }
                return true;
            }
            return false;
        }

        public bool Reject(string rejectionReason = "")
        {
            this.ClaimStatus = "Rejected";
            if (!string.IsNullOrWhiteSpace(rejectionReason))
                this.VerificationResult = rejectionReason;

            return this.Save();
        }

        public static bool DeleteClaim(int claimID)
        {
            return clsClaimDataAccess.DeleteClaim(claimID);
        }

        public static DataTable GetAllClaims()
        {
            return clsClaimDataAccess.GetAllClaims();
        }

        public static bool HasActiveClaimForItem(int itemID)
        {
            return clsClaimDataAccess.HasActiveClaimForItem(itemID);
        }
    }
}