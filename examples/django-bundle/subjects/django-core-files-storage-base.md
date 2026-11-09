# django/core/files/storage/base

- Subject: django/core/files/storage/base (id `5750fcef-99bc-42b9-924d-6f572cfd8ecb`)
- Kind: subject
- Budget: 1200 tokens
- Used: 898 tokens
- Facts shown: 14 of 26
- Conflicts: 0
- Gaps: 0

## Facts

- # Ensure that the name is valid, before and after having the storage # system potentially modifying the name. This duplicates the check made # inside `get_available_name` but it's necessary for those cases where # `get_available_name` is overridden and validation is lost. validate_file_name(name, allow_relative_path=True) [cb189659]
- # Potentially find a different name depending on storage constraints. name = self.get_available_name(name, max_length=max_length) # Validate the (potentially) new name. validate_file_name(name, allow_relative_path=True) [8d3456e8]
- # The save operation should return the actual name of the file saved. name = self._save(name, content) # Ensure that the name returned from the storage system is still valid. validate_file_name(name, allow_relative_path=True) return name [f6a02a13]
- if not hasattr(content, "chunks"): content = File(content, name) [c683be64]
- # The following methods form the public API for storage systems, but with # no default implementations. Subclasses must implement *all* of these. [2d7874fa]
- # The following methods represent a public interface to private methods. # These shouldn't be overridden by subclasses unless absolutely necessary. [0d86407d]
- # These methods are part of the public API, with default implementations. [e84cc414]
- def delete(self, name): """ Delete the specified file from the storage system. """ raise NotImplementedError( "subclasses of Storage must provide a delete() method" ) [a8a9b2a2]
- def exists(self, name): """ Return True if a file referenced by the given name already exists in the storage system, or False if the name is available for a new file. """ raise NotImplementedError( "subclasses of Storage must provide an exists() method" ) [c8f38c6f]
- def generate_filename(self, filename): """ Validate the filename by calling get_valid_name() and return a filename to be passed to the save() method. """ filename = str(filename).replace("\\", "/") # `filename` may include a path as returned by FileField.upload_to. dirname, filename = os.path.split(filename) if ".." in pathlib.PurePath(dirname).parts: raise SuspiciousFileOperation( "Detected path traversal attempt in '%s'" % dirname ) return os.path.normpath(os.path.join(dirname, self.get_valid_name(filename))) [f3aad034]
- def get_accessed_time(self, name): """ Return the last accessed time (as a datetime) of the file specified by name. The datetime will be timezone-aware if USE_TZ=True. """ raise NotImplementedError( "subclasses of Storage must provide a get_accessed_time() method" ) [877e4039]
- def get_alternative_name(self, file_root, file_ext): """ Return an alternative filename, by adding an underscore and a random 7 character alphanumeric string (before the file extension, if one exists) to the filename. """ return "%s_%s%s" % (file_root, get_random_string(7), file_ext) [3b45b9c7]
- def get_valid_name(self, name): """ Return a filename, based on the provided filename, that's suitable for use in the target storage system. """ return get_valid_filename(name) [ced3886c]
- def open(self, name, mode="rb"): """Retrieve the specified file from storage.""" return self._open(name, mode) [8a650f93]

## Beyond the budget

10 more facts did not fit in the budget: [84d46c34] [f88f9d7e] [9dc661c0] [e8b0cc10] [1a25cf8d] [96eebe51] [9eb8310d] [ab44011c] [01ba028a] [43b6bfd121a04d01]
