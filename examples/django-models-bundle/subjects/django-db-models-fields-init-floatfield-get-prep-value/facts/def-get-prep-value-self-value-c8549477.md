# Fact c8549477

Store id: c311e3f6-0d64-40a4-8d80-39f6d22b1e38

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
- posted_at: `2026-11-09T23:44:50.1535930+00:00`

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
  "id": "c311e3f6-0d64-40a4-8d80-39f6d22b1e38",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1535930+00:00"
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
  "subject_id": "e40d8f7e-5a3b-4a1b-86a4-5dab89357132",
  "subject_name": "django/db/models/fields/__init__::FloatField.get_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_value(self, value)"
}
```
