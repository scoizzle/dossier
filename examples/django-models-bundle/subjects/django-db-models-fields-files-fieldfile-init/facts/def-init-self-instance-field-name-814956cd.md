# Fact 814956cd

Store id: 6b26e5fa-0cc3-4e20-b6ea-a280b3f7dcf3

## Text

```text
def __init__(self, instance, field, name)
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
- posted_at: `2026-11-09T23:31:57.3337820+00:00`

## Data

```json
{
  "end_line": 25,
  "entity_kind": "method",
  "parent": "FieldFile",
  "start_line": 20,
  "symbol": "FieldFile.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":20,"selector":"L20-L25","symbol":"FieldFile.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FieldFile.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 25,
    "entity_kind": "method",
    "parent": "FieldFile",
    "start_line": 20,
    "symbol": "FieldFile.__init__"
  },
  "id": "6b26e5fa-0cc3-4e20-b6ea-a280b3f7dcf3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.3337820+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 20,
        "selector": "L20-L25",
        "symbol": "FieldFile.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "0d4349d7-4edb-41f7-b6f3-edab62dd2353",
  "subject_name": "django/db/models/fields/files::FieldFile.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, instance, field, name)"
}
```
