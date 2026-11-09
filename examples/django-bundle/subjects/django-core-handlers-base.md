# django/core/handlers/base

- Subject: django/core/handlers/base (id `79a20b16-e138-4fd4-863f-c0df703bb690`)
- Kind: subject
- Budget: 1200 tokens
- Used: 891 tokens
- Facts shown: 12 of 36
- Conflicts: 0
- Gaps: 0

## Facts

- handler = convert_exception_to_response(mw_instance) handler_is_async = middleware_is_async [8d793d24]
- if hasattr(mw_instance, "process_view"): self._view_middleware.insert( 0, self.adapt_method_mode(is_async, mw_instance.process_view), ) if hasattr(mw_instance, "process_template_response"): self._template_response_middleware.append( self.adapt_method_mode( is_async, mw_instance.process_template_response ), ) if hasattr(mw_instance, "process_exception"): # The exception-handling stack is still always synchronous for # now, so adapt that way. self._exception_middleware.append( self.adapt_method_mode(False, mw_instance.process_exception), ) [09e0fb63]
- if mw_instance is None: raise ImproperlyConfigured( "Middleware factory %s returned None." % middleware_path ) [5e3a3b5f]
- # Adapt the top of the stack, if needed. handler = self.adapt_method_mode(is_async, handler, handler_is_async) # We only assign to this when initialization is complete as it is used # as a flag for initialization being complete. self._middleware_chain = handler [0489c78a]
- # Apply view middleware for middleware_method in self._view_middleware: response = middleware_method( request, callback, callback_args, callback_kwargs ) if response: break [d1c5335e]
- # Complain if the view returned None (a common error). self.check_response(response, callback) [ea83e14b]
- # Complain if the view returned None or an uncalled coroutine. self.check_response(response, callback) [8bb110b2]
- # If the response supports deferred rendering, apply template # response middleware and then render the response if hasattr(response, "render") and callable(response.render): for middleware_method in self._template_response_middleware: response = await middleware_method(request, response) # Complain if the template response middleware returned None or # an uncalled coroutine. self.check_response( response, middleware_method, name="%s.process_template_response" % (middleware_method.__self__.__class__.__name__,), ) try: if iscoroutinefunction(response.render): response = await response.render() else: response = await sync_to_async( response.render, thread_sensitive=True )() except Exception as e: response = await sync_to_async( self.process_exception_by_middleware, thread_sensitive=True, )(e, request) if response is None: raise [60e22a60]
- # If the response supports deferred rendering, apply template # response middleware and then render the response if hasattr(response, "render") and callable(response.render): for middleware_method in self._template_response_middleware: response = middleware_method(request, response) # Complain if the template response middleware returned None # (a common error). self.check_response( response, middleware_method, name="%s.process_template_response" % (middleware_method.__self__.__class__.__name__,), ) try: response = response.render() except Exception as e: response = self.process_exception_by_middleware(e, request) if response is None: raise [554e2514]
- # Make sure the response is not a coroutine if asyncio.iscoroutine(response): raise RuntimeError("Response is still a coroutine.") return response [58ad831b]
- return response [8034aacd88b9c7ae]
- # Other utility methods. [8c062c3a]

## Beyond the budget

22 more facts did not fit in the budget: [6f30c065] [4daee446] [0bbd4302] [bf317459] [c966dfcf] [fe8e1763] [8fba71ae] [8f60cfc6] [09e67880] [cd9d686e] [71365cfa] [a13a139e] [f4943437] [5b138c98] [745783a4] [c253e1c9] [62eab511] [cf6bbf2daef2deb8-2] [01dcc1f0] [48d5f94d] [a783acd9b0048dcc-2] [e529c1f5]
