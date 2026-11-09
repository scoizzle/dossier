# Fact bb171a72

Store id: 04802ced-f3e8-4337-b644-5752be5bf6f4

## Text

```text
def as_postgresql(self, compiler, connection)
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
- posted_at: `2026-11-09T23:31:57.8930230+00:00`

## Data

```json
{
  "end_line": 260,
  "entity_kind": "method",
  "parent": "HasKeyLookup",
  "start_line": 254,
  "symbol": "HasKeyLookup.as_postgresql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":254,"selector":"L254-L260","symbol":"HasKeyLookup.as_postgresql"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::HasKeyLookup.as_postgresql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 260,
    "entity_kind": "method",
    "parent": "HasKeyLookup",
    "start_line": 254,
    "symbol": "HasKeyLookup.as_postgresql"
  },
  "id": "04802ced-f3e8-4337-b644-5752be5bf6f4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.8930230+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 254,
        "selector": "L254-L260",
        "symbol": "HasKeyLookup.as_postgresql"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "e6b69825-31e6-4084-9040-6197c1b72934",
  "subject_name": "django/db/models/fields/json::HasKeyLookup.as_postgresql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_postgresql(self, compiler, connection)"
}
```
