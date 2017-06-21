namespace Sitecore.Support.sitecore.login
{
  using Sitecore.Web.Authentication;
  using System;
  public class Default : Sitecore.sitecore.login.Default
  {
    protected override void OnInit(EventArgs e)
    {
      #region Added code
      if (!Sitecore.Context.User.IsAuthenticated || DomainAccessGuard.GetAccess())
      {
        base.Response.Headers.Add("finalURL", Globals.ServerUrl + Sitecore.Context.RawUrl);
      } 
      #endregion
      base.OnInit(e);
    }
  }
}