# Fact c8549477

Store id: f4e9b7f0-82e4-41f0-a9d9-34b68466e30a

## Text

```text
def get_prep_value(self, value)
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
- posted_at: `2026-11-09T22:39:42.5202950+00:00`

## Data

```json
{
  "end_line": 2115,
  "entity_kind": "method",
  "parent": "FloatField",
  "start_line": 2106,
  "symbol": "FloatField.get_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2106,"selector":"L2106-L2115","symbol":"FloatField.get_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::FloatField.get_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2115,
    "entity_kind": "method",
    "parent": "FloatField",
    "start_line": 2106,
    "symbol": "FloatField.get_prep_value"
  },
  "id": "f4e9b7f0-82e4-41f0-a9d9-34b68466e30a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.5202950+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2106,
        "selector": "L2106-L2115",
        "symbol": "FloatField.get_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "8cd2079f-587d-49ee-b912-72988261d83b",
  "subject_name": "django/db/models/fields/__init__::FloatField.get_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_value(self, value)"
}
```
