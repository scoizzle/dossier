# Fact 7709e6b2

Store id: 51a5db21-aae4-4793-8e44-bfbed3e970ac

## Text

```text
def _require_file(self)
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
- posted_at: `2026-11-09T22:39:43.1922280+00:00`

## Data

```json
{
  "end_line": 48,
  "entity_kind": "method",
  "parent": "FieldFile",
  "start_line": 44,
  "symbol": "FieldFile._require_file"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":44,"selector":"L44-L48","symbol":"FieldFile._require_file"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FieldFile._require_file](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 48,
    "entity_kind": "method",
    "parent": "FieldFile",
    "start_line": 44,
    "symbol": "FieldFile._require_file"
  },
  "id": "51a5db21-aae4-4793-8e44-bfbed3e970ac",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.1922280+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 44,
        "selector": "L44-L48",
        "symbol": "FieldFile._require_file"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "a86da6d3-817b-489c-b4dd-bdc6d775cdef",
  "subject_name": "django/db/models/fields/files::FieldFile._require_file",
  "tags": [
    "entity:method"
  ],
  "text": "def _require_file(self)"
}
```
