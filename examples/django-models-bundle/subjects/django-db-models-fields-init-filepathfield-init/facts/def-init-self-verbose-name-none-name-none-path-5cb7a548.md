# Fact 5cb7a548

Store id: af9c0383-ac53-48b0-943e-40de525cfd13

## Text

```text
def __init__( self, verbose_name=None, name=None, path="", match=None, recursive=False, allow_files=True, allow_folders=False, **kwargs, )
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:50.1435660+00:00`

## Data

```json
{
  "end_line": 2040,
  "entity_kind": "method",
  "parent": "FilePathField",
  "start_line": 2026,
  "symbol": "FilePathField.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2026,"selector":"L2026-L2040","symbol":"FilePathField.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::FilePathField.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2040,
    "entity_kind": "method",
    "parent": "FilePathField",
    "start_line": 2026,
    "symbol": "FilePathField.__init__"
  },
  "id": "af9c0383-ac53-48b0-943e-40de525cfd13",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1435660+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2026,
        "selector": "L2026-L2040",
        "symbol": "FilePathField.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "d8d7e016-6fb5-4623-b920-84966bb1a6a1",
  "subject_name": "django/db/models/fields/__init__::FilePathField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, verbose_name=None, name=None, path=\"\", match=None, recursive=False, allow_files=True, allow_folders=False, **kwargs, )"
}
```
