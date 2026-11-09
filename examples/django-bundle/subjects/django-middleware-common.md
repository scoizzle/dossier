# django/middleware/common

- Subject: django/middleware/common (id `2d3a4089-ac07-4b01-813b-a57145697a50`)
- Kind: subject
- Budget: 1200 tokens
- Used: 888 tokens
- Facts shown: 14 of 30
- Conflicts: 0
- Gaps: 0

## Facts

- - If APPEND_SLASH is set and the initial URL doesn't end with a slash, and it is not found in urlpatterns, form a new URL by appending a slash at the end. If this new URL is found in urlpatterns, return an HTTP redirect to this new URL; otherwise process the initial URL as usual. [e0824212]
- if not self.is_ignorable_request(request, path, domain, referer): ua = request.META.get("HTTP_USER_AGENT", "<none>") ip = request.META.get("REMOTE_ADDR", "<none>") self.send_mail( "Broken %slink on %s" % ( ( "INTERNAL " if self.is_internal_request(domain, referer) else "" ), domain, ), "Referrer: %s\nRequested URL: %s\nUser agent: %s\n" "IP address: %s\n" % (referer, path, ua, ip), ) return response [32d1bee3]
- return self.response_redirect_class(f"{request.scheme}://www.{host}{path}") [2e641ba0]
- This behavior can be customized by subclassing CommonMiddleware and overriding the response_redirect_class attribute. """ [ea71299a]
- # A '?' in referer is identified as a search engine source. if not self.is_internal_request(domain, referer) and "?" in referer: return True [c42141db]
- # APPEND_SLASH is enabled and the referer is equal to the current URL # without a trailing slash indicating an internal redirect. if settings.APPEND_SLASH and uri.endswith("/") and referer == uri[:-1]: return True [ad54de06]
- # Add the Content-Length header to non-streaming responses if not # already set. if not response.streaming and not response.has_header("Content-Length"): response.headers["Content-Length"] = str(len(response.content)) [1c230973]
- # Check for a redirect based on settings.PREPEND_WWW host = request.get_host() [73742115]
- # Check for denied User-Agents user_agent = request.META.get("HTTP_USER_AGENT") if user_agent is not None: for user_agent_regex in settings.DISALLOWED_USER_AGENTS: if user_agent_regex.search(user_agent): raise PermissionDenied("Forbidden user agent") [7bdcaa75]
- # The referer is equal to the current URL, ignoring the scheme (assumed # to be a poorly implemented bot). parsed_referer = urlsplit(referer) if parsed_referer.netloc in ["", domain] and parsed_referer.path == uri: return True [71ce98a0]
- - Forbid access to User-Agents in settings.DISALLOWED_USER_AGENTS [9f779ba6]
- - URL rewriting: Based on the APPEND_SLASH and PREPEND_WWW settings, append missing slashes and/or prepends missing "www."s. [6e075a08]
- Raise a RuntimeError if settings.DEBUG is True and request.method is DELETE, POST, PUT, or PATCH. """ new_path = request.get_full_path(force_append_slash=True) # Prevent construction of scheme relative urls. new_path = escape_leading_slashes(new_path) if settings.DEBUG and request.method in ("DELETE", "POST", "PUT", "PATCH"): raise RuntimeError( "You called this URL via %(method)s, but the URL doesn't end " "in a slash and you have APPEND_SLASH set. Django can't " "redirect to the slash URL while maintaining %(method)s data. " "Change your form to point to %(url)s (note the trailing " "slash), or set APPEND_SLASH=False in your Django settings." % { "method": request.method, "url": request.get_host() + new_path, } ) return new_path [7fde2125]
- return response [8034aacd88b9c7ae-4]

## Beyond the budget

16 more facts did not fit in the budget: [a4230974] [4add0492] [e9a593b3] [e3fa04d2] [2ce80ffa] [2dcd9dec] [90879b09] [550cb374] [572faadf] [16eed756] [7f214eeb] [68d5541d] [e3389af0] [57db19ce] [58610f05] [0b6ef158a9986b9e-2]
