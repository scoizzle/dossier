# django/middleware/clickjacking

- Subject: django/middleware/clickjacking (id `10125b0d-935f-4459-9444-77b76b7d480f`)
- Kind: subject
- Budget: 1200 tokens
- Used: 493 tokens
- Facts shown: 11 of 11
- Conflicts: 0
- Gaps: 0

## Facts

- # Don't set it if they used @xframe_options_exempt if getattr(response, "xframe_options_exempt", False): return response [888773f4]
- This method can be overridden if needed, allowing it to vary based on the request or response. """ return getattr(settings, "X_FRAME_OPTIONS", "DENY").upper() [8e0466d8]
- response.headers["X-Frame-Options"] = self.get_xframe_options_value( request, response, ) return response [e8aa323e]
- By default, set the X-Frame-Options header to 'DENY', meaning the response cannot be displayed in a frame, regardless of the site attempting to do so. To enable the response to be loaded on a frame within the same site, set X_FRAME_OPTIONS in your project's Django settings to 'SAMEORIGIN'. """ [e77e8a39]
- Do not set the header if it's already set or if the response contains a xframe_options_exempt value set to True. [485cf2d6]
- def get_xframe_options_value(self, request, response): """ Get the value to set for the X_FRAME_OPTIONS header. Use the value from the X_FRAME_OPTIONS setting, or 'DENY' if not set. [cbd90d46]
- def process_response(self, request, response): # Don't set it if it's already in the response if response.get("X-Frame-Options") is not None: return response [21906452]
- """ Clickjacking Protection Middleware. [d1eee6e9]
- This module provides a middleware that implements protection against a malicious site loading resources from your site in a hidden frame. """ [7b5bff0c]
- class XFrameOptionsMiddleware(MiddlewareMixin): """ Set the X-Frame-Options HTTP header in HTTP responses. [67ab88f5]
- from django.conf import settings from django.utils.deprecation import MiddlewareMixin [0312896e]
