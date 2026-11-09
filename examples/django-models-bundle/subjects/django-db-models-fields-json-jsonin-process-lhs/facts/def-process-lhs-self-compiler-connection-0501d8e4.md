# Fact 0501d8e4

Store id: ace94e6a-252f-401a-bfb7-5d1587a2d11e

## Text

```text
def process_lhs(self, compiler, connection)
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
- posted_at: `2026-11-09T23:31:57.9522580+00:00`

## Data

```json
{
  "end_line": 462,
  "entity_kind": "method",
  "parent": "JSONIn",
  "start_line": 445,
  "symbol": "JSONIn.process_lhs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":445,"selector":"L445-L462","symbol":"JSONIn.process_lhs"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::JSONIn.process_lhs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 462,
    "entity_kind": "method",
    "parent": "JSONIn",
    "start_line": 445,
    "symbol": "JSONIn.process_lhs"
  },
  "id": "ace94e6a-252f-401a-bfb7-5d1587a2d11e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.9522580+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 445,
        "selector": "L445-L462",
        "symbol": "JSONIn.process_lhs"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "c82eb7b7-eb00-4067-aeb0-7bb512bac6e2",
  "subject_name": "django/db/models/fields/json::JSONIn.process_lhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_lhs(self, compiler, connection)"
}
```
