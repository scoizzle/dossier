# django/core/files/storage/memory

- Subject: django/core/files/storage/memory (id `41f9451c-af66-42e6-949a-9b42783ebc39`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2521 tokens
- Facts shown: 50 facts
- Conflicts: 0
- Gaps: 0

## Highlights

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
- @cached_property def file_permissions_mode(self): return self._value_or_setting( self._file_permissions_mode, settings.FILE_UPLOAD_PERMISSIONS ) [4094fbd72b565b94-2]
- @cached_property def location(self): return os.path.abspath(self.base_location) [09859160e487624d-2]
- Handle path navigation of directory trees, creating missing nodes if needed. """ [7abe88a3]
- Handle unicode/bytes conversion during I/O operations and record creation, modification, and access times. """ [4f7ea5c3]
- def __init__( self, location=None, base_url=None, file_permissions_mode=None, directory_permissions_mode=None, ): self._location = location self._base_url = base_url self._file_permissions_mode = file_permissions_mode self._directory_permissions_mode = directory_permissions_mode self._root = InMemoryDirNode() self._resolve( self.base_location, create_if_missing=True, leaf_cls=InMemoryDirNode ) setting_changed.connect(self._clear_cached_properties) [23957a43]
- def __init__(self): self._children = {} self._initialize_times() [83cf2eec]
- __all__ = ("InMemoryStorage",) [484e01b1]

## All facts

- [8c2892d2] def __init__(self, content="", name=None): super().__init__(content, name) self._content_type = type(content) self._initialize_times()
- [50935899] def _convert_stream_content(self, mode): """Convert actual file content according to the opening mode.""" new_content_type = bytes if "b" in mode else str # No conversion needed. if self._content_type == new_content_type: return
- [fe5417b8] def _initialize_stream(self): """Initialize underlying stream according to the content type.""" self.file = io.BytesIO() if self._content_type == bytes else io.StringIO()
- [7c7e9c66] def _open(self, name, mode="rb"): create_if_missing = "w" in mode file_node = self._resolve( name, create_if_missing=create_if_missing, leaf_cls=InMemoryFileNode ) return file_node.open(mode)
- [62277cd5] def _relative_path(self, name): full_path = self.path(name) return os.path.relpath(full_path, self.location)
- [edff0d4e] def _resolve(self, name, create_if_missing=False, leaf_cls=None, check_exists=True): try: relative_path = self._relative_path(name) return self._root.resolve( relative_path, create_if_missing=create_if_missing, leaf_cls=leaf_cls, check_exists=check_exists, ) except NotADirectoryError as exc: absolute_path = self.path(exc.filename) raise FileExistsError(f"{absolute_path} exists and is not a directory.")
- [33ff554d] def _resolve_child(self, path_segment, create_if_missing, child_cls): if create_if_missing: self._update_accessed_time() self._update_modified_time() if child_cls is InMemoryFileNode: child = child_cls(name=path_segment) else: child = child_cls() return self._children.setdefault(path_segment, child) return self._children.get(path_segment)
- [eb0497d4] def _save(self, name, content): file_node = self._resolve( name, create_if_missing=True, leaf_cls=InMemoryFileNode ) fd = None for chunk in content.chunks(): if fd is None: mode = "wb" if isinstance(chunk, bytes) else "wt" fd = file_node.open(mode) fd.write(chunk)
- [c5ec2c8d] def _update_accessed_time(self): self.accessed_time = now()
- [62f36b95] def _update_modified_time(self): self.modified_time = now()
- [fda611bb] def delete(self, name): path, filename = os.path.split(name) dir_node = self._resolve(path, check_exists=False) if dir_node is None: return None dir_node.remove_child(filename)
- [39df8fd7] def exists(self, name): return self._resolve(name, check_exists=False) is not None
- [2186c5ad] def get_accessed_time(self, name): file_node = self._resolve(name) return file_node.accessed_time
- [14c705c7] def get_created_time(self, name): file_node = self._resolve(name) return file_node.created_time
- [1774ffa3] def get_modified_time(self, name): file_node = self._resolve(name) return file_node.modified_time
- [c9242de9] def listdir(self): directories, files = [], [] for name, entry in self._children.items(): if isinstance(entry, InMemoryDirNode): directories.append(name) else: files.append(name) return directories, files
- [1414f314] def listdir(self, path): node = self._resolve(path, leaf_cls=InMemoryDirNode) return node.listdir()
- [959e348b] def open(self, mode): self._convert_stream_content(mode) self._update_accessed_time() return super().open(mode)
- [2fcfcf800996fb0e-2] def path(self, name): return safe_join(self.location, name)
- [6a3a80f2] def remove_child(self, name): if name in self._children: self._update_accessed_time() self._update_modified_time() del self._children[name]
- [c255bea8] def resolve(self, path, create_if_missing=False, leaf_cls=None, check_exists=True): """ Navigate current directory tree, returning node matching path or creating a new one, if missing. - path: path of the node to search - create_if_missing: create nodes if not exist. Defaults to False. - leaf_cls: expected type of leaf node. Defaults to None. - check_exists: if True and the leaf node does not exist, raise a FileNotFoundError. Defaults to True. """ path_segments = list(pathlib.Path(path).parts) current_node = self
- [24fc9559] def size(self, name): return len(self._open(name, "rb").file.getvalue())
- [252d6834eaf0da2d-2] def url(self, name): if self.base_url is None: raise ValueError("This file is not accessible via a URL.") url = filepath_to_uri(name) if url is not None: url = url.lstrip("/") return urljoin(self.base_url, url)
- [f7031137] def write(self, data): super().write(data) self._update_modified_time()
- [02c913e0] """ Based on dj-inmemorystorage (BSD) by Cody Soyland, Seán Hayes, Tore Birkeland, and Nick Presta. """
- [205994fc] @deconstructible(path="django.core.files.storage.InMemoryStorage") class InMemoryStorage(Storage, StorageSettingsMixin): """A storage saving files in memory."""
- [818521db] class InMemoryDirNode(TimingMixin): """ Helper class representing an in-memory directory node.
- [6e21e5ab] class InMemoryFileNode(ContentFile, TimingMixin): """ Helper class representing an in-memory file node.
- [8b55d8b5] class TimingMixin: def _initialize_times(self): self.created_time = now() self.accessed_time = self.created_time self.modified_time = self.created_time
- [423d3b0acaf4528f-2] from .base import Storage from .mixins import StorageSettingsMixin
- [92d37eed] from django.conf import settings from django.core.files.base import ContentFile from django.core.signals import setting_changed from django.utils._os import safe_join from django.utils.deconstruct import deconstructible from django.utils.encoding import filepath_to_uri from django.utils.functional import cached_property from django.utils.timezone import now
- [6316e3f2] import errno import io import os import pathlib from urllib.parse import urljoin
