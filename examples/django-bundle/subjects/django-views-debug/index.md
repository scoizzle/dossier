# django/views/debug

- Subject: django/views/debug (id `7ec97594-69cb-45f1-843a-4ac2c47b1fa3`)
- Kind: subject
- Budget: 1200 tokens
- Used: 895 tokens
- Facts shown: 6 of 67
- Conflicts: 0
- Gaps: 0

## Facts

- colno = tb_area_colno = "" _, _, start_column, end_column = next( itertools.islice( tb.tb_frame.f_code.co_positions(), tb.tb_lasti // 2, None ) ) if start_column and end_column: underline = "^" * (end_column - start_column) spaces = " " * (start_column + len(str(lineno + 1)) + 2) colno = f"\n{spaces}{underline}" tb_area_spaces = " " * ( 4 + start_column - (len(context_line) - len(context_line.lstrip())) ) tb_area_colno = f"\n{tb_area_spaces}{underline}" yield { "exc_cause": exc_cause, "exc_cause_explicit": exc_cause_explicit, "tb": tb, "type": "django" if module_name.startswith("django.") else "user", "filename": filename, "function": function, "lineno": lineno + 1, "vars": self.filter.get_traceback_frame_variables( self.request, tb.tb_frame ), "id": id(tb), "pre_context": pre_context, "context_line": context_line, "post_context": post_context, "pre_context_lineno": pre_context_lineno + 1, "colno": colno, "tb_area_colno": tb_area_colno, } tb = tb.tb_next [3d2cee16]
- # Check whether exception info is available if self.exc_type: c["exception_type"] = self.exc_type.__name__ if self.exc_value: c["exception_value"] = getattr( self.exc_value, "raw_error_message", self.exc_value ) if exc_notes := getattr(self.exc_value, "__notes__", None): c["exception_notes"] = "\n" + "\n".join(exc_notes) if frames: c["lastframe"] = frames[-1] return c [50587f23]
- # Coroutines don't have a proper `f_back` so they need to be inspected # separately. Handle this by stashing the registered sensitive # variables in a global dict indexed by `hash(file_path:line_number)`. if ( tb_frame.f_code.co_flags & inspect.CO_COROUTINE != 0 and tb_frame.f_code.co_name != "sensitive_variables_wrapper" ): key = hash( f"{tb_frame.f_code.co_filename}:{tb_frame.f_code.co_firstlineno}" ) sensitive_variables = coroutine_functions_to_sensitive_variables.get( key, None ) [25e8af70]
- # If we just read the source from a file, or if the loader did not # apply tokenize.detect_encoding to decode the source into a # string, then we should do that ourselves. if isinstance(source[0], bytes): encoding = "ascii" for line in source[:2]: # File coding may be specified. Match pattern from PEP-263 # (https://www.python.org/dev/peps/pep-0263/) match = re.search(rb"coding[:=]\s*([-\w.]+)", line) if match: encoding = match[1].decode("ascii") break source = [str(sline, encoding, "replace") for sline in source] [43ed1b14]
- # In case there's just one exception, take the traceback from self.tb exc_value = exceptions.pop() tb = self.tb if not exceptions else exc_value.__traceback__ while True: frames.extend(self.get_exception_traceback_frames(exc_value, tb)) try: exc_value = exceptions.pop() except IndexError: break tb = exc_value.__traceback__ return frames [bd6980f3]
- cleansed = {} if self.is_active(request) and sensitive_variables: if sensitive_variables == "__ALL__": # Cleanse all variables for name in tb_frame.f_locals: cleansed[name] = self.cleansed_substitute else: # Cleanse specified variables for name, value in tb_frame.f_locals.items(): if name in sensitive_variables: value = self.cleansed_substitute else: value = self.cleanse_special_types(request, value) cleansed[name] = value else: # Potentially cleanse the request and any MultiValueDicts if they # are one of the frame variables. for name, value in tb_frame.f_locals.items(): cleansed[name] = self.cleanse_special_types(request, value) [52532681]

## Beyond the budget

59 more facts did not fit in the budget: [5fbfbe1a] [352a3ac9] [16971dda] [c93b203e] [bade3bd3] [54da5603] [3b04c03b] [c11f7dea] [d96ebc47] [9fdb0111] [e7c5a87f] [41b0c759] [eede8285] [790cc184] [7c5cb97d] [e3538165] [a59a4e1e] [846c39e6e200e068-2] [d587b733] [87758d77] [591b8ce2] [357d28f157a8ff25-2] [a34b3e33] [5ffeda32] [18273774] [d6acec94] [243fd052] [fe39dd2c] [43ac713f] [7de9921f] [99105181] [89cdb6dd] [ba3ee6d6] [65514fa2] [03eeb652] [0b0da05a] [a129f813] [5d31d357] [f86e7e29] [709faf90] [1d14097b] [92078df2] [8cca50c2] [033e94d6] [3fb440b9] [65326c5f] [61cbd2f3] [b3a47af9] [7ef302e5] [3fc4d86d] [b96c5918] [47318176] [eeae5fe7] [84194fcb37f4a638-2] [11038a82] [bdd2b444] [2608880a] [fac80aaa] [db5a4f6e]
