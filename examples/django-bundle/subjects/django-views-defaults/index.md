# django/views/defaults

- Subject: django/views/defaults (id `44629105-176c-4f54-add9-251d3380b439`)
- Kind: subject
- Budget: 1200 tokens
- Used: 886 tokens
- Facts shown: 9 of 13
- Conflicts: 0
- Gaps: 0

## Facts

- If the template does not exist, an Http403 response containing the text "403 Forbidden" (as per RFC 9110 Section 15.5.4) will be returned. """ try: template = loader.get_template(template_name) except TemplateDoesNotExist: if template_name != ERROR_403_TEMPLATE_NAME: # Reraise if it's a missing custom template. raise return HttpResponseForbidden( ERROR_PAGE_TEMPLATE % {"title": "403 Forbidden", "details": ""}, ) return HttpResponseForbidden( template.render(request=request, context={"exception": str(exception)}) ) [e112f7e1]
- Templates: :template:`400.html` Context: None """ try: template = loader.get_template(template_name) body = template.render(request=request) except TemplateDoesNotExist: if template_name != ERROR_400_TEMPLATE_NAME: # Reraise if it's a missing custom template. raise return HttpResponseBadRequest( ERROR_PAGE_TEMPLATE % {"title": "Bad Request (400)", "details": ""}, ) # No exception content is passed to the template, to not disclose any # sensitive information. return HttpResponseBadRequest(body) [bd9f1983]
- Templates: :template:`403.html` Context: exception The message from the exception which triggered the 403 (if one was supplied). [ee710b53]
- Templates: :template:`404.html` Context: request_path The path of the requested URL (e.g., '/app/pages/bad_page/'). It's quoted to prevent a content injection attack. exception The message from the exception which triggered the 404 (if one was supplied), or the exception class name """ exception_repr = exception.__class__.__name__ # Try to get an "interesting" exception message, if any (and not the ugly # Resolver404 dictionary) try: message = exception.args[0] except (AttributeError, IndexError): pass else: if isinstance(message, str): exception_repr = message context = { "request_path": quote(request.path), "exception": exception_repr, } try: template = loader.get_template(template_name) body = template.render(context, request) except TemplateDoesNotExist: if template_name != ERROR_404_TEMPLATE_NAME: # Reraise if it's a missing custom template. raise # Render template (even though there are no substitutions) to allow # inspecting the context in tests. template = Engine().from_string( ERROR_PAGE_TEMPLATE % { "title": "Not Found", "details": "The requested resource was not found on this server.", }, ) body = template.render(Context(context)) return HttpResponseNotFound(body) [799c5b61]
- Templates: :template:`500.html` Context: None """ try: template = loader.get_template(template_name) except TemplateDoesNotExist: if template_name != ERROR_500_TEMPLATE_NAME: # Reraise if it's a missing custom template. raise return HttpResponseServerError( ERROR_PAGE_TEMPLATE % {"title": "Server Error (500)", "details": ""}, ) return HttpResponseServerError(template.render()) [38e4d65a]
- # These views can be called when CsrfViewMiddleware.process_view() not run, # therefore need @requires_csrf_token in case the template needs # {% csrf_token %}. [6e60317f]
- @requires_csrf_token def bad_request(request, exception, template_name=ERROR_400_TEMPLATE_NAME): """ 400 error handler. [5cec73e7]
- @requires_csrf_token def page_not_found(request, exception, template_name=ERROR_404_TEMPLATE_NAME): """ Default 404 handler. [a5c3272a]
- from urllib.parse import quote [f2476fe7]

## Beyond the budget

4 more facts did not fit in the budget: [2bb1d34d] [be619da7] [912cd6f7] [cf4e9b63]
