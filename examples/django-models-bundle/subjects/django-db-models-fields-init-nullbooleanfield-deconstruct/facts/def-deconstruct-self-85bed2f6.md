# Fact 85bed2f6

Store id: b3bab1ac-1827-49ba-bc57-cf2af0aab55e

## Text

```text
def deconstruct(self)
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
- posted_at: `2026-11-09T23:31:56.7579360+00:00`

## Data

```json
{
  "end_line": 2411,
  "entity_kind": "method",
  "parent": "NullBooleanField",
  "start_line": 2407,
  "symbol": "NullBooleanField.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2407,"selector":"L2407-L2411","symbol":"NullBooleanField.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::NullBooleanField.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2411,
    "entity_kind": "method",
    "parent": "NullBooleanField",
    "start_line": 2407,
    "symbol": "NullBooleanField.deconstruct"
  },
  "id": "b3bab1ac-1827-49ba-bc57-cf2af0aab55e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.7579360+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2407,
        "selector": "L2407-L2411",
        "symbol": "NullBooleanField.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "78e1bfbf-0e60-4c0a-ae46-086ae79abaae",
  "subject_name": "django/db/models/fields/__init__::NullBooleanField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
