# Fact 5cb7a548

Store id: 1f025aa3-c08e-43e1-8dbe-664afaa01497

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
- posted_at: `2026-11-09T23:31:56.6700970+00:00`

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
  "id": "1f025aa3-c08e-43e1-8dbe-664afaa01497",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.6700970+00:00"
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
  "subject_id": "87002c96-002b-4d86-a020-0e2bfb825c3f",
  "subject_name": "django/db/models/fields/__init__::FilePathField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, verbose_name=None, name=None, path=\"\", match=None, recursive=False, allow_files=True, allow_folders=False, **kwargs, )"
}
```
