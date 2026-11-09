# django/contrib/auth/urls

- Subject: django/contrib/auth/urls (id `2b090dfe-a95c-4808-a88d-546238b8fcb7`)
- Kind: subject
- Budget: 1200 tokens
- Used: 288 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- # The views used below are normally mapped in the AdminSite instance. # This URLs file is used to provide a reliable view deployment for test # purposes. It is also provided as a convenience to those who want to deploy # these URLs elsewhere. [7b7bce8c]
- from django.contrib.auth import views from django.urls import path [7ad43aa1]
- urlpatterns = [ path("login/", views.LoginView.as_view(), name="login"), path("logout/", views.LogoutView.as_view(), name="logout"), path( "password_change/", views.PasswordChangeView.as_view(), name="password_change" ), path( "password_change/done/", views.PasswordChangeDoneView.as_view(), name="password_change_done", ), path("password_reset/", views.PasswordResetView.as_view(), name="password_reset"), path( "password_reset/done/", views.PasswordResetDoneView.as_view(), name="password_reset_done", ), path( "reset/<uidb64>/<token>/", views.PasswordResetConfirmView.as_view(), name="password_reset_confirm", ), path( "reset/done/", views.PasswordResetCompleteView.as_view(), name="password_reset_complete", ), ] [9108f3cc]
