# django/core/files/storage/memory

- Subject: django/core/files/storage/memory (id `c6b94f4b-9f96-4c6d-84ea-e6e9a55e7777`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 18 of 50
- Conflicts: 0
- Gaps: 0

## Facts

- # If a leaf_cls is not None, check if leaf node is of right type. if leaf_cls and not isinstance(current_node, leaf_cls): error_cls, error_code = ( (NotADirectoryError, errno.ENOTDIR) if leaf_cls is InMemoryDirNode else (IsADirectoryError, errno.EISDIR) ) raise error_cls(error_code, os.strerror(error_code), path) [728d478f]
- content = self.file.getvalue() content = content.encode() if isinstance(content, str) else content.decode() self._content_type = new_content_type self._initialize_stream() [56ad0d1b]
- file_node.modified_time = now() return self._relative_path(name).replace("\\", "/") [4b8de53b]
- if current_node is None and check_exists: raise FileNotFoundError(errno.ENOENT, os.strerror(errno.ENOENT), path) [0e373030]
- if hasattr(content, "temporary_file_path"): os.remove(content.temporary_file_path()) [950ed05e]
- return current_node [d3c72849]
- self.file.write(content) [a6f4d28c]
- while path_segments: path_segment = path_segments.pop(0) # If current node is a file node and there are unprocessed # segments, raise an error. if isinstance(current_node, InMemoryFileNode): path_segments = os.path.split(path) current_path = "/".join( path_segments[: path_segments.index(path_segment)] ) raise NotADirectoryError( errno.ENOTDIR, os.strerror(errno.ENOTDIR), current_path ) current_node = current_node._resolve_child( path_segment, create_if_missing, leaf_cls if len(path_segments) == 0 else InMemoryDirNode, ) if current_node is None: break [cc7cdb2e]
- @cached_property def base_location(self): return self._value_or_setting(self._location, settings.MEDIA_ROOT) [7a31e0fac4ec8b62-2]
- @cached_property def base_url(self): if self._base_url is not None and not self._base_url.endswith("/"): self._base_url += "/" return self._value_or_setting(self._base_url, settings.MEDIA_URL) [b2e1396457fbae67-2]
- @cached_property def directory_permissions_mode(self): return self._value_or_setting( self._directory_permissions_mode, settings.FILE_UPLOAD_DIRECTORY_PERMISSIONS ) [f8d33481c24a6fb0-2]
- @cached_property def location(self): return os.path.abspath(self.base_location) [09859160e487624d-2]
- Handle path navigation of directory trees, creating missing nodes if needed. """ [7abe88a3]
- Handle unicode/bytes conversion during I/O operations and record creation, modification, and access times. """ [4f7ea5c3]
- def __init__( self, location=None, base_url=None, file_permissions_mode=None, directory_permissions_mode=None, ): self._location = location self._base_url = base_url self._file_permissions_mode = file_permissions_mode self._directory_permissions_mode = directory_permissions_mode self._root = InMemoryDirNode() self._resolve( self.base_location, create_if_missing=True, leaf_cls=InMemoryDirNode ) setting_changed.connect(self._clear_cached_properties) [23957a43]
- def __init__(self): self._children = {} self._initialize_times() [83cf2eec]
- def __init__(self, content="", name=None): super().__init__(content, name) self._content_type = type(content) self._initialize_times() [8c2892d2]
- def _update_accessed_time(self): self.accessed_time = now() [c5ec2c8d]

## Beyond the budget

31 more facts did not fit in the budget: [50935899] [fe5417b8] [7c7e9c66] [62277cd5] [edff0d4e] [33ff554d] [eb0497d4] [62f36b95] [fda611bb] [39df8fd7] [2186c5ad] [14c705c7] [1774ffa3] [c9242de9] [1414f314] [959e348b] [2fcfcf800996fb0e-2] [6a3a80f2] [c255bea8] [24fc9559] [252d6834eaf0da2d-2] [f7031137] [02c913e0] [205994fc] [484e01b1] [818521db] [6e21e5ab] [8b55d8b5] [423d3b0acaf4528f-2] [92d37eed] [6316e3f2]
