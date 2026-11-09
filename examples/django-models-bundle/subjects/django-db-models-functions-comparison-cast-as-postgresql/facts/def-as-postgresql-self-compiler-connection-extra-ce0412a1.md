# Fact ce0412a1

Store id: 91d68a07-cb23-4e08-b4de-03bd60b407ba

## Text

```text
def as_postgresql(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T23:32:00.9597110+00:00`

## Data

```json
{
  "end_line": 58,
  "entity_kind": "method",
  "parent": "Cast",
  "start_line": 49,
  "symbol": "Cast.as_postgresql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/comparison.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":49,"selector":"L49-L58","symbol":"Cast.as_postgresql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/comparison::Cast.as_postgresql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 58,
    "entity_kind": "method",
    "parent": "Cast",
    "start_line": 49,
    "symbol": "Cast.as_postgresql"
  },
  "id": "91d68a07-cb23-4e08-b4de-03bd60b407ba",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.9597110+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 49,
        "selector": "L49-L58",
        "symbol": "Cast.as_postgresql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/comparison.py"
    }
  ],
  "status": "live",
  "subject_id": "8b9bbe4e-d1d3-4a05-8878-c720d3852fef",
  "subject_name": "django/db/models/functions/comparison::Cast.as_postgresql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_postgresql(self, compiler, connection, **extra_context)"
}
```
