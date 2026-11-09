# django/utils/cache

- Subject: django/utils/cache (id `a120155f-f6f2-4c31-bcc0-c4ad912c5700`)
- Kind: subject
- Budget: 1200 tokens
- Used: 895 tokens
- Facts shown: 12 of 45
- Conflicts: 0
- Gaps: 0

## Facts

- # Preserve cookies as per the cookie specification: "If a proxy server # receives a response which contains a Set-cookie header, it should # propagate the Set-cookie header to the client, regardless of whether # the response was 304 (Not Modified) or 200 (OK). # https://curl.haxx.se/rfc/cookie_spec.html new_response.cookies = response.cookies return new_response [a92834b2]
- # Allow overriding private caching and vice versa if "private" in cc and "public" in kwargs: del cc["private"] elif "public" in cc and "private" in kwargs: del cc["public"] [64484717]
- # Evaluation of request preconditions below follows RFC 9110 Section # 13.2.2. # Step 1: Test the If-Match precondition. if if_match_etags and not _if_match_passes(etag, if_match_etags): return _precondition_failed(request) [981101fe]
- # Get HTTP request headers. if_match_etags = parse_etags(request.META.get("HTTP_IF_MATCH", "")) if_unmodified_since = request.META.get("HTTP_IF_UNMODIFIED_SINCE") if_unmodified_since = if_unmodified_since and parse_http_date_safe( if_unmodified_since ) if_none_match_etags = parse_etags(request.META.get("HTTP_IF_NONE_MATCH", "")) if_modified_since = request.META.get("HTTP_IF_MODIFIED_SINCE") if_modified_since = if_modified_since and parse_http_date_safe(if_modified_since) [0cf710f0]
- # If there's already a max-age header but we're being asked to set a new # max-age, use the minimum of the two ages. In practice this happens when # a decorator and a piece of middleware both operate on a given view. if "max-age" in cc and "max_age" in kwargs: kwargs["max_age"] = min(int(cc["max-age"]), kwargs["max_age"]) [8ba5fd1a]
- # Step 2: Test the If-Unmodified-Since precondition. if ( not if_match_etags and if_unmodified_since and not _if_unmodified_since_passes(last_modified, if_unmodified_since) ): return _precondition_failed(request) [4c5ec999]
- # Step 3: Test the If-None-Match precondition. if if_none_match_etags and not _if_none_match_passes(etag, if_none_match_etags): if request.method in ("GET", "HEAD"): return _not_modified(request, response) else: return _precondition_failed(request) [26904ce6]
- # Step 4: Test the If-Modified-Since precondition. if ( not if_none_match_etags and if_modified_since and not _if_modified_since_passes(last_modified, if_modified_since) and request.method in ("GET", "HEAD") ): return _not_modified(request, response) [1cdff23a]
- # Step 5: Test the If-Range precondition (not supported). # Step 6: Return original response since there isn't a conditional # response. return response [910d1fcd]
- * All keyword parameter names are turned to lowercase, and underscores are converted to hyphens. * If the value of a parameter is True (exactly True, not just a true value), only the parameter name is added to the header. * All other parameters are added with their value, after applying str() to it. """ [db4fc17c]
- Each header is only added if it isn't already set. [536c6bd7]
- cc = defaultdict(set) if response.get("Cache-Control"): for field in split_header_value(response.headers["Cache-Control"]): directive, value = dictitem(field) if directive == "no-cache": # no-cache supports multiple field names. cc[directive].add(value) else: cc[directive] = value [9277384a]

## Beyond the budget

33 more facts did not fit in the budget: [39d94733] [f9bf28d2] [2b394b93] [076c31a7] [677d88c9] [c183b838] [ce52092e] [438f7b36] [901411af] [6f7dd6f9] [c3f8a848] [21b8bbd9] [951efb7d] [8be727e6] [0d832f06] [99ed94bd] [edd92feb] [5afde488] [d985fba1] [75bb9285] [176aaa3f] [0abd43bb] [2a95960e] [7ca123fe] [cd353d8a] [54769367] [6c8e99db] [12cd1ed6] [18a5aa13] [a5023467] [b2424159] [06179a23] [429a0d32]
