# Fact dfd51039

Store id: 2b7c8d8d-add3-49be-ad87-719272dcec90

## Text

```text
def __init__( self, verbose_name=None, name=None, upload_to="", storage=None, **kwargs )
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
- posted_at: `2026-11-09T22:39:43.2283590+00:00`

## Data

```json
{
  "end_line": 271,
  "entity_kind": "method",
  "parent": "FileField",
  "start_line": 249,
  "symbol": "FileField.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":249,"selector":"L249-L271","symbol":"FileField.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FileField.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 271,
    "entity_kind": "method",
    "parent": "FileField",
    "start_line": 249,
    "symbol": "FileField.__init__"
  },
  "id": "2b7c8d8d-add3-49be-ad87-719272dcec90",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.2283590+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 249,
        "selector": "L249-L271",
        "symbol": "FileField.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "edf5a826-6066-4d6a-a954-385ac5699319",
  "subject_name": "django/db/models/fields/files::FileField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, verbose_name=None, name=None, upload_to=\"\", storage=None, **kwargs )"
}
```
