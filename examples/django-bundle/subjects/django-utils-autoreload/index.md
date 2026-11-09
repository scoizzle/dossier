# django/utils/autoreload

- Subject: django/utils/autoreload (id `6a7fe331-cc9e-4572-912f-10fa8e8d0dab`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 18 of 71
- Conflicts: 0
- Gaps: 0

## Facts

- et, ev, tb = _exception [57d49198]
- if filename not in _error_files: _error_files.append(filename) if _url_module_exception is not None: raise e from _url_module_exception [fea47ecb]
- if getattr(ev, "filename", None) is None: # get the filename from the last item in the stack filename = traceback.extract_tb(tb)[-1][0] else: filename = ev.filename [8f1050df]
- raise e [65f80218]
- time.sleep(self.SLEEP_TIME) yield [7c250827]
- # Prevent a race condition where URL modules aren't loaded when the # reloader starts by accessing the urlconf_module property. try: get_resolver().urlconf_module except Exception as e: # Loading the urlconf can result in errors during development. # If this occurs then store the error and continue. _url_module_exception = e logger.debug("Apps ready_event triggered. Sending autoreload_started signal.") autoreload_started.send(sender=self) self.run_loop() [0bf49b05]
- Return True if the thread is alive and the ready event has been triggered, or False if the thread is terminated while waiting for the event. """ while django_main_thread.is_alive(): if app_reg.ready_event.wait(timeout=0.1): return True else: logger.debug("Main Django thread has terminated before apps are ready.") return False [06b02e8d]
- expression = ["anyof"] for pattern in patterns: expression.append(["match", pattern, "wholename"]) self._subscribe(directory, "%s:%s" % (prefix, directory), expression) [21c5243f]
- # These are primarily used for testing. @property def should_stop(self): return self._stop_condition.is_set() [12d9a40d]
- # Turn the tree into a list of Path instances. def _walk(node, path): for prefix, child in node.items(): yield from _walk(child, [*path, prefix]) if not node: yield Path(*path) [77bdd8b5]
- @cached_property def client(self): return pywatchman.client(timeout=self.client_timeout) [1456f7ee]
- @classmethod def check_availability(cls): if not pywatchman: raise WatchmanUnavailable("pywatchman not installed.") client = pywatchman.client(timeout=0.1) try: result = client.capabilityCheck() except Exception: # The service is down? raise WatchmanUnavailable("Cannot connect to the watchman service.") version = get_version_tuple(result["version"]) # Watchman 4.9 includes multiple improvements to watching project # directories as well as case insensitive filesystems. logger.debug("Watchman version %s", version) if version < (4, 9): raise WatchmanUnavailable("Watchman 4.9 or later is required.") [3d7cb6bd]
- @classmethod def check_availability(cls): raise NotImplementedError("subclasses must implement check_availability().") [48652595]
- @classmethod def check_availability(cls): return True [96e9b21f]
- @lru_cache def _get_clock(self, root): return self.client.query("clock", root)["clock"] [ad3a72ac]
- def check_server_status(self, inner_ex=None): """Return True if the server is available.""" try: self.client.query("version") except Exception: raise WatchmanUnavailable(str(inner_ex)) from inner_ex return True [91526c1a]
- def stop(self): self._stop_condition.set() [d574f8df]
- return wrapper [656124d6f08b58d6-3]

## Beyond the budget

53 more facts did not fit in the budget: [e11c6ecc] [ed3677aa] [50493ed4] [6a6926c3] [d8c6f6c0] [75e871ac] [1be33d00] [423e519f] [745929e2] [f566ee15] [80504f91] [41c19f6e] [80afe6c5] [55b5d422] [a13181ff] [fdf44536] [5b9c1cd7] [f28dbb55] [3fe3c3be] [a92d2b5f] [26bb79d0] [6a5fab8d] [a877ee7e] [6f43aea5] [afdb8ab3] [1d7a2dc3] [45b0292e] [1cbbb4b5] [8d310d29] [328addf1] [528addfb] [90c1121f] [116d42c9] [8477ee97] [93ac0149] [941ab3c0] [2c03cb2c] [9a3a19f7] [f52d6198] [cf00c336] [cb62178f] [3bc193de] [c93325d2] [7b2a1a71] [8bcb159c] [433aecec] [ea90c5fd] [a442baab] [20587824] [ff18db7d] [c0749372] [e377d757] [d1646ecf]
