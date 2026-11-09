# Fact 3cf0f9e4

Store id: 20471cc1-cc59-4c30-90d1-89346c3c61fa

## Text

```text
def value_to_string(self, obj)
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
- posted_at: `2026-11-09T23:44:50.1076930+00:00`

## Data

```json
{
  "end_line": 1729,
  "entity_kind": "method",
  "parent": "DateTimeField",
  "start_line": 1727,
  "symbol": "DateTimeField.value_to_string"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1727,"selector":"L1727-L1729","symbol":"DateTimeField.value_to_string"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DateTimeField.value_to_string](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1729,
    "entity_kind": "method",
    "parent": "DateTimeField",
    "start_line": 1727,
    "symbol": "DateTimeField.value_to_string"
  },
  "id": "20471cc1-cc59-4c30-90d1-89346c3c61fa",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1076930+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1727,
        "selector": "L1727-L1729",
        "symbol": "DateTimeField.value_to_string"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "e3cb3e7d-a7a5-4595-a117-4958ae491b0e",
  "subject_name": "django/db/models/fields/__init__::DateTimeField.value_to_string",
  "tags": [
    "entity:method"
  ],
  "text": "def value_to_string(self, obj)"
}
```
