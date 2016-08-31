Imports System.Web.Optimization

Public Class Global_asax
    Inherits HttpApplication
    'this is getting even beter

    Sub Application_Start(sender As Object, e As EventArgs)
        ' Fires when the application is started
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)
    End Sub
End Class