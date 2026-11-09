# Fact 93e10c20

Store id: e41d3ecd-8a44-4ff1-803d-f1989ba9cf73

## Text

```text
def _assign_returned_values(self, returned_values, returning_fields)
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
- posted_at: `2026-11-09T23:44:48.5364770+00:00`

## Data

```json
{
  "end_line": 1268,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 1261,
  "symbol": "Model._assign_returned_values"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1261,"selector":"L1261-L1268","symbol":"Model._assign_returned_values"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model._assign_returned_values](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1268,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 1261,
    "symbol": "Model._assign_returned_values"
  },
  "id": "e41d3ecd-8a44-4ff1-803d-f1989ba9cf73",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5364770+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1261,
        "selector": "L1261-L1268",
        "symbol": "Model._assign_returned_values"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "203bc17f-16e8-4b29-ab6c-1b9b5cfb442c",
  "subject_name": "django/db/models/base::Model._assign_returned_values",
  "tags": [
    "entity:method"
  ],
  "text": "def _assign_returned_values(self, returned_values, returning_fields)"
}
```
