# django/core/handlers/wsgi

- Subject: django/core/handlers/wsgi (id `54888a6c-04d2-4969-973d-0e8b3bc87992`)
- Kind: subject
- Budget: 1200 tokens
- Used: 896 tokens
- Facts shown: 16 of 31
- Conflicts: 0
- Gaps: 0

## Facts

- response._handler_class = self.__class__ [7dcbe0e4]
- status = "%d %s" % (response.status_code, response.reason_phrase) response_headers = [ *response.items(), *(("Set-Cookie", c.OutputString()) for c in response.cookies.values()), ] start_response(status, response_headers) if getattr(response, "file_to_stream", None) is not None and environ.get( "wsgi.file_wrapper" ): # If `wsgi.file_wrapper` is used the WSGI server does not call # .close on the response, but on the file wrapper. Patch it to use # response.close instead which takes care of closing all files. response.file_to_stream.close = response.close response = environ["wsgi.file_wrapper"]( response.file_to_stream, response.block_size ) return response [a0ea8057]
- # If Apache's mod_rewrite had a whack at the URL, Apache set either # SCRIPT_URL or REDIRECT_URL to the full resource URL before applying any # rewrites. Unfortunately not every web server (lighttpd!) passes this # information through all the time, so FORCE_SCRIPT_NAME, above, is still # needed. script_url = get_bytes_from_wsgi(environ, "SCRIPT_URL", "") or get_bytes_from_wsgi( environ, "REDIRECT_URL", "" ) [53d5bad6]
- @cached_property def COOKIES(self): raw_cookie = get_str_from_wsgi(self.environ, "HTTP_COOKIE", "") return parse_cookie(raw_cookie) [a8cf3e9d]
- @cached_property def GET(self): # The WSGI spec says 'QUERY_STRING' may be absent. raw_query_string = get_bytes_from_wsgi(self.environ, "QUERY_STRING", "") return QueryDict(raw_query_string, encoding=self._encoding) [a0364332]
- @property def FILES(self): if not hasattr(self, "_files"): self._load_post_and_files() return self._files [b35ddadb]
- Based on the implementation from werkzeug.wsgi.LimitedStream. See: https://github.com/pallets/werkzeug/blob/dbf78f67/src/werkzeug/wsgi.py#L828 """ [ab8665ad]
- POST = property(_get_post, _set_post) [89ed1bdc]
- def __call__(self, environ, start_response): set_script_prefix(get_script_name(environ)) signals.request_started.send(sender=self.__class__, environ=environ) request = self.request_class(environ) response = self.get_response(request) [8d895d28]
- def __init__(self, *args, **kwargs): super().__init__(*args, **kwargs) self.load_middleware() [4054be62]
- def __init__(self, stream, limit): self._read = stream.read self._readline = stream.readline self._pos = 0 self.limit = limit [79531bb4]
- def _get_post(self): if not hasattr(self, "_post"): self._load_post_and_files() return self._post [4fde63522f010ddd-2]
- def _get_scheme(self): return self.environ.get("wsgi.url_scheme") [e8e9497d]
- def _set_post(self, post): self._post = post [412b9cfd2b807fd4-2]
- def read(self, size=-1, /): _pos = self._pos limit = self.limit if _pos >= limit: return b"" if size == -1 or size is None: size = limit - _pos else: size = min(size, limit - _pos) data = self._read(size) self._pos += len(data) return data [3ff1f2dd]
- def readline(self, size=-1, /): _pos = self._pos limit = self.limit if _pos >= limit: return b"" if size == -1 or size is None: size = limit - _pos else: size = min(size, limit - _pos) line = self._readline(size) self._pos += len(line) return line [f395bc5a]

## Beyond the budget

14 more facts did not fit in the budget: [d5cfd7a3] [4202d9ae] [5bebb903] [fc37c9cb] [3e18016c] [3d58609b] [1c245b46] [9ff69772] [19fc12e9] [d9ad4dae] [70225bd6] [93dc7d9c] [08ac259c] [6fade208]
