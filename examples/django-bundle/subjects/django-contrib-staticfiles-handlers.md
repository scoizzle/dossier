# django/contrib/staticfiles/handlers

- Subject: django/contrib/staticfiles/handlers (id `fb1667af-5928-4e4c-980f-0ab43ff27cb7`)
- Kind: subject
- Budget: 1200 tokens
- Used: 888 tokens
- Facts shown: 17 of 21
- Conflicts: 0
- Gaps: 0

## Facts

- async def awrapper(): for part in await sync_to_async(list)(_iterator): yield part [e59f0855]
- response.streaming_content = awrapper() return response [8da2866b]
- # May be used to differentiate between handler types (e.g. in a # request_finished signal) handles_files = True [c4a1ec01]
- async def __call__(self, scope, receive, send): # Only even look at HTTP requests if scope["type"] == "http" and self._should_handle(scope["path"]): # Serve static content # (the one thing super() doesn't do is __call__, apparently) return await super().__call__(scope, receive, send) # Hand off to the main app return await self.application(scope, receive, send) [6f0aba14]
- async def get_response_async(self, request): response = await super().get_response_async(request) response._resource_closers.append(request.close) # FileResponse is not async compatible. if response.streaming and not response.is_async: _iterator = response.streaming_content [0162b6d7]
- async def get_response_async(self, request): try: return await sync_to_async(self.serve, thread_sensitive=False)(request) except Http404 as e: return await sync_to_async(response_for_exception, thread_sensitive=False)( request, e ) [d6cb268a]
- def __call__(self, environ, start_response): if not self._should_handle(get_path_info(environ)): return self.application(environ, start_response) return super().__call__(environ, start_response) [8218328432d4cea8]
- def __init__(self, application): self.application = application self.base_url = urlparse(self.get_base_url()) [907f4c5d]
- def _should_handle(self, path): """ Check if the path should be handled. Ignore the path if: * the host is provided as part of the base_url * the request's path isn't under the media path (or equal) """ return path.startswith(self.base_url.path) and not self.base_url.netloc [2f1c56e919cc4e14]
- def file_path(self, url): """ Return the relative path to the media file on disk for the given URL. """ relative_url = url.removeprefix(self.base_url.path) return url2pathname(relative_url) [8971f97d]
- def get_base_url(self): utils.check_settings() return settings.STATIC_URL [cd3d7bc5]
- def get_response(self, request): try: return self.serve(request) except Http404 as e: return response_for_exception(request, e) [16c86f1d]
- def load_middleware(self): # Middleware are already loaded for self.application; no need to reload # them for self. pass [a9ca79da]
- def serve(self, request): """Serve the request path.""" return serve(request, self.file_path(request.path), insecure=True) [e72c6fdb]
- class ASGIStaticFilesHandler(StaticFilesHandlerMixin, ASGIHandler): """ ASGI application which wraps another and intercepts requests for static files, passing them off to Django's static file serving. """ [cc895d63]
- class StaticFilesHandler(StaticFilesHandlerMixin, WSGIHandler): """ WSGI middleware that intercepts calls to the static files directory, as defined by the STATIC_URL setting, and serves those files. """ [fdb0b94a]
- class StaticFilesHandlerMixin: """ Common methods used by WSGI and ASGI handlers. """ [e8fc6790]

## Beyond the budget

3 more facts did not fit in the budget: [770890ad88958a4c-7] [58720100] [59b91910]
