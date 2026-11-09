# Fact 5cb7a548

Store id: dd5ed810-b910-4fa6-8b79-a608e49c2dd4

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
- posted_at: `2026-11-09T22:39:42.5015530+00:00`

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
  "id": "dd5ed810-b910-4fa6-8b79-a608e49c2dd4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.5015530+00:00"
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
  "subject_id": "c65fd974-c8f5-4dd4-9bb9-47dd89e7a3a5",
  "subject_name": "django/db/models/fields/__init__::FilePathField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, verbose_name=None, name=None, path=\"\", match=None, recursive=False, allow_files=True, allow_folders=False, **kwargs, )"
}
```
