# django/test/client

- Subject: django/test/client (id `4c6b77bc-1f35-4281-acbb-8fb54d471531`)
- Kind: subject
- Budget: 1200 tokens
- Used: 898 tokens
- Facts shown: 10 of 128
- Conflicts: 0
- Gaps: 0

## Facts

- # Attach the originating request to the response so that it could be # later retrieved. response.wsgi_request = request [03f53218]
- # Create a fake request to store login details. request = HttpRequest() if self.session: request.session = self.session else: engine = import_module(settings.SESSION_ENGINE) request.session = engine.SessionStore() login(request, user, backend) # Save the session values. request.session.save() self._set_login_cookies(request) [5781d5cd]
- # Create a fake request to store login details. request = HttpRequest() session = await self.asession() if session: request.session = session else: engine = import_module(settings.SESSION_ENGINE) request.session = engine.SessionStore() [ab805118]
- # Curry a data dictionary into an instance of the template renderer # callback function. data = {} on_template_render = partial(store_rendered_templates, data) signal_uid = "template-render-%s" % id(request) signals.template_rendered.connect(on_template_render, dispatch_uid=signal_uid) # Capture exceptions created by the handler. exception_uid = "request-exception-%s" % id(request) got_request_exception.connect(self.store_exc_info, dispatch_uid=exception_uid) try: response = self.handler(environ) finally: signals.template_rendered.disconnect(dispatch_uid=signal_uid) got_request_exception.disconnect(dispatch_uid=exception_uid) # Check for signaled exceptions. self.check_exception(response) # Save the client and request that stimulated the response. response.client = self response.request = request # Add any rendered template detail to the response. response.templates = data.get("templates", []) response.context = data.get("context") response.json = partial(self._parse_json, response) # Attach the ResolverMatch instance to the response. urlconf = getattr(response.wsgi_request, "urlconf", None) response.resolver_match = SimpleLazyObject( lambda: resolve(request["PATH_INFO"], urlconf=urlconf), ) # Flatten a single context. Not really necessary anymore thanks to the # __getattr__ flattening in ContextList, but has some edge case # backwards compatibility implications. if response.context and len(response.context) == 1: response.context = response.context[0] # Update persistent cookie data. if response.cookies: self.cookies.update(response.cookies) return response [6e0b2325]
- # Emulate a WSGI server by calling the close method on completion. if response.streaming: if response.is_async: response.streaming_content = aclosing_iterator_wrapper( response.streaming_content, response.close ) else: response.streaming_content = closing_iterator_wrapper( response.streaming_content, response.close ) else: request_finished.disconnect(close_old_connections) response.close() # will fire request_finished request_finished.connect(close_old_connections) [5e20690e]
- # Request goes through middleware. response = self.get_response(request) [5f3de978]
- # Simulate behaviors of most web servers. conditional_content_removal(request, response) [e26cf2ff]
- Return True if login is possible or False if the provided credentials are incorrect. """ from django.contrib.auth import authenticate [3dc801c6]
- await alogin(request, user, backend) # Save the session values. await request.session.asave() self._set_login_cookies(request) [8285baf4]
- Usage: [ba557877235e48a9-3]

## Beyond the budget

102 more facts did not fit in the budget: [e8cf74f6] [a2b791ed] [c2fd2488] [464ead90] [654e7887] [a882b77b] [cd5be963] [efd39f2b] [8034aacd88b9c7ae-9] [3a33dbbb] [6a6973fa] [164cafb0] [595277ad] [fd125784] [49c19216] [061814a2] [b442ebdf] [1d2cca2c] [6d3561c0] [648041ca] [cad146cb] [dfb97515] [9851af4b] [72370a73] [bd380bab] [180aadef] [b360b86e] [7ece64dc] [e5d9f200] [a3977757] [41772f37] [30bc787a] [0c10e3bd] [41050b92] [ca79ade2] [842250aa] [b0420100] [d45a0fc1] [8691da51] [05aa3b54] [526b3fec] [0ae99c6ffbb721da] [289633d2] [7240aee1] [e06f08e0] [e80cbd93] [e50ada32] [28fed6c8] [ca588d00] [c1dd9320] [4d002381] [0e863b48] [e6a5bc30] [d755aa22] [8fb494f8] [8713ef6a] [db2b3d22] [a0f393c9] [190bc8ce] [9f2e5b94] [8d225dcd] [9d7e7807] [72513397] [be451027] [6e1e3cd8] [03b8c237] [c0ca0073] [3ac241de] [6cfda3f3] [1c5d3c50] [213f7052] [3c7354b3] [86a69c23] [6b9f5d10] [c3f96b12] [dcf61c84] [54d8464a] [e17aaa7a] [4ac429a2] [75c09e2f] [702ae061] [29805ae1] [6ce9f80b] [fbd3a836] [7dc7cfef] [0116dedc] [2610654f] [d3fefb0a] [c4a5666b] [aaea725f] [6b2061d9] [453ad111] [ab140d6a] [91e788f2] [c63c0c37] [247f2bb0] [3cc5e5c7] [2d263189] [427bd060] [770890ad88958a4c-15] [caf29e82] [6c404ef6]
