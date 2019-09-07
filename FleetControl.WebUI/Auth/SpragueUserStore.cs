using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

namespace FleetControl.WebUI.Auth
{
    public class SpragueUserStore : UserStore
    {
        public SpragueUserStore(DbContext context, IdentityErrorDescriber describer = null) : base(context, describer)
        {
        }

        public override IQueryable<IdentityUser<string>> Users => base.Users;

        public override Task AddClaimsAsync(IdentityUser<string> user, IEnumerable<Claim> claims, CancellationToken cancellationToken = default)
        {
            return base.AddClaimsAsync(user, claims, cancellationToken);
        }

        public override Task AddLoginAsync(IdentityUser<string> user, UserLoginInfo login, CancellationToken cancellationToken = default)
        {
            return base.AddLoginAsync(user, login, cancellationToken);
        }

        public override Task AddToRoleAsync(IdentityUser<string> user, string normalizedRoleName, CancellationToken cancellationToken = default)
        {
            return base.AddToRoleAsync(user, normalizedRoleName, cancellationToken);
        }

        public override string ConvertIdFromString(string id)
        {
            return base.ConvertIdFromString(id);
        }

        public override string ConvertIdToString(string id)
        {
            return base.ConvertIdToString(id);
        }

        public override Task<int> CountCodesAsync(IdentityUser<string> user, CancellationToken cancellationToken)
        {
            return base.CountCodesAsync(user, cancellationToken);
        }

        public override Task<IdentityResult> CreateAsync(IdentityUser<string> user, CancellationToken cancellationToken = default)
        {
            return base.CreateAsync(user, cancellationToken);
        }

        public override Task<IdentityResult> DeleteAsync(IdentityUser<string> user, CancellationToken cancellationToken = default)
        {
            return base.DeleteAsync(user, cancellationToken);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override Task<IdentityUser<string>> FindByEmailAsync(string normalizedEmail, CancellationToken cancellationToken = default)
        {
            return base.FindByEmailAsync(normalizedEmail, cancellationToken);
        }

        public override Task<IdentityUser<string>> FindByIdAsync(string userId, CancellationToken cancellationToken = default)
        {
            return base.FindByIdAsync(userId, cancellationToken);
        }

        public override Task<IdentityUser<string>> FindByLoginAsync(string loginProvider, string providerKey, CancellationToken cancellationToken = default)
        {
            return base.FindByLoginAsync(loginProvider, providerKey, cancellationToken);
        }

        public override Task<IdentityUser<string>> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken = default)
        {
            return base.FindByNameAsync(normalizedUserName, cancellationToken);
        }

        public override Task<int> GetAccessFailedCountAsync(IdentityUser<string> user, CancellationToken cancellationToken = default)
        {
            return base.GetAccessFailedCountAsync(user, cancellationToken);
        }

        public override Task<string> GetAuthenticatorKeyAsync(IdentityUser<string> user, CancellationToken cancellationToken)
        {
            return base.GetAuthenticatorKeyAsync(user, cancellationToken);
        }

        public override Task<IList<Claim>> GetClaimsAsync(IdentityUser<string> user, CancellationToken cancellationToken = default)
        {
            return base.GetClaimsAsync(user, cancellationToken);
        }

        public override Task<string> GetEmailAsync(IdentityUser<string> user, CancellationToken cancellationToken = default)
        {
            return base.GetEmailAsync(user, cancellationToken);
        }

