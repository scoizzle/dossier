# django/core/management/commands/runserver

- Subject: django/core/management/commands/runserver (id `f018472a-88d6-411f-9685-f402157a7921`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 8 of 21
- Conflicts: 0
- Gaps: 0

## Facts

- if not options["skip_checks"]: self.stdout.write("Performing system checks...\n\n") check_kwargs = super().get_check_kwargs(options) check_kwargs["display_num_errors"] = True self.check(**check_kwargs) # Need to check migrations here, so can't use the # requires_migrations_check attribute. self.check_migrations() # Close all connections opened during migration checking. for conn in connections.all(initialized_only=True): conn.close() [d561d9f0]
- if self._raw_ipv6: addr = f"[{self.addr}]" elif self.addr == "0": addr = "0.0.0.0" else: addr = self.addr [c3bcdfaa]
- if use_reloader: autoreload.run_with_reloader(self.inner_run, **options) else: self.inner_run(None, **options) [8a0b1ac9]
- now = datetime.now().strftime("%B %d, %Y - %X") version = self.get_version() print( f"{now}\n" f"Django version {version}, using settings {settings.SETTINGS_MODULE!r}\n" f"Starting WSGI development server at {self.protocol}://{addr}" f":{server_port}/\n" f"Quit the server with {quit_command}.", file=self.stdout, ) docs_version = get_docs_version() if os.environ.get("DJANGO_RUNSERVER_HIDE_WARNING") != "true": self.stdout.write( self.style.WARNING( "WARNING: This is a development server. Do not use it in a " "production setting. Use a production WSGI or ASGI server " "instead.\nFor more information on production servers see: " f"https://docs.djangoproject.com/en/{docs_version}/howto/" "deployment/" ) ) [474d26a3]
- self.use_ipv6 = options["use_ipv6"] if self.use_ipv6 and not socket.has_ipv6: raise CommandError("Your Python does not support IPv6.") self._raw_ipv6 = False if not options["addrport"]: self.addr = "" self.port = self.default_port else: m = re.match(naiveip_re, options["addrport"]) if m is None: raise CommandError( '"%s" is not a valid port number ' "or address:port pair." % options["addrport"] ) self.addr, _ipv4, _ipv6, _fqdn, self.port = m.groups() if not self.port.isdigit(): raise CommandError("%r is not a valid port number." % self.port) if self.addr: if _ipv6: self.addr = self.addr[1:-1] self.use_ipv6 = True self._raw_ipv6 = True elif self.use_ipv6 and not _fqdn: raise CommandError('"%s" is not a valid IPv6 address.' % self.addr) if not self.addr: self.addr = self.default_addr_ipv6 if self.use_ipv6 else self.default_addr self._raw_ipv6 = self.use_ipv6 self.run(**options) [0a0701d2]
- threading = options["use_threading"] # 'shutdown_message' is a stealth option. shutdown_message = options.get("shutdown_message", "") [05366f7b]
- try: handler = self.get_handler(*args, **options) run( self.addr, int(self.port), handler, ipv6=self.use_ipv6, threading=threading, on_bind=self.on_bind, server_cls=self.server_cls, ) except OSError as e: # Use helpful error messages instead of ugly tracebacks. ERRORS = { errno.EACCES: "You don't have permission to access that port.", errno.EADDRINUSE: "That port is already in use.", errno.EADDRNOTAVAIL: "That IP address can't be assigned to.", } try: error_text = ERRORS[e.errno] except KeyError: error_text = e self.stderr.write("Error: %s" % error_text) # Need to use an OS exit because sys.exit doesn't work in a thread os._exit(1) except KeyboardInterrupt: if shutdown_message: self.stdout.write(shutdown_message) sys.exit(0) [46d4b07a]
- def get_check_kwargs(self, options): """Validation is called explicitly each time the server reloads.""" return {"tags": set()} [3d487086]

## Beyond the budget

13 more facts did not fit in the budget: [6ad23dd5] [3d438805] [6796c24e] [04bb1d43] [939c0281] [c15460bd] [888c88ad] [122caad4] [99243bb6] [0734d085] [eeaeea97] [f2d92b3c] [ca07f227]
