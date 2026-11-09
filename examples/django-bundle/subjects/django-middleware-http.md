# django/middleware/http

- Subject: django/middleware/http (id `360bcec2-5886-47b5-91b2-a4ffba7e5440`)
- Kind: subject
- Budget: 1200 tokens
- Used: 417 tokens
- Facts shown: 8 of 8
- Conflicts: 0
- Gaps: 0

## Facts

- etag = response.get("ETag") last_modified = response.get("Last-Modified") last_modified = last_modified and parse_http_date_safe(last_modified) [b9786ddf]
- if etag or last_modified: return get_conditional_response( request, etag=etag, last_modified=last_modified, response=response, ) [b07945c3]
- if self.needs_etag(response) and not response.has_header("ETag"): set_response_etag(response) [a0df1046]
- return response [8034aacd88b9c7ae-8]
- def needs_etag(self, response): """Return True if an ETag header should be added to response.""" directives = split_directive_names(response.get("Cache-Control", "")) return "no-store" not in directives [3c5648d2]
- def process_response(self, request, response): # It's too late to prevent an unsafe request with a 412 response, and # for a HEAD request, the response body is always empty so computing # an accurate ETag isn't possible. if request.method != "GET": return response [7b880bf4]
- class ConditionalGetMiddleware(MiddlewareMixin): """ Handle conditional GET operations. If the response has an ETag or Last-Modified header and the request has If-None-Match or If-Modified-Since, replace the response with HttpNotModified. Add an ETag header if needed. """ [5eaad3ee]
- from django.utils.cache import get_conditional_response, set_response_etag from django.utils.deprecation import MiddlewareMixin from django.utils.http import parse_http_date_safe, split_directive_names [f79e5f97]
