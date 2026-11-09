# django/contrib/staticfiles/management/commands/collectstatic

- Subject: django/contrib/staticfiles/management/commands/collectstatic (id `f211823d-67ac-4121-b7b6-df99d4138cb1`)
- Kind: subject
- Budget: 1200 tokens
- Used: 898 tokens
- Facts shown: 12 of 31
- Conflicts: 0
- Gaps: 0

## Facts

- if prefixed_path not in found_files: found_files[prefixed_path] = (storage, path) handler(path, prefixed_path, storage) else: self.skipped_files.append(prefixed_path) self.log( "Found another file with the destination path '%s'. It " "will be ignored since only the first encountered file " "is collected. If this is not what you want, make sure " "every static file has a unique path." % prefixed_path, level=2, ) [47f1d534]
- raise CommandError( "Symlinking is not supported in this " "platform (%s)." % platform.platform() ) except OSError as e: raise CommandError(e) if prefixed_path not in self.symlinked_files: self.symlinked_files.append(prefixed_path) [6be05fd1]
- message.append( "Are you sure you want to do this?\n\n" "Type 'yes' to continue, or 'no' to cancel: " ) if input("".join(message)) != "yes": raise CommandError("Collecting static files cancelled.") [23bf5ac2]
- # Storage backends may define a post_process() method. if self.post_process and hasattr(self.storage, "post_process"): processor = self.storage.post_process(found_files, dry_run=self.dry_run) for original_path, processed_path, processed in processor: if isinstance(processed, Exception): self.stderr.write("Post-processing '%s' failed!" % original_path) # Add a blank line before the traceback, otherwise it's # too easy to miss the relevant part of the error message. self.stderr.write() # Re-raise exceptions as CommandError and display notes. message = str(processed) if hasattr(processed, "__notes__"): message += "\n" + "\n".join(processed.__notes__) raise CommandError(message) from processed if processed: self.log( "Post-processed '%s' as '%s'" % (original_path, processed_path), level=2, ) self.post_processed_files.append(original_path) else: self.log("Skipped post-processing '%s'" % original_path) [81ee49e4]
- Split off from handle() to facilitate testing. """ if self.symlink and not self.local: raise CommandError("Can't symlink to a remote destination.") [5594518d]
- collected = self.collect() [2eb80621]
- dirs, files = self.storage.listdir(path) for f in files: fpath = os.path.join(path, f) if self.dry_run: self.log("Pretending to delete '%s'" % fpath, level=2) self.deleted_files.append(fpath) else: self.log("Deleting '%s'" % fpath, level=2) self.deleted_files.append(fpath) try: full_path = self.storage.path(fpath) except NotImplementedError: self.storage.delete(fpath) else: if not os.path.exists(full_path) and os.path.lexists(full_path): # Delete broken symlinks os.unlink(full_path) else: self.storage.delete(fpath) for d in dirs: self.clear_dir(os.path.join(path, d)) [d522870e]
- found_files = {} for finder in get_finders(): for path, storage in finder.list(self.ignore_patterns): # Prefix the relative path if the source storage contains it if getattr(storage, "prefix", None): prefixed_path = os.path.join(storage.prefix, path) else: prefixed_path = path [caf9e78b]
- if self.clear: self.clear_dir("") [0040a97f]
- if self.interactive and should_warn_user: if self.clear: message.append("This will DELETE ALL FILES in this location!\n") else: message.append("This will overwrite existing files!\n") [78297355]
- if self.symlink: handler = self.link_file else: handler = self.copy_file [8d74e420]
- import os [bbf3e0cdec1c52e4]

## Beyond the budget

19 more facts did not fit in the budget: [d6297b12] [a542f2a6] [4b99fc98] [68572a71] [2f7059d8] [b0e2481e] [6d8b1609] [3b029c97] [1f56641c] [d2f9c0f6] [d8655688] [85fd36e9] [563c809b] [9a43058d] [be04ce66] [21e68ab1] [0647511f] [3042a5b6] [faf58416]
