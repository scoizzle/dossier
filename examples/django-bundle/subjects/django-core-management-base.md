# django/core/management/base

- Subject: django/core/management/base (id `3c73551c-f3c1-4b9b-bebd-d33d24973b4c`)
- Kind: subject
- Budget: 1200 tokens
- Used: 890 tokens
- Facts shown: 13 of 90
- Conflicts: 0
- Gaps: 0

## Facts

- # SystemCheckError takes care of its own formatting. if isinstance(e, SystemCheckError): self.stderr.write(str(e), lambda x: x) else: self.stderr.write("%s: %s" % (e.__class__.__name__, e)) sys.exit(e.returncode) finally: try: connections.close_all() except ImproperlyConfigured: # Ignore if connections aren't setup at this point (e.g. no # configured settings). pass [213fcc01]
- for issues, group_name in sorted_issues: if issues: visible_issue_count += len(issues) formatted = ( ( self.style.ERROR(str(e)) if e.is_serious() else self.style.WARNING(str(e)) ) for e in issues ) formatted = "\n".join(sorted(formatted)) body += "\n%s:\n%s\n" % (group_name, formatted) [9b70237b]
- To validate an individual application's models rather than all applications' models, call ``self.check(app_configs)`` from ``handle()``, where ``app_configs`` is the list of application's configuration provided by the app registry. [dc4ebe3c]
- header, body, footer = "", "", "" visible_issue_count = 0 # excludes silenced warnings [67e59387]
- if all_issues: debugs = [ e for e in all_issues if e.level < checks.INFO and not e.is_silenced() ] infos = [ e for e in all_issues if checks.INFO <= e.level < checks.WARNING and not e.is_silenced() ] warnings = [ e for e in all_issues if checks.WARNING <= e.level < checks.ERROR and not e.is_silenced() ] errors = [ e for e in all_issues if checks.ERROR <= e.level < checks.CRITICAL and not e.is_silenced() ] criticals = [ e for e in all_issues if checks.CRITICAL <= e.level and not e.is_silenced() ] sorted_issues = [ (criticals, "CRITICALS"), (errors, "ERRORS"), (warnings, "WARNINGS"), (infos, "INFOS"), (debugs, "DEBUGS"), ] [833b70f5]
- if any(e.is_serious(fail_level) and not e.is_silenced() for e in all_issues): msg = self.style.ERROR("SystemCheckError: %s" % header) + body + footer raise SystemCheckError(msg) else: msg = header + body + footer [62a9ba40]
- if display_num_errors: if visible_issue_count: footer += "\n" footer += "System check identified %s (%s silenced)." % ( ( "no issues" if visible_issue_count == 0 else ( "1 issue" if visible_issue_count == 1 else "%s issues" % visible_issue_count ) ), len(all_issues) - visible_issue_count, ) [fca89a02]
- if msg: if visible_issue_count: self.stderr.write(msg, lambda x: x) else: self.stdout.write(msg) [8db345c7]
- if self.missing_args_message == LabelCommand.missing_args_message: self.missing_args_message = self.missing_args_message % self.label [a8b2cda2]
- if self.requires_system_checks and not options["skip_checks"]: check_kwargs = self.get_check_kwargs(options) self.check(**check_kwargs) if self.requires_migrations_checks: self.check_migrations() output = self.handle(*args, **options) if output: if self.output_transaction: connection = connections[options.get("database", DEFAULT_DB_ALIAS)] output = "%s\n%s\n%s" % ( self.style.SQL_KEYWORD(connection.ops.start_transaction_sql()), output, self.style.SQL_KEYWORD(connection.ops.end_transaction_sql()), ) self.stdout.write(output) return output [47541786]
- if visible_issue_count: header = "System check identified some issues:\n" [ce429cbf]
- # Metadata about this command. help = "" [779fc1a3]
- pass [7655780f0d17b825-37]

## Beyond the budget

77 more facts did not fit in the budget: [e389588a] [13cbac5e] [76217ea9] [73a040c3] [ad561fca] [7765a71b] [326818f7] [766fbf8d] [c0dd071a] [03d926e6] [c807066f] [059d9710] [42ad5425] [7a816f9e] [9297630e] [9b49dc57] [8256d678] [fb950463] [4bb55c0b] [6371205d] [c3ae0dd3] [e5d8b776] [0f772a70] [613624ef] [99403c95] [c7e0302a] [68c0d22e] [292c0d25] [7fed2328] [dfc7168e] [fc5d43bc] [98d30f79] [c0a8ab5b] [8f972b4b] [7875b922] [2e4d32b1] [8b5e06c0] [07e3b354] [b6b1dd51] [26acbdd1] [66161456] [91622f31] [14c92e22] [fb600ff8] [fbcf0ce8] [6effcdce] [84b17ea3] [077726b6] [2475015f] [70b33875] [9c11775a] [af346368] [cb54a872] [ac14a9ac] [ceddc873] [fca4b29b] [0dd9e334] [06db2f39] [319f0b3b] [43bb9416] [656124d6f08b58d6] [e67942b4] [5b9241ec] [f86be6fd] [4fc2609a] [9aee45ed] [7b170bde] [2935f635] [eee9947e] [10353238] [cb8709a7] [fca8b201] [f1194b20] [8a9062a3] [84e4fb97] [ee2c4963] [d8754b85]
