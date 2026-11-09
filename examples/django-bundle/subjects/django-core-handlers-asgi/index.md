# django/core/handlers/asgi

- Subject: django/core/handlers/asgi (id `8d35ae39-8862-424b-af3a-90ae253277dc`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 16 of 34
- Conflicts: 0
- Gaps: 0

## Facts

- # Quit out if that's the end. if not message.get("more_body", False): break body_file.seek(0) return body_file [3439ca27]
- class RequestProcessed(Exception): pass [401ef10b]
- if response is None: await signals.request_finished.asend(sender=self.__class__) else: await sync_to_async(response.close)() [2bec1c58]
- response = None try: try: async with asyncio.TaskGroup() as tg: tg.create_task(self.listen_for_disconnect(receive)) response = await self.run_get_response(request) await self.send_response(response, send) raise RequestProcessed except* (RequestProcessed, RequestAborted): pass except BaseExceptionGroup as exception_group: if len(exception_group.exceptions) == 1: raise exception_group.exceptions[0] raise [ec80a77f]
- async with ThreadSensitiveContext(): await self.handle(scope, receive, send) [f9b4e107]
- with closing(body_file): # Request is complete and can be served. set_script_prefix(get_script_prefix(scope)) await signals.request_started.asend(sender=self.__class__, scope=scope) # Get the request and check for basic issues. request, error_response = self.create_request(scope, body_file) if request is None: body_file.close() await self.send_response(error_response, send) await sync_to_async(error_response.close)() return [364cdcb5]
- # Number of seconds until a Request gives up on trying to read a request # body and aborts. body_receive_timeout = 60 [325e84ea]
- @cached_property def COOKIES(self): return parse_cookie(self.META.get("HTTP_COOKIE", "")) [6fb707fc]
- @cached_property def GET(self): return QueryDict(self.META["QUERY_STRING"]) [a8caadb6]
- @classmethod def chunk_bytes(cls, data): """ Chunks some data up so it can be sent in reasonable size messages. Yields (chunk, last_chunk) tuples. """ position = 0 if not data: yield data, True return while position < len(data): yield ( data[position : position + cls.chunk_size], (position + cls.chunk_size) >= len(data), ) position += cls.chunk_size [49e61220]
- POST = property(_get_post, _set_post) FILES = property(_get_files) [71d0a3b8]
- async def __call__(self, scope, receive, send): """ Async entrypoint - parses the request and hands off to get_response. """ # Serve only HTTP connections. # FIXME: Allow to override this. if scope["type"] != "http": raise ValueError( "Django can only handle ASGI/HTTP connections, not %s." % scope["type"] ) [9eaab3fe]
- async def handle(self, scope, receive, send): """ Handles the ASGI request. Called via the __call__ method. """ # Receive the HTTP request body as a stream object. try: body_file = await self.read_body(receive) except RequestAborted: return [973acb31]
- async def listen_for_disconnect(self, receive): """Listen for disconnect from the client.""" message = await receive() if message["type"] == "http.disconnect": raise RequestAborted() # This should never happen. assert False, "Invalid ASGI message after request body: %s" % message["type"] [5983b4cc]
- def __init__(self): super().__init__() self.load_middleware(is_async=True) [5c798dc7]
- def _get_files(self): if not hasattr(self, "_files"): self._load_post_and_files() return self._files [589c0488]

## Beyond the budget

17 more facts did not fit in the budget: [069b73a6] [205bd34a] [a36fffed] [4e4bf3c4] [8d2b436e] [412b9cfd2b807fd4] [740dfe57] [aae5d157] [37591200] [4253f5d3] [0b632ed7] [a964b6ab] [c41d859e] [3349edb8] [8484f9df] [1f56a096] [a783acd9b0048dcc]
