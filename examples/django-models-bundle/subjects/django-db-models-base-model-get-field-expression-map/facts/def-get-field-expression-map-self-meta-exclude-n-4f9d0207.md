# Fact 4f9d0207

Store id: 50f9364e-5a03-4d9c-b152-0c5fa1b99d2b

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
- posted_at: `2026-11-09T23:31:53.7530680+00:00`

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
  "id": "50f9364e-5a03-4d9c-b152-0c5fa1b99d2b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7530680+00:00"
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
  "subject_id": "fbc7ce2d-0d96-491f-9ba2-8ac421eef14e",
  "subject_name": "django/db/models/base::Model._get_field_expression_map",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_field_expression_map(self, meta, exclude=None)"
}
```
