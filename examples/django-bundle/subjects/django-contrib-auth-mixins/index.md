# django/contrib/auth/mixins

- Subject: django/contrib/auth/mixins (id `0ab003c2-cb6f-4a5e-a3e8-95872c13a903`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1159 tokens
- Facts shown: 20 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- path = self.request.build_absolute_uri() resolved_login_url = resolve_url(self.get_login_url()) # If the login url is the same scheme and net location then use the # path as the "next" url. login_scheme, login_netloc = urlsplit(resolved_login_url)[:2] current_scheme, current_netloc = urlsplit(path)[:2] if (not login_scheme or login_scheme == current_scheme) and ( not login_netloc or login_netloc == current_netloc ): path = self.request.get_full_path() return redirect_to_login( path, resolved_login_url, self.get_redirect_field_name(), ) [82229837]
- def dispatch(self, request, *args, **kwargs): if not request.user.is_authenticated: return self.handle_no_permission() return super().dispatch(request, *args, **kwargs) [327205b7]
- def dispatch(self, request, *args, **kwargs): if not self.has_permission(): return self.handle_no_permission() return super().dispatch(request, *args, **kwargs) [bc66536e]
- def dispatch(self, request, *args, **kwargs): user_test_result = self.get_test_func()() if not user_test_result: return self.handle_no_permission() return super().dispatch(request, *args, **kwargs) [abb78718]
- def get_login_url(self): """ Override this method to override the login_url attribute. """ login_url = self.login_url or settings.LOGIN_URL if not login_url: raise ImproperlyConfigured( f"{self.__class__.__name__} is missing the login_url attribute. Define " f"{self.__class__.__name__}.login_url, settings.LOGIN_URL, or override " f"{self.__class__.__name__}.get_login_url()." ) return str(login_url) [30ef5a28]
- def get_permission_denied_message(self): """ Override this method to override the permission_denied_message attribute. """ return self.permission_denied_message [30547c62]
- def get_permission_required(self): """ Override this method to override the permission_required attribute. Must return an iterable. """ if self.permission_required is None: raise ImproperlyConfigured( f"{self.__class__.__name__} is missing the " f"permission_required attribute. Define " f"{self.__class__.__name__}.permission_required, or override " f"{self.__class__.__name__}.get_permission_required()." ) if isinstance(self.permission_required, str): perms = (self.permission_required,) else: perms = self.permission_required return perms [ade5fe4e]
- def get_redirect_field_name(self): """ Override this method to override the redirect_field_name attribute. """ return self.redirect_field_name [6ad13a09]
- def get_test_func(self): """ Override this method to use a different test_func method. """ return self.test_func [13476f27]
- def handle_no_permission(self): if self.raise_exception or self.request.user.is_authenticated: raise PermissionDenied(self.get_permission_denied_message()) [45e82ea8]
- def has_permission(self): """ Override this method to customize the way permissions are checked. """ perms = self.get_permission_required() return self.request.user.has_perms(perms) [be2edd22]
- def test_func(self): raise NotImplementedError( "{} is missing the implementation of the test_func() method.".format( self.__class__.__name__ ) ) [0d3589f3]
- login_url = None permission_denied_message = "" raise_exception = False redirect_field_name = REDIRECT_FIELD_NAME [d809d6d6]

## All facts

- [eb377127] permission_required = None
- [702f58e6] class AccessMixin: """ Abstract CBV mixin that gives access mixins the same customizable functionality. """
- [f346b335] class LoginRequiredMixin(AccessMixin): """Verify that the current user is authenticated."""
- [b88488bf] class PermissionRequiredMixin(AccessMixin): """Verify that the current user has all specified permissions."""
- [bdd8a75c] class UserPassesTestMixin(AccessMixin): """ Deny a request with a permission error if the test_func() method returns False. """
- [60b7900e] from django.conf import settings from django.contrib.auth import REDIRECT_FIELD_NAME from django.contrib.auth.views import redirect_to_login from django.core.exceptions import ImproperlyConfigured, PermissionDenied from django.shortcuts import resolve_url
- [de548eb6] from urllib.parse import urlsplit
