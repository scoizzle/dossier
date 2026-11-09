# Fact 3a4ac993

Store id: a9b37785-e013-4f5b-bc48-254605186c68

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
- posted_at: `2026-11-09T23:31:56.5893490+00:00`

## Data

```json
{
  "end_line": 1588,
  "entity_kind": "method",
  "parent": "DateField",
  "start_line": 1586,
  "symbol": "DateField.value_to_string"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1586,"selector":"L1586-L1588","symbol":"DateField.value_to_string"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DateField.value_to_string](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1588,
    "entity_kind": "method",
    "parent": "DateField",
    "start_line": 1586,
    "symbol": "DateField.value_to_string"
  },
  "id": "a9b37785-e013-4f5b-bc48-254605186c68",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5893490+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1586,
        "selector": "L1586-L1588",
        "symbol": "DateField.value_to_string"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "b8b36a94-91e5-479e-ba0c-6dd29eb915a0",
  "subject_name": "django/db/models/fields/__init__::DateField.value_to_string",
  "tags": [
    "entity:method"
  ],
  "text": "def value_to_string(self, obj)"
}
```
