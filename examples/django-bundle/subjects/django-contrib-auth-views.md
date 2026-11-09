# django/contrib/auth/views

- Subject: django/contrib/auth/views (id `1958a101-1a21-4084-9afc-aa77d49d4109`)
- Kind: subject
- Budget: 1200 tokens
- Used: 888 tokens
- Facts shown: 11 of 49
- Conflicts: 0
- Gaps: 0

## Facts

- # Display the "Password reset unsuccessful" page. return self.render_to_response(self.get_context_data()) [0c24fd63]
- Optionally takes a request argument, allowing use outside class-based views. """ if request is None: request = self.request redirect_to = request.POST.get( self.redirect_field_name, request.GET.get(self.redirect_field_name) ) url_is_safe = url_has_allowed_host_and_scheme( url=redirect_to, allowed_hosts=self.get_success_url_allowed_hosts(request), require_https=request.is_secure(), ) return redirect_to if url_is_safe else "" [c5c992fb]
- if self.user is not None: token = kwargs["token"] if token == self.reset_url_token: session_token = self.request.session.get(INTERNAL_RESET_SESSION_TOKEN) if self.token_generator.check_token(self.user, session_token): # If the token is valid, display the password reset form. self.validlink = True return super().dispatch(*args, **kwargs) else: if self.token_generator.check_token(self.user, token): # Store the token in the session and redirect to the # password reset form at a URL without the token. That # avoids the possibility of leaking the token in the # HTTP Referer header. self.request.session[INTERNAL_RESET_SESSION_TOKEN] = token redirect_url = self.request.path.replace( token, self.reset_url_token ) return HttpResponseRedirect(redirect_url) [ac0ea5ea]
- self.validlink = False self.user = self.get_user(kwargs["uidb64"]) [6738626f]
- def dispatch(self, *args, **kwargs): if "uidb64" not in kwargs or "token" not in kwargs: raise ImproperlyConfigured( "The URL path must contain 'uidb64' and 'token' parameters." ) [35a6617c]
- def dispatch(self, request, *args, **kwargs): if self.redirect_authenticated_user and self.request.user.is_authenticated: redirect_to = self.get_success_url() if redirect_to == self.request.path: raise ValueError( "Redirection loop for authenticated user detected. Check that " "your LOGIN_REDIRECT_URL doesn't point to a login page." ) return HttpResponseRedirect(redirect_to) return super().dispatch(request, *args, **kwargs) [4a34a34f]
- def form_valid(self, form): """Security check complete. Log the user in.""" auth_login(self.request, form.get_user()) return HttpResponseRedirect(self.get_success_url()) [5fe00cf1]
- def form_valid(self, form): form.save() # Updating the password logs out all other sessions for the user # except the current one. update_session_auth_hash(self.request, form.user) return super().form_valid(form) [33cea90f]
- def form_valid(self, form): opts = { "use_https": self.request.is_secure(), "token_generator": self.token_generator, "from_email": self.from_email, "email_template_name": self.email_template_name, "subject_template_name": self.subject_template_name, "request": self.request, "html_email_template_name": self.html_email_template_name, "extra_email_context": self.extra_email_context, } form.save(**opts) return super().form_valid(form) [82cca819]
- def form_valid(self, form): user = form.save() del self.request.session[INTERNAL_RESET_SESSION_TOKEN] if self.post_reset_login: auth_login(self.request, user, self.post_reset_login_backend) return super().form_valid(form) [55e0b8db]
- def get_form_class(self): return self.authentication_form or self.form_class [20e1c251]

## Beyond the budget

37 more facts did not fit in the budget: [5b74fd03] [49b4b158] [17aa5b60] [4887d69a] [56625906] [016f2714] [7bb60d38] [3001a035] [c746de6c] [43f3fec6] [826eb03d] [f2448376] [fe102e4f] [3ba16cc5] [aa33a8a6] [69e19bc9] [1477e2bb] [f7d1c08d] [56debdd8] [29eed29b] [8dffcc8d] [62407c5b] [16e2956a] [7289de07] [2045db65] [be830948] [ab5852cf] [17193361] [2fa46812] [470da165] [890d18efd7375f44-3] [c4713e0a] [11a43688] [56ff7b66] [0060b689] [60c1cf40f51b59b8] [ee671c75]
