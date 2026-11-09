# Fact 4f9d0207

Store id: 71755c78-edb8-4954-8b63-1c623b82ace4

## Text

```text
def _get_field_expression_map(self, meta, exclude=None)
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
- posted_at: `2026-11-09T22:39:40.3465260+00:00`

## Data

```json
{
  "end_line": 1441,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 1397,
  "symbol": "Model._get_field_expression_map"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1397,"selector":"L1397-L1441","symbol":"Model._get_field_expression_map"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model._get_field_expression_map](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1441,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 1397,
    "symbol": "Model._get_field_expression_map"
  },
  "id": "71755c78-edb8-4954-8b63-1c623b82ace4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3465260+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1397,
        "selector": "L1397-L1441",
        "symbol": "Model._get_field_expression_map"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "b2db4410-c938-4ead-bd21-9fca5f957dfb",
  "subject_name": "django/db/models/base::Model._get_field_expression_map",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_field_expression_map(self, meta, exclude=None)"
}
```
