# Fact 546c86b6

Store id: 0845b8e9-af5f-4524-b02a-3c250a8b9025

## Text

```text
def as_sqlite(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T22:39:47.0713210+00:00`

## Data

```json
{
  "end_line": 65,
  "entity_kind": "method",
  "parent": "Chr",
  "start_line": 64,
  "symbol": "Chr.as_sqlite"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":64,"selector":"L64-L65","symbol":"Chr.as_sqlite"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Chr.as_sqlite](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 65,
    "entity_kind": "method",
    "parent": "Chr",
    "start_line": 64,
    "symbol": "Chr.as_sqlite"
  },
  "id": "0845b8e9-af5f-4524-b02a-3c250a8b9025",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.0713210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 64,
        "selector": "L64-L65",
        "symbol": "Chr.as_sqlite"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "b41d788b-bbc9-455e-858a-904bfb7564ab",
  "subject_name": "django/db/models/functions/text::Chr.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
