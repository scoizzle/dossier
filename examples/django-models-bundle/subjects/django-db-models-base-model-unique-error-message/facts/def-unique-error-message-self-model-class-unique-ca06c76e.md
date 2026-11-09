# Fact ca06c76e

Store id: 770129fd-bcd8-494c-af14-1256fbfe83d0

## Text

```text
def unique_error_message(self, model_class, unique_check)
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
- posted_at: `2026-11-09T23:31:53.7573710+00:00`

## Data

```json
{
  "end_line": 1671,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 1641,
  "symbol": "Model.unique_error_message"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1641,"selector":"L1641-L1671","symbol":"Model.unique_error_message"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model.unique_error_message](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1671,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 1641,
    "symbol": "Model.unique_error_message"
  },
  "id": "770129fd-bcd8-494c-af14-1256fbfe83d0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7573710+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1641,
        "selector": "L1641-L1671",
        "symbol": "Model.unique_error_message"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "f6113cf1-7f47-4dfa-9723-25de8cd9a86e",
  "subject_name": "django/db/models/base::Model.unique_error_message",
  "tags": [
    "entity:method"
  ],
  "text": "def unique_error_message(self, model_class, unique_check)"
}
```
