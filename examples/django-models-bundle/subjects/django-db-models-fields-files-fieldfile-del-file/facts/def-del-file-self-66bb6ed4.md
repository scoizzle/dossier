# Fact 66bb6ed4

Store id: 82b53261-739a-4f39-b5b4-7ded46734176

## Text

```text
def _del_file(self)
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
- posted_at: `2026-11-09T23:31:57.3545200+00:00`

## Data

```json
{
  "end_line": 60,
  "entity_kind": "method",
  "parent": "FieldFile",
  "start_line": 59,
  "symbol": "FieldFile._del_file"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":59,"selector":"L59-L60","symbol":"FieldFile._del_file"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FieldFile._del_file](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 60,
    "entity_kind": "method",
    "parent": "FieldFile",
    "start_line": 59,
    "symbol": "FieldFile._del_file"
  },
  "id": "82b53261-739a-4f39-b5b4-7ded46734176",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.3545200+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 59,
        "selector": "L59-L60",
        "symbol": "FieldFile._del_file"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "513943a1-90dd-494e-89af-9c8752fc48e4",
  "subject_name": "django/db/models/fields/files::FieldFile._del_file",
  "tags": [
    "entity:method"
  ],
  "text": "def _del_file(self)"
}
```
