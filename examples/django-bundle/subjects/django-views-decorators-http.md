# django/views/decorators/http

- Subject: django/views/decorators/http (id `000c7f24-91b7-48df-8669-2e0276a7fb44`)
- Kind: subject
- Budget: 1200 tokens
- Used: 888 tokens
- Facts shown: 14 of 30
- Conflicts: 0
- Gaps: 0

## Facts

- @wraps(func) async def inner(request, *args, **kwargs): if request.method not in request_method_list: response = HttpResponseNotAllowed(request_method_list) log_response( "Method Not Allowed (%s): %s", request.method, request.path, response=response, request=request, ) return response return await func(request, *args, **kwargs) [76753044]
- @wraps(func) async def inner(request, *args, **kwargs): response, res_etag, res_last_modified = _pre_process_request( request, *args, **kwargs ) if response is None: response = await func(request, *args, **kwargs) _post_process_request(request, response, res_etag, res_last_modified) return response [64ed0dc6]
- @require_http_methods(["GET", "POST"]) def my_view(request): # I can assume now that only GET or POST requests make it this far # ... [dfb28e7b]
- def _post_process_request(request, response, res_etag, res_last_modified): # Set relevant headers on the response if they don't already exist # and if the request method is safe. if request.method in ("GET", "HEAD"): if res_last_modified and not response.has_header("Last-Modified"): response.headers["Last-Modified"] = http_date(res_last_modified) if res_etag: response.headers.setdefault("ETag", res_etag) [b88e782d]
- else: [6ad07797f4838346-26]
- else: [6ad07797f4838346-27]
- if iscoroutinefunction(func): [9b3c6cee9ff9a8ff-2]
- return inner [b9689d746b8236ce-6]
- return inner [b9689d746b8236ce-7]
- Note that request methods should be in uppercase. """ [090e7cbe]
- The ETag function should return a complete ETag, including quotes (e.g. '"etag"'), since that's the only way to distinguish between weak and strong ETags. If an unquoted ETag is returned (e.g. 'etag'), it will be converted to a strong ETag by adding quotes. [1ec170be]
- The parameters are callables to compute the ETag and last modified time for the requested resource, respectively. The callables are passed the same parameters as the view itself. The ETag function should return a string (or None if the resource doesn't exist), while the last_modified function should return a datetime object (or None if the resource doesn't exist). [cfeca162]
- This decorator will either pass control to the wrapped view function or return an HTTP 304 response (unmodified) or 412 response (precondition failed), depending upon the request method. In either case, the decorator will add the generated ETag and Last-Modified headers to the response if the headers aren't already set and if the request's method is safe. """ [d7395ce4]
- def decorator(func): def _pre_process_request(request, *args, **kwargs): # Compute values (if any) for the requested resource. res_last_modified = None if last_modified_func: if dt := last_modified_func(request, *args, **kwargs): if not timezone.is_aware(dt): dt = timezone.make_aware(dt, datetime.UTC) res_last_modified = int(dt.timestamp()) # The value from etag_func() could be quoted or unquoted. res_etag = etag_func(request, *args, **kwargs) if etag_func else None res_etag = quote_etag(res_etag) if res_etag is not None else None response = get_conditional_response( request, etag=res_etag, last_modified=res_last_modified, ) return response, res_etag, res_last_modified [294c2a35]

## Beyond the budget

13 more facts did not fit in the budget: [b9afc59d556f7366] [021b5df2d691cbd2-10] [021b5df2d691cbd2-11] [dc03318e] [da646f98] [c151a1e0] [430379cf] [0ed1ec6e] [47f95029] [0b764db1] [6ec31215] [736b18ee] [ac05727b]
