# django/middleware/cache

- Subject: django/middleware/cache (id `b4fc190d-5142-4555-aca3-2e2bc5d6ae75`)
- Kind: subject
- Budget: 1200 tokens
- Used: 888 tokens
- Facts shown: 10 of 39
- Conflicts: 0
- Gaps: 0

## Facts

- # Derive the age estimation of the cached response. if (max_age_seconds := get_max_age(response)) is not None and ( expires_timestamp := parse_http_date_safe(response["Expires"]) ) is not None: now_timestamp = int(time.time()) remaining_seconds = expires_timestamp - now_timestamp # Use Age: 0 if local clock got turned back. response["Age"] = max(0, max_age_seconds - remaining_seconds) [d1e4df3e]
- # Don't cache responses that set a user-specific (and maybe security # sensitive) cookie while varying on Cookie. if response.cookies and has_vary_header(response, "Cookie"): return response [c4c415a4]
- # Don't cache responses when the Cache-Control header is set to # private, no-cache, or no-store. Qualified forms like # `private="Set-Cookie"` reduce to their directive name and match too. cache_control_parts = set( split_directive_names(response.get("Cache-Control", "")) ) if cache_control_parts.intersection({"private", "no-cache", "no-store"}): return response [dc1563b3]
- # Don't cache responses when the Vary header contains '*'. if has_vary_header(response, "*"): return response [a3f2cb0f]
- # Page timeout takes precedence over the "max-age" and the default # cache timeout. timeout = self.page_timeout if timeout is None: # The timeout from the "max-age" section of the "Cache-Control" # header takes precedence over the default cache timeout. timeout = get_max_age(response) if timeout is None: timeout = self.cache_timeout elif timeout == 0: # max-age was set to 0, don't cache. return response patch_response_headers(response, timeout) # Make the response vary on Authorization if the request bears that # header, unless allowed by "public" per RFC 9111, Section 3.5. No # exceptions are made for "s-maxage" and "must-revalidate" since these # are not currently implemented by Django. if request.headers.get("Authorization") and "public" not in cache_control_parts: patch_vary_headers(response, ("Authorization",)) if timeout and response.status_code == 200: cache_key = learn_cache_key( request, response, timeout, self.key_prefix, cache=self.cache ) if hasattr(response, "render") and callable(response.render): response.add_post_render_callback( lambda r: self.cache.set(cache_key, r, timeout) ) else: self.cache.set(cache_key, response, timeout) return response [1f9e5f1d]
- # hit, return cached response request._cache_update_cache = False return response [895fe453]
- # try and get the cached GET response cache_key = get_cache_key(request, self.key_prefix, "GET", cache=self.cache) if cache_key is None: request._cache_update_cache = True return None # No cache information available, need to rebuild. response = self.cache.get(cache_key) # if it wasn't found and we are looking for a HEAD, try looking just # for that if response is None and request.method == "HEAD": cache_key = get_cache_key( request, self.key_prefix, "HEAD", cache=self.cache ) response = self.cache.get(cache_key) [585d4a21]
- if cache_timeout is not None: self.cache_timeout = cache_timeout self.page_timeout = page_timeout [592e3c3d]
- if response is None: request._cache_update_cache = True return None # No cache information available, need to rebuild. [7248c55a]
- if response.streaming or response.status_code not in (200, 304): return response [38de4b9b]

## Beyond the budget

28 more facts did not fit in the budget: [75d4a9bb] [0b2463de0782a8a0] [33fbc2bb] [bbe3b265] [4e91819d] [761a6eac] [da1f6267] [982e6b6a] [796d6a26] [119486fc] [d87313b5] [e4ca573f] [92964e45] [b7770531] [b73e0e01] [daecc6da] [d84dc992] [b60d598b] [47a9ed19] [a27d651b] [1d0145cf] [b7781190] [576b175c] [34db66b5] [efe39b8a] [11282d3f] [6c0f9ada] [4e1c949b]
