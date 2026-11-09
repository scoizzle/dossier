# Fact d3302e1a

Store id: bd214ebe-333c-4815-9b37-5074c711ecf8

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
- posted_at: `2026-11-09T23:31:56.6556540+00:00`

## Data

```json
{
  "end_line": 1986,
  "entity_kind": "method",
  "parent": "DurationField",
  "start_line": 1984,
  "symbol": "DurationField.value_to_string"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1984,"selector":"L1984-L1986","symbol":"DurationField.value_to_string"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DurationField.value_to_string](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1986,
    "entity_kind": "method",
    "parent": "DurationField",
    "start_line": 1984,
    "symbol": "DurationField.value_to_string"
  },
  "id": "bd214ebe-333c-4815-9b37-5074c711ecf8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.6556540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1984,
        "selector": "L1984-L1986",
        "symbol": "DurationField.value_to_string"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "69d7045c-26fc-4704-a8d4-6192197cf086",
  "subject_name": "django/db/models/fields/__init__::DurationField.value_to_string",
  "tags": [
    "entity:method"
  ],
  "text": "def value_to_string(self, obj)"
}
```
