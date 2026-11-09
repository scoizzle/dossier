# django/core/servers/basehttp

- Subject: django/core/servers/basehttp (id `25e80bae-cca6-4258-8211-51f1f0d00e8d`)
- Kind: subject
- Budget: 1200 tokens
- Used: 894 tokens
- Facts shown: 18 of 39
- Conflicts: 0
- Gaps: 0

## Facts

- handler = ServerHandler( self.rfile, self.wfile, self.get_stderr(), self.get_environ() ) handler.request_handler = self # backpointer for logging & connection closing handler.run(self.server.get_app()) [8a610bbe]
- if not self.parse_request(): # An error code has been sent, just exit return [2115e79d]
- log_message( logger, format, *args, request=self.request, status_code=status_code, server_time=self.log_date_time_string(), ) [2dbf2eb8]
- return super().get_environ() [6233a1be]
- # socketserver.ThreadingMixIn.process_request() passes this method as # the target to a new Thread object. def process_request_thread(self, request, client_address): if self.connections_override: # Override this thread's database connections with the ones # provided by the parent thread. for alias, conn in self.connections_override.items(): connections[alias] = conn super().process_request_thread(request, client_address) [1a845356]
- If settings.WSGI_APPLICATION is not set (is ``None``), return whatever ``django.core.wsgi.get_wsgi_application`` returns. """ from django.conf import settings [802062f0]
- This function, and the ``WSGI_APPLICATION`` setting itself, are only useful for Django's internal server (runserver); external WSGI servers should just be configured to point to the correct application object directly. [b2fcd996]
- app_path = getattr(settings, "WSGI_APPLICATION") if app_path is None: return get_wsgi_application() [8f355695]
- daemon_threads = True [be4379de]
- def __init__(self, *args, connections_override=None, **kwargs): super().__init__(*args, **kwargs) self.connections_override = connections_override [09ff0f6b]
- def __init__(self, *args, ipv6=False, allow_reuse_address=True, **kwargs): if ipv6: self.address_family = socket.AF_INET6 self.allow_reuse_address = allow_reuse_address super().__init__(*args, **kwargs) [542b0ed6]
- def __init__(self, stdin, stdout, stderr, environ, **kwargs): """ Use a LimitedStream so that unread request data will be ignored at the end of the request. WSGIRequest uses a LimitedStream but it shouldn't discard the data since the upstream servers usually do this. This fix applies only for testserver/runserver. """ try: content_length = int(environ.get("CONTENT_LENGTH")) except (ValueError, TypeError): content_length = 0 super().__init__( LimitedStream(stdin, content_length), stdout, stderr, environ, **kwargs ) [7ecbd80a]
- def _close_connections(self): # Used for mocking in tests. connections.close_all() [ba3dc3d4]
- def address_string(self): # Short-circuit parent method to not call socket.getfqdn return self.client_address[0] [140f9aed]
- def close(self): self.get_stdin().read() super().close() [695e9de4]
- def close_request(self, request): self._close_connections() super().close_request(request) [aa049382]
- def handle(self): self.close_connection = True self.handle_one_request() while not self.close_connection: self.handle_one_request() try: self.connection.shutdown(socket.SHUT_WR) except (AttributeError, OSError): pass [ee08565e]
- request_queue_size = 10 [1ae3d3b5]

## Beyond the budget

21 more facts did not fit in the budget: [1a3e2204] [740cdc34] [20545396] [117280d3] [e30b90d6] [9ad02d69] [63086266] [a6c29d50] [ddf8a2b2] [f26f6806] [ed59c54f] [0a35b87d] [a1e14f45] [1c9122be] [3f54cd23] [cd665939] [cd2bf5af] [bdcdfd89] [3eef7d6e] [83481ee6] [f3bfc816]
