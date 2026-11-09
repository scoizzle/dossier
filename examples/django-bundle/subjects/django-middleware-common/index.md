# django/middleware/common

- Subject: django/middleware/common (id `c584956d-1b51-4b9e-baf6-a83fec4564a0`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1938 tokens
- Facts shown: 30 of 30
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [a4230974] if settings.PREPEND_WWW and host and not host.startswith("www."): # Check if we also need to append a slash so we can do it all # with a single redirect. (This check may be somewhat expensive, # so we only do it if we already know we're sending a redirect, # or in process_response if we get a 404.) if self.should_redirect_with_slash(request): path = self.get_full_path_with_slash(request) else: path = request.get_full_path()
- [4add0492] return any(pattern.search(uri) for pattern in settings.IGNORABLE_404_URLS)
- [e9a593b3] try: mail_managers(subject, message, *args, using=self.using, **kwargs) except MailerDoesNotExist: pass
- [e3fa04d2] def get_full_path_with_slash(self, request): """ Return the full path of the request with a trailing slash appended.
- [2ce80ffa] def is_ignorable_request(self, request, uri, domain, referer): """ Return True if the given request *shouldn't* notify the site managers according to project settings or in situations outlined by the inline comments. """ # The referer is empty. if not referer: return True
- [2dcd9dec] def is_internal_request(self, domain, referer): """ Return True if the referring URL is the same domain as the current request. """ # Different subdomains are treated as different domains. return bool(re.match("^https?://%s/" % re.escape(domain), referer))
- [90879b09] def process_request(self, request): """ Check for denied User-Agents and rewrite the URL based on settings.APPEND_SLASH and settings.PREPEND_WWW """
- [550cb374] def process_response(self, request, response): """ When the status code of the response is 404, it may redirect to a path with an appended slash if should_redirect_with_slash() returns True. """ # If the given URL is "Not Found", then check if we should redirect to # a path with a slash appended. if response.status_code == 404 and self.should_redirect_with_slash(request): response = self.response_redirect_class( self.get_full_path_with_slash(request) )
- [572faadf] def process_response(self, request, response): """Send broken link emails for relevant 404 NOT FOUND responses.""" if response.status_code == 404 and not settings.DEBUG: domain = request.get_host() path = request.get_full_path() referer = request.META.get("HTTP_REFERER", "")
- [16eed756] def send_mail(self, subject, message, *args, **kwargs): # RemovedInDjango2028Warning. if not mailers._is_configured: mail_managers(subject, message, *args, fail_silently=True, **kwargs) return
- [7f214eeb] def should_redirect_with_slash(self, request): """ Return True if settings.APPEND_SLASH is True and appending a slash to the request path turns an invalid path into a valid one. """ if settings.APPEND_SLASH and not request.path_info.endswith("/"): urlconf = getattr(request, "urlconf", None) if not is_valid_path(request.path_info, urlconf): match = is_valid_path("%s/" % request.path_info, urlconf) if match: view = match.func return getattr(view, "should_append_slash", True) return False
- [68d5541d] response_redirect_class = HttpResponsePermanentRedirect
- [e3389af0] class BrokenLinkEmailsMiddleware(MiddlewareMixin): # Set to override the mail.mailers alias used for sending the email. using = None
- [57db19ce] class CommonMiddleware(MiddlewareMixin): """ "Common" middleware for taking care of some basic operations:
- [58610f05] from django.conf import settings from django.core.exceptions import PermissionDenied from django.core.mail import MailerDoesNotExist, mail_managers, mailers from django.http import HttpResponsePermanentRedirect from django.urls import is_valid_path from django.utils.deprecation import MiddlewareMixin from django.utils.http import escape_leading_slashes
- [0b6ef158a9986b9e-2] import re from urllib.parse import urlsplit