        public override Task<bool> GetEmailConfirmedAsync(IdentityUser<string> user, CancellationToken cancellationToken = default)
        {
            return base.GetEmailConfirmedAsync(user, cancellationToken);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override Task<bool> GetLockoutEnabledAsync(IdentityUser<string> user, CancellationToken cancellationToken = default)
        {
            return base.GetLockoutEnabledAsync(user, cancellationToken);
        }

        public override Task<DateTimeOffset?> GetLockoutEndDateAsync(IdentityUser<string> user, CancellationToken cancellationToken = default)
        {
            return base.GetLockoutEndDateAsync(user, cancellationToken);
        }

        public override Task<IList<UserLoginInfo>> GetLoginsAsync(IdentityUser<string> user, CancellationToken cancellationToken = default)
        {
            return base.GetLoginsAsync(user, cancellationToken);
        }

        public override Task<string> GetNormalizedEmailAsync(IdentityUser<string> user, CancellationToken cancellationToken = default)
        {
            return base.GetNormalizedEmailAsync(user, cancellationToken);
        }

        public override Task<string> GetNormalizedUserNameAsync(IdentityUser<string> user, CancellationToken cancellationToken = default)
        {
            return base.GetNormalizedUserNameAsync(user, cancellationToken);
        }

        public override Task<string> GetPasswordHashAsync(IdentityUser<string> user, CancellationToken cancellationToken = default)
        {
            return base.GetPasswordHashAsync(user, cancellationToken);
        }

        public override Task<string> GetPhoneNumberAsync(IdentityUser<string> user, CancellationToken cancellationToken = default)
        {
            return base.GetPhoneNumberAsync(user, cancellationToken);
        }

        public override Task<bool> GetPhoneNumberConfirmedAsync(IdentityUser<string> user, CancellationToken cancellationToken = default)
        {
            return base.GetPhoneNumberConfirmedAsync(user, cancellationToken);
        }

        public override Task<IList<string>> GetRolesAsync(IdentityUser<string> user, CancellationToken cancellationToken = default)
        {
            return base.GetRolesAsync(user, cancellationToken);
        }

        public override Task<string> GetSecurityStampAsync(IdentityUser<string> user, CancellationToken cancellationToken = default)
        {
            return base.GetSecurityStampAsync(user, cancellationToken);
        }

        public override Task<string> GetTokenAsync(IdentityUser<string> user, string loginProvider, string name, CancellationToken cancellationToken)
        {
            return base.GetTokenAsync(user, loginProvider, name, cancellationToken);
        }

        public override Task<bool> GetTwoFactorEnabledAsync(IdentityUser<string> user, CancellationToken cancellationToken = default)
        {
            return base.GetTwoFactorEnabledAsync(user, cancellationToken);
        }

        public override Task<string> GetUserIdAsync(IdentityUser<string> user, CancellationToken cancellationToken = default)
        {
            return base.GetUserIdAsync(user, cancellationToken);
        }

        public override Task<string> GetUserNameAsync(IdentityUser<string> user, CancellationToken cancellationToken = default)
        {
            return base.GetUserNameAsync(user, cancellationToken);
        }

        public override Task<IList<IdentityUser<string>>> GetUsersForClaimAsync(Claim claim, CancellationToken cancellationToken = default)
        {
            return base.GetUsersForClaimAsync(claim, cancellationToken);
        }

        public override Task<IList<IdentityUser<string>>> GetUsersInRoleAsync(string normalizedRoleName, CancellationToken cancellationToken = default)
        {
            return base.GetUsersInRoleAsync(normalizedRoleName, cancellationToken);
        }

        public override Task<bool> HasPasswordAsync(IdentityUser<string> user, CancellationToken cancellationToken = default)
        {
            return base.HasPasswordAsync(user, cancellationToken);
        }

        public override Task<int> IncrementAccessFailedCountAsync(IdentityUser<string> user, CancellationToken cancellationToken = default)
        {
            return base.IncrementAccessFailedCountAsync(user, cancellationToken);
        }

        public override Task<bool> IsInRoleAsync(IdentityUser<string> user, string normalizedRoleName, CancellationToken cancellationToken = default)
        {
            return base.IsInRoleAsync(user, normalizedRoleName, cancellationToken);
        }

        public override Task<bool> RedeemCodeAsync(IdentityUser<string> user, string code, CancellationToken cancellationToken)
        {
            return base.RedeemCodeAsync(user, code, cancellationToken);
        }

        public override Task RemoveClaimsAsync(IdentityUser<string> user, IEnumerable<Claim> claims, CancellationToken cancellationToken = default)
        {
            return base.RemoveClaimsAsync(user, claims, cancellationToken);
        }

        public override Task RemoveFromRoleAsync(IdentityUser<string> user, string normalizedRoleName, CancellationToken cancellationToken = default)
        {
            return base.RemoveFromRoleAsync(user, normalizedRoleName, cancellationToken);
        }

        public override Task RemoveLoginAsync(IdentityUser<string> user, string loginProvider, string providerKey, CancellationToken cancellationToken = default)
        {
            return base.RemoveLoginAsync(user, loginProvider, providerKey, cancellationToken);
        }

        public override Task RemoveTokenAsync(IdentityUser<string> user, string loginProvider, string name, CancellationToken cancellationToken)
        {
            return base.RemoveTokenAsync(user, loginProvider, name, cancellationToken);
        }

        public override Task ReplaceClaimAsync(IdentityUser<string> user, Claim claim, Claim newClaim, CancellationToken cancellationToken = default)
        {
            return base.ReplaceClaimAsync(user, claim, newClaim, cancellationToken);
        }

        public override Task ReplaceCodesAsync(IdentityUser<string> user, IEnumerable<string> recoveryCodes, CancellationToken cancellationToken)
        {
            return base.ReplaceCodesAsync(user, recoveryCodes, cancellationToken);
        }

        public override Task ResetAccessFailedCountAsync(IdentityUser<string> user, CancellationToken cancellationToken = default)
        {
            return base.ResetAccessFailedCountAsync(user, cancellationToken);
        }

        public override Task SetAuthenticatorKeyAsync(IdentityUser<string> user, string key, CancellationToken cancellationToken)
        {
            return base.SetAuthenticatorKeyAsync(user, key, cancellationToken);
        }

        public override Task SetEmailAsync(IdentityUser<string> user, string email, CancellationToken cancellationToken = default)
        {
            return base.SetEmailAsync(user, email, cancellationToken);
        }

        public override Task SetEmailConfirmedAsync(IdentityUser<string> user, bool confirmed, CancellationToken cancellationToken = default)
        {
            return base.SetEmailConfirmedAsync(user, confirmed, cancellationToken);
        }

        public override Task SetLockoutEnabledAsync(IdentityUser<string> user, bool enabled, CancellationToken cancellationToken = default)
        {
            return base.SetLockoutEnabledAsync(user, enabled, cancellationToken);
        }

        public override Task SetLockoutEndDateAsync(IdentityUser<string> user, DateTimeOffset? lockoutEnd, CancellationToken cancellationToken = default)
        {
            return base.SetLockoutEndDateAsync(user, lockoutEnd, cancellationToken);
        }

        public override Task SetNormalizedEmailAsync(IdentityUser<string> user, string normalizedEmail, CancellationToken cancellationToken = default)
        {
            return base.SetNormalizedEmailAsync(user, normalizedEmail, cancellationToken);
        }

        public override Task SetNormalizedUserNameAsync(IdentityUser<string> user, string normalizedName, CancellationToken cancellationToken = default)
        {
            return base.SetNormalizedUserNameAsync(user, normalizedName, cancellationToken);
        }

        public override Task SetPasswordHashAsync(IdentityUser<string> user, string passwordHash, CancellationToken cancellationToken = default)
        {
            return base.SetPasswordHashAsync(user, passwordHash, cancellationToken);
        }

        public override Task SetPhoneNumberAsync(IdentityUser<string> user, string phoneNumber, CancellationToken cancellationToken = default)
        {
            return base.SetPhoneNumberAsync(user, phoneNumber, cancellationToken);
        }

        public override Task SetPhoneNumberConfirmedAsync(IdentityUser<string> user, bool confirmed, CancellationToken cancellationToken = default)
        {
            return base.SetPhoneNumberConfirmedAsync(user, confirmed, cancellationToken);
        }

        public override Task SetSecurityStampAsync(IdentityUser<string> user, string stamp, CancellationToken cancellationToken = default)
        {
            return base.SetSecurityStampAsync(user, stamp, cancellationToken);
        }

        public override Task SetTokenAsync(IdentityUser<string> user, string loginProvider, string name, string value, CancellationToken cancellationToken)
        {
            return base.SetTokenAsync(user, loginProvider, name, value, cancellationToken);
        }

        public override Task SetTwoFactorEnabledAsync(IdentityUser<string> user, bool enabled, CancellationToken cancellationToken = default)
        {
            return base.SetTwoFactorEnabledAsync(user, enabled, cancellationToken);
        }

        public override Task SetUserNameAsync(IdentityUser<string> user, string userName, CancellationToken cancellationToken = default)
        {
            return base.SetUserNameAsync(user, userName, cancellationToken);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override Task<IdentityResult> UpdateAsync(IdentityUser<string> user, CancellationToken cancellationToken = default)
        {
            return base.UpdateAsync(user, cancellationToken);
        }

        protected override Task AddUserTokenAsync(IdentityUserToken<string> token)
        {
            return base.AddUserTokenAsync(token);
        }

        protected override IdentityUserClaim<string> CreateUserClaim(IdentityUser<string> user, Claim claim)
        {
            return base.CreateUserClaim(user, claim);
        }

        protected override IdentityUserLogin<string> CreateUserLogin(IdentityUser<string> user, UserLoginInfo login)
        {
            return base.CreateUserLogin(user, login);
        }

        protected override IdentityUserRole<string> CreateUserRole(IdentityUser<string> user, IdentityRole role)
        {
            return base.CreateUserRole(user, role);
        }

        protected override IdentityUserToken<string> CreateUserToken(IdentityUser<string> user, string loginProvider, string name, string value)
        {
            return base.CreateUserToken(user, loginProvider, name, value);
        }

        protected override Task<IdentityRole> FindRoleAsync(string normalizedRoleName, CancellationToken cancellationToken)
        {
            return base.FindRoleAsync(normalizedRoleName, cancellationToken);
        }

        protected override Task<IdentityUserToken<string>> FindTokenAsync(IdentityUser<string> user, string loginProvider, string name, CancellationToken cancellationToken)
        {
            return base.FindTokenAsync(user, loginProvider, name, cancellationToken);
        }

        protected override Task<IdentityUser<string>> FindUserAsync(string userId, CancellationToken cancellationToken)
        {
            return base.FindUserAsync(userId, cancellationToken);
        }

        protected override Task<IdentityUserLogin<string>> FindUserLoginAsync(string userId, string loginProvider, string providerKey, CancellationToken cancellationToken)
        {
            return base.FindUserLoginAsync(userId, loginProvider, providerKey, cancellationToken);
        }

        protected override Task<IdentityUserLogin<string>> FindUserLoginAsync(string loginProvider, string providerKey, CancellationToken cancellationToken)
        {
            return base.FindUserLoginAsync(loginProvider, providerKey, cancellationToken);
        }

        protected override Task<IdentityUserRole<string>> FindUserRoleAsync(string userId, string roleId, CancellationToken cancellationToken)
        {
            return base.FindUserRoleAsync(userId, roleId, cancellationToken);
        }

        protected override Task RemoveUserTokenAsync(IdentityUserToken<string> token)
        {
            return base.RemoveUserTokenAsync(token);
        }
    }
}
