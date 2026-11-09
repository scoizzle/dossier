# Fact 3cf0f9e4

Store id: 66df0bd2-8d3f-44fc-ac85-f965a2422f14

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
- posted_at: `2026-11-09T23:31:56.6037590+00:00`

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
  "id": "66df0bd2-8d3f-44fc-ac85-f965a2422f14",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.6037590+00:00"
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
  "subject_id": "0a540d2b-2666-488e-aaf1-0194187a6243",
  "subject_name": "django/db/models/fields/__init__::DateTimeField.value_to_string",
  "tags": [
    "entity:method"
  ],
  "text": "def value_to_string(self, obj)"
}
```
