# Fact 5aabf944

Store id: c11458b2-9d02-4d80-90ba-d761f07407ce

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
- posted_at: `2026-11-09T22:39:42.4653400+00:00`

## Data

```json
{
  "end_line": 1923,
  "entity_kind": "method",
  "parent": "DecimalField",
  "start_line": 1921,
  "symbol": "DecimalField.get_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1921,"selector":"L1921-L1923","symbol":"DecimalField.get_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DecimalField.get_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1923,
    "entity_kind": "method",
    "parent": "DecimalField",
    "start_line": 1921,
    "symbol": "DecimalField.get_prep_value"
  },
  "id": "c11458b2-9d02-4d80-90ba-d761f07407ce",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.4653400+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1921,
        "selector": "L1921-L1923",
        "symbol": "DecimalField.get_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "b5f8f8a2-4f46-4368-9505-1ff48cfa556a",
  "subject_name": "django/db/models/fields/__init__::DecimalField.get_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_value(self, value)"
}
```
