# django/core/management/templates

- Subject: django/core/management/templates (id `0d7145d4-07da-4510-a5de-4cca6bf7f0f7`)
- Kind: subject
- Budget: 1200 tokens
- Used: 893 tokens
- Facts shown: 13 of 40
- Conflicts: 0
- Gaps: 0

## Facts

- # Only render the Python files, as we don't want to # accidentally render Django templates files if new_path.endswith(extensions) or filename in extra_files: with open(old_path, encoding="utf-8") as template_file: content = template_file.read() template = Engine().from_string(content) content = template.render(context) with open(new_path, "w", encoding="utf-8") as new_file: new_file.write(content) else: shutil.copyfile(old_path, new_path) [2cc33139]
- if os.path.exists(new_path): raise CommandError( "%s already exists. Overlaying %s %s into an existing " "directory won't replace conflicting files." % ( new_path, self.a_or_an, app_or_project, ) ) [f435e20b]
- if self.verbosity >= 2: self.stdout.write("Creating %s" % new_path) try: self.apply_umask(old_path, new_path) self.make_writeable(new_path) except OSError: self.stderr.write( "Notice: Couldn't set permission bits on %s. You're " "probably using an uncommon filesystem setup. No " "problem." % new_path, self.style.NOTICE, ) [7e6cbaa2]
- for dirname in dirs[:]: if "exclude" not in options: if dirname.startswith(".") or dirname == "__pycache__": dirs.remove(dirname) elif dirname in excluded_directories: dirs.remove(dirname) [c216991a]
- for filename in files: if filename.endswith((".pyo", ".pyc", ".py.class")): # Ignore some files as they cause various breakages. continue old_path = os.path.join(root, filename) new_path = os.path.join( top_dir, relative_dir, filename.replace(base_name, name) ) for old_suffix, new_suffix in self.rewrite_template_suffixes: if new_path.endswith(old_suffix): new_path = new_path.removesuffix(old_suffix) + new_suffix break # Only rewrite once [7883958c]
- # Falling back to content type guessing ext = self.splitext(guessed_filename)[1] content_type = headers["content-type"] if not ext and content_type: ext = mimetypes.guess_extension(content_type) if ext: guessed_filename += ext [d8de95d6]
- # Find formatters, which are external executables, before input # from the templates can sneak into the path. formatter_paths = find_formatters() [cc9ebdb1]
- # Giving up return the_path [3ed1c3bb]
- # Move the temporary file to a filename that has better # chances of being recognized by the archive utils if used_name != guessed_filename: guessed_path = safe_join(tempdir, guessed_filename) shutil.move(the_path, guessed_path) return guessed_path [ee8cde91]
- # Setup a stub settings environment for template rendering if not settings.configured: settings.configure() django.setup() [0f942dbd]
- # Trying to get better name from response headers content_disposition = headers["content-disposition"] if content_disposition: _, params = parse_header_parameters(content_disposition) guessed_filename = params.get("filename") or used_name else: guessed_filename = used_name [e0244d1d]
- context = Context( { **options, base_name: name, base_directory: top_dir, camel_case_name: camel_case_value, "docs_version": get_docs_version(), "django_version": django.__version__, }, autoescape=False, ) [28c6afd3]
- def cleanup_url(url): tmp = url.rstrip("/") filename = tmp.split("/")[-1] if url.endswith("/"): display_url = tmp + "/" else: display_url = url return filename, display_url [b4d88f12]

## Beyond the budget

27 more facts did not fit in the budget: [4783ccb2] [a144e993] [f0679743] [39c84f4f] [59c2e486] [416b1f03] [be53c836] [166a8b45] [7995aee5] [e306d8f3] [a0320a31] [30846e96] [0558b9c5] [bd4ee78e] [d2b9c7ac] [0b77e720] [492e9644] [914f58a7] [3b22b025] [5898a3ea] [62fe50af] [e51735a5] [4d75e293] [792dae9b] [49e3a53d] [348548e0] [f2eb45a6]
